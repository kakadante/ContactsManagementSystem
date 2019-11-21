using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsManagementSystem.Models
{
    public class Gender
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("GENDER")]
        public string Gendername { get; set; }
    }
}
