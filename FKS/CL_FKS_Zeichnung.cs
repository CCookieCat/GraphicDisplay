using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Grafikeditor
{
    class CL_FKS_Zeichnung
    {
        private CL_FKS_Grafikelement[] dieGrafikelemente;
        private int anzahl_Elemente = 0;
        public CL_Datenhaltung_MySQL o_Datenhaltung_MySQL = null;
        public CL_FKS_Zeichnung(Control in_Parent)
        {
            dieGrafikelemente = new CL_FKS_Grafikelement[1000];
            o_Datenhaltung_MySQL = new CL_Datenhaltung_MySQL();
        }

        public void erzeuge_Rechteck1(float in_x, float in_y, float in_B, float in_H, Color in_BrushColor, Color in_PenColor)
        {
            CL_FKS_Rechteck l_Rechteck = new CL_FKS_Rechteck(15, in_y , in_B, in_H, in_BrushColor, in_PenColor);
            registriere_neues_Element(l_Rechteck);
        }
        public void erzeuge_Rechteck2(float in_x, float in_y, float in_B, float in_H, Color in_BrushColor, Color in_PenColor)
        {
            CL_FKS_Rechteck l_Rechteck = new CL_FKS_Rechteck(in_x, in_y, in_B, in_H, in_BrushColor, in_PenColor);
            registriere_neues_Element(l_Rechteck);
        }
        public void erzeuge_Rechteck3(float in_x, float in_y, float in_B, float in_H, Color in_BrushColor, Color in_PenColor)
        {
            CL_FKS_Rechteck l_Rechteck = new CL_FKS_Rechteck(in_x, in_y, in_B, in_H, in_BrushColor, in_PenColor);
            registriere_neues_Element(l_Rechteck);
        }
        public void erzeuge_Rechteck4(float in_x, float in_y, float in_B, float in_H, Color in_BrushColor, Color in_PenColor)
        {
            CL_FKS_Rechteck l_Rechteck = new CL_FKS_Rechteck(in_x, in_y, in_B, in_H, in_BrushColor, in_PenColor);
            registriere_neues_Element(l_Rechteck);
        }

        public void erzeuge_Kreis(float in_x, float in_y, float in_Radius, Color in_BrushColor, Color in_PenColor)
        {
            CL_FKS_Kreis l_Kreis = new CL_FKS_Kreis(in_x, in_y, in_Radius, in_BrushColor, in_PenColor);
            registriere_neues_Element(l_Kreis);
        }

        public void erzeuge_Rahmen(float in_y, float in_x, float in_b, float in_h, Color in_BrushColor, Color in_PenColor)
        {
            CL_FKS_Rahmen l_Rahmen = new CL_FKS_Rahmen(in_x, in_y, in_h, in_b, in_BrushColor, in_PenColor);
            registriere_neues_Element(l_Rahmen);
        }

        private void registriere_neues_Element(CL_FKS_Grafikelement in_neuesElement)
        {
            dieGrafikelemente[anzahl_Elemente++] = in_neuesElement;
        }

        public void paint(Graphics o_Graphics, Pen o_Pen, SolidBrush o_Brush)
        {
            for (int li = 0; li < anzahl_Elemente; li++)
            {
                dieGrafikelemente[li].paint(o_Graphics, o_Pen, o_Brush);
            }
        }

        public void werWurdeGetroffen(int in_click_x, int in_click_y, ref int id, ref string name)
        {
            //string out_Name = "";

            for (int dieID = 0; dieID < anzahl_Elemente; dieID++)
            {
                bool rueck = dieGrafikelemente[dieID].wurdestDuGetroffen(in_click_x, in_click_y);
                if (rueck == true)
                {
                    //out_Name = dieGrafikelemente[dieID].gibName();
                    name = dieGrafikelemente[dieID].gibName();
                    id = dieID;
                }
            }
        }

        public void set_Element_X(int elementID, int in_x)
        {
            dieGrafikelemente[elementID].set_x(in_x);
            //refresh();
        }

        public void set_Element_Y(int elementID, int in_y)
        {
            dieGrafikelemente[elementID].set_y(in_y);
            //refresh();
        }

        public void refresh()
        {
            for (int dieID = 0; dieID < anzahl_Elemente; dieID++)
            {
                dieGrafikelemente[dieID].refresh();
            }
        }

        public void grafikElemente_in_DB_speichern()
        {
            o_Datenhaltung_MySQL.connectUndLoescheTablle();
            o_Datenhaltung_MySQL.connectDatabase();
            for (int i = 0; i < anzahl_Elemente; i++)
            {
                string elementTyp = dieGrafikelemente[i].get_elementTyp();
                float x = dieGrafikelemente[i].get_x();
                float y = dieGrafikelemente[i].get_y();
                float b_r = dieGrafikelemente[i].get_b_r();
                float h = dieGrafikelemente[i].get_h();
                Color farbe = dieGrafikelemente[i].get_Color();
                Color farbe_P = dieGrafikelemente[i].get_PColor();

                o_Datenhaltung_MySQL.schreibeDatensatz(elementTyp, x, y, b_r, h, farbe, farbe_P);
            }
            o_Datenhaltung_MySQL.closeConnection();
        }

        public void grafikElemente_aus_DB_laden()
        {
            string sql_Befehl = "SELECT * FROM t_Zeichnung";

            int    out_Element_ID_PK = 0;
            string out_Typname = "";
            float out_x_pos = 0;
            float out_y_pos = 0;
            float out_b_r = 0;
            float out_h = 0;
            Color out_Color = Color.White;
            Color out_PColor = Color.White;

            //anzahl_Elemente = 0;
            clear();
            o_Datenhaltung_MySQL.connectDatabase();
            
            int dieAnzahlDB = o_Datenhaltung_MySQL.erstelleAbfrage(sql_Befehl);
            for (int i = 0; i < dieAnzahlDB; i++)
            //for (int i = 0; i < 3; i++)
            {
                o_Datenhaltung_MySQL.gibDatensatz(ref out_Element_ID_PK,
                                                  ref out_Typname,
                                                  ref out_x_pos,
                                                  ref out_y_pos,
                                                  ref out_b_r,
                                                  ref out_h,
                                                  ref out_Color,
                                                  ref out_PColor);

                if (out_Typname == "Rechteck")
                {
                    erzeuge_Rechteck1(out_x_pos, out_y_pos, out_b_r, out_h, out_Color, out_PColor); 

                }
                else if(out_Typname == "Kreis")
                {
                    erzeuge_Kreis(out_x_pos, out_y_pos, out_b_r, out_Color, out_PColor);
                }

            }
        }

        public void clear()
        {
            anzahl_Elemente = 0;
        }
    }
}
