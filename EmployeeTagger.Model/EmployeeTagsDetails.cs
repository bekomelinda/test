﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTagger.Model
{
    public class EmployeeTagsDetails:Employee
    {
        public ICollection<Tag> TagList { get; set; }
    }
}
