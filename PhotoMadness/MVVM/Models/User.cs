using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace PhotoMadness.MVVM.Models
{
    [Table("Users")]
    class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Column("Name"), Indexed, NotNull]
        public string? Name { get; set; }

        [Column("Password"), Indexed, NotNull]
        public string? Password { get; set; }

        [Indexed]
        public int RoleId { get; set; }

        [Ignore]
        public Role Role { get; set; }
    }
}
