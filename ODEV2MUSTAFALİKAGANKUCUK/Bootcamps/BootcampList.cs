using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ODEV2MUSTAFALİKAGANKUCUK.Models;

namespace ODEV2MUSTAFALİKAGANKUCUK.Bootcamps
{
    public class BootcampList
    {
        static List<Bootcamp> empList = null;
        static BootcampList()
        {
            empList = new List<Bootcamp>(){
            new Bootcamp()
            {
                BootcampID = 1,
                Name = "Arvato",

            }
            
            };
        }

        public static List<Bootcamp> SelectBootcampList()
        {
            return empList;
        }

        public static void InsertBootcampList(Bootcamp emp)
        {
            empList.Add(emp);
        }

        public static void UpdateEmployeeList(Bootcamp emp)
        {
            Bootcamp empUpdate = empList.Find(x => x.BootcampID == emp.BootcampID);
            empUpdate.Name = emp.Name;
           
        }
        public static void DeleteBootcampList(int id)
        {
            Bootcamp empDelete = empList.Find(x => x.BootcampID == id);
            empList.Remove(empDelete);
        }
    }
}