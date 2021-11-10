using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.SDK
{
   public interface IPlug
    {
        //Bu handshake pattern'i için kullanacağımız interface:
        string Name { get;  }
        void Draw(Graphics graphics, SolidBrush solidBrush, int x, int y, int width, int height);

    }
}
