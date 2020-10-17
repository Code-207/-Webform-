using System;

namespace Model
{
    public class LoanChoose : BaseEntity
    {
        public Guid LoanType_Id { get; set; }
        public string LoanChoose_Detail { get; set; }
    }
}