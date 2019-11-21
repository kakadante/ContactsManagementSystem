using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsManagementSystem.Models
{
    public class Allcontacts
    {
        [Key]
        public int AllcontactsId { get; set; }

        [DisplayName("NAME")]
        public string Name { get; set; }

        [DisplayName("PHONE NUMBER")]
        public string Phone_Number { get; set; }

        [DisplayName("EMAIL")]
        public string Email { get; set; }


        public Gender Gender { get; set; }
        [DisplayName("GENDER")]
        public int GenderId { get; set; }
    }
}
