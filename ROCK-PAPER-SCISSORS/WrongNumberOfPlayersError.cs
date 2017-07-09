using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ROCK_PAPER_SCISSORS
{
    public class WrongNumberOfPlayersError : Exception
    {
        public WrongNumberOfPlayersError()
          : base()
        {
        }
        
        public WrongNumberOfPlayersError(String message)
          : base(message)
        {
        }
        
        public WrongNumberOfPlayersError(String message, Exception innerException)
          : base(message, innerException)
        {
        }
        
        protected WrongNumberOfPlayersError(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
}
