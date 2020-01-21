using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Core.Command.Base
{
    public interface ICommand<T> where T : class
    {
        T Execute();
    }
}
