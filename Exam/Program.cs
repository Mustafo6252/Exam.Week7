
// -----------------------------  1- bo'lim ------------------------------------

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
WebApplication app = builder.Build();

app.MapControllers();
app.Run();

//------------------------------  2- bo'lim ------------------------------------

// class Program
// {
//     static void Main()
//     {
        //    -----------------------  Task 1  ---------------------

        // string Path = "/Users/macbook/Desktop/course/Week 15";
        //
        // if (Directory.Exists(Path))
        // {
        //     Console.WriteLine("Directory exists");
        // }
        // else
        // {
        //     Console.WriteLine("Directory doesn't exist");
        // }

        //    -----------------------  Task 2  ---------------------

        // string filepath = "/Users/macbook/Desktop/course/text.txt";
        //
        // if (File.Exists(filepath))
        // {
        //     Console.WriteLine("File already exists");
        // }
        // else
        // {
        //     File.Create(filepath).Close();
        //     Console.WriteLine("File created");
        // }
    
        //    -----------------------  Task 3  ---------------------
        
        // string filepath = "/Users/macbook/Desktop/course/text.txt";
        // FileInfo fileInfo = new FileInfo(filepath);
        // if (File.Exists(filepath))
        // {
        //     Console.WriteLine($"File Name: {fileInfo.Name}");
        //     Console.WriteLine($"File  Extension: {fileInfo.Extension}");
        //     Console.WriteLine($"File Size: {fileInfo.Length} bayt");
        // }
        // else
        // {
        //     Console.WriteLine($"File not found");
        // }

        //    -----------------------  Task 4  ---------------------

        // string path1 = "/Users/macbook/Desktop/course";
        // string path2 = "kitoblar";
        //
        // string newPath=Path.Combine(path1, path2);
        //
        // Console.WriteLine(newPath);

        //    -----------------------  Task5  ---------------------
        
        // string path = "/Users/macbook/Desktop/course/text.txt";
        // File.WriteAllText(path, "My name is Mustafo");
        //
        // Console.WriteLine(File.ReadAllText(path));

//     }
// }

