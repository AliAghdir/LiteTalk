using LiteTalk.Data.Entities.Users;
using LiteTalk.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteTalk.Data.Entities.Roles
{
    public class RolePermission:BaseEntity
    {
        public long RoleId { get; set; }
        public Permission Permission { get; set; }

        #region Relations
        [ForeignKey("RoleId")]
        public Role Role { get; set; }
        #endregion
    }
}
