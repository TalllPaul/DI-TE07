using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnlazarBLL;


namespace DashBoardDI04Paul
{
    public partial class Form1 : Form
    {
        public ControlUsuario.ResumenVentas resumen = new ControlUsuario.ResumenVentas();
        private UserControl anual;
        private TableLayoutPanel tlp;
        private TableLayoutPanel comtlp;
        private UserControl comerciales;
        Popup pop;

        private int comNum;
        public Form1()
        {
            InitializeComponent();
            tlp = tlp_base;
            comtlp = tlp_com;
            anual = new ControlUsuario.FacturaAnual();
            pop = new Popup();
            MetodoToolTip();
            

        }

        //Resumen anual
        private void but_fact_Click(object sender, EventArgs e)
        {
            comtlp.Controls.Remove(comerciales);
            tlp.Controls.Add(anual, 1, 1); 
        }

        //Comercial 1
        private void butt_1_Click(object sender, EventArgs e)
        {
            comtlp.Controls.Remove(comerciales);
            tlp.Controls.Remove(anual);
            comNum = 0;
            comerciales = new ControlUsuario.Comercial(0);
            comtlp.Controls.Add(comerciales, 1, 1);
          
        }

        //Comercial 2
        private void butt_2_Click(object sender, EventArgs e)
        {
            comtlp.Controls.Remove(comerciales);
            tlp.Controls.Remove(anual);
            comNum = 1;
            comerciales = new ControlUsuario.Comercial(1);
            comtlp.Controls.Add(comerciales, 1, 1);
        }

        //Comercial 3
        private void butt_3_Click(object sender, EventArgs e)
        {
            comtlp.Controls.Remove(comerciales);
            tlp.Controls.Remove(anual);
            comNum = 2;
            comerciales = new ControlUsuario.Comercial(2);
            comtlp.Controls.Add(comerciales, 1, 1);
            
        }

        //Resumen Mensual
        private void button1_Click(object sender, EventArgs e)
        {
            comtlp.Controls.Remove(resumen);
            tlp.Controls.Remove(anual);
            resumen.commercialnum(comNum);
            comtlp.Controls.Add(resumen, 1, 2);
            
        }
        //Metodo para establecer los globos del ToolTip.
        private void MetodoToolTip()
        {
            //Botones superiores
            this.ttMensaje.SetToolTip(butt_1, "Mostrar infromacion sobre el comercial 1");
            this.ttMensaje.SetToolTip(butt_2, "Mostrar infromacion sobre el comercial 2");
            this.ttMensaje.SetToolTip(butt_3, "Mostrar infromacion sobre el comercial 3");

            //Botones laterales
            this.ttMensaje.SetToolTip(but_fact, "Mostrar infromacion sobre la facturacion anual de cada empresa");
            this.ttMensaje.SetToolTip(button1, "Mostrar infromacion sobre el resumen mensual");

            this.ttMensaje.SetToolTip(button2, "Muestra la ventana emergente sobre la licencia");
        }
        //Metodo para abrir la ventana emergente acerca de desde el menu desplegable Ayuda.
        private void butt_pop_Click(object sender, EventArgs e)
        {
         
            pop.Show();
        }
        //Metodo que permite al usuario cerrar el programa desde el menu Archivo.
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Metodo que abre el manual de usuario cuando pinchas en el submenu de Ayuda, Manual de usuario.
        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://..\\..\\..\\Resources\\ManualdeUsuario.chm");
        }

        //Metodo para mostrar la ventana emergente al pinchar en el boton Acerca de.
        private void button2_Click(object sender, EventArgs e)
        {
            pop.Show();
        }
    }
}
