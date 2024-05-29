using System.IO;

Console.WriteLine("Hello");
string filePath = "questions/grat.txt";
// string[] text = File.ReadAllLines("questions.txt");
if (File.Exists(filePath))
{

 string[] text = File.ReadAllLines("questions/grat.txt");
foreach(string line in text){
 Console.WriteLine(line);
}
}
else{
 Console.WriteLine($"Error: File not found at path {filePath}");
}