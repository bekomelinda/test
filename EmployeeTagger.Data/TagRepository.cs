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
            tagList.Add(new Tag { Id = 1, Name = "Funny" });
            tagList.Add(new Tag { Id = 1, Name = "Slowly" });
            tagList.Add(new Tag { Id = 1, Name = ".net" });
            return tagList;
        }
    }
}
