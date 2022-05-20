// See https://aka.ms/new-console-template for more information
using MoodAnalyzer;

Console.WriteLine("Welcome to Mood Analyzer Problem!");
MoodAnalyser analyse = new();
string result = analyse.analyseMood("I am in Happy mood");
Console.WriteLine(result);