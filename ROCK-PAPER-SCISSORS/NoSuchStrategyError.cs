using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ROCK_PAPER_SCISSORS
{
    public class NoSuchStrategyError : Exception
    {
        public NoSuchStrategyError()
          : base()
        {
        }

        public NoSuchStrategyError(String message)
          : base(message)
        {
        }

        public NoSuchStrategyError(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected NoSuchStrategyError(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
}
