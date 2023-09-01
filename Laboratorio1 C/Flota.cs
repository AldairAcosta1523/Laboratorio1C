using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1_C
{
    public class Flota
    {
        private List<Vehiculo> vehiculos { get; set; }

        public Flota()
        {
            vehiculos = new List<Vehiculo>();
        }

        public void MostrarFlota()
        {
            foreach (var vehiculo in vehiculos)
            {
                vehiculo.MostrarInformacion();
            }
        }
    }
}
