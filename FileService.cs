using System.IO;
using System.Threading.Tasks;

namespace Advent_of_Code_2024
{
    internal class FileService
    {
        public static async Task<string> ReadFromFile(string FileName)
        {  
            using StreamReader reader = new(FileName);
            return await reader.ReadToEndAsync();
        }
    }
}
