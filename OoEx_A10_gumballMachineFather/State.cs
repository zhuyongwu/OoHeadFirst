﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_A10_gumballMachineFather {
    public interface State {
        void insertQuarter();
        void ejectQuarter();
        void turnCrank();
        void dispense();
    }
}
