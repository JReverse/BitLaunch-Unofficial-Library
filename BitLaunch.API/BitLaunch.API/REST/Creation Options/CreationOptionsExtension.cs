namespace BitLaunch
{
    public class Disk
    {
        public string type { get; set; }
        public int count { get; set; }
        public string size { get; set; }
        public string unit { get; set; }
    }

    public class HostOptions
    {
        public bool rebuild { get; set; }
        public bool resize { get; set; }
        public bool backups { get; set; }
        public bool userScript { get; set; }
        public bool access { get; set; }
    }

    public class Image
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public int minDiskSize { get; set; }
        public List<object> unavailableRegions { get; set; }
        public Version version { get; set; }
        public List<Version> versions { get; set; }
        public int extraCostPerMonth { get; set; }
        public bool windows { get; set; }
        public List<object> unavailablePlans { get; set; }
    }

    public class PlanType
    {
        public string type { get; set; }
        public string description { get; set; }
        public string name { get; set; }
    }

    public class Region
    {
        public int id { get; set; }
        public string name { get; set; }
        public string iso { get; set; }
        public Subregion subregion { get; set; }
        public List<Subregion> subregions { get; set; }
    }

    public class CreationOptionsExtension
    {
        public int hostID { get; set; }
        public List<Image> image { get; set; }
        public List<Region> region { get; set; }
        public List<Size> size { get; set; }
        public bool available { get; set; }
        public int bandwidthCost { get; set; }
        public List<PlanType> planTypes { get; set; }
        public HostOptions hostOptions { get; set; }
    }

    public class Size
    {
        public string id { get; set; }
        public string slug { get; set; }
        public int bandwidthGB { get; set; }
        public int cpuCount { get; set; }
        public int diskGB { get; set; }
        public List<Disk> disks { get; set; }
        public int memoryMB { get; set; }
        public int costPerHr { get; set; }
        public int costPerMonth { get; set; }
        public string planType { get; set; }
    }

    public class Subregion
    {
        public string id { get; set; }
        public string description { get; set; }
        public string slug { get; set; }
        public List<string> unavailableSizes { get; set; }
    }

    public class Subregion2
    {
        public string id { get; set; }
        public string description { get; set; }
        public string slug { get; set; }
        public List<string> unavailableSizes { get; set; }
    }

    public class Version
    {
        public string id { get; set; }
        public string description { get; set; }
        public bool passwordUnsupported { get; set; }
    }

    public class Version2
    {
        public string id { get; set; }
        public string description { get; set; }
        public bool passwordUnsupported { get; set; }
    }
}
