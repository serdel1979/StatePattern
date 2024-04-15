using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternState.State
{
    public class RevisionState : IState
    {
        public void Action(CustomerContext customerContext)
        {
            Console.WriteLine("En revision");
            Console.WriteLine("Puede pasar a cerrado o solucionado");
            customerContext.Requesst();
        }
    }
}
