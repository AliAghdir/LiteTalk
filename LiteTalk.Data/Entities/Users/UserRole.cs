using LiteTalk.Data.Entities.Roles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteTalk.Data.Entities.Users
{
    public class UserRole:BaseEntity
    {
        public long UserId { get; set; }
        public long RoleId { get; set; }

        #region MyRegion
        [ForeignKey("UserId")]
        public User User { get; set; }
        [ForeignKey("RoleId")]
        public Role Role { get; set; }
        #endregion
    }
}
