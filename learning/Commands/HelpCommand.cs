using System;
using learning.Abstract;
namespace learning.Commands
{
	public class HelpCommand:ICommand
	{
        public void Execute()
        {
            Console.WriteLine("HELP!");
        }
        
	}
}

