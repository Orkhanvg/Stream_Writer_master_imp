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
 - Employees list*/
      
        public Employe employe { get; set; }
        public string Name { get; set; }
        public List<Employe> Employes;
        public Department()
        {
            Employes   = new List<Employe>();
          
            
        }
        
        /*- AddEmployee() - employee obyekti qebul edecek
- GetEmployeeById() - id qebul edecek
- RemoveEmployee() - id qebul edecek*/
        public void AddEmploye(Employe employe)
        {
            Employes.Add(employe);
        }
        public void GetEmployeeById(int  id)
        {

        
            foreach (var item in Employes.FindAll(i => i.Id == id) )
            {
                item.ShowInfo();
            }

            

          
            
         
        }
        public void RemoveEmploye(int id)
        {
            
                Employes.RemoveAll(item => item.Id == id);
            
        


        }
    }
    }
