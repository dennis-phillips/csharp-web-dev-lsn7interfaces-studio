using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public string DiscType { get; set; }
        public string Title { get; set; }
        public int TrackCount { get; set; }

        public int DiscSPeed { get; set; }

        public List<string> Contents;

        
        protected BaseDisc()
        {
        }

        protected BaseDisc(string discType, string title, int trackCount, int discSPeed, List<string> contents)
        {
            DiscType = discType;
            Title = title;
            TrackCount = trackCount;
            DiscSPeed = discSPeed;
            Contents = contents;
        }

        public virtual void DisplayContents(List<string> contents)
        {
            int counter = 1;
            foreach (string item in contents)
            {
                
                Console.WriteLine(counter.ToString() + ". "+ item);
                counter++;
            }
        }
        public virtual void DisplayMenu()
        {
            Console.WriteLine($"**************\nTitle: {Title}\nTracks: {TrackCount}\n");

        }

    }
        
} 
