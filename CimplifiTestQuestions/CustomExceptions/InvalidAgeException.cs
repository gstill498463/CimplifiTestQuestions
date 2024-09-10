namespace CimplifiTestQuestions.CustomExceptions
{
    public class InvalidAgeException : Exception
    {
        //generic constructor
        public InvalidAgeException()
        {
        }

        //constructor that takes a message
        public InvalidAgeException(string message) : base(message)
        {
        }

        //constructor that takes a message as well as an inner exception
        public InvalidAgeException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
