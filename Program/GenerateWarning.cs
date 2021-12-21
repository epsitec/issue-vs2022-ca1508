//	Copyright © 2021, EPSITEC SA, CH-1400 Yverdon-les-Bains, Switzerland
//	Author: Pierre ARNAUD, Maintainer: Pierre ARNAUD

namespace Bug;

public static class GenerateWarning
{
    public static string ShowProblem(Customer? customer)
    {
        if (customer is null)
        {
            return "";
        }

        if ((customer.FirstName.Length == 0) &&
            (customer.LastName.Length == 0)) // warning CA1508: 'customer.LastName.Length == 0' is always 'true'. Remove or refactor the condition(s) to avoid dead code.
        {
            return "";
        }

        return customer.FirstName + " " + customer.LastName;
    }
}
