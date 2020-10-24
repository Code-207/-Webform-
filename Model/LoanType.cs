using System;

namespace Model
{
    public class LoanType 
    {
        public Guid LoanType_Id { get; set; } = Guid.NewGuid();

        public int LoanType_DeleteId { get; set; } = 1;

        public DateTime LoanType_CreateTime { get; set; } = DateTime.Now;
        public DateTime LoanType_UpdateTime { get; set; } = DateTime.Now;
        public string LoanType_Title { get; set; }

        public string LoanType_Detail { get; set; }

        public string LoanType_Image { get; set; }
    }
}