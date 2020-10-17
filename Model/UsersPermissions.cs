using System;

namespace Model
{
    public class UsersPermissions : BaseEntity
    {
        public Guid UsersPermissions_RolesId { get; set; }
        public Guid UsersPermissions_SystemMenusId { get; set; }

    }
}