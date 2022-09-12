using System;
using System.Collections.Generic;
using System.IO;

class EntryPoint
{
    static void Main()
    {
        DirectoryInfo mainPath = new DirectoryInfo(@"E:\video\New folder\New folder\Nudes\Nudes");
        DirectoryInfo mainPathNew = new DirectoryInfo(@"E:\video\New folder\New folder\Nudes");
        DirectoryInfo mp4Files = new DirectoryInfo(mainPathNew + @"\Mp4 Files");
        DirectoryInfo jpegFiles = new DirectoryInfo(mainPathNew + @"\Jpeg Files");
        DirectoryInfo webpFiles = new DirectoryInfo(mainPathNew + @"\Webp Files");
        DirectoryInfo gifFiles = new DirectoryInfo(mainPathNew + @"\Gif Files");
        DirectoryInfo pngFiles = new DirectoryInfo(mainPathNew + @"\Png Files");
        DirectoryInfo[] subDirectories = mainPath.GetDirectories();
        int j = 0;
        List<FileInfo> videofiles = new List<FileInfo>();
        int mp4 = 0, jpeg = 0, webp = 0, gif = 0, png = 0;
        int jpegFailed = 0, mp4Failed = 0, webpFailed = 0, gifFailed = 0, pngFailed = 0;
        
        
        
        if (!mp4Files.Exists)
        {
            mp4Files.Create();
        }

        if (!jpegFiles.Exists)
        {
            jpegFiles.Create();
        }

        if (!webpFiles.Exists)
        {
            webpFiles.Create();
        }

        if (!gifFiles.Exists)
        {
            gifFiles.Create();
        }

        if (!pngFiles.Exists)
        {
            pngFiles.Create();
        }

        for (int i = 0; i < subDirectories.Length; i++)
        {
            FileInfo[] allFiles = subDirectories[i].GetFiles();
            foreach (var item in allFiles)
            {
                if (item.Extension == ".mp4")
                {
                    mp4++;
 

                    try
                    {
                        item.MoveTo(mp4Files.FullName + @"\" + item.Name);
                    }
                    catch (IOException)
                    {
                        Console.Write(item.Name + "\t");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Item Deleted");
                        Console.ResetColor();
                        Console.WriteLine($"The directory for the file is: {item.Directory}");
                        Console.WriteLine("\n\n");
                        mp4Failed++;

                        item.Delete();
                    }
                    
                }
                else if (item.Extension == ".jpeg")
                {
                    jpeg++;
                    //item.CopyTo(jpegFiles.FullName + @"\" + item.Name);

                    try
                    {
                        item.MoveTo(jpegFiles.FullName + @"\" + item.Name);
                    }
                    catch (IOException)
                    {
                        Console.Write(item.Name + "\t");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Item Deleted");
                        Console.ResetColor();
                        Console.WriteLine($"The directory for the file is: {item.Directory}");
                        Console.WriteLine("\n\n");
                        jpegFailed++;

                        item.Delete();
                    }

                }
                else if(item.Extension == ".webp")
                {
                    webp++;
                    //item.CopyTo(webpFiles.FullName + @"\" + item.Name);

                    try
                    {
                        item.MoveTo(webpFiles.FullName + @"\" + item.Name);
                    }
                    catch (IOException)
                    {
                        Console.Write(item.Name + "\t");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Item Deleted");
                        Console.ResetColor();
                        Console.WriteLine($"The directory for the file is: {item.Directory}");
                        Console.WriteLine("\n\n");
                        webpFailed++;

                        item.Delete();
                    }
                }
                else if (item.Extension == ".gif")
                {
                    gif++;

                    try
                    {
                        item.MoveTo(gifFiles.FullName + @"\" + item.Name);
                    }
                    catch (IOException)
                    {
                        Console.Write(item.Name + "\t");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Item Deleted");
                        Console.ResetColor();
                        Console.WriteLine($"The directory for the file is: {item.Directory}");
                        Console.WriteLine("\n\n");
                        gifFailed++;

                        item.Delete();
                    }
                }
                else if (item.Extension == ".png")
                {
                    png++;
                    
                    try
                    {
                        item.MoveTo(pngFiles.FullName + @"\" + item.Name);
                    }
                    catch (IOException)
                    {
                        Console.Write(item.Name + "\t");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Item Deleted");
                        Console.ResetColor();
                        Console.WriteLine($"The directory for the file is: {item.Directory}");
                        Console.WriteLine("\n\n");
                        pngFailed++;

                        item.Delete();
                    }
                }
                else
                {
                    Console.WriteLine(item.Extension);
                }
            }

        }

        Console.WriteLine("mp4 = {0}\tjpeg = {1}\twebp = {2}\tgif = {3}\tpng = {4}\nmp4Failed = {5}\tjpegFailed = {6}\twebpFailed = {7}\tgifFailed = {8}\tpngFailed = {9}", mp4, jpeg, webp, gif, png, mp4Failed, jpegFailed, webpFailed, gifFailed, pngFailed);

    }
}

