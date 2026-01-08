class Smartphone
{
    private String _telnummer;
    private String _pincode;
    public Smartphone(String telnummer, String pincode)
    {
        _telnummer = telnummer;
        _pincode = pincode;
    }
    // definieer hier de Property Telnummer

    public String Telnummer
    {
        get { return _telnummer; }
        set { _telnummer = value; }
    }

    // definieer hier de Property Pincode

    public String Pincode
    {
        get { return _pincode; }
        set { _pincode = value; }
    }

    static void Main()
    {
        Smartphone mijnSmartphone = new Smartphone("0475/12.34.56", "1234");
        Console.WriteLine("Mijn telefoonnummer is: " + mijnSmartphone.Telnummer);
        Console.WriteLine("Mijn pincode is: " + mijnSmartphone.Pincode);
    }
}