using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SpinningDiscs
{
    public class CD : BaseDisc , IOpticalDisc
    {

        public const int StorageCapacityMB = 770;
        public string Artist { get; set; }

        public CD()
        {
        }

        public CD(string discType, string title, int trackCount, int discSPeed, List<string> contents) : base(discType, title, trackCount, discSPeed, contents)
        {
            this.DiscSPeed = discSPeed;  
        }



        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
        public void SpinDisc(CD x)
        {
            Console.WriteLine($"This CD is spinning at {x.DiscSPeed} rpm.");
        }
        public void LoadData()
        {
            Console.WriteLine("Loading................");

        }

        public void WriteData()
        {
            Console.WriteLine("Writing Data.....");
        }

        public void ReadData()
        {
            Console.WriteLine("Reading Data.....");
        }

        public void StoreData()
        {
            Console.WriteLine("Storing Data....");
        }
    }
}
