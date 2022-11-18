namespace Cargo4You_Project.Service
{
    public class Courier
    {
        public string CourierName { get; set; }
        public int MinimumVolume { get; set; }
        public int Volume2 { get; set; }
        public int? Volume3 { get; set; } //can be zero
        public int? Volume4 { get; set; } //can be zero
        public int MaxVolume { get; set; }

        public int VolumePrice1 { get; set; }
        public int? VolumePrice2 { get; set; } //can be zero
        public int? VolumePrice3 { get; set; } //can be zero

        public int VolumePrice4 { get; set; } //highest price of any calss

        public int? MinimumWeight { get; set; } //can be zero, courier might not have a minimum
        public int Weight2 { get; set; }
        public int Weight3 { get; set; }
        public int MaxWeight { get; set; }

        public int WeightPrice1 { get; set; }
        public int WeightPrice2 { get; set; }

        public int WeightPrice3 { get; set; }
        public int? ExcessWeightBase { get; set; }//can be zero , only to be used if theres a specific calculation 

        public int? ExcessWeightRate { get; set; } //can be zero  , only to be used if theres a specific calculation 

    }
}
