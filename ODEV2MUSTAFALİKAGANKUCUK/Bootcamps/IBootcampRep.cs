using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ODEV2MUSTAFALİKAGANKUCUK.Models;
using ODEV2MUSTAFALİKAGANKUCUK.Repository;

namespace ODEV2MUSTAFALİKAGANKUCUK.Bootcamps
{
    public interface IBootcampRep
    {

        List<Bootcamp> SelectAllBootcamps();
        Bootcamp SelectBootcampById(int id);
        void InsertBootcamp(Bootcamp emp);
        void UpdateBootcamp(Bootcamp emp);
        void DeleteBootcamp(int id);
    }
}