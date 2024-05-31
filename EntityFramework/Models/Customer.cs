using System;
using System.Collections.Generic;

namespace EntityFramework.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<CreditRisk> CreditRisks { get; set; } = new List<CreditRisk>();

}
