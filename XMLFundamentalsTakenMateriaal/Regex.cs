using System;

public class Regex
{
    public Regex()
    {
        var email = new Regex(@".+@.+\..+");
        var bankRekeningNummer = new Regex(@"[0-9]{3}-[0-9]{7}-[0-9]{2}");
        var nummerplaat = new Regex(@"[0-9]-[A-Z]{3}-[0-9]{3}");
    }
}
