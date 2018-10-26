using System;

public class Regex
{
    public Regex()
    {
        var email = new Regex(@"^.+@.+\..+$");
        var bankRekeningNummer = new Regex(@"^\d{3}-\d{7}-\d{2}$");
        var nummerplaat = new Regex(@"^\d-[A-Z]{3}-\d{3}$");
    }
}
