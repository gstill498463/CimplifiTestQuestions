using CimplifiTestQuestions.CustomExceptions;

namespace CimplifiTestQuestions.Services
{
    public class ValidateAge
    {
        //this method validates the age and uses the custom InvalidAgeException exception.
        public void ValidateGivenAge(int age)
        {
            if (age < 0 || age > 120)
            {
                throw new InvalidAgeException("This age is invalid, please enter a valid age.");
            }
            else
            {
                Console.WriteLine("Valid age!");
            }

        }
    }
}
