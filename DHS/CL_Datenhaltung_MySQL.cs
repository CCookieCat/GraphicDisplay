using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data;
using System.Drawing;

namespace Grafikeditor
{
    class CL_Datenhaltung_MySQL
    {
        protected string a_File;
        protected System.Data.Odbc.OdbcConnection conn = new System.Data.Odbc.OdbcConnection();
        protected System.Data.Odbc.OdbcCommand cmd = new System.Data.Odbc.OdbcCommand();
        protected OdbcDataAdapter my_ODBC_Adapter = new OdbcDataAdapter();
        protected System.Data.DataSet dataSet1 = new System.Data.DataSet();
        protected DataTable dieTabelle = null;
        protected int dieDatensatzAnzahl = 0;
        protected int derIndex;
        protected DataRow derDatensatz;

        public CL_Datenhaltung_MySQL()//<<Konstructor>>
        {

        }
        //--------------------------------------------------------------------
        public virtual void connectDatabase(string in_File)
        {
            a_File = in_File;
            conn.Close();
            cmd.Connection = conn;
            conn.ConnectionString = "Driver={MySQL ODBC 5.1 Driver};" +
                                    "Server=localhost;" +
                                    "Database=grafikeditor_mysql_db;" +
                                    "uid=root;" +   
                                    "port=3306";
            conn.Open();
        }
        //---------------------------------------------------------------------
        public virtual void connectDatabase()
        {
            conn.Close();
            cmd.Connection = conn;
            conn.ConnectionString = "Driver={MySQL ODBC 5.1 Driver};" +
                                    "Server=localhost;" +
                                    "Database=grafikeditor_mysql_db;" +
                                    "uid=root;" +
                                    "port=3306";
            conn.Open();
        }
        //---------------------------------------------------------------------
        public void schreibeDatensatz( string in_Element_Typ,
                                       float in_x,
                                       float in_y,
                                       float in_b_r,
                                       float in_h,
                                       Color in_Farbe
                                       )
        {
            cmd.CommandText = " INSERT INTO `t_zeichnung`"
                             + " (`Element_Typ`,`x_pos` ,`y_pos`  ,`b_r`  ,`h`,`Farbe_R`,`Farbe_G`,`Farbe_B` ) "
                             + " VALUES ( "
                             + "'" + in_Element_Typ+"',"
                             + "'" + in_x.ToString()+"',"
                             + "'" + in_y.ToString()+"',"
                             + "'" + in_b_r.ToString()+"',"
                             + "'" + in_h.ToString()+ "',"
                             + "'" + in_Farbe.R.ToString() + "',"
                             + "'" + in_Farbe.G.ToString() + "',"
                             + "'" + in_Farbe.B.ToString() + "'"
                             + ");";

            cmd.ExecuteNonQuery();
        }
        //------------------------------------------------------------------
        public void schreibeDatensatz(string in_Element_Typ,
                                       float in_x,
                                       float in_y,
                                       float in_b_r,
                                       float in_h,
                                       Color in_Farbe,
                                       Color in_Farbe_P
                                       )
        {
            cmd.CommandText = " INSERT INTO `t_zeichnung`"
                             + " (`Element_Typ`,`x_pos` ,`y_pos`  ,`b_r`  ,`h`,`Farbe_R`,`Farbe_G`,`Farbe_B`,`FarbeP_R`,`FarbeP_G`,`FarbeP_B` ) "
                             + " VALUES ( "
                             + "'" + in_Element_Typ + "',"
                             + "'" + in_x.ToString() + "',"
                             + "'" + in_y.ToString() + "',"
                             + "'" + in_b_r.ToString() + "',"
                             + "'" + in_h.ToString() + "',"
                             + "'" + in_Farbe.R.ToString() + "',"
                             + "'" + in_Farbe.G.ToString() + "',"
                             + "'" + in_Farbe.B.ToString() + "',"
                             + "'" + in_Farbe_P.R.ToString() + "',"
                             + "'" + in_Farbe_P.G.ToString() + "',"
                             + "'" + in_Farbe_P.B.ToString() + "'"
                             + ");";

            cmd.ExecuteNonQuery();
        }
        //------------------------------------------------------------------
        public int erstelleAbfrage(string in_SqlBefehl)
        { 
            connectDatabase(a_File);
            cmd.CommandText = in_SqlBefehl;
            my_ODBC_Adapter.TableMappings.Clear();
            my_ODBC_Adapter.TableMappings.Add("Table", "t_Zeichnung");
            my_ODBC_Adapter.SelectCommand = cmd;
            dataSet1.Clear();
            my_ODBC_Adapter.Fill(this.dataSet1);
            dieTabelle = dataSet1.Tables["t_Zeichnung"];
            dieDatensatzAnzahl=dieTabelle.Rows.Count;
            derIndex = 0;
            return  dieDatensatzAnzahl;
        }
        //------------------------------------------------------------------
        public void gibDatensatz( ref int    out_Element_ID_PK,
                                  ref string out_Typname,
                                  ref float out_x_pos,
                                  ref float out_y_pos,
                                  ref float out_b_r,
                                  ref float out_h,
                                  ref Color out_Color            
                                )
        {
                derDatensatz = dieTabelle.Rows[derIndex];
                out_Element_ID_PK = int.Parse(derDatensatz[0].ToString());
                out_Typname = derDatensatz[1].ToString();
                out_x_pos = float.Parse(derDatensatz[2].ToString());
                out_y_pos = float.Parse(derDatensatz[3].ToString());
                out_b_r = float.Parse(derDatensatz[4].ToString());
                out_h = float.Parse(derDatensatz[5].ToString());
                byte l_R = byte.Parse(derDatensatz[6].ToString());
                byte l_G = byte.Parse(derDatensatz[7].ToString());
                byte l_B = byte.Parse(derDatensatz[8].ToString());
                out_Color = Color.FromArgb(l_R, l_G, l_B);
                derIndex++;
         }
        //------------------------------------------------------------------
        public void gibDatensatz(ref int out_Element_ID_PK,
                                  ref string out_Typname,
                                  ref float out_x_pos,
                                  ref float out_y_pos,
                                  ref float out_b_r,
                                  ref float out_h,
                                  ref Color out_Color,
                                  ref Color out_PColor
                                )
        {
            derDatensatz = dieTabelle.Rows[derIndex];
            out_Element_ID_PK = int.Parse(derDatensatz[0].ToString());
            out_Typname = derDatensatz[1].ToString();
            out_x_pos = float.Parse(derDatensatz[2].ToString());
            out_y_pos = float.Parse(derDatensatz[3].ToString());
            out_b_r = float.Parse(derDatensatz[4].ToString());
            out_h = float.Parse(derDatensatz[5].ToString());
            byte l_R = byte.Parse(derDatensatz[6].ToString());
            byte l_G = byte.Parse(derDatensatz[7].ToString());
            byte l_B = byte.Parse(derDatensatz[8].ToString());
            out_Color = Color.FromArgb(l_R, l_G, l_B);
            byte lP_R = byte.Parse(derDatensatz[9].ToString());
            byte lP_G = byte.Parse(derDatensatz[10].ToString());
            byte lP_B = byte.Parse(derDatensatz[11].ToString());
            out_PColor = Color.FromArgb(lP_R, lP_G, lP_B);
            derIndex++;
        }
        //------------------------------------------------------------------
        public void connectUndLoescheTablle(string in_File)
        {
            a_File = in_File;
            connectDatabase(a_File);
            cmd.CommandText = " Delete  From `t_zeichnung` ";
            cmd.ExecuteNonQuery();
        }
        //------------------------------------------------------------------
        public void connectUndLoescheTablle()
        {
            connectDatabase();
            cmd.CommandText = " Delete  From `t_zeichnung` ";
            cmd.ExecuteNonQuery();
        }
        //------------------------------------------------------------------
        public void closeConnection()
        {
           conn.Close();
        }
        //------------------------------------------------------------------
    }
}
