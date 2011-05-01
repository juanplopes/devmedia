using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCSharp
{
public class Customer
{
    string _fname;
    public string FirstName { get { return _fname; } }

    string _lname;
    public string LastName { get { return _lname; } }

    public Customer(string fname, string lname)
    {
        if (fname == null) throw new ArgumentNullException("fname");
        if (lname == null) throw new ArgumentNullException("lname");

        _fname = fname;
        _lname = lname;
    }
}
}
