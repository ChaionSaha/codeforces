using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;



//1. Main directory and Sorted SubDirectory
//2. Get Files from Main Directory
//3. Sort Files, which ones we keep and which one we dont
//4. Move the files that we will keep in the second directory


class EntryPoint
{
    static void Main()
    {
        //1. Main directory and Sorted Directory
        string mainPath = @"F:\files";
        string sortedPath = @"Sorted";

        DirectoryInfo mainDirectory = new DirectoryInfo(mainPath);

        CreateSubDirectory(mainPath, sortedPath, mainDirectory);


        //2. Get files from main directory
        FileInfo[] files = mainDirectory.GetFiles();
        List<FileInfo> srtFiles = new List<FileInfo>();
        List<FileInfo> aviFiles = new List<FileInfo>();
        List<FileInfo> srtFilesToKeep = new List<FileInfo>();

        foreach (var item in files)
        {
            if (item.Extension == ".srt")
            {
                srtFiles.Add(item);
            }
            else if (item.Extension == ".avi")
            {
                aviFiles.Add(item);
            }
        }

        //3. Sort files, which one to keep and which ones dont
        foreach (var avi in aviFiles)
        {
            foreach (var srt in srtFiles)
            {
                if ((avi.Name.Substring(0, avi.Name.LastIndexOf(".")) == srt.Name.Substring(0, srt.Name.LastIndexOf("."))))
                {
                    srtFilesToKeep.Add(srt);
                }
            }
        }



        //4. Move the files that we will keep in the second directory
        for (int i = 0; i < srtFilesToKeep.Count; i++)
        {
            srtFilesToKeep[i].MoveTo(mainPath + "\\" + sortedPath + "\\" + srtFilesToKeep[i].Name);
            Console.Write(srtFilesToKeep[i].Name);
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\tMoved\n");
            Console.ResetColor();
            
            
            aviFiles[i].MoveTo(mainPath + "\\" + sortedPath + "\\" + aviFiles[i].Name);
            Console.Write(aviFiles[i].Name);
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\tMoved\n");
            Console.ResetColor();
        }

        Console.WriteLine("\n\n");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 100; j++)
            {
                Console.Write('-');
                Thread.Sleep(10);
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n\n");

        //5. Delete unnecessry files
        FileInfo[] filesToDelete = mainDirectory.GetFiles();

        foreach (var item in filesToDelete)
        {
            Console.Write(item.Name);
            item.Delete();
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\tDeleted\n");
            Console.ResetColor();
        }
        



    }





    private static void CreateSubDirectory(string mainPath, string sortedPath, DirectoryInfo mainDirectory)
    {
        if (!Directory.Exists(mainPath + @"\" + sortedPath))
        {
            mainDirectory.CreateSubdirectory(sortedPath);
        }
    }
}

