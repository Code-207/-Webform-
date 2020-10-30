using System;

namespace Model
{
    public class Order 
    {
        public Guid Order_Id { get; set; }
        public string Order_Name { get; set; }
        public string Order_Phone { get; set; }
        public string Order_Amount { get; set; }
        public DateTime Order_Date { get; set; }
        public int Order_IsRead { get; set; }

    }
}