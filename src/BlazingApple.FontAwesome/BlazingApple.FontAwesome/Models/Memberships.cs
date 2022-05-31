using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingApple.FontAwesome.Models;

/// <summary>The types of memberships a <see cref="FontAwesomeIcon" /> has, and the styles available to them.</summary>
public class Memberships
{
    /// <summary>The list of styles within the "free" membership.</summary>
    public List<string>? Free { get; set; }

    /// <summary>The list of styles within the "paid" membership.</summary>
    public List<string>? Paid { get; set; }
}
