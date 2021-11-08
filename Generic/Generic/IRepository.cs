using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
   public interface IRepository<T> where T:class,IEntity,new()
    {
        T GetT();
        void SomeProcess(T type);
    }
}
