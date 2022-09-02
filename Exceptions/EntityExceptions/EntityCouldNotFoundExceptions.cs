using System;
namespace Exceptions.EntityExceptions
{
    
    public class EntityCouldNotFoundExceptions : Exception 
    {
        private const string message = "Entity could not found!";

        public EntityCouldNotFoundExceptions() : base(message)
        {

        }

            
    }
}

