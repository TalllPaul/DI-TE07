using System;
using System.Collections.Generic;

using System.Text;
using LeerDAL;

namespace EnlazarBLL
{

    public class CsvEnlace
    {
        public LeerDatos controladorDAL;
        public CsvEnlace()
        {
            controladorDAL = new LeerDatos();
        }

        public string comercianteDatos(int id)
        {
            //LLamar al DAL para conseguir datos.
            string comDatos = controladorDAL.leerCSV(id);
            
            return comDatos;
        }

        public string facturAnual()
        {
            string anuales = controladorDAL.leerAnual();
            Console.WriteLine(anuales);
            return anuales;
        }

        public string mensual(int num)
        {
            string valores = controladorDAL.leerMenusal(num);

            return valores;
        }

    }


}
