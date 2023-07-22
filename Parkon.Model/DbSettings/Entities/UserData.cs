using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Prkn.Model.DbSettings.Entities
{
    public class UserData
    {
        [Column(Order = 0), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Department { get; set; }
        public string Level { get; set; }
        public string UserNamew { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Job { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Picture { get; set; }
    }
}
