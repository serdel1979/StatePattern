﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternState.State
{
    public interface IState
    {
        public void Action(CustomerContext customerContext);
    }
}
