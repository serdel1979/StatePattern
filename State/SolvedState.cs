using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternState.State
{
    public class SolvedState : IState
    {
        public void Action(CustomerContext customerContext)
        {
            Console.WriteLine("Solucionado, no puede cambiar de estado");
        }
    }
}
