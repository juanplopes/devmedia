public class Cliente:
    [getter(FirstName)]
    _fname as string

    [getter(LastName)]
    _lname as string

    public def constructor([required]fname, [required]lname):
        _fname = fname;
        _lname = lname;
