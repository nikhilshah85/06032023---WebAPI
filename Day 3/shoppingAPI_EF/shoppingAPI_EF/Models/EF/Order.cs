using System;
using System.Collections.Generic;

namespace shoppingAPI_EF.Models.EF;

public partial class Order
{
    public int OId { get; set; }

    public string? OProduct { get; set; }

    public int? OQty { get; set; }

    public int? OValue { get; set; }
}
