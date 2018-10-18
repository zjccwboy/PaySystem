

using Base.Common.Attritubes;

namespace PayEntities
{
    public class TpaySetting : BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public string Fsid { get; set; }
        public string FprivateKey { get; set; }
        public string FpublicKey { get; set; }
        public int FpayType { get; set; }
        public string Femail { get; set; }
        public string FredirectUrl { get; set; }
        public string Fextened { get; set; }
        public string FlastInfo { get; set; }
    }
}
