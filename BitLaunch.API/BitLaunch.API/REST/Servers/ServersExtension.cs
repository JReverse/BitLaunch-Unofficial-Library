namespace BitLaunch
{
    public class CreateServerRequest
    {
        public Server server { get; set; }
    }

    public class Server
    {
        public string name { get; set; }
        public int hostID { get; set; }
        public string hostImageID { get; set; }
        public string sizeID { get; set; }
        public string regionID { get; set; }
        public List<string> sshKeys { get; set; }
        public string password { get; set; }
        public string initscript { get; set; }
    }

    public class CreateServerResponse
    {
        public string id { get; set; }
        public string name { get; set; }
        public int host { get; set; }
        public string ipv4 { get; set; }
        public string region { get; set; }
        public string size { get; set; }
        public string sizeDescription { get; set; }
        public string image { get; set; }
        public string imageDescription { get; set; }
        public DateTime created { get; set; }
        public int rate { get; set; }
        public int bandwidthUsed { get; set; }
        public long bandwidthAllowance { get; set; }
        public string status { get; set; }
        public string errorText { get; set; }
        public bool backupsEnabled { get; set; }
        public string version { get; set; }
        public bool abuse { get; set; }
        public int diskGB { get; set; }
    }

}
