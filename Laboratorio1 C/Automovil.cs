using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1_C
{
    public class Automovil : Vehiculo
    {
        public string Combustible { get; set; }

        public Automovil(string MarcaA, string ModeloA, int AnnioA, string CombustibleA)
            : base(MarcaA, ModeloA, AnnioA)
        {
            Combustible = CombustibleA;
        }
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Combustible: " + Combustible);
        }
    }
}

