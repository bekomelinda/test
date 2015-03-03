using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTagger.Model
{
    public class EmployeeTags:Employee
    {
        public ICollection<Tag> TagList { get; set; }
    }
}
