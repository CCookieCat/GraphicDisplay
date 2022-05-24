using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Grafikeditor
{
    class CL_FKS_Grafikelement
    {
        protected float x;
        protected float y;
        protected Color brushColor;
        protected Color penColor;
        protected string elementTyp;
        protected float b_r;
        protected float h;

        public CL_FKS_Grafikelement(float in_x, float in_y, Color in_BrushColor, Color in_PenColor)
        {
            x = in_x;
            y = in_y;
            brushColor = in_BrushColor;
            penColor = in_PenColor;
        }


        //--------------------
        //---Datenkapselung---
        //--------------------

        // Methoden X
        public void set_x(float in_x)
        {
            x = in_x;
        }

        public float get_x()
        {
            return x;
        }

        // Methoden Y
        public void set_y(float in_y)
        {
            y = in_y;
        }

        public float get_y()
        {
            return y;
        }

        //--------------------
        //---Funktionen-------
        //--------------------
        public virtual void paint(Graphics in_Graphics, Pen in_Pen, SolidBrush in_Brush)
        {
            
        }

        public virtual bool wurdestDuGetroffen(int in_click_x, int in_click_y)
        {
            return false;
        }

        public virtual string gibName()
        {
            return "";
        }

        public virtual string get_elementTyp()
        {
            return elementTyp;
        }

        public virtual float get_b_r()
        {
            return b_r;
        }

        public virtual float get_h()
        {
            return h;
        }

        public virtual Color get_Color()
        {
            return brushColor;
        }

        public virtual Color get_PColor()
        {
            return penColor;
        }

        public virtual void refresh()
        {

        }
    }
}
