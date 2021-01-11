using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Models
{
    public class Hospitals : CommonEntity
    {
        public Hospitals()
        {
            this.Department = new HashSet<Department>();
        }



        [MinLength(1, ErrorMessage = "Name length should be more than 1 characters")]
        [MaxLength(15, ErrorMessage = "Name length should be less than 15 characters")]
        public string Name { get; set; }

        [MinLength(1, ErrorMessage = "Address length should be more than 1 characters")]
        [MaxLength(15, ErrorMessage = "Address length should be less than 15 characters")]
        public string Address { get; set; }

        [Range(1, 1000)]
        public int Count_employees { get; set; }

        public virtual ICollection<Department> Department { get; set; }
    }
}
