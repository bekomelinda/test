using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeTagger.Model;
using System.Data;
using System.Data.Entity;

namespace EmployeeTagger.Data
{
    public class TagRepository
    {
       
        public List<Tag> GetTags()
        {
            List<Tag> tagList = new List<Tag>();
            tagList.Add(new Tag { Id = 1, Name = "Helpful" });
            tagList.Add(new Tag { Id = 2, Name = "Funny" });
            tagList.Add(new Tag { Id = 3, Name = "Slowly" });
            tagList.Add(new Tag { Id = 4, Name = ".net" });
            tagList.Add(new Tag { Id = 5, Name = "tired" });
            tagList.Add(new Tag { Id = 6, Name = "css" });
            tagList.Add(new Tag { Id = 7, Name = "quickly" });
            tagList.Add(new Tag { Id = 8, Name = "java" });
            tagList.Add(new Tag { Id = 9, Name = "javascript" });
            tagList.Add(new Tag { Id = 10, Name = "javascript guru" });
            tagList.Add(new Tag { Id = 11, Name = "mvc" });
            tagList.Add(new Tag { Id = 12, Name = "productiv" });
            return tagList;
        }
    }
}
