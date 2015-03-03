using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeTagger.Model;
using EmployeeTagger.Data.Contracts;
using System.Data;
using System.Data.Entity;


namespace EmployeeTagger.Data
{
    public class EmployeeTagsRepository
    {

        public List<EmployeeTags> GetEmployeeTags()
        {
            List<EmployeeTags> employeeTags = new List<EmployeeTags>();
            employeeTags.Add(new EmployeeTags() { Id = 1, FirstName = "aaa", LastName = "ttt", Position = "developer", TagList = GetTags() });
            employeeTags.Add(new EmployeeTags() { Id = 2, FirstName = "bbb", LastName = "uuu", Position = "developer", TagList = GetTags() });
            employeeTags.Add(new EmployeeTags() { Id = 3, FirstName = "bbb", LastName = "vvv", Position = "developer", TagList = GetTags() });

            return employeeTags;
        }
        public List<Tag> GetTags()
        {
            List<Tag> tagList = new List<Tag>();
            tagList.Add(new Tag { Id = 1, Name = "Helpful" });
            tagList.Add(new Tag { Id = 2, Name = "Funny" });
            tagList.Add(new Tag { Id = 3, Name = "Slowly" });
            tagList.Add(new Tag { Id = 4, Name = ".net" });
            return tagList;
        }
    }
} 