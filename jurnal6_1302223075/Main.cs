// See https://aka.ms/new-console-template for more information
using jurnal6_1302223075;

class main
{
    public static void Main(String[] args)
    {
        SayaTubeUser user1 = new SayaTubeUser("lando");
        SayaTubeVideo vid1 = new SayaTubeVideo("Harry Potter and the sorcier stone");
        vid1.IncreasePlayCount(20);
        user1.AddVideo(vid1);

        SayaTubeUser user2 = new SayaTubeUser("max");
        SayaTubeVideo vid2 = new SayaTubeVideo("Avengers Endgame");
        vid1.IncreasePlayCount(20);
        user1.AddVideo(vid2);

        SayaTubeUser user3 = new SayaTubeUser("charles");
        SayaTubeVideo vid3 = new SayaTubeVideo("Star Wars The Last Jedi");
        vid1.IncreasePlayCount(20);
        user1.AddVideo(vid3);

        SayaTubeUser user4 = new SayaTubeUser("Baskara");
        SayaTubeVideo vid4 = new SayaTubeVideo("Bebas");
        vid1.IncreasePlayCount(20);
        user1.AddVideo(vid4);

        SayaTubeUser user5 = new SayaTubeUser("max");
        SayaTubeVideo vid5 = new SayaTubeVideo("X men Dark Phoenix");
        vid1.IncreasePlayCount(20);
        user1.AddVideo(vid5);

        SayaTubeUser user6 = new SayaTubeUser("lando");
        SayaTubeVideo vid6 = new SayaTubeVideo("Harry Potter and the goblet of fire");
        vid1.IncreasePlayCount(20);
        user1.AddVideo(vid6);

        SayaTubeUser user7 = new SayaTubeUser("max");
        SayaTubeVideo vid7 = new SayaTubeVideo("Avengers Infinity War");
        vid1.IncreasePlayCount(20);
        user1.AddVideo(vid7);

        SayaTubeUser user8 = new SayaTubeUser("charles");
        SayaTubeVideo vid8 = new SayaTubeVideo("Transformers");
        vid1.IncreasePlayCount(20);
        user1.AddVideo(vid8);

        SayaTubeUser user9 = new SayaTubeUser("Baskara");
        SayaTubeVideo vid9 = new SayaTubeVideo("Si Doel");
        vid1.IncreasePlayCount(20);
        user1.AddVideo(vid9);

        SayaTubeUser user10 = new SayaTubeUser("max");
        SayaTubeVideo vid10 = new SayaTubeVideo("Wolverine");
        vid1.IncreasePlayCount(20);
        user1.AddVideo(vid10);

        Console.WriteLine("== Review Film oleh Dara Sheiba ==");
        user1.PrintAllVideoPlayCount();
        user2.PrintAllVideoPlayCount();
        user3.PrintAllVideoPlayCount();
        user4.PrintAllVideoPlayCount();
        user5.PrintAllVideoPlayCount();
        user6.PrintAllVideoPlayCount();
        user7.PrintAllVideoPlayCount();
        user8.PrintAllVideoPlayCount();
        user9.PrintAllVideoPlayCount();
        user10.PrintAllVideoPlayCount();
    }
}

