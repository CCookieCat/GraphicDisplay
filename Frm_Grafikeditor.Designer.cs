namespace Grafikeditor
{
    partial class Frm_Grafikeditor
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Grafikeditor));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_PenColor = new System.Windows.Forms.Button();
            this.btn_BrushColor = new System.Windows.Forms.Button();
            this.pnl_left = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_load_db = new System.Windows.Forms.Button();
            this.btn_save_db = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_save_as = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_Coords = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_Rechteck = new System.Windows.Forms.Button();
            this.tBx_Breite = new System.Windows.Forms.TextBox();
            this.tBx_Hoehe = new System.Windows.Forms.TextBox();
            this.lbl_Hoehe = new System.Windows.Forms.Label();
            this.lbl_Breite = new System.Windows.Forms.Label();
            this.tBx_Radius = new System.Windows.Forms.TextBox();
            this.lbl_Radius = new System.Windows.Forms.Label();
            this.btn_Kreis = new System.Windows.Forms.Button();
            this.tBx_y = new System.Windows.Forms.TextBox();
            this.tBx_X = new System.Windows.Forms.TextBox();
            this.lbl_Y = new System.Windows.Forms.Label();
            this.lbl_x = new System.Windows.Forms.Label();
            this.pnl_center = new System.Windows.Forms.Panel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.lbl_objektAnzeige = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Rahmen = new System.Windows.Forms.Button();
            this.pnl_top.SuspendLayout();
            this.pnl_left.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnl_center.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_top.Controls.Add(this.btn_PenColor);
            this.pnl_top.Controls.Add(this.btn_BrushColor);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(694, 54);
            this.pnl_top.TabIndex = 0;
            // 
            // btn_PenColor
            // 
            this.btn_PenColor.Location = new System.Drawing.Point(214, 12);
            this.btn_PenColor.Name = "btn_PenColor";
            this.btn_PenColor.Size = new System.Drawing.Size(82, 35);
            this.btn_PenColor.TabIndex = 1;
            this.btn_PenColor.Text = "PenColor";
            this.btn_PenColor.UseVisualStyleBackColor = true;
            this.btn_PenColor.Click += new System.EventHandler(this.btn_PenColor_Click);
            // 
            // btn_BrushColor
            // 
            this.btn_BrushColor.Location = new System.Drawing.Point(126, 12);
            this.btn_BrushColor.Name = "btn_BrushColor";
            this.btn_BrushColor.Size = new System.Drawing.Size(82, 35);
            this.btn_BrushColor.TabIndex = 0;
            this.btn_BrushColor.Text = "BrushColor";
            this.btn_BrushColor.UseVisualStyleBackColor = true;
            this.btn_BrushColor.Click += new System.EventHandler(this.btn_Farbe_Click);
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_left.Controls.Add(this.btn_Rahmen);
            this.pnl_left.Controls.Add(this.btn_clear);
            this.pnl_left.Controls.Add(this.btn_load_db);
            this.pnl_left.Controls.Add(this.btn_save_db);
            this.pnl_left.Controls.Add(this.btn_print);
            this.pnl_left.Controls.Add(this.btn_save_as);
            this.pnl_left.Controls.Add(this.statusStrip1);
            this.pnl_left.Controls.Add(this.btn_Rechteck);
            this.pnl_left.Controls.Add(this.tBx_Breite);
            this.pnl_left.Controls.Add(this.tBx_Hoehe);
            this.pnl_left.Controls.Add(this.lbl_Hoehe);
            this.pnl_left.Controls.Add(this.lbl_Breite);
            this.pnl_left.Controls.Add(this.tBx_Radius);
            this.pnl_left.Controls.Add(this.lbl_Radius);
            this.pnl_left.Controls.Add(this.btn_Kreis);
            this.pnl_left.Controls.Add(this.tBx_y);
            this.pnl_left.Controls.Add(this.tBx_X);
            this.pnl_left.Controls.Add(this.lbl_Y);
            this.pnl_left.Controls.Add(this.lbl_x);
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 54);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(126, 571);
            this.pnl_left.TabIndex = 1;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(10, 392);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(105, 26);
            this.btn_clear.TabIndex = 17;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_load_db
            // 
            this.btn_load_db.Location = new System.Drawing.Point(10, 424);
            this.btn_load_db.Name = "btn_load_db";
            this.btn_load_db.Size = new System.Drawing.Size(105, 26);
            this.btn_load_db.TabIndex = 16;
            this.btn_load_db.Text = "Aus DB laden";
            this.btn_load_db.UseVisualStyleBackColor = true;
            this.btn_load_db.Click += new System.EventHandler(this.btn_load_db_Click);
            // 
            // btn_save_db
            // 
            this.btn_save_db.Location = new System.Drawing.Point(10, 456);
            this.btn_save_db.Name = "btn_save_db";
            this.btn_save_db.Size = new System.Drawing.Size(105, 26);
            this.btn_save_db.TabIndex = 15;
            this.btn_save_db.Text = "Speichern in DB";
            this.btn_save_db.UseVisualStyleBackColor = true;
            this.btn_save_db.Click += new System.EventHandler(this.btn_save_db_Click);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(10, 488);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(105, 26);
            this.btn_print.TabIndex = 14;
            this.btn_print.Text = "Drucken";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_save_as
            // 
            this.btn_save_as.Location = new System.Drawing.Point(10, 520);
            this.btn_save_as.Name = "btn_save_as";
            this.btn_save_as.Size = new System.Drawing.Size(105, 26);
            this.btn_save_as.TabIndex = 13;
            this.btn_save_as.Text = "Speichern unter";
            this.btn_save_as.UseVisualStyleBackColor = true;
            this.btn_save_as.Click += new System.EventHandler(this.btn_save_as_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_Coords});
            this.statusStrip1.Location = new System.Drawing.Point(0, 549);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(126, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_Coords
            // 
            this.lbl_Coords.Name = "lbl_Coords";
            this.lbl_Coords.Size = new System.Drawing.Size(54, 17);
            this.lbl_Coords.Text = "X: 0   Y: 0";
            // 
            // btn_Rechteck
            // 
            this.btn_Rechteck.Location = new System.Drawing.Point(10, 196);
            this.btn_Rechteck.Name = "btn_Rechteck";
            this.btn_Rechteck.Size = new System.Drawing.Size(105, 26);
            this.btn_Rechteck.TabIndex = 7;
            this.btn_Rechteck.Text = "Rechteck";
            this.btn_Rechteck.UseVisualStyleBackColor = true;
            this.btn_Rechteck.Click += new System.EventHandler(this.btn_Rechteck_Click);
            // 
            // tBx_Breite
            // 
            this.tBx_Breite.Location = new System.Drawing.Point(38, 142);
            this.tBx_Breite.Name = "tBx_Breite";
            this.tBx_Breite.Size = new System.Drawing.Size(77, 20);
            this.tBx_Breite.TabIndex = 11;
            this.tBx_Breite.Text = "70";
            // 
            // tBx_Hoehe
            // 
            this.tBx_Hoehe.Location = new System.Drawing.Point(38, 170);
            this.tBx_Hoehe.Name = "tBx_Hoehe";
            this.tBx_Hoehe.Size = new System.Drawing.Size(77, 20);
            this.tBx_Hoehe.TabIndex = 10;
            this.tBx_Hoehe.Text = "20";
            // 
            // lbl_Hoehe
            // 
            this.lbl_Hoehe.AutoSize = true;
            this.lbl_Hoehe.Location = new System.Drawing.Point(7, 173);
            this.lbl_Hoehe.Name = "lbl_Hoehe";
            this.lbl_Hoehe.Size = new System.Drawing.Size(18, 13);
            this.lbl_Hoehe.TabIndex = 9;
            this.lbl_Hoehe.Text = "H:";
            // 
            // lbl_Breite
            // 
            this.lbl_Breite.AutoSize = true;
            this.lbl_Breite.Location = new System.Drawing.Point(7, 145);
            this.lbl_Breite.Name = "lbl_Breite";
            this.lbl_Breite.Size = new System.Drawing.Size(17, 13);
            this.lbl_Breite.TabIndex = 8;
            this.lbl_Breite.Text = "B:";
            // 
            // tBx_Radius
            // 
            this.tBx_Radius.Location = new System.Drawing.Point(38, 70);
            this.tBx_Radius.Name = "tBx_Radius";
            this.tBx_Radius.Size = new System.Drawing.Size(77, 20);
            this.tBx_Radius.TabIndex = 6;
            this.tBx_Radius.Text = "50";
            // 
            // lbl_Radius
            // 
            this.lbl_Radius.AutoSize = true;
            this.lbl_Radius.Location = new System.Drawing.Point(7, 73);
            this.lbl_Radius.Name = "lbl_Radius";
            this.lbl_Radius.Size = new System.Drawing.Size(18, 13);
            this.lbl_Radius.TabIndex = 5;
            this.lbl_Radius.Text = "R:";
            // 
            // btn_Kreis
            // 
            this.btn_Kreis.Location = new System.Drawing.Point(10, 106);
            this.btn_Kreis.Name = "btn_Kreis";
            this.btn_Kreis.Size = new System.Drawing.Size(105, 26);
            this.btn_Kreis.TabIndex = 4;
            this.btn_Kreis.Text = "Kreis";
            this.btn_Kreis.UseVisualStyleBackColor = true;
            this.btn_Kreis.Click += new System.EventHandler(this.btn_Kreis_Click);
            // 
            // tBx_y
            // 
            this.tBx_y.Location = new System.Drawing.Point(38, 44);
            this.tBx_y.Name = "tBx_y";
            this.tBx_y.Size = new System.Drawing.Size(77, 20);
            this.tBx_y.TabIndex = 3;
            this.tBx_y.Text = "300";
            // 
            // tBx_X
            // 
            this.tBx_X.Location = new System.Drawing.Point(38, 18);
            this.tBx_X.Name = "tBx_X";
            this.tBx_X.Size = new System.Drawing.Size(77, 20);
            this.tBx_X.TabIndex = 2;
            this.tBx_X.Text = "200";
            // 
            // lbl_Y
            // 
            this.lbl_Y.AutoSize = true;
            this.lbl_Y.Location = new System.Drawing.Point(7, 47);
            this.lbl_Y.Name = "lbl_Y";
            this.lbl_Y.Size = new System.Drawing.Size(15, 13);
            this.lbl_Y.TabIndex = 1;
            this.lbl_Y.Text = "y:";
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.Location = new System.Drawing.Point(7, 21);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(15, 13);
            this.lbl_x.TabIndex = 0;
            this.lbl_x.Text = "x:";
            // 
            // pnl_center
            // 
            this.pnl_center.Controls.Add(this.statusStrip2);
            this.pnl_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_center.Location = new System.Drawing.Point(126, 54);
            this.pnl_center.Name = "pnl_center";
            this.pnl_center.Size = new System.Drawing.Size(568, 571);
            this.pnl_center.TabIndex = 2;
            this.pnl_center.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_center_Paint);
            this.pnl_center.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_center_MouseMove);
            this.pnl_center.Resize += new System.EventHandler(this.pnl_center_Resize);
            this.pnl_center.MouseHover += new System.EventHandler(this.pnl_center_MouseHover);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_objektAnzeige});
            this.statusStrip2.Location = new System.Drawing.Point(0, 549);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(568, 22);
            this.statusStrip2.TabIndex = 0;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // lbl_objektAnzeige
            // 
            this.lbl_objektAnzeige.Name = "lbl_objektAnzeige";
            this.lbl_objektAnzeige.Size = new System.Drawing.Size(68, 17);
            this.lbl_objektAnzeige.Text = "Kein Objekt";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // btn_Rahmen
            // 
            this.btn_Rahmen.Location = new System.Drawing.Point(10, 229);
            this.btn_Rahmen.Name = "btn_Rahmen";
            this.btn_Rahmen.Size = new System.Drawing.Size(105, 27);
            this.btn_Rahmen.TabIndex = 18;
            this.btn_Rahmen.Text = "Resize";
            this.btn_Rahmen.UseVisualStyleBackColor = true;
            this.btn_Rahmen.Click += new System.EventHandler(this.btn_Rahmen_Click);
            // 
            // Frm_Grafikeditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 625);
            this.Controls.Add(this.pnl_center);
            this.Controls.Add(this.pnl_left);
            this.Controls.Add(this.pnl_top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Grafikeditor";
            this.Text = "Grafikeditor";
            this.pnl_top.ResumeLayout(false);
            this.pnl_left.ResumeLayout(false);
            this.pnl_left.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnl_center.ResumeLayout(false);
            this.pnl_center.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Panel pnl_center;
        private System.Windows.Forms.Label lbl_Y;
        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.TextBox tBx_y;
        private System.Windows.Forms.TextBox tBx_X;
        private System.Windows.Forms.Label lbl_Radius;
        private System.Windows.Forms.Button btn_Kreis;
        private System.Windows.Forms.TextBox tBx_Breite;
        private System.Windows.Forms.TextBox tBx_Hoehe;
        private System.Windows.Forms.Label lbl_Hoehe;
        private System.Windows.Forms.Label lbl_Breite;
        private System.Windows.Forms.Button btn_Rechteck;
        private System.Windows.Forms.TextBox tBx_Radius;
        private System.Windows.Forms.Button btn_BrushColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btn_PenColor;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Coords;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel lbl_objektAnzeige;
        private System.Windows.Forms.Button btn_save_as;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button btn_save_db;
        private System.Windows.Forms.Button btn_load_db;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Rahmen;
    }
}

