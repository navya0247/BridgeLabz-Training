using System;
using System.Collections.Generic;
using System.Text;

class LegacyAPI
{
    [Obsolete("OldFeature is obsolete. Use NewFeature instead.")]
    public void OldFeature()
    {
        Console.WriteLine("Old feature executed");
    }

    public void NewFeature()
    {
        Console.WriteLine("New feature executed");
    }
}

class ObsoleteAttribute
{
    public static void Main(string[] args)
    {
        LegacyAPI api = new LegacyAPI();

        api.OldFeature();   // Warning will appear
        api.NewFeature();
    }
}