using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPlanner
{
    internal class FileOps
    {
        internal void SaveTasksToFile(string fileName, List<string> tasks)
        {
            using StreamWriter writer = new(fileName);
            foreach (string task in tasks)
            {
                writer.WriteLine(task);
            }
        }

        internal List<string> LoadTasksFromFile(string fileName)
        {
            List<string> loadedTasks = new();

            if (File.Exists(fileName))
            {
                using StreamReader reader = new(fileName);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    loadedTasks.Add(line);
                }
            }

            return loadedTasks;
        }

        internal void ClearFile(string fileName)
        {
            File.WriteAllText(fileName, string.Empty);
        }
    }
}
