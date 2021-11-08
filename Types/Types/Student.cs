using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public class Student
    {
        public IAddress Address { get; set; }
    }

    public interface IAddress
    {
        public string City { get; set; }
    }
    public class HomeAddress : IAddress
    {
        public string Street { get; set; }
        public string City { get; set; }
    }
    public class BusinessAdress : IAddress
    {
        public string City { get; set ; }
    }

    public class FamilyAddress : IAddress
    {
        public string City { get; set ; }
    }
}
