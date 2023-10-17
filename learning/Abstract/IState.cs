using System;
namespace learning.Abstract
{
	public interface IState
	{
        void Render();
        ICommand GetCommand();
    }
}

