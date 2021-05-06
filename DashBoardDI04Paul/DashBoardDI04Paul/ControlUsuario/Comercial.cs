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

namespace DashBoardDI04Paul.ControlUsuario
{
    public partial class Comercial : UserControl
    {
        private CsvEnlace controladorBLL;
        public Comercial(int num)
        {
            InitializeComponent();
            controladorBLL = new CsvEnlace();
            CambiarTexto(num);
        }

        public void CambiarTexto(int num)
        {
            var datos = controladorBLL.comercianteDatos(num);
            var leer = datos.Split(',');

            var id = new List<string>();
            id.Add(leer[0]);

            var nombre = new List<string>();
            nombre.Add(leer[1]);

            var apellido = new List<string>();
            apellido.Add(leer[2]);

            var localidad = new List<string>();
            localidad.Add(leer[3]);

            var edad = new List<string>();
            edad.Add(leer[4]);

         
            tb_com.Text = "ID: " + id[0];
            tb_com.AppendText(" -  Nombre y apellido: " + nombre[0] + " " + apellido[0]);
            tb_com.AppendText(" -  Localidad: " + localidad[0]);
            tb_com.AppendText(" - Edad: " + edad[0]);

        }

        private void tb_com_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
