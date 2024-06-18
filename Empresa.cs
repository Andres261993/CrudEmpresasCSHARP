using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEmpresaPOO
{
    internal class Empresa
    {
        private string ruc;
        private string razon_social;
        private string direccion;

        public Empresa(string r, string rs, string d)
        {
            this.ruc = r;
            this.razon_social = rs;
            this.direccion = d;
        }

        public string Ruc { get => ruc; set => ruc = value;}
        public string Razon { get => razon_social; set => razon_social = value;}
        public string Direccion { get => direccion; set => direccion = value; }

        public void Mostrar()
        {
            Console.WriteLine($"Ruc:  {this.ruc} ");
            Console.WriteLine($"Razon Social:  {this.razon_social} ");
            Console.WriteLine($"Dirección:  {this.direccion} ");
        }

        public string ToCsv()
        {
            return $"{this.ruc},{this.razon_social},{this.direccion}";
        }

        public static Empresa FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            if (values.Length != 3) 
            {
                throw new ArgumentException("El formato csv no es valido");
            }
            return new Empresa(values[0], values[1], values[2]);
        }
    }
}
