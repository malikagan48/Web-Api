using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ODEV2MUSTAFALİKAGANKUCUK.Bootcamps;
using ODEV2MUSTAFALİKAGANKUCUK.Models;

namespace ODEV2MUSTAFALİKAGANKUCUK.Bootcamps
{
    public class BootcampRep: IBootcampRep
    {
        public List<Models.Bootcamp> SelectAllBootcamps()
        {
            return BootcampList.SelectBootcampList();
        }

        public Models.Bootcamp SelectBootcampById(int id)
        {
            return BootcampList.SelectBootcampList().Find(x => x.BootcampID == id);
        }

        public void InsertBootcamp(Models.Bootcamp emp)
        {
            BootcampList.InsertBootcampList(emp);
        }

        public void UpdateBootcamp(Models.Bootcamp emp)
        {
            BootcampList.UpdateEmployeeList(emp);
        }

        public void DeleteBootcamp(int id)
        {
            BootcampList.DeleteBootcampList(id);
        }
    }
}