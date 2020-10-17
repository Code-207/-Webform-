using System;

namespace Model
{
    public class WebMenus :BaseEntity
    {
        public string WebMenus_Title { get; set; }
        public string WebMenus_Link { get; set; }
        public Guid WebMenus_ParentId { get; set; }
        public string WebMenus_Icon { get; set; }
    }
}