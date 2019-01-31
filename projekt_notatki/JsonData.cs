using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace projekt_notatki
{
    public class JsonData
    {
        static Dictionary<string, List<Note>> notes = new Dictionary<string, List<Note>>();

        public static List<Note> allNotes = new List<Note>();
        //public static List<Note> homeNotes = new List<Note>();
        //public static List<Note> workNotes = new List<Note>();
      

        public static void getNotesFromJson()
        {
            string path = "test.json";
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                notes = JsonConvert.DeserializeObject<Dictionary<string, List<Note>>>(json);
                allNotes.AddRange(notes["all"]);
                // homeNotes.AddRange(notes["home"]);
                // workNotes.AddRange(notes["work"]);
                allNotes.Sort((t2, t1) => t2.Date.CompareTo(t1.Date));
                notes.Clear();
            }
        }

        public static void setNotesToJson()
        {
            string path = "test.json";

            JsonSerializerSettings microsoftDateFormatSettings = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
            };

            notes.Clear();
            notes.Add("all", allNotes);
            //notes.Add("home", homeNotes);          
           // notes.Add("work", workNotes);
        

            string json = JsonConvert.SerializeObject(notes, Formatting.Indented, microsoftDateFormatSettings);
            FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            file.Close();
            File.WriteAllText(path, json);

        }
    }
}
