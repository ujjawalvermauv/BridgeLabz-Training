using System;

class EarthVolume
{
    static void Main()
    {
        double radiusKm = 6378;
        double volumeKm = (4.0 / 3.0) * Math.PI * radiusKm * radiusKm * radiusKm;
        double volumeMiles = volumeKm / (1.6 * 1.6 * 1.6);

        Console.WriteLine("The volume of earth in cubic kilometers is " + volumeKm + " and cubic miles is " + volumeMiles);
    }
}
