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
using System.IO;

namespace DashBoardDI04Paul.ControlUsuario
{
    public partial class FacturaAnual : UserControl
    {
        private CsvEnlace controladorBLL;
        public FacturaAnual()
        {
            InitializeComponent();
            chartData();
        }

        private void chartData()
        {
            controladorBLL = new CsvEnlace();
            var result = controladorBLL.facturAnual();

            var leer = result.Split(',');

            var emp1 = new List<string>();
            emp1.Add(leer[0]);

            var emp2 = new List<string>();
            emp2.Add(leer[1]);

           
            this.chart1.Series["Empresa1"].Points.AddXY("Empresas", emp1[0]);
            this.chart1.Series["Empresa2"].Points.AddXY("-", emp2[0]);

        }

    }
}
