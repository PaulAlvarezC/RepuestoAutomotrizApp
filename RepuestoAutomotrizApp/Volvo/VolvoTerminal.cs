﻿using RepuestoAutomotrizApp.Repuesto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepuestoAutomotrizApp.Volvo
{
    public class VolvoTerminal : Terminal
    {
        //Atributos
        const string DESCRIPCION = "Terminal original Volvo";
        const double PRECIO = 15.55;
        int cantidad;

        //Varibale global
        double total = 0.00;
        public VolvoTerminal(int cantidad)
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
