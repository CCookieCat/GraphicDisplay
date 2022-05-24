using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Grafikeditor
{
    class CL_FKS_Rechteck : CL_FKS_Grafikelement
    {
        protected float dieBreite = 20.0f;
        protected float dieHoehe = 20.0f;

        protected Graphics o_Graphics;
        protected Pen o_Pen;
        protected SolidBrush o_Brush;
        

        public CL_FKS_Rechteck(float in_x, float in_y, float in_B, float in_H, Color in_BrushColor, Color in_PenColor)
            :base(in_x, in_y, in_BrushColor, in_PenColor) // Konstruktoraufruf BasisKlasse
        {
            dieBreite = in_B;
            dieHoehe = in_H;

            b_r = dieBreite = 20;
            h = dieHoehe = 100;
            elementTyp = "Rechteck";
        }

        public override void paint(Graphics in_Graphics, Pen in_Pen, SolidBrush in_Brush)
        {
            in_Brush.Color = brushColor;
            in_Pen.Color = penColor;

            o_Graphics = in_Graphics;
            o_Pen = in_Pen;
            o_Brush = in_Brush;

            in_Graphics.FillRectangle(in_Brush, x, y, dieBreite, dieHoehe);
            in_Graphics.DrawRectangle(in_Pen, x, y, dieBreite, dieHoehe);
            //in_Graphics.DrawEllipse(in_Pen, x, y, dieBreite, dieHoehe);
            //in_Graphics.FillEllipse(in_Brush, x, y, dieBreite, dieHoehe);
            
        }

        public override bool wurdestDuGetroffen(int in_click_x, int in_click_y)
        {
            if (in_click_x >= this.x && in_click_x <= (this.x + dieBreite) && in_click_y >= this.y && in_click_y <= (this.y + dieHoehe))
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
            return "Rechteck";
        }

        public override void refresh()
        {
            this.paint(o_Graphics, o_Pen, o_Brush);
        }
    }
}
