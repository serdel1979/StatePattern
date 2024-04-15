using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternState.State
{
    public class ClosedState : IState
    {
        public void Action(CustomerContext customerContext)
        {
            Console.WriteLine("Cerrado, no puede cambiar de estado");
            customerContext.Requesst();
        }
    }
}
