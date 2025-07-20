using System;

namespace Revision;

public struct Name
{
    private string fname, lname, mname;
    public Name(string first, string last, string middle)
    {
        fname = first;
        lname = last;
        mname = middle;
    }

    public string firstName
    {
        get
        {
            return fname;
        }
        set
        {
            fname = firstName;
        }
    }
    public string lastName
    {
        get
        {
            return lname;
        }
        set
        {
            lname = lastName;
        }

    }
    public string middleName
    {
        get
        {
            return mname;
        }
        set
        {
            mname = middleName;
        }
    }

    public override string ToString()
    {
        return $"{fname},{mname},{lname}";
    }
    public string Initials()
    {
        return $"{fname.Substring(0, 1)}, {mname.Substring(0, 1)}, {lname.Substring(0,1)}";
    }
}
