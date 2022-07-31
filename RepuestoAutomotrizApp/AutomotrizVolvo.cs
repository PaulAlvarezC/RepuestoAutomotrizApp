using RepuestoAutomotrizApp.Volvo;
using RepuestoAutomotrizApp.Repuesto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepuestoAutomotrizApp
{
    public class AutomotrizVolvo : IAutomotriz
    {
        public Axial createAxial(int cantidad)
        {
            return new VolvoAxial(cantidad);
        }

        public Rotula createRotula(int cantidad)
        {
            return new VolvoRotula(cantidad);
        }

        public Terminal createTerminal(int cantidad)
        {
            return new VolvoTerminal(cantidad);
        }
    }
}
