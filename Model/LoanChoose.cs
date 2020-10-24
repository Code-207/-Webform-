using System;

namespace Model
{
    public class LoanChoose 
    {
        public Guid LoanChoose_Id { get; set; } = Guid.NewGuid();

        public int LoanChoose_DeleteId { get; set; } = 1;

        public DateTime LoanChoose_CreateTime { get; set; } = DateTime.Now;
        public DateTime LoanChoose_UpdateTime { get; set; } = DateTime.Now;
        public Guid LoanType_Id { get; set; }
        public string LoanChoose_Detail { get; set; }
    }
}