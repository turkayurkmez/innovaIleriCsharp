using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Product : IEntity
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public T GetId<T>(T parameter) where T:struct
        {
            return default(T);
        }
    }
}
