using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMusicApplication
{
    internal class AlbumsDAO
    {
        // Version 1 contains fake data
        // No connection to the actual data
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=music;";
        public List<Album> getAllAlbums()
        {
            // Empty List
            List<Album> returnThis = new List<Album>() ;

            // Connecting to the MySQL server

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            //Define the SQL statement to fetch all the albums

            MySqlCommand command = new MySqlCommand("SELECT * FROM ALBUMS", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while(reader.Read())
                {
                    Album a = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumTitle = reader.GetString(1),
                        ArtistTitle = reader.GetString(2),
                        YearRelease = reader.GetInt32(3),
                        ImageLink = reader.GetString(4),
                        Summary = reader.GetString(5)
                    };
                    a.Tracks = getTracksForAlbum(a.ID);
                    returnThis.Add(a);
                }
            }
            connection.Close();
            return returnThis;
        }

        public List<Album> searchTitles(String searchTerm)
        {
            // Empty List
            List<Album> returnThis = new List<Album>();

            // Connecting to the MySQL server

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            //Define the SQL statement to fetch all the albums
            String searchWildTerm = "%" + searchTerm + "%";
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT ID, TITLE_ALBUM, ARTIST, RELEASE_YEAR, IMAGE_TITLE, SUMMARY FROM ALBUMS WHERE TITLE_ALBUM LIKE @search";
            command.Parameters.AddWithValue("@search", searchWildTerm);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumTitle = reader.GetString(1),
                        ArtistTitle = reader.GetString(2),
                        YearRelease = reader.GetInt32(3),
                        ImageLink = reader.GetString(4),
                        Summary = reader.GetString(5)
                    };

                    returnThis.Add(a);
                }
            }
            connection.Close();
            return returnThis;
        }

        internal int addOneAlbum(Album album)
        {
            // Empty List
            List<Album> returnThis = new List<Album>();

            // Connecting to the MySQL server

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            //Define the SQL statement to fetch all the albums

            MySqlCommand command = new MySqlCommand("INSERT INTO `albums`(`TITLE_ALBUM`, `ARTIST`, `RELEASE_YEAR`, `IMAGE_TITLE`, `SUMMARY`) VALUES (@albumtitle, @artist, @year, @imageURL, @description)", connection);

            command.Parameters.AddWithValue("@albumtitle", album.AlbumTitle);

            command.Parameters.AddWithValue("@artist", album.ArtistTitle);

            command.Parameters.AddWithValue("@year", album.YearRelease);

            command.Parameters.AddWithValue("@imageURL", album.ImageLink);

            command.Parameters.AddWithValue("@description", album.Summary);

            int newRows = command.ExecuteNonQuery();

            connection.Close();

            return newRows;
        }

        internal int updateAlbum(Album album, int albumID)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Define the SQL statement to fetch all albums

            MySqlCommand command = new MySqlCommand("UPDATE `albums` SET `TITLE_ALBUM`= @albumtitle,`ARTIST`= @artist,`RELEASE_YEAR`= @year,`IMAGE_TITLE`= @imageURL,`SUMMARY`= @summary WHERE `albums`.`ID` = @albumsID;", connection);

            command.Parameters.AddWithValue("@albumtitle", album.AlbumTitle);

            command.Parameters.AddWithValue("@artist", album.ArtistTitle);

            command.Parameters.AddWithValue("@year", album.YearRelease);

            command.Parameters.AddWithValue("@imageURL", album.ImageLink);

            command.Parameters.AddWithValue("@summary", album.Summary);

            int updatedRows = command.ExecuteNonQuery();
            connection.Close();

            return updatedRows;

        }

        internal int updateTrack(Track newTrack, int updateTrackID)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //define the sql statementt to fetch all albumms

            MySqlCommand command = new MySqlCommand("UPDATE `tracks` SET `track_title`= @trackTitle,`number`= @trackNumber,`video_url`= @videoURL,`lyrics`= @lyrics,`albums_ID`= @albumID WHERE `tracks`.`ID` = @trackID;", connection);

            command.Parameters.AddWithValue("@trackTitle", newTrack.Name);

            command.Parameters.AddWithValue("@trackNumber", newTrack.Number);

            command.Parameters.AddWithValue("@videoURL", newTrack.VideoURL);

            command.Parameters.AddWithValue("@lyrics", newTrack.Lyrics);

            command.Parameters.AddWithValue("@albumID", newTrack.AlbumID);

            command.Parameters.AddWithValue("@trackID", updateTrackID);

            int updatedRows = command.ExecuteNonQuery();
            connection.Close();

            return updatedRows;
        }

        internal int newTrack(Track newTrack)
        {
            // Empty List
            List<Album> returnThis = new List<Album>();

            // Connecting to the MySQL server

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            //Define the SQL statement to fetch all the albums

            MySqlCommand command = new MySqlCommand("INSERT INTO `tracks`(`track_title`, `number`, `video_url`, `lyrics`, `albums_ID`) VALUES (,'[value-2]','[value-3]','[value-4]','[value-5]','[value-6]')", connection);

            command.Parameters.AddWithValue("@trackTitle", newTrack.Name);

            command.Parameters.AddWithValue("@trackNumber", newTrack.Number);

            command.Parameters.AddWithValue("@videoURL", newTrack.VideoURL);

            command.Parameters.AddWithValue("@lyrics", newTrack.Lyrics);

            command.Parameters.AddWithValue("@albumID", newTrack.AlbumID);

            int newRows = command.ExecuteNonQuery();

            connection.Close();

            return newRows;
        }
        public List<Track> getTracksForAlbum(int albumID)
        {
            // Empty List
            List<Track> returnThis = new List<Track>();

            // Connecting to the MySQL server

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            //Define the SQL statement to fetch all the albums
            
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM TRACKS WHERE albums_ID = @albumid";
            command.Parameters.AddWithValue("@albumid", albumID);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Track t = new Track
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Number = reader.GetInt32(2),
                        VideoURL = reader.GetString(3),
                        Lyrics = reader.GetString(4),
                    };
                    returnThis.Add(t);
                }
            }
            connection.Close();
            return returnThis;
        }


        public List<JObject> getTracksUsingJoin(int albumID)
        {
            // Empty List
            List<JObject> returnThis = new List<JObject>();

            // Connecting to the MySQL server

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            //Define the SQL statement to fetch all the albums

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT  tracks.ID as TrackID, albums.TITLE_ALBUM, `track_title`, `number`, `video_url` FROM `tracks` JOIN albums ON albums_ID = albums.ID WHERE albums_ID = @albumid";
            command.Parameters.AddWithValue("@albumid", albumID);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    JObject newTrack = new JObject();

                    for(int i = 0; i < reader.FieldCount; i++)
                    {
                        newTrack.Add(reader.GetName(i).ToString(), reader.GetValue(i).ToString());
                    }

                    returnThis.Add(newTrack);
                }
            }
            connection.Close();
            return returnThis;
        }

        internal int deleteTrack(int trackID)
        {
            // Empty List
            List<Album> returnThis = new List<Album>();

            // Connecting to the MySQL server

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            //Define the SQL statement to fetch all the albums

            MySqlCommand command = new MySqlCommand("DELETE FROM `tracks` WHERE `tracks`.`ID` = @trackID", connection);

            command.Parameters.AddWithValue("@trackID",trackID);

            int result = command.ExecuteNonQuery();

            connection.Close();

            return result;
        }
    }
}
