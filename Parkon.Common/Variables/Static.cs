using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prkn.Common.Variables
{
    public class Static
    {
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }

        #region METHOD DATE TIME
        /// <summary>
        /// Act Datetime için bu metod kullanılır.
        /// Geriye Datetime döndürür.
        /// </summary>
        /// <returns></returns>
        public static DateTime DateTimeNow()
        {
            return DateTime.Now;
        }

        /// <summary>
        /// Act GTM seviyesinde Datetime için bu metod kullanılır.
        /// Geriye Datetime döndürür.
        /// </summary>
        /// <returns></returns>
        public static DateTime NowGMT()
        {
            return DateTime.Now.ToUniversalTime();
        }
        #endregion


        #region BENZERSIZ DOSYA ADI

        /// <summary>
        /// OpenFileDialog üzerinden verilen path'daki dosyanın adını, GUID ile değiştirir.
        /// Geriye string olarak döndürür.
        /// </summary>
        /// <param name="OpenFileDialog1"></param>
        /// <returns></returns>
        public static string CreateNewNameViaGuid(OpenFileDialog OpenFileDialog1)
        {
            try
            {
                var ext = OpenFileDialog1.FileName.Substring(OpenFileDialog1.FileName.LastIndexOf('.'));
                var extension = ext.ToLower();
                string NewFileName = Guid.NewGuid().ToString() + extension;
                return NewFileName;
            }
            catch (Exception HATA)
            {

                return string.Empty;
            }

        }

        /// <summary>
        /// OpenFileDialog üzerinden verilen path'daki dosyanın adını, "pic_yyyMMdd_HHmmssfff" ile değiştirir.
        /// Geriye string olarak döndürür.
        /// </summary>
        /// <param name="OpenFileDialog1"></param>
        /// <returns></returns>
        public static string CreateNewNameViaDate(OpenFileDialog OpenFileDialog1)
        {
            try
            {
                var ext = OpenFileDialog1.FileName.Substring(OpenFileDialog1.FileName.LastIndexOf('.'));
                var extension = ext.ToLower();
                string NewFileName = CreateDateName() + extension;
                return NewFileName;
            }
            catch (Exception HATA)
            {
                return string.Empty;
            }
        }

        public static string CreateDateName()
        {
            return "pic_" + DateTime.Now.ToString("yyyMMdd_HHmmssfff");
        }
        #endregion


    }
}
