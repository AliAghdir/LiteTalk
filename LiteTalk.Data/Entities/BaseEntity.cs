using System.ComponentModel.DataAnnotations;

namespace LiteTalk.Data.Entities
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
