using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Models
{
    public class Department : CommonEntity
    {
        public Department()
        {
            this.Personal = new HashSet<Personal>();
        }

        [MinLength(1, ErrorMessage = "Name length should be more than 1 characters")]
        [MaxLength(15, ErrorMessage = "Name length should be less than 15 characters")]
        public string Name { get; set; }


        [Range(1, 1000)]
        public int Places { get; set; }
        public virtual Hospitals Hospitals { get; set; }
        public virtual ICollection<Personal> Personal { get; set; }
    }
}
