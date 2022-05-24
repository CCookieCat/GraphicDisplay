using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Printing;
//using System.Diagnostics;

namespace Grafikeditor
{
    public partial class Frm_Grafikeditor : Form
    {
        private CL_GUI_Zeichenflaeche o_Zeichenflaeche = null;
        public Frm_Grafikeditor()
        {
            InitializeComponent();

            o_Zeichenflaeche = new CL_GUI_Zeichenflaeche(pnl_center);
            o_Zeichenflaeche.registriereCoordsLabel(lbl_Coords);
            o_Zeichenflaeche.registriereObjektAnzeigeLabel(lbl_objektAnzeige);

            
        }

        private void btn_Farbe_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btn_BrushColor.BackColor = colorDialog1.Color;


            // using System.Diagnostics;
            //Process P = new Process();
            //P.StartInfo.FileName = "taskmgr.exe";
            // hier kann z.B. eine Textdatei mit übergeben werden
            // P.StartInfo.Arguments = "Test.txt";
            //P.Start();
        }

        private void pnl_center_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Rechteck_Click(object sender, EventArgs e)
        {
            float lx = float.Parse(tBx_X.Text); // Typumwandlung von Text nach Float
            float ly = float.Parse(tBx_y.Text);
            float lb = float.Parse(tBx_Breite.Text);
            float lh = float.Parse(tBx_Hoehe.Text);
            o_Zeichenflaeche.erzeuge_Rechteck(lx, ly, lb, lh, btn_BrushColor.BackColor, btn_PenColor.BackColor);
        }

        private void btn_PenColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btn_PenColor.BackColor = colorDialog1.Color;
        }

        private void btn_Kreis_Click(object sender, EventArgs e)
        {
            float lx = float.Parse(tBx_X.Text);
            float ly = float.Parse(tBx_y.Text);
            float lr = float.Parse(tBx_Radius.Text);
            o_Zeichenflaeche.erzeuge_Kreis(lx, ly, lr, btn_BrushColor.BackColor, btn_PenColor.BackColor);
        }

        private void pnl_center_MouseHover(object sender, EventArgs e)
        {

        }

        private void pnl_center_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pnl_center_Resize(object sender, EventArgs e)
        {

        }

        private void btn_save_as_Click(object sender, EventArgs e)
        {
            Stream myStream;

            saveFileDialog1.Filter = "Bmp files (*.bmp)|*.bmp|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    myStream = o_Zeichenflaeche.save_as(myStream);
                    myStream.Close();
                }
            }

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            PrintImage();
        }

        private void PrintImage()
        {
            PrintDocument pd = new PrintDocument();

            pd.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
            pd.OriginAtMargins = false;
            pd.DefaultPageSettings.Landscape = true;

            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);


            printPreviewDialog1.Document = pd;
            printPreviewDialog1.ShowDialog();

            //pd.Print();
        }

        void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            //double cmToUnits = 100 / 2.54;
            //e.Graphics.DrawImage(bmIm, 0, 0, (float)(15 * cmToUnits), (float)(10 * cmToUnits));

            o_Zeichenflaeche.pd_PrintPage(sender, e);
        }

        private void btn_save_db_Click(object sender, EventArgs e)
        {
            o_Zeichenflaeche.grafikElemente_in_DB_speichern();
        }

        private void btn_load_db_Click(object sender, EventArgs e)
        {
            o_Zeichenflaeche.grafikElemente_aus_DB_laden();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            o_Zeichenflaeche.clear();
        }

        private void btn_Rahmen_Click(object sender, EventArgs e)
        {
            float lx = float.Parse(tBx_X.Text); // Typumwandlung von Text nach Float
            float ly = float.Parse(tBx_y.Text);
            float lb = float.Parse(tBx_Breite.Text);
            float lh = float.Parse(tBx_Hoehe.Text);
            o_Zeichenflaeche.erzeuge_Rahmen(lx, ly, lb, lh, btn_BrushColor.BackColor, btn_PenColor.BackColor);
        
        }
    }
}



