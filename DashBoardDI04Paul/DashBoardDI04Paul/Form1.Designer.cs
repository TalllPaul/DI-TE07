
namespace DashBoardDI04Paul
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tlp_base = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.but_fact = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.butt_3 = new System.Windows.Forms.Button();
            this.butt_2 = new System.Windows.Forms.Button();
            this.butt_1 = new System.Windows.Forms.Button();
            this.tlp_com = new System.Windows.Forms.TableLayoutPanel();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlp_base.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_base
            // 
            this.tlp_base.BackColor = System.Drawing.Color.Black;
            this.tlp_base.ColumnCount = 2;
            this.tlp_base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.12406F));
            this.tlp_base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.87594F));
            this.tlp_base.Controls.Add(this.pictureBox1, 0, 0);
            this.tlp_base.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tlp_base.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tlp_base.Controls.Add(this.tlp_com, 1, 1);
            this.tlp_base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_base.Location = new System.Drawing.Point(0, 24);
            this.tlp_base.Name = "tlp_base";
            this.tlp_base.RowCount = 2;
            this.tlp_base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.16006F));
            this.tlp_base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.83994F));
            this.tlp_base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_base.Size = new System.Drawing.Size(1064, 657);
            this.tlp_base.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::DashBoardDI04Paul.Properties.Resources.dashCompanyLogo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.but_fact, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 76);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.89474F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.10526F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 277F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(122, 578);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(7, 527);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "Acerca de";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // but_fact
            // 
            this.but_fact.BackColor = System.Drawing.Color.Black;
            this.but_fact.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.but_fact.Location = new System.Drawing.Point(3, 3);
            this.but_fact.Name = "but_fact";
            this.but_fact.Size = new System.Drawing.Size(108, 48);
            this.but_fact.TabIndex = 0;
            this.but_fact.Text = "Facturacion Anual";
            this.but_fact.UseVisualStyleBackColor = false;
            this.but_fact.Click += new System.EventHandler(this.but_fact_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(3, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Resumen Mensual";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.butt_3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.butt_2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.butt_1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(131, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(930, 67);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // butt_3
            // 
            this.butt_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butt_3.BackColor = System.Drawing.Color.Black;
            this.butt_3.Location = new System.Drawing.Point(528, 10);
            this.butt_3.Name = "butt_3";
            this.butt_3.Size = new System.Drawing.Size(103, 47);
            this.butt_3.TabIndex = 2;
            this.butt_3.Text = "Comercial 3";
            this.butt_3.UseVisualStyleBackColor = false;
            this.butt_3.Click += new System.EventHandler(this.butt_3_Click);
            // 
            // butt_2
            // 
            this.butt_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butt_2.BackColor = System.Drawing.Color.Black;
            this.butt_2.Location = new System.Drawing.Point(296, 10);
            this.butt_2.Name = "butt_2";
            this.butt_2.Size = new System.Drawing.Size(103, 47);
            this.butt_2.TabIndex = 1;
            this.butt_2.Text = "Comercial 2";
            this.butt_2.UseVisualStyleBackColor = false;
            this.butt_2.Click += new System.EventHandler(this.butt_2_Click);
            // 
            // butt_1
            // 
            this.butt_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butt_1.BackColor = System.Drawing.Color.Black;
            this.butt_1.Location = new System.Drawing.Point(64, 10);
            this.butt_1.Margin = new System.Windows.Forms.Padding(0);
            this.butt_1.Name = "butt_1";
            this.butt_1.Size = new System.Drawing.Size(103, 47);
            this.butt_1.TabIndex = 0;
            this.butt_1.Text = "Comercial 1";
            this.butt_1.UseVisualStyleBackColor = false;
            this.butt_1.Click += new System.EventHandler(this.butt_1_Click);
            // 
            // tlp_com
            // 
            this.tlp_com.ColumnCount = 1;
            this.tlp_com.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_com.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_com.Location = new System.Drawing.Point(131, 76);
            this.tlp_com.Name = "tlp_com";
            this.tlp_com.RowCount = 2;
            this.tlp_com.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.345576F));
            this.tlp_com.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.65443F));
            this.tlp_com.Size = new System.Drawing.Size(930, 578);
            this.tlp_com.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualDeUsuarioToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            this.manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            this.manualDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manualDeUsuarioToolStripMenuItem.Text = "Manual de Usuario";
            this.manualDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.manualDeUsuarioToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(9)))), ((int)(((byte)(5)))));
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.tlp_base);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.tlp_base.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_base;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button but_fact;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button butt_3;
        private System.Windows.Forms.Button butt_2;
        private System.Windows.Forms.Button butt_1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tlp_com;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Button button2;
    }
}

