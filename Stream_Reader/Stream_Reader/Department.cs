using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream_Reader
{
    internal class Department
    {
        /* Department
 - Id
 - Name
 - employeees list*/
      
        public employee employee { get; set; }
        public string Name { get; set; }
        public List<employee> employees;
        public Department()
        {
            employees   = new List<employee>();
          
            
        }
        
        
        public void Addemployee(employee employee)
        {
            employees.Add(employee);
        }
        public void GetemployeeeById(int  id)
        {

        
            foreach (var item in employees.FindAll(i => i.Id == id) )
            {
                item.ShowInfo();
            }

            

          
            
         
        }
        public void Removeemployee(int id)
        {
            
                employees.RemoveAll(item => item.Id == id);
            
        


        }
    }
    }
