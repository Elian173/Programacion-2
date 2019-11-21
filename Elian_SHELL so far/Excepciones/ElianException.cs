using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{

    [Serializable]
    public class ElianException: Exception
    {
        public ElianException()
        {
        }
        public ElianException( string message ) : base(message) { }
        public ElianException( string message, Exception inner ) : base(message, inner) { }

    }
}
