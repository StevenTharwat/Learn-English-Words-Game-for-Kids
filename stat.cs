using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnEnglish
{
    static public class stat
    {
        static public string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "words.json");
        static public string wrongJsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "wrong.json");
        static public Dictionary<string, string> words = ReadJsonFile(jsonFilePath); // =json


        static public void init()
        {
            words = ReadJsonFile(jsonFilePath);
        }

        static public void CreateDefaultJsonFile()
        {
            if (File.Exists(jsonFilePath))
            {
            string json = JsonConvert.SerializeObject(words, Formatting.Indented);
            File.WriteAllText(jsonFilePath, json);
            }
        }

        static public void addToWrongJson(string arabic, string english)
        {
            if (File.Exists(wrongJsonFilePath))
                {
                // Read existing JSON content
                string jsonContent = File.ReadAllText(wrongJsonFilePath);

                // Deserialize JSON to a single WrongData object
                List<WrongData> existingData = JsonConvert.DeserializeObject<List<WrongData>>(jsonContent);

                // Create a new list to store existing and new data
                var wrongDataList = new List<WrongData>();

                // Add existing data to the list if it exists
                if (existingData != null)
                {
                    foreach (var item in existingData)
                    {
                    wrongDataList.Add(item);
                        
                    }
                }

                // Add new data to the list
                wrongDataList.Add(new WrongData { Arabic = arabic, English = english });

                // Serialize the list back to JSON
                string updatedJson = JsonConvert.SerializeObject(wrongDataList, Formatting.Indented);

                // Write the updated JSON content back to the file
                File.WriteAllText(wrongJsonFilePath, updatedJson);

            }
        }

        static public Dictionary<string, string> ReadJsonFile(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        }
    }
}
