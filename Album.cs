using System;
using System.Collections.Generic;

public class Album{
  public string Title {get; set;}
  public List<Song> SongList = new List<Song>();

  public Album(string Title)
  {
    this.Title = Title;
  }

  public void AddSongs(Song song1)
  {
    SongList.Add(song1);
    Console.WriteLine("Song: " + song1.Title + " has been added to the album: " + Title);
  }
 
  public void RemoveSong(int ID)
  {
    SongList.Remove(SongList.Find(Song => Song.ID == ID));
    Console.WriteLine("The Song: " + Title + "has been removed from list");
  }
  
  public void DisplaySongs()
  {
    Console.WriteLine("Here are the songs in Album: " + Title);
    foreach (var Song in SongList)
    {
      Console.WriteLine(Song.ID + " " + Song.Title + " by: " + Song.ArtistInfo);
    }
  }
}