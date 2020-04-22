using System;

public class Movie
{

    public string name; // Name of the movie
    public string description; // Description of the movie
    public int duration; // In minutes
    public string genre; // genre name


    // Constructor
    public Movie(string name, string description, int duration, string genre)
    {

        this.name = name;
        this.description = description;
        this.duration = duration;
        this.genre = genre;

        

    }
    public string GetMovieName()
    {
        return this.name;
    }



}