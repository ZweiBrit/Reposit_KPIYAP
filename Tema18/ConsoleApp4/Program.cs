using System;
using System.Collections;

class MusicCatalog
{
    private Hashtable catalog; 

    public MusicCatalog()
    {
        catalog = new Hashtable();
    }

    public void AddDisk(string diskName)
    {
        if (!catalog.ContainsKey(diskName))
        {
            catalog.Add(diskName, new ArrayList());
            Console.WriteLine($"Disk '{diskName}' added to the catalog.");
        }
        else
        {
            Console.WriteLine($"Disk '{diskName}' already exists in the catalog.");
        }
    }

    public void RemoveDisk(string diskName)
    {
        if (catalog.ContainsKey(diskName))
        {
            catalog.Remove(diskName);
            Console.WriteLine($"Disk '{diskName}' removed from the catalog.");
        }
        else
        {
            Console.WriteLine($"Disk '{diskName}' does not exist in the catalog.");
        }
    }

    public void AddSongToDisk(string diskName, string songName)
    {
        if (catalog.ContainsKey(diskName))
        {
            ArrayList songs = (ArrayList)catalog[diskName];
            songs.Add(songName);
            Console.WriteLine($"Song '{songName}' added to disk '{diskName}'.");
        }
        else
        {
            Console.WriteLine($"Disk '{diskName}' does not exist in the catalog.");
        }
    }

    public void RemoveSongFromDisk(string diskName, string songName)
    {
        if (catalog.ContainsKey(diskName))
        {
            ArrayList songs = (ArrayList)catalog[diskName];
            if (songs.Contains(songName))
            {
                songs.Remove(songName);
                Console.WriteLine($"Song '{songName}' removed from disk '{diskName}'.");
            }
            else
            {
                Console.WriteLine($"Song '{songName}' does not exist on disk '{diskName}'.");
            }
        }
        else
        {
            Console.WriteLine($"Disk '{diskName}' does not exist in the catalog.");
        }
    }

    public void DisplayCatalog()
    {
        Console.WriteLine("Music Catalog:");

        foreach (DictionaryEntry entry in catalog)
        {
            string diskName = (string)entry.Key;
            ArrayList songs = (ArrayList)entry.Value;

            Console.WriteLine($"Disk: {diskName}");
            Console.WriteLine("Songs:");
            foreach (string song in songs)
            {
                Console.WriteLine($"- {song}");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MusicCatalog catalog = new MusicCatalog();

        catalog.AddDisk("Best Hits");
        catalog.AddSongToDisk("Best Hits", "Song 1");
        catalog.AddSongToDisk("Best Hits", "Song 2");

        catalog.AddDisk("Rock Classics");
        catalog.AddSongToDisk("Rock Classics", "Song A");
        catalog.AddSongToDisk("Rock Classics", "Song B");

        catalog.RemoveSongFromDisk("Best Hits", "Song 2");
        catalog.RemoveDisk("Rock Classics");

        catalog.DisplayCatalog();
    }
}
