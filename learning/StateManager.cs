using System;
using learning.Abstract;

namespace learning
{
	public class StateManager
	{
        private IState _state;
        public void SwitchState(IState state)
        {
            _state = state;
        }
        public void Run(IState initialState)
        {
            _state = initialState;
           
                _state.Render();
                var command = _state.GetCommand();
                command.Execute();
            
        }
    }
}

