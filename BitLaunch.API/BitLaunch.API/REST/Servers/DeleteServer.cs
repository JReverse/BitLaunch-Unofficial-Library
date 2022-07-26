namespace BitLaunch
{
    public static class DeleteServer
    {
        public static async void Delete(this BitLaunchClient client, string id)
        {
            try
            { 
               await client.HttpClient.Delete("servers/" + id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
