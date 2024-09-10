namespace CimplifiTestQuestions.Services
{
    public class SquaresOfOddNumbers
    {
        public List<int> GetSquaresOfOddNumbers(List<int> numbers)
        {
            //in this line I am filtering the odd numbers, squaring them and putting them to a list
            var squares = numbers.Where(n => n % 2 != 0).Select(n => n * n).ToList();
            return squares;


        }
    }
}
