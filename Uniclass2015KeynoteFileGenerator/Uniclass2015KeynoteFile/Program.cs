using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uniclass2015KeynoteFile
{
    class Program
    {
        const string filePath = "../../../../Keynote Files/UK_NBS_Uniclass2015.txt";

        static void Main(string[] args)
        {
            Console.WriteLine("Generating Revit keynote file for Uniclass2015...");

            using (var webClient = new System.Net.WebClient())
            {
                // Access and parse Uniclass2015 classification json from the BIM toolkit, to get a collection of tab seperated strings
                string jsonText = webClient.DownloadString("https://toolkit.thenbs.com/Articles/Classification/Uniclass2015");
                var jsonDataRoot = (JArray)(JObject.Parse(jsonText)["data"]);
                var classifications = jsonDataRoot.ToObject<List<List<string>>>();
                string keynoteEntries = classifications
                    // Project the json arrays into tab seperated strings
                    .Select(classificationData => string.Format("{0}\t{1}\t{2}", classificationData[0], classificationData[1], classificationData[2]))
                    // Join the strings, seperating them by newlines
                    .Aggregate((s1, s2) => s1 + "\n" + s2)
                    // Remove the 'Uniclass2015' parent as this is not supported by Revit
                    .Replace("\tUniclass2015\n", "\n");

                // Write the strings to a file
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.Write(keynoteEntries);
                }

                // Open the file for display
                System.Diagnostics.Process.Start(Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), filePath));
            }
        }
    }
}
