using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1_C
{
    internal class Camion : Vehiculo 
    {
        public double CapacidadCarga { get; set; }

        public Camion(string MarcaA, string ModeloA, int AnnioA, double CapacidadCargaA)
                    : base(MarcaA, ModeloA, AnnioA)
        {
            CapacidadCarga = CapacidadCargaA;
        }
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("CapacidadCarga: " + CapacidadCarga);
        }
    }
}
