﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepuestoAutomotrizApp.Repuesto
{
    public abstract class Axial : IRepuesto
    {

        public abstract string insertarItemProforma();

        public abstract double insertarTotalProforma();
       
    }
}
