using System;

namespace Model
{
    public class Materials : BaseEntity
    {
        public Guid LoanType_Id { get; set; }
        public string Materials_Detail { get; set; }
    }
}