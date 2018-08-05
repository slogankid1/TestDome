using System;

public class Song
{
    private string name;
    public Song NextSong { get; set; }

    public Song(string name)
    {
        this.name = name;
    }

    public bool IsRepeatingPlaylist()
    {

        while (NextSong != null)
        {
            if (NextSong.name == name) { return true; }
            NextSong = NextSong.NextSong;
        }

        return false;
    }

    public static void Main(string[] args)
    {
        Song first = new Song("Hello");
        Song second = new Song("Eye of the tiger");

        first.NextSong = second;
        second.NextSong = first;

        Console.WriteLine(first.IsRepeatingPlaylist());
        Console.ReadKey();
    }
}