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
        private static EmployeeTagsRepository instance;

        private EmployeeTagsRepository(){}

        private static EmployeeTagsRepository Instance 
        {
            get
            {
                if (instance == null)
                {
                    instance = new EmployeeTagsRepository();
                }
                return instance;
            }
        }

        public static List<EmployeeTagsDetails> GetEmployeeTagsDetails()
        {
            List<EmployeeTagsDetails> employeeTags = new List<EmployeeTagsDetails>();
            employeeTags.Add(new EmployeeTagsDetails() { 
                Id = 1,
                FirstName = "Tomas",
                LastName = "Black", 
                Position = "developer",
                TagList = new List<Tag>() { 
                    new Tag { Id = 1, Name = "helpful" }, 
                    new Tag { Id = 2, Name = "team player" }, 
                    new Tag { Id = 3, Name = "web forms" }, 
                    new Tag { Id = 4, Name = "javascript" },
                    new Tag { Id = 5, Name = "javascript" }}
            
            });
            employeeTags.Add(new EmployeeTagsDetails() { 
                Id = 2,
                FirstName = "Peter",
                LastName = "Green", 
                Position = "Business analyst",
                TagList = new List<Tag>() { 
                    new Tag { Id = 6, Name = "tired" }, 
                    new Tag { Id = 7, Name = "quickly" }, 
                    new Tag { Id = 8, Name = "productiv" } }

            });
            employeeTags.Add(new EmployeeTagsDetails()
            {
                Id = 3,
                FirstName = "John",
                LastName = "White",
                Position = "developer",
                TagList = new List<Tag>() { 
                    new Tag { Id = 9, Name = "css" }, 
                    new Tag { Id = 10, Name = "mvc" }, 
                    new Tag { Id = 11, Name = "java" }, 
                    new Tag { Id = 12, Name = "team player" },
                    new Tag { Id = 12, Name = "css" },
                    new Tag { Id = 12, Name = "git" },
                    new Tag { Id = 12, Name = "team lead" },
                    new Tag { Id = 12, Name = "security" },
                    new Tag { Id = 12, Name = "pair programming" }}

            });

            return employeeTags;
        }
        
    }
} 