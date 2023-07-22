using Prkn.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model.Base
{
    public class BaseSoftwareVersion : BaseEntity
    {
        public string Platform { get; set; }
        public string VerNo { get; set; }
        public string VerInfo { get; set; }
        public string VerTitle { get; set; }
        public string VerContent { get; set; }
    }
}
