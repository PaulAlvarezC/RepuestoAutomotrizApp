using RepuestoAutomotrizApp.BMW;
using RepuestoAutomotrizApp.Repuesto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepuestoAutomotrizApp
{
    public class AutomotrizBMW : IAutomotriz
    {
        public Axial createAxial(int cantidad)
        {
            return new BMWAxial(cantidad);
        }

        public Rotula createRotula(int cantidad)
        {
            return new BMWRotula(cantidad);
        }

        public Terminal createTerminal(int cantidad)
        {
            return new BMWTerminal(cantidad);  
        }
    }
}
