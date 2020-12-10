using System;

class MainClass {
  public static void Main (string[] args) {
    //creating the artist
    Artist SB = new Artist("Scott", "Bonnette");
    //displaying said artist
    SB.Display();
    //creating the songs
    Song s1 = new Song(1234567890, "Body Terror Song");
    Song s2 = new Song(0987654321, "Survival Song");
    Song s3 = new Song(1122334455, "Kokopelli Face Tattoo");
    //adding the artist's info to those songs
    s1.AddArtistInfo(SB);
    s2.AddArtistInfo(SB);
    s3.AddArtistInfo(SB);
    //displaying song info, including artist info
    s1.Display();
    s2.Display();
    s3.Display();
    //creating the album
    Album a1 = new Album("The Best of Andrew Jackson Jihad");
    //adding songs to the album
    a1.AddSongs(s1);
    a1.AddSongs(s2);
    a1.AddSongs(s3);
    //displaying songs on the album for the 1st time
    a1.DisplaySongs();
    //removing song #2
    //for some reason it's displaying the Album Title rather than the song title and I cant figure out why.
    //Anyway, partial credit here I come!
    a1.RemoveSong(0987654321);
    //Displaying songs on the album for the last time
    a1.DisplaySongs();

    //Thanks for a great semester Professor! - JV
  }
}