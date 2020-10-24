using System;

namespace Model
{
    public class Product 
    {
        public Guid Product_Id { get; set; } = Guid.NewGuid();

        public int Product_DeleteId { get; set; } = 1;

        public DateTime Product_CreateTime { get; set; } = DateTime.Now;
        public DateTime Product_UpdateTime { get; set; } = DateTime.Now;
        public Guid About_Id { get; set; }

        public string Product_Detail { get; set; }
    }
}