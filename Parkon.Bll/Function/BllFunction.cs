using System.Collections.Generic;

namespace Prkn.Spersys.Bll.Functions
{
    public static class BllFunction
    {
        public static List<string> DegisenAlanlariGetir<T>(this T oldEntity, T currentEntity)
        {
            List<string> alanlar = new List<string>();

            foreach (var prop in currentEntity.GetType().GetProperties())
            {
                if (prop.PropertyType.Namespace == "System.Collections.Generic") continue;
                var oldValue = prop.GetValue(oldEntity) ?? string.Empty;
                var currentValue = prop.GetValue(currentEntity) ?? string.Empty;

                //Value Byte ise null geldiğinde sıfır bas
                if (prop.PropertyType == typeof(byte[]))
                {
                    if (string.IsNullOrEmpty(oldValue.ToString()))
                    {
                        oldValue = new byte[] { 0 };
                    }
                    if (string.IsNullOrEmpty(currentEntity.ToString()))
                    {
                        currentValue = new byte[] { 0 };
                    }

                    if (((byte[])oldValue).Length != ((byte[])currentValue).Length)
                    {
                        alanlar.Add(prop.Name);
                    }
                }
                else if (!currentValue.Equals(oldValue))
                {
                    alanlar.Add(prop.Name);
                }
            }

            return alanlar;
        }
    }
}
