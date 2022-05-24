using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Printing;

namespace Grafikeditor
{
    class CL_GUI_Zeichenflaeche:Panel
    {
        private CL_FKS_Zeichnung o_Zeichnung = null;
        private Graphics o_Graphics;
        private Pen o_Pen;
        private SolidBrush o_Brush;
        private ToolStripStatusLabel coordsLabel;
        private ToolStripStatusLabel objektAnzeileLabel;
        private bool dragEnabled = false;
        private int dragElement = 0;
        private Bitmap dasBitmap = null;
        private Graphics dieBmpGraphic = null;

        public CL_GUI_Zeichenflaeche(Control in_Parent)
        {
            Parent = in_Parent;
            Dock = System.Windows.Forms.DockStyle.Fill;
            BackColor = Color.Silver;
            Paint += new System.Windows.Forms.PaintEventHandler(this.paint_event);
            MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_event);
            MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_event);
            Resize += new System.EventHandler(resize);
            
            //MouseHover += new System.EventHandler (this.mouseHover_event);
            MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_event);
            o_Zeichnung = new CL_FKS_Zeichnung(this);
            o_Pen = new Pen(Color.Black);
            o_Brush = new SolidBrush(Color.Red);
            o_Graphics = CreateGraphics();

            dasBitmap = new Bitmap(Width, Height);
            dieBmpGraphic = Graphics.FromImage(dasBitmap);
        }

        private void paint_event(object sender, PaintEventArgs e)
        {
            zeichne();
            this.dieBmpGraphic.Clear(BackColor);
            

            o_Zeichnung.paint(dieBmpGraphic, o_Pen, o_Brush);
            o_Graphics.DrawImage(dasBitmap, 0, 0);
        }
        private void zeichne()
        {
            this.dieBmpGraphic.Clear(BackColor);
            o_Zeichnung.paint(dieBmpGraphic, o_Pen, o_Brush);
            o_Graphics.DrawImage(dasBitmap, 0, 0);
        }

        public void resize(object sender, EventArgs e)
        {
            if (Parent.Height != 0 && Parent.Width != 0)
            {
                dasBitmap = new Bitmap(Parent.Width, Parent.Height);
                dieBmpGraphic = Graphics.FromImage(dasBitmap);
                this.o_Graphics = this.CreateGraphics();
            }
        }

        private void mouseDown_event(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("X: " + e.X + " Y: " + e.Y);
            int rueck_ID = 0;
            string rueck_Name = "";
            o_Zeichnung.werWurdeGetroffen(e.X, e.Y, ref rueck_ID, ref rueck_Name);
            if (rueck_Name != "")
            {
                dragEnabled = true;
                dragElement = rueck_ID;
                //zeige_ID_und_Name(rueck_ID, rueck_Name);
            }
        }

        private void mouseUp_event(object sender, MouseEventArgs e)
        {
            dragEnabled = false;
        }

        private void mouseMove_event(object sender, EventArgs e)
        {
            var pos = this.PointToClient(Cursor.Position);
            coordsLabel.Text = "" + pos;
            int rueck_ID = 0;
            string rueck_Name = "";
            o_Zeichnung.werWurdeGetroffen(pos.X, pos.Y, ref rueck_ID, ref rueck_Name);
            if (rueck_Name != "")
            {
                objektAnzeileLabel.Text = "" + rueck_Name;
            }
            else
            {
                objektAnzeileLabel.Text = "Kein Objekt";
            }

            if (dragEnabled == true)
            {
                //this.Invalidate();
                o_Zeichnung.set_Element_X(dragElement, pos.X);
                o_Zeichnung.set_Element_Y(dragElement, pos.Y);
                this.zeichne();
            }
        }

        public void registriereCoordsLabel(ToolStripStatusLabel in_Label)
        {
            coordsLabel = in_Label;
        }

        public void registriereObjektAnzeigeLabel(ToolStripStatusLabel in_Label)
        {
            objektAnzeileLabel = in_Label;


        }

        private void MoveCursor()
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(Cursor.Position.X - 50, Cursor.Position.Y - 50);
            Cursor.Clip = new Rectangle(this.Location, this.Size);
        }
        
        public void erzeuge_Rechteck(float in_x, float in_y, float in_B, float in_H, Color in_BrushColor, Color in_PenColor)
        {
            o_Zeichnung.erzeuge_Rechteck1(Cursor.Position.X, 20, in_B, in_H, in_BrushColor, in_PenColor); //vert
            o_Zeichnung.erzeuge_Rechteck2(Cursor.Position.X, 550, in_B, in_H, in_BrushColor, in_PenColor);//vert
            o_Zeichnung.erzeuge_Rechteck3(in_x, in_y, in_B, in_H, in_BrushColor, in_PenColor);
            o_Zeichnung.erzeuge_Rechteck4(in_x, in_y, in_B, in_H, in_BrushColor, in_PenColor);
            o_Zeichnung.paint(o_Graphics, o_Pen, o_Brush);
        }

        public void erzeuge_Rahmen(float in_x, float in_y, float in_B, float in_H, Color in_BrushColor, Color in_PenColor)
        {
            o_Zeichnung.erzeuge_Rahmen(in_x, in_y, in_B, in_H, in_BrushColor, in_PenColor);
            o_Zeichnung.paint(o_Graphics, o_Pen, o_Brush);
        }

        public void erzeuge_Kreis(float in_x, float in_y, float in_Radius, Color in_BrushColor, Color in_PenColor)
        {
            o_Zeichnung.erzeuge_Kreis(in_x, in_y, in_Radius, in_BrushColor, in_PenColor);
            o_Zeichnung.paint(o_Graphics, o_Pen, o_Brush);
        }

        public void zeige_ID_und_Name(int in_ID, string in_Name)
        {
            MessageBox.Show("ID: " + in_ID + "\nName: " + in_Name);
        }

        public Stream save_as(Stream in_Stream)
        {
            this.dasBitmap.Save(in_Stream, ImageFormat.Bmp);
            return in_Stream;
        }

        public PrintPageEventArgs pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            double cmToUnits = 100 / 2.54;
            e.Graphics.DrawImage(dasBitmap, 0, 0, (float)(15 * cmToUnits), (float)(10 * cmToUnits));
            return e;
        }

        public void grafikElemente_in_DB_speichern()
        {
            o_Zeichnung.grafikElemente_in_DB_speichern();
        }

        public void grafikElemente_aus_DB_laden()
        {
            o_Zeichnung.grafikElemente_aus_DB_laden();
            this.Refresh();
        }

        public void clear()
        {
            o_Zeichnung.clear();
            this.Refresh();
        }
    }
}
