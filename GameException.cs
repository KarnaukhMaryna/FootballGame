using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Football_Game_Model
{
    [Serializable]
    class GameException : Exception
    {
        public override string Message
        {
            get
            {
                return "The team's players use doping. So, the game's ended before it even started";
            }
        }

        public GameException()
        {
        }

        public GameException(string message) : base(message)
        {
        }

        public GameException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected GameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

    }
}
