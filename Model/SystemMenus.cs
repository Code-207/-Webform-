using System;

namespace Model
{
    public class SystemMenus :BaseEntity
    {
        public string SystemMenus_Title { get; set; }
        public string SystemMenus_Link { get; set; }
        public Guid SystemMenus_ParentId { get; set; }
        public string SystemMenus_Icon { get; set; }
    }
}