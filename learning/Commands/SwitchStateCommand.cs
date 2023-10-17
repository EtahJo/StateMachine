using System;
using learning.Abstract;

namespace learning.Commands
{
 class SwitchStateCommand:ICommand
	{
        private StateManager _manager;
        private IState _newState;
        public SwitchStateCommand(StateManager manager, IState newState)
        {
            _manager = manager;
            _newState = newState;

        }
        public void Execute()
        {
            _newState.Render();
            var command = _newState.GetCommand();
            command.Execute();
           
        }
    }
}

