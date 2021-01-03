using System;
using System.Collections.Generic;
using System.Text;

namespace SolidEdge1
{
    class Song                      //Static class attribute - creates an attribute specific to this class Song
    {
        //Declare class attributes
        public string title;        //Public means the attribute can be accessed by anyone
        public string artist;
        public int duration;            
        public static int songCount = 0;    //Attribute about the entire class = same across all the objects of this class

        //Building a constructor - special method that gets called when calling object of this class
        public Song(string aTitle, string aArtist, int aDuration) 
        {
            title = aTitle;     
            artist = aArtist;       //Assigns title to aTitle from constructor
            duration = aDuration;   
            songCount++;            //Increments the song count everytime a song is created
        }

        public int getSongCount()   //Method to get the song count for each object
        {
            return songCount;
        }
        
    }
}
