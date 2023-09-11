using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string autor { get; set; }
        public string editorial { get; set; }
        public string genero { get; set; }
        public double precio { get; set; }


        public Libro(int codigo, string nombre, string autor, string editorial, string genero, double precio)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.autor = autor;
            this.editorial = editorial;
            this.genero = genero;
            this.precio = precio;
        }

        public void Mostrar()
        {
            Console.WriteLine($"CODIGO: {this.autor} \nNOMBRE: {this.nombre} \nAUTOR: {this.autor}\n" +
                $"EDITORIAL: {this.editorial} \nGENERO: {this.genero} \nPRECIO: ${this.precio}");
        }
        double pValor = 11000.77;
        public void MostrarPrecio()
        {
            if (this.precio > pValor)
            {
                Console.WriteLine($"El precio {this.precio} es mayor");
            }
            else
            {
                Console.WriteLine($"El precio {this.precio} es menor");
            }
        }

    }
}
