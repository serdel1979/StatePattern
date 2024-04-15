using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternState.State
{
    public class PendingState : IState
    {
        public void Action(CustomerContext customerContext)
        {
            Console.WriteLine("Puede pasar a revisión o solucionado");
        }
    }
}
