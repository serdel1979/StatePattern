using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternState.State
{
    public class CustomerContext 
    {
        private IState _state;

        public CustomerContext()
        {
            _state = new PendingState();
        }

        public void SetState(IState state) => _state = state;

        public IState GetState {
            get
            {
                return _state;
            }
        }

        public void Requesst() => _state.Action(this);
    }
}
