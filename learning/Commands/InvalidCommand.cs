using System;
using learning.Abstract;
namespace learning.Commands
{
	public class InvalidCommand:ICommand
	{
        public void Execute()
        {
            Console.WriteLine("Invalid command");
        }
    }
}

