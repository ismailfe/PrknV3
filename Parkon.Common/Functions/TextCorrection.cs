using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prkn.Common.Functions
{
    public static class TextCorrection
    {
       private static char CharToEnglishUpper(KeyPressEventArgs e)
        {

            switch (e.KeyChar) 
            {
                case 'Ö':
                case 'ö':
                    e.KeyChar = 'O';
                    break;
                case 'Ü':
                case 'ü':
                    e.KeyChar = 'U';
                    break;
                case 'Ğ':
                case 'ğ':
                    e.KeyChar = 'G';
                    break;
                case 'Ş':
                case 'ş':
                    e.KeyChar = 'S';
                    break;
                case 'İ':
                case 'ı':
                    e.KeyChar = 'I';
                    break;
                case 'Ç':
                case 'ç':
                    e.KeyChar = 'C';
                    break;


                default:
                    break;
            }

            return e.KeyChar;
        }


        public static void TextEdit_KeyPressForUpperEnglish(object sender, KeyPressEventArgs e)
        {
            if (((TextEdit)sender).Properties.CharacterCasing != CharacterCasing.Upper)
            {
                ((TextEdit)sender).Properties.CharacterCasing = CharacterCasing.Upper;
            }
         
            CharToEnglishUpper(e);
        }
    }
}
