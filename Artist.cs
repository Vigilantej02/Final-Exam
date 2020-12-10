using System;

public class Artist{
  public string FirstName {get; set;}
  public string LastName {get; set;}
  public string Email {get; set;}

  public Artist(string FirstName, string LastName)
  {
    this.FirstName = FirstName;
    this.LastName = LastName;
    Email = "Unknown.";
  }
  public void Display()
  {
    Console.WriteLine("Artist Info: " + FirstName + " " + LastName);
  }
}