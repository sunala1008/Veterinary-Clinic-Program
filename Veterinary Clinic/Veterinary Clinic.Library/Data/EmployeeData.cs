using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary_Clinic.Library.Data
{
    public class EmployeeData : EntityData<Employee>
    {
        public List<Employee> Search(string name, string num)
        {
            using (VETEntities entities = new VETEntities())
            {
                entities.Database.Log = x => Debug.WriteLine(x);

                var query = from x in entities.Employee
                            select x;

                if (string.IsNullOrEmpty(name) == false)
                    query = query.Where(x => x.Name.Contains(name));

                if (string.IsNullOrEmpty(num) == false)
                    query = query.Where(x => x.PhoneNum.Contains(num));

                return  query.ToList();
            }
        }
    }
}
