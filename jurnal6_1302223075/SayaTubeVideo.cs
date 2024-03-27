using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnal6_1302223075
{
    internal class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;

        public SayaTubeVideo (String title)
        {
            Random random = new Random();
            this.id = random.Next(1111, 99999);
            this.title = title; 
            this.playCount = playCount;
            playCount = 0;
        }
        public void IncreasePlayCount(int playCount)
        {
            try
            {
                checked
                {
                    this.playCount = playCount;
                }
            }catch(OverflowException ex)
            {
                Console.WriteLine("Jumlah penambahan play count melebihi batas.");
            }
            
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("ID            : " + this.id);
            Console.WriteLine("Judul         : " + this.title);
            Console.WriteLine("Jumlah Tayang : " + this.playCount);
        }
        public int GetPlayVideo() { return playCount; }
    }
}
