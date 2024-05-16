using Newtonsoft.Json;

namespace Helper
{
    public class WriteToJson
    {
        public static string WriteToFileAsJson<T>(T data, string fileName)
        {
            string path = String.Empty;
            if (String.IsNullOrEmpty(fileName))
            {
                Console.WriteLine("имя файла не корректно");
            }
            else
            {
                string json = JsonConvert.SerializeObject(data, Formatting.Indented);
                path = $"D:\\Pr\\ExamPapers\\ExamPapers\\Data\\{fileName}";
                File.WriteAllText(path, json);
            }

            return path;
        }
    }
}
