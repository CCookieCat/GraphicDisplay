using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Grafikeditor
{
    class CL_FKS_Kreis : CL_FKS_Grafikelement
    {
        protected float derRadius = 20.0f;

        protected Graphics o_Graphics;
        protected Pen o_Pen;
        protected SolidBrush o_Brush;
        

        public CL_FKS_Kreis(float in_x, float in_y, float in_Radius, Color in_BrushColor, Color in_PenColor)
            :base(in_x, in_y, in_BrushColor, in_PenColor) // Konstruktoraufruf BasisKlasse
        {
            derRadius = in_Radius;
            b_r = derRadius;
            h = 0;
            elementTyp = "Kreis";
        }

        public override void paint(Graphics in_Graphics, Pen in_Pen, SolidBrush in_Brush)
        {
            in_Brush.Color = brushColor;
            in_Pen.Color = penColor;

            o_Graphics = in_Graphics;
            o_Pen = in_Pen;
            o_Brush = in_Brush;


            in_Graphics.FillEllipse(in_Brush, x - derRadius, y - derRadius, derRadius * 2, derRadius * 2);
            in_Graphics.DrawEllipse(in_Pen, x - derRadius, y - derRadius, derRadius * 2, derRadius * 2);
        }

        public override bool wurdestDuGetroffen(int in_click_x, int in_click_y)
        {
            double mausRadius = Math.Sqrt(Math.Pow(Math.Abs(x - in_click_x), 2) + Math.Pow(Math.Abs(in_click_y - y), 2));

            if(mausRadius <= derRadius)
            {
                return true;
            } else {
                return false;
            }
        }

        public override string gibName()
        {
            return "Kreis";
        }

        public override void refresh()
        {
            this.paint(o_Graphics, o_Pen, o_Brush);
        }
    }
}
