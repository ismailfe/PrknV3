using System;
using System.Data.SqlServerCe;
using System.IO;
using System.Linq;

namespace Prkn.UI.Win
{
    /// <summary>
    /// SQLCE ile işlem yapmak için hazırlanmış metodlar bu classta bulunur.
    /// ID 07.01.2020
    /// </summary>
    public class SQLCE_Fnc
    {
        #region FUNCTION SQLCE 
        public void SQLCE_ControlSDF(bool VarsaSil_YeniOlustur, string DBPath, string DBName, string DBPassword = null)
        {
            string Path = DBPath; // CLS.ProgramData_Path;
            string Name = DBName + ".sdf";
            string Password = string.Empty;

            try
            {
                if (DBPassword != null && DBPassword != string.Empty)
                {
                    Password = "; Password = " + DBPassword;
                }
                string ConStr = "Data Source = " + Path + Name + Password;
                SqlCeEngine engine = new SqlCeEngine(ConStr);


                if (File.Exists(Path + Name))
                {
                    if (VarsaSil_YeniOlustur)
                    {
                        File.Delete(Path + Name);
                        engine.CreateDatabase();
                    }
                }
                else
                {
                    engine.CreateDatabase();
                }
            }
            catch (Exception HATA)
            {

            }

        }
        public void PreCreateTable(string TableName)
        {
            //    DataSet DS2 = new DataSet();
            ////    CLS.Id_MySQL.READ_FromSQL_FillDGV(TableName, null, DS2);
            //    int Cnt = DS2.Tables[0].Columns.Count;
            //    string[] CName = new string[Cnt];
            //    string[] CType = new string[Cnt];

            //    for (int K = 0; K < Cnt; K++)
            //    {
            //        CName[K] = DS2.Tables[0].Columns[K].ColumnName;

            //        //string cmd2 = "exec sp_help '[" + TableName + "]'";  //For MS SQL
            //        string cmd2 = "select COLUMN_TYPE from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = '" + TableName + "'";  //For MS SQL

            //        DataSet DS3 = new DataSet();
            //        string s0 = CLS.Id_MySQL.Open_CMD_ResultinDGV(cmd2, null, DS3);

            //        CType[K] = DS3.Tables[0].Rows[K][0].ToString();

            //    }

            //    Create_Table(TableName, CName, CType, false);
        }
        public string SQLCE_ControlTable(IDSQLCE.SQL MySQLCE, string TableName, string[] ColumnName, string[] ColumnType, bool VarsaSil_YeniOlustur)
        {
            string Return = string.Empty;
            string Temp1 = string.Empty;
            string s2 = MySQLCE.Open_CMD("SELECT TOP 1 * FROM " + TableName);

            if ((VarsaSil_YeniOlustur && s2.TrimStart().StartsWith("1")) || s2.TrimStart().StartsWith("-1"))
            {
                string s0 = MySQLCE.Open_CMD("DROP TABLE " + TableName + string.Empty);

                string CType = string.Empty;

                for (int i = 0; i < ColumnName.Length; i++)
                {

                    if (ColumnType[i].StartsWith("nvarchar"))
                    {
                        CType = "nvarchar(2048)";
                    }
                    else if (ColumnType[i].StartsWith("datetime"))
                    {
                        CType = "nvarchar(2048)";  //"datetime";
                    }
                    else if (ColumnType[i].StartsWith("text"))
                    {
                        CType = "nvarchar(2048)";
                    }
                    else if (ColumnType[i].StartsWith("bigint"))
                    {
                        if (ColumnName[i] == "Id")
                        {
                            CType = "bigint IDENTITY(1,1) PRIMARY KEY";
                        }
                        else
                        {
                            CType = "bigint";
                        }
                    }
                    else if (ColumnType[i].StartsWith("int"))
                    {
                        CType = "int";
                    }



                    if (i != ColumnName.Length - 1)
                    {
                        Temp1 += ColumnName[i] + " " + CType + " , ";
                    }
                    else
                    {
                        Temp1 += ColumnName[i] + " " + CType + " ";
                    }
                }

                string CMD = "CREATE TABLE " + TableName + "(" + Temp1 + ")"; //  " (First_Name nvarchar(100),Last_Name char(50),Address char(50),City char(50),Country char(25),Birth_Date datetime);";
                Return = MySQLCE.Open_CMD(CMD);
            }
            return Return;
        }
        public string SQLCE_DeleteTable(IDSQLCE.SQL MySQLCE, string TableName)
        {
            string Return = string.Empty;
            string CMD = "DROP TABLE " + TableName; //  " (First_Name nvarchar(100),Last_Name char(50),Address char(50),City char(50),Country char(25),Birth_Date datetime);";
            Return = MySQLCE.Open_CMD(CMD);
            return Return;
        }
        public string SQLCE_ConnString(IDSQLCE.SQL MySQLCE, string DBPath, string DBName, string DBPassowrd = null)
        {
            string Result = string.Empty;
            string Path = DBPath; // CLS.ProgramData_Path;
            string Name = DBName + ".sdf"; // "ext.sdf";
            string Password = string.Empty;
            if (DBPassowrd != null && DBPassowrd != string.Empty)
            {
                Password = ";Password=" + DBPassowrd;
            }
            string ConnectionPath = "Data Source=" + Path + Name + Password; 
            MySQLCE.ConnectionPath = ConnectionPath;
            MySQLCE.ConnectionAutoClose_ON = true;
            Result = SQLCE_ConnTest(MySQLCE);


            return Result;
        }
        public string SQLCE_ConnTest(IDSQLCE.SQL SQLCE)
        {
            string Status = string.Empty;
            Status = DateTime.Now + " - " + SQLCE.ConnectionTest();
            return Status;
        }
        #endregion
    }
}

