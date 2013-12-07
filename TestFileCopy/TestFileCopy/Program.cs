using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFileCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"F:\视频\电影\极速蜗牛HD中字1280版.rmvb";
            string resPath = @"F:\视频\极速蜗牛HD中字1280版.rmvb";
            using (FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (FileStream fsWrite = new FileStream(resPath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] buffer = new byte[1024 * 1024 * 5];
                   
                    while (true)
                    {
                        int n = fsRead.Read(buffer, 0, buffer.Length);
                        fsWrite.Write(buffer, 0, n);
                        if (n == 0)
                        {
                            break;
                        }
                    }
                }
               
            }
            Console.WriteLine("复制成功");
            Console.ReadKey();
        }
    }
}
