using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.Net
{
    public class FileClass
    {
        public void ReadFileData()
        {
            string loc = "D:\\sample3.txt";
            FileInfo fileInfo = new FileInfo(loc);
            
            if(fileInfo.Exists)
            {
                var data = File.ReadAllText(loc);
                var fileData = data.Split(new char[] {' ', '\n'}, StringSplitOptions.RemoveEmptyEntries);
                int count = 0;
                int maxLength = 0;
                string word = string.Empty;
                foreach(var item in fileData)
                {
                    if (item.Length > maxLength)
                    {
                        maxLength = item.Length;
                        word = item;
                    }
                    count++;
                }

                Console.WriteLine(word + ": Length: {0}", word.Length);
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine("File deosn't exists in provided location");
            }
        }
    }
}
