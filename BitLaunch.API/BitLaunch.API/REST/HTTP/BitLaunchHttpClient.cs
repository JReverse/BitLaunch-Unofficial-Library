using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace BitLaunch
{
    public class BitLaunchHttpClient
    {
        private readonly BitLaunchClient _BitLaunchClient;
        public string Api { get; set; } = "https://app.bitlaunch.io/api/";
        public BitLaunchHttpClient(BitLaunchClient smsClient)
        {
            _BitLaunchClient = smsClient;
        }

        public async Task<HttpResponseMessage> Get(string endpoint)
        {
            var webClient = new HttpClient();

            while (true)
            {
                try
                {
                    webClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _BitLaunchClient.Api_key);
                    return await webClient.GetAsync(Api + endpoint);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
            }
        }
        public async Task<HttpResponseMessage> Delete(string endpoint)
        {
            var webClient = new HttpClient();

            while (true)
            {
                try
                {
                    webClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _BitLaunchClient.Api_key);
                    return await webClient.DeleteAsync(Api + endpoint);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
            }
        }
        public async Task<HttpResponseMessage> PostCreate(string endpoint, CreateServerRequest PostData)
        {
            var webClient = new HttpClient();

            while (true)
            {
                try
                {
                    webClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/json");
                    webClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                    webClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _BitLaunchClient.Api_key);
                    Console.WriteLine(JsonConvert.SerializeObject(PostData, Formatting.None));
                    return await webClient.PostAsync(Api + endpoint, new StringContent(JsonConvert.SerializeObject(PostData, Formatting.None), Encoding.UTF8, "application/json"));
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
            }
        }
    }
}
