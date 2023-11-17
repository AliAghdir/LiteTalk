using LiteTalk.Data.Entities.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiteTalk.Data.Entities.Chats
{
    public class ChatGroup : BaseEntity
    {
        [MaxLength(100)]
        public string GroupTitle { get; set; }
        [MaxLength(110)]
        public string GroupToken { get; set; }
        public long OwnerId { get; set; }

        #region Relations
        [ForeignKey("OwnerId")]
        public User Owner { get; set; }
        public ICollection<Chat> Chats { get; set; }
        #endregion
    }
}
