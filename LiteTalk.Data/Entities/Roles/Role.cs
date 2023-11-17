using System.ComponentModel.DataAnnotations;

namespace LiteTalk.Data.Entities.Roles
{
    public class Role : BaseEntity
    {
        [MaxLength(50)]
        public string Title { get; set; }
    }
}
