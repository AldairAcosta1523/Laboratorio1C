using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1_C
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Annio { get; set;}

        public Vehiculo(string MarcaA, string ModeloA, int AnnioA)
        {
            Marca = MarcaA;
            Modelo = ModeloA;
            Annio = AnnioA;
        }

       

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Año: {Annio}");
            Console.WriteLine("Marca: " + Marca + ", Modelo: " + Modelo + ", Año: " + Annio);
        }
    }
}