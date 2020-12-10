using System;

public class Song{
  public int ID {get; set;}
  public string Title {get; set;}
  public string ArtistInfo {get; set;}
  
  public Song()
  {

  }
  public Song(int ID, string Title)
  {
    this.ID = ID;
    this.Title = Title;
  }

  public void AddArtistInfo(Artist a1)
  { 
    this.ArtistInfo = a1.FirstName + " " + a1.LastName;
    Console.WriteLine("Artist " + ArtistInfo + " added to the song titled " + Title + ".");
  }

  public void Display()
  {
    Console.WriteLine("Song Info: " + Convert.ToString(ID) + " " + Title + " by: " + ArtistInfo + ".");
  }
}