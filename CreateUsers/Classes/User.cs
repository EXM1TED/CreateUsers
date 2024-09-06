using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateUsers.Classes
{
    [Table("Users")]
    public class User
    {

        public User(string name, int age) 
        {
            this.Name = name;
            this.Age = age;
        }

        [Column("User_id")]
        public int Id { get; set; }
        [Column("User_name")]
        public string Name { get; set; }
        [Column("User_age")]
        public int Age { get; set; }
    }
}
