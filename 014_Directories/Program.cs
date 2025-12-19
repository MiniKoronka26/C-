// Directory(Static), DirectoryInfo, File(Static), FleInfo


// Directory

/*// string path = "C:\\Folder1";
string path = @"Folder1";
Directory.CreateDirectory(path);*/

// Creating Folder in Folder
/*string path = @"Folder1/505";
Directory.CreateDirectory(path);*/

// Deleting Folder
/*string path = @"Folder1\Images";
Directory.Delete(path, true);*/

// Rename and replace Folder

//Rename
/*string pathFrom = @"Folder1\Folder2";
string pathTo = @"Folder1\Folder100";

Directory.Move(pathFrom, pathTo);*/

//Replace
/*string pathFrom = @"Folder1\Folder100";
string pathTo = @"Folder1\Films\Folder100";

Directory.Move(pathFrom, pathTo);*/

// Check for Existence
/*string pathTo = @"Folder1\Films\Folder100";
if (Directory.Exists(pathTo))
    Console.WriteLine("+");
else
    Console.WriteLine("-");*/

//Access for parents Folder
/*string path = @"Folder1\Films\Folder100";
DirectoryInfo parent = Directory.GetParent(path);

Console.WriteLine(parent.FullName);*/

// List of logical discs
/*string[] drives = Directory.GetLogicalDrives();

foreach (var drive in drives)
{
    Console.WriteLine(drive);
}*/

// Print Folders(List of Folders)
/*string path = @"Folder1";

string[] directories = Directory.GetDirectories(path);

foreach (string directory in directories)
{
    DirectoryInfo directoryInfo = new DirectoryInfo(directory);

    Console.WriteLine(directoryInfo.Name);
}*/


// Print Files(List of Files)
/*string path = @"Folder1";

string[] directories = Directory.GetFiles(path);

foreach (string directory in directories)
{
    FileInfo fileInfo = new FileInfo(directory);

    Console.WriteLine(fileInfo.Name);
}*/



// File

// Create
/*string path = @"Folder1\Films\Folder100\data3.txt";
File.Create(path);*/

// Delete
/*string path = @"Folder1\Films\Folder100\data3.txt";
File.Delete(path);*/

// Copy
/*string pathFrom = @"Folder1\Films\Folder100\image1.png";
string pathTo = @"Folder1\Films\image1.png";

File.Copy(pathFrom, pathTo);*/


// DirectoryInfo
/*string path = "Folder1";
DirectoryInfo directoryInfo = new DirectoryInfo(path);

Console.WriteLine(directoryInfo.Name);
Console.WriteLine(directoryInfo.FullName);
Console.WriteLine(directoryInfo.Parent.Name);
Console.WriteLine(directoryInfo.Root.Name);
Console.WriteLine(directoryInfo.CreationTime);
Console.WriteLine(directoryInfo.LastWriteTime);*/

// FileInfo
/*string path = "Folder1/myfile.txt";

FileInfo fileInfo = new FileInfo(path);

//fileInfo.Create();*/

/*void Find(string fileName, DirectoryInfo root)
{
    foreach (FileInfo file in root.GetFiles())
    {
        if (file.Name == fileName)
            Console.WriteLine(file.Name);
    }

    foreach (DirectoryInfo directory in root.GetDirectories())
    {
        Find(fileName, directory);
    }
}

string fileName = "data.txt";
string directoryPath = "Folder1";
DirectoryInfo root = new DirectoryInfo(directoryPath);

Find(fileName, root);*/

using System.Transactions;

void Delete(string name, DirectoryInfo root)
{
    foreach(FileInfo file in root.GetFiles())
    {
        if (file.Name == name)
            file.Delete();
    }
    foreach (DirectoryInfo directory in root.GetDirectories())
    {
        Delete(name, directory);
    }
}

Console.WriteLine("Enter name: ");
string name = Console.ReadLine();
Console.WriteLine("Enter path: ");
string path = Console.ReadLine();
DirectoryInfo root = new DirectoryInfo(path);

Delete(name, root);

