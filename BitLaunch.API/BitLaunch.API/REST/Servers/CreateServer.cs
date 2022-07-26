using Newtonsoft.Json;

namespace BitLaunch
{
    public static class CreateServer
    {
        public static async Task<CreateServerRequest> Create(this BitLaunchClient client, string name, int hostID, string hostImageID, string sizeID, string regionID, string password, string? initscript = null, List<string>? sshKeys = null)
        {
            try
            {
                Server server = new Server();
                server.name = name;
                server.hostID = hostID;
                server.hostImageID = hostImageID;
                server.sizeID = sizeID;
                server.regionID = regionID;
                server.password = password;
                if (sshKeys != null)
                    server.sshKeys = sshKeys;
                if (initscript != null)
                    server.initscript = initscript;
                HttpResponseMessage post = await client.HttpClient.PostCreate("servers", new CreateServerRequest { server = server});
                Console.WriteLine(await post.Content.ReadAsStringAsync());
                return JsonConvert.DeserializeObject<CreateServerRequest>(await post.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}

