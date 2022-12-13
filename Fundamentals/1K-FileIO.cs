using System.IO;

class FileIO
{
    public void CreateFile()
    {
        string folderPath = @"D:\Apps\.NET Training 5";
        string fileName = "abc.txt";
        string fullPath = @$"{folderPath}\{fileName}";
        File.Create(fullPath);
    } 
}
