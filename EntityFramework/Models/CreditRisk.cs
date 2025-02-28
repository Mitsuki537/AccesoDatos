﻿using System;
using System.Collections.Generic;

namespace EntityFramework.Models;

public partial class CreditRisk
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int CustomerId { get; set; }

    public virtual Customer Customer { get; set; } = null!;
}
