namespace HttpClientCalls.Models
{
    public class PostDataModel
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }

        List<PostDataModel> pList = new List<PostDataModel>();

        public List<PostDataModel> GetPostData()
        {
            string url = "https://jsonplaceholder.typicode.com/posts";

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var call = client.GetAsync(url).Result;

            if (call.IsSuccessStatusCode)
            {
                //we read the data

                var data = call.Content.ReadAsAsync<List<PostDataModel>>();
                data.Wait(); //this is for async calls, wait for all the data to come before return 
                pList = data.Result;
            }
            else
            {
                throw new Exception("Could not get data, please contact Admin");
            }

            return pList;
        }
    }
}
