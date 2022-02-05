using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_Max_Sum
{
    public class interview
    {
        public void mobilBill() {
            Console.WriteLine("Please enter Start time with formate\nStart time: 2019-08-31 08:59:13 am");
            string startInput = Console.ReadLine();
            string endInput = Console.ReadLine();
            string[] startInputArray = startInput.Split(' ');
            string[] endInputArray = endInput.Split(' ');

            int ConvertedStartTime, ConvertedendTime;
            
            ConvertedStartTime = timeConverter(startInputArray[3], startInputArray[4]);

            ConvertedendTime = timeConverter(endInputArray[3], endInputArray[4]);

            int[] PeakHr = { timeConverter("9:00:00", "am"), timeConverter("10:59:59", "pm") };

            int taka = 0;
            for (int i= ConvertedStartTime; i <= ConvertedendTime; i = i + 20) {

                if (i < PeakHr[0] && i + 20 < PeakHr[0])
                {
                    taka += 20;
                }
                else if (i < PeakHr[0] && i + 20 > PeakHr[0] || i > PeakHr[0] && i < PeakHr[1])
                {
                    taka += 30;
                }
                else if (i > PeakHr[1]) {
                    taka += 20;
                }
                
             
            
            }

           
            double amount = Convert.ToDouble(taka)/100;
            string mobilBill = String.Format("{0} Taka", amount);
            Console.WriteLine (mobilBill);
        }

        public int timeConverter(string str, string flag)
        {
           
       
            string[] time = str.Split(':');
            int hr = int.Parse(time[0]);
            int min = int.Parse(time[1]);
            int sec = int.Parse(time[2]);
            if (flag == "pm") {
                hr = hr + 12;
            }

            return hr*60*60 + min*60 + sec ;
        }
    }
}
