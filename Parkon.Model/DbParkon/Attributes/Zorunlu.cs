using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prkn.Model.Entities.Attributes
{
    class Zorunlu : Attribute
    {
        public string Description { get; }
        public string ControlName { get; }


        /// <summary>
        /// Validation işlemleri sırasında zorunlu olan alanları işaretlemek için kullanılacak.
        /// </summary>
        /// <param name="description">Uyarı mesajnda gösterilecek olan açıklama</param>
        /// <param name="controlName">Uyarı mesajı sonrası focuslanılacak Control Adı </param>
        public Zorunlu(string description, string controlName)
        {
            Description = description;
            ControlName = controlName;
        }

    }
}
