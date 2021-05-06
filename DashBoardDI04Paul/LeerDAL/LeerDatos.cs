using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace LeerDAL
{
    public class LeerDatos
    {
        //Constantes de las rutas de los ficheros .csv
        const string ruta = "..\\..\\..\\BD\\BD\\1_datos_comerciales.csv";
        const string ruta2 = "..\\..\\..\\BD\\BD\\2_facturacion_comercial.csv";
        public LeerDatos()
        {
        }
        //Metodo para leer el fichero .csv de los comerciales. El ID del comercial esta pasado como parametro.
        public string leerCSV(int idParam)
        {
            //Leer todas las lineas para luego ser procesado
            string[] csv = File.ReadAllLines(ruta);

            //Listas para almacenar cada columna - 1, Ander, Lopez, Bilbao, 35
            var id = new List<string>();
            var nombre = new List<string>();
            var apellido = new List<string>();
            var localidad = new List<string>();
            var edad = new List<string>();

            //Recorrer archivo, split columnas y agregar valores a las listas que les corresponden
            for(int i = 1; i < csv.Length; i++)
            {
                string[] filas = csv[i].Split(',');

                id.Add(filas[0]);
                nombre.Add(filas[1]);
                apellido.Add(filas[2]);
                localidad.Add(filas[3]);
                edad.Add(filas[4]);

            }

            string comercial = null;

            for(int i = idParam; i <= idParam; i++)
            {
            
                comercial = id[i] + "," + nombre[i] + "," + apellido[i] + "," + localidad[i]
                    + "," + edad[i];
                
            }
            //Devuelve el string de los datos del comercial.
           return comercial;
        }
        
        //Metodo que lee el fichero de facturacion para recoger los datos anuales.
        public string leerAnual()
        {
            //Leer todas las lineas para luego ser procesado
            string[] csv = File.ReadAllLines(ruta2);

            var com = new List<string>();
            var emp = new List<string>();
            /*
             * numero_comercial, numero_empresa, enero, febrero, marzo, abril, mayo, junio, julio, agosto, septiembre, octubre, noviembre, diciembre
               1,1,11,23,45,56,3,56,66,33,23,56,12,57
             */
            int total = 0;
            int emp1 = 0;
            int emp2 = 0;
            for (int i = 1; i < csv.Length - 1; i++)
            {
                string[] cols = csv[i].Split(',');
                
                com.Add(cols[0]);
                emp.Add(cols[1]);

                //Convierta los valores desde el segundo indice a int para realizar la suma
                int[] nums = Array.ConvertAll(cols, int.Parse);
                //int[] total = nums.Skip(2);
                total = 0;
                //Condicon que comprueba el ID de la empresa y suma los valores
                for (int j = 0; j <= emp.Count - 1; j++) {
                    if (emp[j].Equals("1"))
                    {
                        emp1 += nums[j];
                        
                    } else if (emp[j].Equals("2"))
                    {
                        emp2 += nums[j];
                        
                    }
                }
            }
            //Devuelvo los dos valores.
            return (emp1.ToString() + "," + emp2.ToString());

        }

        //Lee el fichero para procesar los datos mensuales. Pasado el parametro del comercial.
        public string leerMenusal(int num)
        {
            num = num + 1;
            string comNum = num.ToString();
            int j = 0;
         
            string[] csv = File.ReadAllLines(ruta2);

            var com = new List<string>();
            var emp = new List<string>();

            //Meses de la empresa 1
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
            //Meses de la empresa 2
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

            for (int i = 1; i < csv.Length - 1; i++)
            {
                
                string[] cols = csv[i].Split(',');

                com.Add(cols[0]);
                emp.Add(cols[1]);

               //Condicion que comprueba el numero ID de la empresa para agregar al Array que le corresponde
                if (emp[j].Equals("1") && com[j].Equals(comNum))
                    {
                        jan.Add(cols[2]);
                        feb.Add(cols[3]);
                        mar.Add(cols[4]);
                        apr.Add(cols[5]);
                        may.Add(cols[6]);
                        jun.Add(cols[7]);
                        jul.Add(cols[8]);
                        aug.Add(cols[9]);
                        sep.Add(cols[10]);
                        oct.Add(cols[11]);
                        nov.Add(cols[12]);
                        dec.Add(cols[13]);           
                       
                    }
                    else if (emp[j].Equals("2") && com[j].Equals(comNum))
                    {

                        jan2.Add(cols[2]);
                        feb2.Add(cols[3]);
                        mar2.Add(cols[4]);
                        apr2.Add(cols[5]);
                        may2.Add(cols[6]);
                        jun2.Add(cols[7]);
                        jul2.Add(cols[8]);
                        aug2.Add(cols[9]);
                        sep2.Add(cols[10]);
                        oct2.Add(cols[11]);
                        nov2.Add(cols[12]);
                        dec2.Add(cols[13]);

                    }
                  
                j++;
            }

           string resultado = null;
            //Procesa cada array para poder pasar el string.
            #region foreach array
            foreach (var element in jan)
            {
                resultado += element;
            }

            foreach (var element in feb)
            {
                resultado += "," + element;
            }

            foreach (var element in mar)
            {
                resultado += "," + element;
            }

            foreach (var element in apr)
            {
                resultado += "," + element;
            }

            foreach (var element in may)
            {
                resultado += "," + element;
            }

            foreach (var element in jun)
            {
                resultado += "," + element;
            }

            foreach (var element in jul)
            {
                resultado += "," + element;
            }

            foreach (var element in aug)
            {
                resultado += "," + element;
            }

            foreach (var element in sep)
            {
                resultado += "," + element;
            }

            foreach (var element in oct)
            {
                resultado += "," + element;
            }

            foreach (var element in nov)
            {
                resultado += "," + element;
            }

            foreach (var element in dec)
            {
                resultado += "," + element;
            }

            foreach (var element in jan2)
            {
                resultado += "," + element;
            }

            foreach (var element in feb2)
            {
                resultado += "," + element;
            }

            foreach (var element in mar2)
            {
                resultado += "," + element;
            }

            foreach (var element in apr2)
            {
                resultado += "," + element;
            }

            foreach (var element in may2)
            {
                resultado += "," + element;
            }

            foreach (var element in jun2)
            {
                resultado += "," + element;
            }

            foreach (var element in jul2)
            {
                resultado += "," + element;
            }

            foreach (var element in aug2)
            {
                resultado += "," + element;
            }

            foreach (var element in sep2)
            {
                resultado += "," + element;
            }

            foreach (var element in oct2)
            {
                resultado += "," + element;
            }

            foreach (var element in nov2)
            {
                resultado += "," + element;
            }

            foreach (var element in dec2)
            {
                resultado += "," + element;
            }
            #endregion

            return resultado;
        }
    }
}
