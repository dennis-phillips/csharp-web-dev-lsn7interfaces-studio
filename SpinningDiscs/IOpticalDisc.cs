using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public interface IOpticalDisc
    {
        public void SpinDisc()
        {
            ;
        }
        
        public void LoadData();

        public void WriteData();

        public void ReadData();

       public  void StoreData();
    }
}
