using Data_Access_Layer.Models;
using Data_Access_Layer.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Service
{
    public class EmployeeService
    {
        public static object Get()
        {
            return EmployeeRepo.Get();
        }
        public static Employee Get(int id)
        {
            return EmployeeRepo.Get(id);
        }
        public static bool Update(Employee employee)
        {
            return EmployeeRepo.Update(employee);
        }
        public static bool Delete(int id)
        {
            return EmployeeRepo.Del(id);
        }
        public static bool Create(Employee employee)
        {
            return EmployeeRepo.Create(employee);  
        }
    }
}
