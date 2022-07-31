using RepuestoAutomotrizApp.Jac;
using RepuestoAutomotrizApp.Repuesto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepuestoAutomotrizApp
{
    public class AutomotrizJac : IAutomotriz
    {
        public Axial createAxial(int cantidad)
        {
            return new JacAxial(cantidad);
        }

        public Rotula createRotula(int cantidad)
        {
            return new JacRotula(cantidad);
        }

        public Terminal createTerminal(int cantidad)
        {
            return new JacTerminal(cantidad);
        }
    }
}
