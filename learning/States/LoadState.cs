using System;
using learning.Abstract;
using learning.Commands;
namespace learning.States
{
	 class LoadState:IState
	{
        private StateManager _manager;
        private IState _lastState;

        public LoadState(StateManager manager, IState lastState)
        {
            _manager = manager;
            _lastState = lastState;
        }

        public void Render()
        {

            Console.WriteLine("----------");
            Console.WriteLine("SAVE STATE ------");
            Console.WriteLine("[back]");
            Console.WriteLine("-------------");
        }
        public ICommand GetCommand()
        {
            var input=Console.ReadLine();
            if(input == "back")
            {
                return new SwitchStateCommand(_manager, _lastState);
            }
            return new InvalidCommand();
        }

      
    }
}

