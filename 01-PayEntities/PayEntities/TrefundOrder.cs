

namespace PayEntities
{
    public class TrefundOrder : BaseEntity
    {
        public long FoderNum { get; set; }
        public string FmorderNum { get; set; }
        public int Fmid { get; set; }
        public decimal Famount { get; set; }
        public int FrefundType { get; set; }
        public decimal FrefundCharge { get; set; }
        public decimal FrefundAmount { get; set; }
    }
}
