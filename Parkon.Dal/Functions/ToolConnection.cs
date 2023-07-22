using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prkn.Dal.Functions
{
    public static class ToolConnection
    {
        // all params are optional
        public static void ChangeDatabase(
            this DbContext source,
            string initialCatalog = "",
            string dataSource = "",
            string userId = "",
            string password = "",
            bool integratedSecuity = true,
            string configConnectionStringName = "")
        /* this would be used if the
        *  connectionString name varied from 
        *  the base EF class name */
        {
            try
            {
                // use the const name if it's not null, otherwise
                // using the convention of connection string = EF contextname
                // grab the type name and we're done
                var configNameEf = string.IsNullOrEmpty(configConnectionStringName)
                    ? source.GetType().Name
                    : configConnectionStringName;

                // add a reference to System.Configuration
                var entityCnxStringBuilder = new EntityConnectionStringBuilder
                    (System.Configuration.ConfigurationManager.ConnectionStrings[configNameEf].ConnectionString);

                // init the sqlbuilder with the full EF connectionstring cargo
                var sqlCnxStringBuilder = new SqlConnectionStringBuilder
                    (entityCnxStringBuilder.ProviderConnectionString);

                // only populate parameters with values if added
                if (!string.IsNullOrEmpty(initialCatalog))
                    sqlCnxStringBuilder.InitialCatalog = initialCatalog;
                if (!string.IsNullOrEmpty(dataSource))
                    sqlCnxStringBuilder.DataSource = dataSource;
                if (!string.IsNullOrEmpty(userId))
                    sqlCnxStringBuilder.UserID = userId;
                if (!string.IsNullOrEmpty(password))
                    sqlCnxStringBuilder.Password = password;

                // set the integrated security status
                sqlCnxStringBuilder.IntegratedSecurity = integratedSecuity;

                // now flip the properties that were changed
                source.Database.Connection.ConnectionString
                    = sqlCnxStringBuilder.ConnectionString;
            }
            catch (Exception ex)
            {
                // set log item if required
            }
        }



        /// <summary>
        /// SQLCE için DB konum değiştirme 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="connectionStringName">AppConfig içindeki string Adı</param>
        /// <param name="connectionStrings">Connection Strings</param>
        /// <param name="password">Şifre</param>
        public static void ChangeDatabaseSQLCE(this DbContext source, string connectionStringName, string connectionStrings, string password = null)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");

            //connectionStringsSection.ConnectionStrings["Blah"].ConnectionString = "Data Source=blah;Initial Catalog=blah;UID=blah;password=blah";

            if (!connectionStrings.StartsWith("Data Source="))
            {
                var tempConnstr = connectionStrings;
                connectionStrings = "Data Source=" + tempConnstr;
            }

            if (!string.IsNullOrEmpty(password))
            {
                if (!connectionStrings.EndsWith(";"))
                {
                    connectionStrings += ";";
                }
                connectionStrings += "Password=" + password + "";
            }

            connectionStringsSection.ConnectionStrings[connectionStringName].ConnectionString = connectionStrings;
            connectionStringsSection.SectionInformation.ForceSave = true;
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");
        }
    }
}
