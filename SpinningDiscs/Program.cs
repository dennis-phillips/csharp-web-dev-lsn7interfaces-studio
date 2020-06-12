using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            List<string> playList = new List<string>();
            playList.Add("Curtains Up(skit)");
            playList.Add("White America");
            playList.Add("Business");
            playList.Add("Cleanin' Out My Closet");
            playList.Add("Square Dance");
            playList.Add("The Kiss (skit)");
            playList.Add("Soldier");
            playList.Add("Say Goodbye Hollywood");
            playList.Add("Drips (featuring Obie Trice)");
            playList.Add("Without Me");
            playList.Add("Paul Rosenberg (skit)");
            playList.Add("Sing for the Moment");
            playList.Add("Superman (featuring Dina Rae)");
            playList.Add("Hailie's Song");
            playList.Add("Steve Berman(skit)");
            playList.Add("When the Music Stops(featuring D12)");
            playList.Add("Say What You Say(featuring Dr.Dre)");
            playList.Add("'Till I Collapse (featuring Nate Dogg)");
            playList.Add("My Dad's Gone Crazy (featuring Hailie Jade)");
            playList.Add("Curtains Close (skit)");

            CD cd1 = new CD("Compact Disc", "The Eminem Show", playList.Count, 300, playList);

            List<string> chapterList = new List<string>();
            chapterList.Add("Ch1");
            chapterList.Add("Ch2");
            chapterList.Add("Ch3");
            chapterList.Add("Ch4");
            chapterList.Add("Ch5");
            chapterList.Add("Ch6");

            DVD dvd1 = new DVD("Digital Video Disc","300", chapterList.Count, 500, chapterList);

            cd1.DisplayMenu();
            cd1.DisplayContents(playList);
            cd1.LoadData();
            cd1.ReadData();
            cd1.SpinDisc(cd1);
            dvd1.DisplayMenu();
            dvd1.DisplayContents(chapterList);

            // TODO: Call each CD and DVD method to verify that they work as expected.
        }
    }
}
