using Draw.SDK;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.Plugins
{
    public class Kare : IPlug
    {
        public string Name => "Kare";

        public void Draw(Graphics graphics, SolidBrush solidBrush, int x, int y, int width, int height)
        {
            graphics.FillRectangle(solidBrush, x, y, width, height);
        }
    }
}
