
namespace DashBoardDI04Paul
{
    partial class Popup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.tlp_Pop = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Pop = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tlp_Pop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_Pop
            // 
            this.tlp_Pop.ColumnCount = 1;
            this.tlp_Pop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Pop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Pop.Controls.Add(this.tb_Pop, 0, 1);
            this.tlp_Pop.Controls.Add(this.button1, 0, 2);
            this.tlp_Pop.Controls.Add(this.pictureBox1, 0, 0);
            this.tlp_Pop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Pop.Location = new System.Drawing.Point(0, 0);
            this.tlp_Pop.Name = "tlp_Pop";
            this.tlp_Pop.RowCount = 3;
            this.tlp_Pop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.5203F));
            this.tlp_Pop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.24354F));
            this.tlp_Pop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.23616F));
            this.tlp_Pop.Size = new System.Drawing.Size(516, 334);
            this.tlp_Pop.TabIndex = 0;
            // 
            // tb_Pop
            // 
            this.tb_Pop.BackColor = System.Drawing.SystemColors.MenuText;
            this.tb_Pop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Pop.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Pop.Location = new System.Drawing.Point(0, 98);
            this.tb_Pop.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Pop.Multiline = true;
            this.tb_Pop.Name = "tb_Pop";
            this.tb_Pop.ReadOnly = true;
            this.tb_Pop.Size = new System.Drawing.Size(516, 181);
            this.tb_Pop.TabIndex = 0;
            this.tb_Pop.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(220, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DashBoardDI04Paul.Properties.Resources.logoPYMES;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(516, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(516, 334);
            this.Controls.Add(this.tlp_Pop);
            this.HelpButton = true;
            this.helpProvider1.SetHelpString(this, "");
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Popup";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Acerca de";
            this.tlp_Pop.ResumeLayout(false);
            this.tlp_Pop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.TableLayoutPanel tlp_Pop;
        private System.Windows.Forms.TextBox tb_Pop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}