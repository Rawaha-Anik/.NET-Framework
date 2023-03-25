using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    public class EmployeeRepo
    {
        static DBContext ContextClass;
        static EmployeeRepo()
        {
            ContextClass = new DBContext();
        }
        /*Getting all the employees*/
        public static List<Employee>Get()
        {
            return ContextClass.Employees.ToList();
        }
        /*Getting a particular employee*/
        public static Employee Get(int id)
        {
            return ContextClass.Employees.Find(id);
        }
        public static bool Create(Employee employee)
        {
            ContextClass.Employees.Add(employee);
            return ContextClass.SaveChanges() > 0;
        }
        public static bool Update(Employee employee)
        {
            var ex=ContextClass.Employees.Find(employee.Id);
            ContextClass.Entry(ex).CurrentValues.SetValues(employee);
            return ContextClass.SaveChanges() > 0;
        }
        public static bool Del(int id)
        {
            var ex = Get(id);
            ContextClass.Employees.Remove(ex);
            return ContextClass.SaveChanges() > 0;
        }
    }
}
