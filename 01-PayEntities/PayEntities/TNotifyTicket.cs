
namespace PayEntities
{
    public partial class TNotifyTicket : BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public long ForderNum { get; set; }
        public int Fstate { get; set; }
    }
}
