
namespace DashBoardDI04Paul.ControlUsuario
{
    partial class Comercial
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_com = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_com
            // 
            this.tb_com.BackColor = System.Drawing.SystemColors.MenuText;
            this.tb_com.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_com.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_com.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_com.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_com.Location = new System.Drawing.Point(0, 0);
            this.tb_com.Name = "tb_com";
            this.tb_com.Size = new System.Drawing.Size(930, 20);
            this.tb_com.TabIndex = 0;
            this.tb_com.TextChanged += new System.EventHandler(this.tb_com_TextChanged);
            // 
            // Comercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tb_com);
            this.Name = "Comercial";
            this.Size = new System.Drawing.Size(930, 22);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_com;
    }
}
