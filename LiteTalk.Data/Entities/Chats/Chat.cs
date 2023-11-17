using LiteTalk.Data.Entities.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LiteTalk.Data.Entities.Chats
{
    public class Chat:BaseEntity
    {
        public string TextBody { get; set; }
        public long UserId { get; set; }
        public long ChatGroupId { get; set; }

        #region Relations
        [ForeignKey("UserId")]
        public User User { get; set; }
        [ForeignKey("GroupId")]
        public ChatGroup ChatGroup { get; set; }
        #endregion
    }
}
