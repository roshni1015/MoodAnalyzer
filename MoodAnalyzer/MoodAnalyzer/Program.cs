// See https://aka.ms/new-console-template for more information
using MoodAnalyzer;

Console.WriteLine("Welcome to Mood Analyzer Problem!");
MoodAnalyser analyse = new();
string result = analyse.analyseMood("I am in Happy mood");
Console.WriteLine(result);

MoodAnalyzerusingConstructor analyse1 = new();
string result1 = analyse1.analyseMood1();
Console.WriteLine("Mood is (Using Default Constructor) : " + result1);

MoodAnalyzerusingConstructor analyse2 = new();
string result2 = analyse2.analyseMood1();
Console.WriteLine("Mood is (Using Parameterized Constructor) : " + result2);