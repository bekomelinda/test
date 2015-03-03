using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeTagger.Model;

namespace EmployeeTagger.Data.Contracts
{
    public interface IEmployeeTagsRepository:IRepository<EmployeeTags>
    {
        //IQueryable<Tag> GetEmployeeTags();
        List<EmployeeTags> GetEmployeeTags();
    } 
}
