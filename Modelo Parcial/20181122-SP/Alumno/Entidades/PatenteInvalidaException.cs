using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    [Serializable]
    public class PatenteInvalidaException : Exception
    {
        public PatenteInvalidaException( string message ) : base(message) { }
        public PatenteInvalidaException( string message, Exception inner ) : base(message, inner) { }
     
    }
}
