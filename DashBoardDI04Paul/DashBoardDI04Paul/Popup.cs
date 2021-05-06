using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Esta ventana emergente muestra datos basicos sobre la licencia del software. Se podria incluir un enlace a algun documento
 * online que explica mas sobre la licencia. Lleva el logo y nombre de la empresa desarrollador (Empresa PYMES).
 */
namespace DashBoardDI04Paul
{
    public partial class Popup : Form
    {
        public Popup()
        {
            InitializeComponent();
            //Texto para mostrar en el textbox de la ventana emergente
            tb_Pop.Text = "Empresa PYMES\r\nVersion 1.1\r\n\r\n ©2021 Empresa PYMES. Todos los derechos reservados\r\n" +
                "\r\nTodos los derechos reservados. Este software y su interfaz de usuario " +
                "están protegidos por las leyes de marca comercial y otros derechos de propiedad intelectual actuales " +
                "y pendientes en Europa y otros paises y regiones.";
            //Texto del helpProvider que muestra lo que hace el boton y solo pinchas en el boton.
                this.helpProvider1.SetHelpString(this.button1, "Hacer clic para cerrar");

        }

        //Boton cerrar de la ventana emergente
        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
