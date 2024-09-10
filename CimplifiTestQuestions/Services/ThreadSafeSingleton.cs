namespace CimplifiTestQuestions.Services
{
    public class ThreadSafeSingleton
    {
        //thread safe using lazy initialization, making sure the instance is created only when needed
        private static readonly Lazy<ThreadSafeSingleton> _instance = new Lazy<ThreadSafeSingleton>(() => new ThreadSafeSingleton());

        //private constructor prevents immediate initialization
        private ThreadSafeSingleton()
        {
        }

        //gets instance of singleton class with a public method
        public static ThreadSafeSingleton GetInstance()
        {
            return _instance.Value;
        }


        public string RewardingSingletonCode()
        {
            return "nicely done!";
        }
    }
}
