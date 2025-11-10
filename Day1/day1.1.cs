using System;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Linq;

namespace Advent_of_Code_2024.Day1
{
    internal static class Day1_1
    {

        private static (int[] Left, int[] Right) SplitContent(string FileContent)
        {
            var lines = FileContent.Split(new[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);

            var LeftList = new List<int>(lines.Length);
            var RightList = new List<int>(lines.Length);

            foreach(var line in lines){
                var columns = line.Split("   ");

                if(int.TryParse(columns[0].Trim(), out int left) && int.TryParse(columns[1].Trim(), out int right)){
                    LeftList.Add(left);
                    RightList.Add(right);
                }
            }

            return (LeftList.ToArray(), RightList.ToArray());
        }

        private static async Task<string> GetFileContent()
        {
            string FileName = "./Day1/day1.1.input.txt";
            string FileContent = await FileService.ReadFromFile(FileName);


            return FileContent;
        }
        
        public static async Task<int> SumDiff()
        {
            string content = await GetFileContent();
            (int[] LeftList, int[] RightList) = SplitContent(content);

            Array.Sort(LeftList);
            Array.Sort(RightList);

            int sum = 0;

            for (int i = 0; i < LeftList.Length; i++)
            {
                sum += Math.Abs(LeftList[i] - RightList[i]);
            }


            return sum;
        }
    }
   
} 
