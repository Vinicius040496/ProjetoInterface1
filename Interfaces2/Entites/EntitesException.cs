using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2.Entites
{
    internal class EntitesException : ApplicationException
    {
        public EntitesException(string Message) : base(Message) 
        {

        }
    }
}
