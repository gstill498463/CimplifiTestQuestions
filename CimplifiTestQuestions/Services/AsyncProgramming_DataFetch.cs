namespace CimplifiTestQuestions.Services
{
    public class AsyncProgramming_DataFetch
    {
        private readonly HttpClient _httpClient;

        public AsyncProgramming_DataFetch(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task FetchDataAsync(string url1, string url2)
        {
            //start both tasks
            Task<string> urlFetch1 = _httpClient.GetStringAsync(url1);
            Task<string> urlFetch2 = _httpClient.GetStringAsync(url2);

            //await the tasks
            string data1 = await urlFetch1;
            string data2 = await urlFetch2;

            //print length fetched from urls
            Console.WriteLine($"data length from {url1} is: {data1.Length}");
            Console.WriteLine($"data length from {url2} is: {data2.Length}");
        }
    }
}
