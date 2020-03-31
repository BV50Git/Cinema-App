using System;

public class Movie
{

    public string name; // Name of the movie
    public string description; // Description of the movie
    public int duration; // In minutes


    // Constructor
    public Movie(string name, string description, int duration)
    {

        this.name = name;
        this.description = description;
        this.duration = duration;

        

    }
    public string GetMovieName()
    {
        return this.name;
    }



}