using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace Grafikeditor
{
    class CL_FKS_Rahmen: CL_FKS_Grafikelement
    {

        protected Graphics o_Graphics;
        protected Pen o_Pen;
        protected SolidBrush o_Brush;
        

    public CL_FKS_Rahmen(float in_x, float in_y,float in_h, float in_b, Color in_BrushColor, Color in_PenColor)
            :base(in_x, in_y, in_BrushColor, in_PenColor) // Konstruktoraufruf BasisKlasse
        {
            b_r = in_b;
            h = in_h;
            brushColor = in_BrushColor;
            penColor = in_PenColor;
            x = in_x;
            y = in_y;
            elementTyp = "Rahmen";
        }

        public override void paint(Graphics in_Graphics, Pen in_Pen, SolidBrush in_Brush)
        {
            in_Brush.Color = brushColor;
            in_Pen.Color = penColor;

            o_Graphics = in_Graphics;
            o_Pen = in_Pen;
            o_Brush = in_Brush;
            
        }

        public override bool wurdestDuGetroffen(int in_click_x, int in_click_y)
        {
            if (in_click_x >= this.x && in_click_x <= (this.x + b_r) && in_click_y >= this.y && in_click_y <= (this.y + h))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string gibName()
        {
            return "Rahmen";
        }

        public override void refresh()
        {
            this.paint(o_Graphics, o_Pen, o_Brush);
        }
    }
}
