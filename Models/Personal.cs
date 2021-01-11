using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Models
{
    public class Personal : CommonEntity
    {


        [MinLength(1, ErrorMessage = "Name length should be more than 1 characters")]
        [MaxLength(15, ErrorMessage = "Name length should be less than 15 characters")]
        public string Name { get; set; }

        [MinLength(1, ErrorMessage = "Surname length should be more than 1 characters")]
        [MaxLength(15, ErrorMessage = "Surname length should be less than 15 characters")]
        public string Surname { get; set; }

        [MinLength(1, ErrorMessage = "Profesion length should be more than 1 characters")]
        [MaxLength(15, ErrorMessage = "Professon length should be less than 15 characters")]
        public string Profession { get; set; }

        public virtual Department Deparment { get; set; }
    }
}
