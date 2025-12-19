using _014_JsonSerialize;
using System.ComponentModel;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

/*Point point = new Point { X = 10, Y = 20 };

var options = new JsonSerializerOptions
{
    WriteIndented = true // Додає пробіли та переноси рядків
};

string jsonString = JsonSerializer.Serialize(point, options);

Console.WriteLine(jsonString);

string path = "point.json";
File.WriteAllText(path, jsonString);*/


string path = "point.json";
string jsonString = File.ReadAllText(path);

Console.WriteLine(jsonString);

Point point = JsonSerializer.Deserialize<Point>(jsonString);

Console.WriteLine(point);