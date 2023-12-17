using System.ComponentModel;

namespace _01._Songs
{
    internal class Program
    {
        public class Song
        {
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }


            public Song(string typeList, string name, string time)
            {
                this.TypeList = typeList;
                this.Name = name;
                this.Time = time;
            }
        }


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("_");
                //"{typeList}_{name}_{time}"

                string typeList = input[0];
                string name = input[1];
                string time = input[2];

                Song song = new Song(typeList, name, time);
                songs.Add(song);
            }

            string command = Console.ReadLine();

            if(command == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                songs = songs.Where(s => s.TypeList == command).ToList();
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
}