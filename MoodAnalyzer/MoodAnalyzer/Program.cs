// See https://aka.ms/new-console-template for more information
using MoodAnalyzer;

Console.WriteLine("Welcome to Mood Analyzer Problem!");
while (true)
{
    Console.WriteLine("Please choose the option :\n1)Happy or SAD Mood\n2)Using the Default and Parametterized Constructor\n3)Exception\n4)Custom Exception\n5)Using Reflection with Default Constructor");
    int option = Convert.ToInt16(Console.ReadLine());
    switch (option)
    {
        case 1:
            MoodAnalyser analyse = new();
            string result = analyse.analyseMood("I am in Happy mood");
            Console.WriteLine(result);
            break;
        case 2:
            MoodAnalyzerusingConstructor analyse1 = new();
            string result1 = analyse1.analyseMood1();
            Console.WriteLine("Mood is (Using Default Constructor) : " + result1);

            MoodAnalyzerusingConstructor analyse2 = new();
            string result2 = analyse2.analyseMood1();
            Console.WriteLine("Mood is (Using Parameterized Constructor) : " + result2);
            break;
        case 3:
            UsingExceptions analyse3 = new();
            string result3 = analyse3.analyseMood(null);
            Console.WriteLine(result3);
            break;
        case 4:
            UsingcustomExceptions analyse4 = new();
            string result4 = analyse4.analyseMood(null);
            Console.WriteLine(result4);
            break;
        case 5:
            object analyser5 = MoodAnalyserFactor.CreateMoodanalyser("MoodAnalyser.Usingcustomxceptions", "UsingcustomExceptions");
            Console.WriteLine(analyser5);
            break;
        default:
            Console.WriteLine("Please Choose Correct Option");
            break;
    }
}
         


