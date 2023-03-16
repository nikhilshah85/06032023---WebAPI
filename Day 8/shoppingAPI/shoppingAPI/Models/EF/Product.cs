using System;
using System.Collections.Generic;

namespace shoppingAPI.Models.EF;

public partial class Product
{
    public int Pid { get; set; }

    public string? PName { get; set; }

    public string? PCategory { get; set; }

    public int? PPrice { get; set; }

    public bool? PIsInStock { get; set; }
}
