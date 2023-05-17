﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.State;

namespace VendingMachine.FactoryMethod
{
    public abstract class Report
    {
        public abstract void GenerateReport(List<StateClass> states);
    }
}
