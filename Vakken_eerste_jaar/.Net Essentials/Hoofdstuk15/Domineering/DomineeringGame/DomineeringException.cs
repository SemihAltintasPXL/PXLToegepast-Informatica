using System;

namespace DomineeringGame
{
    [Serializable]
    internal class DomineeringException : Exception
    {
        public DomineeringException(string message) : base(message)
        {
        }
    }
}