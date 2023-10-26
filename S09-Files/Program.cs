using S08_Files.Utilities.FileHandling;

Console.WriteLine("Hello, World!\n\n");

var workinFolerPatch= @"E:\MaktabSharif.S08\";
//var textToWrite = "Hello";

//File.WriteAllText(workinFolerPatch + "Hello.txt", textToWrite);

//var fileContentToProccess = File.ReadAllText(workinFolerPatch + "Hello.txt");
//Console.WriteLine(fileContentToProccess);

//var iohelper = new IOHelper();
//iohelper.ShowListOfDrives();
//iohelper.GetDriveInfo("C");

//iohelper.ShowListOfDirectories(@"C:\Windows");
//iohelper.SearchInDirectory(@"C:\","?i*");



//Directory.CreateDirectory(workinFolerPatch + "HasanDirectory");
//Directory.CreateDirectory(workinFolerPatch + "HasanDirectory_2");
//File.WriteAllText(workinFolerPatch + "HasanNote.txt", "---------------------");

//File.Copy(workinFolerPatch + "HasanNote.txt", workinFolerPatch + "HasanDirectory" + @"\HasanNote.bak1");
//File.Copy(workinFolerPatch + "HasanNote.txt", workinFolerPatch + "HasanDirectory_2" + @"\HasanNote.bak2");



//var files =Directory.GetFiles(workinFolerPatch);
//foreach (var file in files)
//{
//    Console.WriteLine(file + "\n----------------------------------");
//    var fileInfo=new FileInfo(file);

//    //Console.WriteLine($"---Times-------");
//    //Console.WriteLine($"CreationTime : {fileInfo.CreationTime}");
//    //Console.WriteLine($"CreationTimeUtc : {fileInfo.CreationTimeUtc}");
//    //Console.WriteLine($"LastAccessTime : {fileInfo.LastAccessTime}");
//    //Console.WriteLine($"LastAccessTimeUtc : {fileInfo.LastAccessTimeUtc}");
//    //Console.WriteLine($"LastWriteTime : {fileInfo.LastWriteTime}");
//    //Console.WriteLine($"LastWriteTimeUtc : {fileInfo.LastWriteTimeUtc}");


//    if (fileInfo.Extension.Contains("txt"))
//    {
//        if (File.Exists(workinFolerPatch + "renamedFile") == false)
//        {
//            File.Move(file, workinFolerPatch + "renamedFile");
//        }
//    }

//    Console.WriteLine("\n\n");
//}



Console.WriteLine(Path.GetExtension(@"E:\MaktabSharif.S08\Hello.txt"));
Console.WriteLine(Path.GetFileName(@"E:\MaktabSharif.S08\Hello.txt"));
Console.WriteLine(Path.GetFileNameWithoutExtension(@"E:\MaktabSharif.S08\Hello.txt"));
Console.WriteLine(Path.GetPathRoot(@"E:\MaktabSharif.S08\Hello.txt"));


Console.WriteLine("\n\n");


csv