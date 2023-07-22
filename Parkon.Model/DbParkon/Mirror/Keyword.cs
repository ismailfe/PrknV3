using Prkn.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model.Mirror
{
    [Table("UserPrkn.Keyword")]
    public partial class Keyword :Base.BaseKeyword
    {
    }
}
