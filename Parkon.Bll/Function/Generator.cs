using Prkn.Common.Enums;
using System;

namespace Prkn.Spersys.Bll.Functions
{
    public class Generator
    {
        public static long CreateId(IslemTuru islemTuru, long DefaultId)
        {
            //2017 04 04 18 04 23 515 65
            //  17 04 04 18 04 23 515 65
            long result = 0;

            string SifirEkle(string val)
            {
                if (val.Length == 1) return "0" + val;
                return val;
            }

            string UcBasamakYap(string val)
            {

                switch (val.Length)
                {
                    case 1:
                        return "00" + val;
                    case 2:
                        return "0" + val;
                }
                return val;
            }

            string Id()
            {
                var yil         = SifirEkle(DateTime.Now.Year.ToString().Substring(1, 3)); // 1974 => 74 'ü al
                var ay          = SifirEkle(DateTime.Now.Month.ToString());
                var gun         = SifirEkle(DateTime.Now.Day.ToString());
                var saat        = SifirEkle(DateTime.Now.Hour.ToString());
                var dakika      = SifirEkle(DateTime.Now.Minute.ToString());
                var saniye      = SifirEkle(DateTime.Now.Second.ToString());
                var milisaniye  = UcBasamakYap(DateTime.Now.Millisecond.ToString());
                var random      = UcBasamakYap(new Random().Next(0, 999).ToString());
                    // 20    11    27    15      42       21       512         591
                return yil + ay + gun + saat + dakika + saniye + milisaniye + random;

            }

            if (islemTuru == IslemTuru.Insert)
            {
                result = long.Parse(Id());
            }
            else
            {
                result = DefaultId;
            }

            return result;  //islemTuru == IslemTuru.EntityUpdate ? selectedEntity.Id : long.Parse(Id());
        }
        public static long CreateRefNo(IslemTuru islemTuru, long? DefaultRefNo)
        {
            //170404180423515
            //17 04 04 18 04 23 515
            long result = 0;

            string SifirEkle(string val)
            {
                if (val.Length == 1) return "0" + val;
                return val;
            }

            string UcBasamakYap(string val)
            {

                switch (val.Length)
                {
                    case 1:
                        return "00" + val;
                    case 2:
                        return "0" + val;
                }
                return val;
            }

            string Id()
            {
                var yil         = SifirEkle(DateTime.Now.ToString("yy"));
                var ay          = SifirEkle(DateTime.Now.Month.ToString());
                var gun         = SifirEkle(DateTime.Now.Day.ToString());
                var saat        = SifirEkle(DateTime.Now.Hour.ToString());
                var dakika      = SifirEkle(DateTime.Now.Minute.ToString());
                var saniye      = SifirEkle(DateTime.Now.Second.ToString());
                var milisaniye  = UcBasamakYap(DateTime.Now.Millisecond.ToString());
                var random      = SifirEkle(new Random().Next(0, 99).ToString());
                //20 06 15 21 41 51 582  // yıl + ay + gün saat + dk + sn + ms
                return yil + ay + gun + saat + dakika + saniye + milisaniye; //+ gun + random  

            }

            if (islemTuru == IslemTuru.Insert)
            {
                result = long.Parse(Id());
            }
            else if(DefaultRefNo == null || DefaultRefNo == 0)
            {
                result = long.Parse(Id());
            }
            else 
            {
                result = (long)DefaultRefNo;
            }

            return result;  //islemTuru == IslemTuru.EntityUpdate ? selectedEntity.Id : long.Parse(Id());
        }
        public static string FileNameWithDateTime()
        {
            //170404180423515
            //17 04 04 18 04 23 515
            string result = "";

            string SifirEkle(string val)
            {
                if (val.Length == 1) return "0" + val;
                return val;
            }

            string UcBasamakYap(string val)
            {

                switch (val.Length)
                {
                    case 1:
                        return "00" + val;
                    case 2:
                        return "0" + val;
                }
                return val;
            }

            string Id()
            {
                var yil         = SifirEkle(DateTime.Now.ToString("yy"));
                var ay          = SifirEkle(DateTime.Now.Month.ToString());
                var gun         = SifirEkle(DateTime.Now.Day.ToString());
                var saat        = SifirEkle(DateTime.Now.Hour.ToString());
                var dakika      = SifirEkle(DateTime.Now.Minute.ToString());
                var saniye      = SifirEkle(DateTime.Now.Second.ToString());
                var milisaniye  = UcBasamakYap(DateTime.Now.Millisecond.ToString());
                var random      = SifirEkle(new Random().Next(0, 99).ToString());
                //20 06 15 21 41 51 582  // yıl + ay + gün saat + dk + sn + ms
                return yil + ay + gun + saat + dakika + saniye + milisaniye; //+ gun + random  

            }


            result = Id();


            return result;  //islemTuru == IslemTuru.EntityUpdate ? selectedEntity.Id : long.Parse(Id());
        }
    }
}
