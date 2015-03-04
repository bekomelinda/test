﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmployeeTagger.Model
{
    public class Tag
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
