using System.Text.Json;

namespace Prog_224_W24_JSON_031124
{
    internal class Program
    {
        static string folderPath = @"../../../JSONFolder/";
        static string artistsJson = @"artists.json";
        static List<Artist> artists = new List<Artist>();

        static void Main(string[] args)
        {
            //string listFromFile = File.ReadAllText(filePath);
            //cds = JsonSerializer.Deserialize<List<CompactDisc>>(listFromFile);

            // Read back a JSON file
            string listFromFile = File.ReadAllText(folderPath + artistsJson);
            artists = JsonSerializer.Deserialize<List<Artist>>(listFromFile);


            Console.WriteLine(artists.Count);

            foreach (Artist item in artists)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine("\tAlbum");
                item.DisplayAlbums();
            }



        } // Main

        public static void CodeExample()
        {
            string folderPath = @"../../../JSONFolder/test.json";




            //Person person = new Person()
            //{
            //    FirstName = "Will",
            //    LastName = "Cram"
            //};

            //JsonSerializerOptions jso = new JsonSerializerOptions()
            //{
            //    WriteIndented = true
            //};

            //string json = JsonSerializer.Serialize(person, jso);

            //File.WriteAllText(folderPath, json);

            ////File.WriteAllText

        }

        public static void SaveJSONDataExample()
        {
            // 1. To use json, you have to add the using
            // System.Text.Json;
            // 2. Create a JsonO
            // 3. Use "JsonSerializer" to convert a object to JSON

            //Person will = new Person()
            //{
            //    Name = "Will",
            //    Age = 40,
            //    Car = new Car("Hyundai","Sonata", 2010, 22434)
            //    {
            //        Engine = new Engine(150)
            //    }

            //};

            List<Artist> artists = new List<Artist>()
            {
                new Artist("Ark Patrol"),
                new Artist("Taylor Swift"),
                new Artist("AR Rahman"),
                new Artist("Garbage")
            };

            artists[0].Albums.Add(new Album("Let Go", 2015));
            artists[0].Albums[0].AddTrack(new Track("Runaway", 150));


            JsonSerializerOptions jso = new JsonSerializerOptions()
            {
                WriteIndented = true

            };


            // string name = JsonSerializer.Serialize(object);



            string json = JsonSerializer.Serialize(artists, jso);

            Console.WriteLine($"Json Object: {json}");

            File.WriteAllText(folderPath + artistsJson, json);


        }

    } // class



} // namespace
