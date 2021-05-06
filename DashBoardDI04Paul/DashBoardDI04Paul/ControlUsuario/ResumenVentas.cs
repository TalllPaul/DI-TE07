using EnlazarBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DashBoardDI04Paul.ControlUsuario
{
    public partial class ResumenVentas : UserControl
    {
        //Enlace con la capa BLL
        private CsvEnlace controlador;

        public ResumenVentas()
        {
            InitializeComponent();
            controlador = new CsvEnlace();
        }

        //El numero de comercial pasado como parametro desde la capa UI.
        public void commercialnum(int num)
        {

            string valores = controlador.mensual(num);

            var jan = new List<string>();
            var feb = new List<string>();
            var mar = new List<string>();
            var apr = new List<string>();
            var may = new List<string>();
            var jun = new List<string>();
            var jul = new List<string>();
            var aug = new List<string>();
            var sep = new List<string>();
            var oct = new List<string>();
            var nov = new List<string>();
            var dec = new List<string>();
            //meses2
            var jan2 = new List<string>();
            var feb2 = new List<string>();
            var mar2 = new List<string>();
            var apr2 = new List<string>();
            var may2 = new List<string>();
            var jun2 = new List<string>();
            var jul2 = new List<string>();
            var aug2 = new List<string>();
            var sep2 = new List<string>();
            var oct2 = new List<string>();
            var nov2 = new List<string>();
            var dec2 = new List<string>();

            Series S1 = chart1.Series["Empresa 1"];
            Series S2 = chart1.Series["Empresa 2"];

            chart1.Series["Empresa 1"].Points.Clear();
            chart1.Series["Empresa 2"].Points.Clear();

            for (int i = 1; i < valores.Length - 1; i++)
            {

                var leer = valores.Split(',');

                jan.Add(leer[0]);
                feb.Add(leer[1]);
                mar.Add(leer[2]);
                apr.Add(leer[3]);
                may.Add(leer[4]);
                jun.Add(leer[5]);
                jul.Add(leer[6]);
                aug.Add(leer[7]);
                sep.Add(leer[8]);
                oct.Add(leer[9]);
                nov.Add(leer[10]);
                dec.Add(leer[11]);

                jan2.Add(leer[12]);
                feb2.Add(leer[13]);
                mar2.Add(leer[14]);
                apr2.Add(leer[15]);
                may2.Add(leer[16]);
                jun2.Add(leer[17]);
                jul2.Add(leer[18]);
                aug2.Add(leer[19]);
                sep2.Add(leer[20]);
                oct2.Add(leer[21]);
                nov2.Add(leer[22]);
                dec2.Add(leer[23]);

            }

            if (num == 0)
            {
                S1.Points.AddXY("January", jan[0]);
                S1.Points.AddXY("February", feb[0]);
                S1.Points.AddXY("March", mar[0]);
                S1.Points.AddXY("Abril", apr[0]);
                S1.Points.AddXY("Mayo", may[0]);
                S1.Points.AddXY("Junio", jun[0]);
                S1.Points.AddXY("Julio", jul[0]);
                S1.Points.AddXY("Agosto", aug[0]);
                S1.Points.AddXY("Septiembre", sep[0]);
                S1.Points.AddXY("Octubre", oct[0]);
                S1.Points.AddXY("Noviembre", nov[0]);
                S1.Points.AddXY("Diciembre", dec[0]);

                S2.Points.AddXY("Enero", jan2[0]);
                S2.Points.AddXY("Febrero", feb2[0]);
                S2.Points.AddXY("Marzo", mar2[0]);
                S2.Points.AddXY("April", apr2[0]);
                S2.Points.AddXY("Mayo", may2[0]);
                S2.Points.AddXY("Junio", jun2[0]);
                S2.Points.AddXY("Julio", jul2[0]);
                S2.Points.AddXY("Agosto", aug2[0]);
                S2.Points.AddXY("Septiembre", sep2[0]);
                S2.Points.AddXY("Octubre", oct2[0]);
                S2.Points.AddXY("Noviembre", nov2[0]);
                S2.Points.AddXY("Diciembre", dec2[0]);

            }
            else if (num == 1)
            {
                S1.Points.AddXY("January", jan[0]);
                S1.Points.AddXY("February", feb[0]);
                S1.Points.AddXY("March", mar[0]);
                S1.Points.AddXY("Abril", apr[0]);
                S1.Points.AddXY("Mayo", may[0]);
                S1.Points.AddXY("Junio", jun[0]);
                S1.Points.AddXY("Julio", jul[0]);
                S1.Points.AddXY("Agosto", aug[0]);
                S1.Points.AddXY("Septiembre", sep[0]);
                S1.Points.AddXY("Octubre", oct[0]);
                S1.Points.AddXY("Noviembre", nov[0]);
                S1.Points.AddXY("Diciembre", dec[0]);

                S2.Points.AddXY("Enero", jan2[0]);
                S2.Points.AddXY("Febrero", feb2[0]);
                S2.Points.AddXY("Marzo", mar2[0]);
                S2.Points.AddXY("April", apr2[0]);
                S2.Points.AddXY("Mayo", may2[0]);
                S2.Points.AddXY("Junio", jun2[0]);
                S2.Points.AddXY("Julio", jul2[0]);
                S2.Points.AddXY("Agosto", aug2[0]);
                S2.Points.AddXY("Septiembre", sep2[0]);
                S2.Points.AddXY("Octubre", oct2[0]);
                S2.Points.AddXY("Noviembre", nov2[0]);
                S2.Points.AddXY("Diciembre", dec2[0]);
            }
            else if (num == 2)
            {
                S1.Points.AddXY("January", jan[0]);
                S1.Points.AddXY("February", feb[0]);
                S1.Points.AddXY("March", mar[0]);
                S1.Points.AddXY("Abril", apr[0]);
                S1.Points.AddXY("Mayo", may[0]);
                S1.Points.AddXY("Junio", jun[0]);
                S1.Points.AddXY("Julio", jul[0]);
                S1.Points.AddXY("Agosto", aug[0]);
                S1.Points.AddXY("Septiembre", sep[0]);
                S1.Points.AddXY("Octubre", oct[0]);
                S1.Points.AddXY("Noviembre", nov[0]);
                S1.Points.AddXY("Diciembre", dec[0]);

                S2.Points.AddXY("Enero", jan2[0]);
                S2.Points.AddXY("Febrero", feb2[0]);
                S2.Points.AddXY("Marzo", mar2[0]);
                S2.Points.AddXY("April", apr2[0]);
                S2.Points.AddXY("Mayo", may2[0]);
                S2.Points.AddXY("Junio", jun2[0]);
                S2.Points.AddXY("Julio", jul2[0]);
                S2.Points.AddXY("Agosto", aug2[0]);
                S2.Points.AddXY("Septiembre", sep2[0]);
                S2.Points.AddXY("Octubre", oct2[0]);
                S2.Points.AddXY("Noviembre", nov2[0]);
                S2.Points.AddXY("Diciembre", dec2[0]);
            }
        }
    }
}
