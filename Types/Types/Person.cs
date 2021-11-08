using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public class Person
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Boş olamaz");
                }
                if (value.Length<2)
                {
                    throw new Exception("En az iki karakter olmalıdır");
                }
                name = value;
            }
        }

        public string LastName { get; set; }
        public int Age { get; set; }
        public string EmailAddress { get; set; }

        public void ChangeName()
        {
            
        }

        private void test()
        {

        }

    }
}
