//	Copyright © 2021-2022, EPSITEC SA, CH-1400 Yverdon-les-Bains, Switzerland
//	Author: Pierre ARNAUD, Maintainer: Pierre ARNAUD

[assembly:CLSCompliant(true)]

namespace Bug;

static class Program
{
    public static void Main()
    {
        var customer = new Customer ();
        GenerateWarning.ShowProblem (customer);
    }
}
