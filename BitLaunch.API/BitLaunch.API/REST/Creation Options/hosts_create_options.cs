using Newtonsoft.Json;

namespace BitLaunch
{
    public static class hosts_create_options
    {
        public static async Task<CreationOptionsExtension> GetHostCreateOptions(this BitLaunchClient client, int host_id)
        {
            try
            {
                HttpResponseMessage post = await client.HttpClient.Get("hosts-create-options/" + host_id);
                return JsonConvert.DeserializeObject<CreationOptionsExtension>(await post.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
