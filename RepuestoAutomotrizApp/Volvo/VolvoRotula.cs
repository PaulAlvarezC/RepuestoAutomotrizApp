using RepuestoAutomotrizApp.Repuesto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepuestoAutomotrizApp.Volvo
{
    public class VolvoRotula : Rotula
    {
        //Atributos
        const string DESCRIPCION = "Rotula original Volvo";
        const double PRECIO = 10.00;
        int cantidad;

        //Varibale global
        double total = 0.00;
        public VolvoRotula(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public override string insertarItemProforma()
        {
            double importe = this.cantidad * PRECIO;
            string presupuesto = "|  " + cantidad + "\t| " + "\t" + DESCRIPCION + "\t\t| " + "   " + PRECIO +
                                "    |   " + importe + "\t" + "   |\n" +
                                "---------------------------------------------------------------------------\n";


            return presupuesto;
        }

        public override double insertarTotalProforma()
        {
            total = cantidad * PRECIO;
            return total;
        }
    }
}
