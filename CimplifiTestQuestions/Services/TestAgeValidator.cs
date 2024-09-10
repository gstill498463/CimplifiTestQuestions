using CimplifiTestQuestions.CustomExceptions;

namespace CimplifiTestQuestions.Services
{
    public class TestAgeValidator
    {
        static void AgeValidationTest(int age)
        {
            ValidateAge ageValidator = new ValidateAge();

            try
            {
                ageValidator.ValidateGivenAge(age);
            }
            catch (InvalidAgeException ex)
            {
                //exception handled here
                Console.WriteLine($"error!: {ex.Message}");
            }
        }
    }
}
