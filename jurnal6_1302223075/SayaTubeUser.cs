using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnal6_1302223075
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadVideo;
        private String username;

        public SayaTubeUser(String username)
        {
            Random random = new Random();
            this.id = random.Next(1111, 99999);
            this.username = username;
            this.uploadVideo = new List<SayaTubeVideo>();
            
        }
        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach (SayaTubeVideo video in uploadVideo)
            {
                total += video.GetPlayVideo();
            }
            return total;
        }
        public void AddVideo(SayaTubeVideo video)
        {
            this.uploadVideo.Add(video);
        }
        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("User: " + username);
            int i = 0;
            foreach (SayaTubeVideo video in uploadVideo)
            {
                Console.WriteLine("Video " + i);
                video.PrintVideoDetails();
                i++;
            }
            

        }
    }
}
