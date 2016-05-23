using System;

namespace Problem21ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main()
        {
            float meters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float mps = Convert.ToSingle((float)(meters) / (float)((hours * 3600) + (minutes * 60) + seconds));
            float kmph = Convert.ToSingle((float)(meters / 1000) / (float)(hours + (minutes / 60) + (seconds / 3600)));
            float mlph = Convert.ToSingle((float)(meters / 1609) / (float)(hours + (minutes / 60) + (seconds / 3600)));


            Console.WriteLine("{0:0.#######}", mps);
            Console.WriteLine("{0:0.#######}", kmph);
            Console.WriteLine("{0:0.#######}", mlph);
        }
    }
}
