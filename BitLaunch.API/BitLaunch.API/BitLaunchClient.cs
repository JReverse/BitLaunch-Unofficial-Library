namespace BitLaunch
{
    public class BitLaunchClient
    {
        public string Api_key { get; set; }

        public BitLaunchHttpClient HttpClient { get; private set; }

        public BitLaunchClient(string api_key)
        {
            HttpClient = new BitLaunchHttpClient(this);
            Api_key = api_key;
        }
    }
}
