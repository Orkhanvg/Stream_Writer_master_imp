using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Stream_Reader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (!Directory.Exists(@"C:\Users\User\Desktop\File"))
            {
                Directory.CreateDirectory(@"C:\Users\User\Desktop\File");

            }
            
            if (!(File.Exists(@"C:\Users\User\Desktop\File\database.json")))
            {
                File.Create(@"C:\Users\User\Desktop\File\database.json");

            }
      
           
            Department department = new Department();
            int secim;
            do
            {
                Console.WriteLine("1.Add emloyee\n" +
                  "2.Get employee by id\n" +
                  "3.Remove employeee\n" +
                  "0.Qiut\n");
                Console.WriteLine("secin");
                secim=Convert.ToInt32(Console.ReadLine());
                switch (secim)

                {
                    case 1:

                        Console.WriteLine("Ad daxil edin");
                        string Name = Console.ReadLine();
                        Console.WriteLine("Maasi qey edin");
                        int Salary = Convert.ToInt16(Console.ReadLine());
                        employee employee = new employee(Name, Salary);

                        department.Addemployee(employee);
                    

                        string result = JsonConvert.SerializeObject(department);
                        string path = (@"C:\Users\User\Desktop\File\database.json");
                        using (StreamWriter stream = new(path))
                        {
                            stream.WriteLine(result);
                        }
                        employee.ShowInfo();

                        break;
                    case 2:

                        string result2;
                        string path2 = (@"C:\Users\User\Desktop\File\database.json");
                        Console.WriteLine("Id daxil edin");
                        int idd = Convert.ToInt32(Console.ReadLine());
                        using (StreamReader stream = new(path2))
                        {
                            result2 = stream.ReadToEnd();
                        }
                        Department department2 = JsonConvert.DeserializeObject<Department>(result2);
                        foreach (var item in department2.employees)
                        {
                          department.GetemployeeeById(item.Id);

                        }
                        break;
                    case 3:
                        string result3;
                        string path3 = (@"C:\Users\User\Desktop\File\database.json");
                        Console.WriteLine("Id daxil edin");
                        int iddd = Convert.ToInt32(Console.ReadLine());
                        using (StreamReader stream = new(path3))
                        {
                            result3 = stream.ReadToEnd();
                        }
                        Department department3 = JsonConvert.DeserializeObject<Department>(result3);
                        foreach (var item in department3.employees)
                        {

                            department.Removeemployee(item.Id);

                        }
                        string result4 = JsonConvert.SerializeObject(department3);
                        string path4 = (@"C:\Users\User\Desktop\File\database.json");
                        using (StreamWriter stream = new(path4))
                        {
                            stream.WriteLine(result4);
                        }
                        break;

                    case 0: break;
                }

            } while (true);  

         }
    }
}
