//	Copyright © 2021-2022, EPSITEC SA, CH-1400 Yverdon-les-Bains, Switzerland
//	Author: Pierre ARNAUD, Maintainer: Pierre ARNAUD

[assembly:CLSCompliant(true)]

namespace Bug;

public sealed class Customer
{
    public Customer()
    {
        this.FirstName = "";
        this.LastName = "";
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
