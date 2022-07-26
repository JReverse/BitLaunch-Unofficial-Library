using Newtonsoft.Json;

namespace BitLaunch
{
    public static class ListServer
    {
        public static async Task<List<CreateServerResponse>> GetServers(this BitLaunchClient client)
        {
            try
            {
                HttpResponseMessage post = await client.HttpClient.Get("servers");
                return JsonConvert.DeserializeObject<List<CreateServerResponse>>(await post.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
