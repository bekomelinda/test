using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmployeeTagger.Model
{
    public class EmployeeTags
    {
        [Required]
        public int EmployeeId { get; set;}
        [Required]
        public int TagId { get; set; }
    }
}
