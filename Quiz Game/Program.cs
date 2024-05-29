using System.IO;

Console.WriteLine("Hello");
string filePath = "questions/grat.txt";
string[] text = File.ReadAllLines("questions.txt");
List<string> questions = new List<string>();
List<string> answers = new List<string>();
for(int i = 0; i <  text.Length; i++)
{
 if(i % 4 == 0)
 {
  questions.Add(text[i]);
 }
 else{
  answers.Add(text[i]);
 }
 int questionsIndex = 0;
 int answersIndex = 0;
 int score = 0;
}