using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

class EntryPoint
{
    static void Main()
    {
        string sortedFileName = @"\Video Files";
        DirectoryInfo mainPath = new DirectoryInfo(@"F:\Chaion memory card");
        DirectoryInfo sortedPath = new DirectoryInfo(mainPath + sortedFileName);

        if(!sortedPath.Exists)
        {
            sortedPath.Create();
        }


        //int i = 0;
        FileInfo[] allFiles = mainPath.GetFiles();
        List<FileInfo> videoFiles = new List<FileInfo>();
        string[] extensions = { ".webm", ".mp4" };

        foreach (var item in allFiles)
        {
            //i++;
            //Console.WriteLine(i + ". " + item.Extension + "\n");

            if (item.Extension == extensions[0] || item.Extension == extensions[1] || item.Extension == ".mkv") ;
            {
                videoFiles.Add(item);
            }
        }

        for (int i = 0; i < videoFiles.Count; i++)
        {
            videoFiles[i].MoveTo(sortedPath + @"\" + videoFiles[i].Name);
        }


    }
}
