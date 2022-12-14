
using Newtonsoft.Json;
using System;
using System.IO;

namespace FileDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var originalDirectory = new DirectoryInfo(@"C:\\sil\\");
            string pathString = originalDirectory.ToString();
            DirectoryInfo fileinfo = new DirectoryInfo(pathString);
            foreach (FileInfo item in fileinfo.GetFiles("*.txt"))
            {
                //gün değişmişse dosyayı al ve sil
                if((DateTime.Now - item.CreationTime  ).TotalSeconds >= 1)
                {
                    File.Delete(item.FullName);
                }
            }
         
        }
        
    }
}

