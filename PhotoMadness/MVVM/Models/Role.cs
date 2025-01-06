using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace PhotoMadness.MVVM.Models
{
    [Table("Roles")]
    public class Role
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Column("Name"), Unique, NotNull]
        public string? Name { get; set; }

    }
}
