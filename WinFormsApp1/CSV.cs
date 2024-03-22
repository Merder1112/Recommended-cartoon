using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class CsvWriter
    {
        private string filePath = @"D:\Lab\final oop\Recommended cartoon\Data.csv";


        public bool WriteToCsv(int[] count)
        {
            string content = "";
            for(int i = 0; i < count.Length; i++)
            {
                content += "หนังเรื่องที่" + (i + 1) + "," + "จำนวนการเข้าชม = " + count[i] + "\n";
            }
            try
            {
                File.AppendAllText(filePath, content);
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public bool ReadFile()
        {
            try
            {
                File.ReadAllText(filePath);
                return true;
            }
            catch { return false; }
        }

    } 
}
