using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {

        public const int StorageCapacityGB = 24;

        public DVD(string discType, string title, int trackCount, int discSPeed, List<string> contents) : base(discType, title, trackCount, discSPeed, contents)
        {
        }

        // TODO: Implement your custom interface.

        public void SpinDisc(DVD x)
        {
            Console.WriteLine($"This DVD is spinning at {x.DiscSPeed} ");
        }
        public void LoadData()
        {
            Console.WriteLine("Pointless function to call");
        }

        public void WriteData()
        {
            Console.WriteLine("Pointless function to call");
        }

        public void ReadData()
        {
            Console.WriteLine("Pointless function to call");
        }

        public void StoreData()
        {
            Console.WriteLine("Pointless function to call");
        }

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
    }
}
