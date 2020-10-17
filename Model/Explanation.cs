using System;

namespace Model
{
    public class Explanation : BaseEntity
    {
        public Guid LoanType_Id { get; set; }
        public string Explanation_Detail { get; set; }

    }
}