using System;

namespace Model
{
    public class Product :BaseEntity
    {
        public Guid About_Id { get; set; }

        public string Product_Detail { get; set; }
    }
}