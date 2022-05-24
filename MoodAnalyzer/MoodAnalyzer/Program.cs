// See https://aka.ms/new-console-template for more information
using MoodAnalyzer;

Console.WriteLine("Welcome to Mood Analyzer Problem!");
while (true)
{
    Console.WriteLine("Please choose the option :\n1)Happy or SAD Mood\n2)Using the Default and Parametterized Constructor\n3)Exception\n4)Custom Exception\n5)Using Reflection with Default Constructor\n6)Using Reflection Parameterized Constructor\n7)Invoke method\n8)Reflection to change Mood Dynamically");
    int option = Convert.ToInt16(Console.ReadLine());
    switch (option)
    {
        case 1:
            MoodAnalyser analyse = new();
            string result = analyse.analyseMood();
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
        case 6:
            object analyser6 = MoodanalayserParameterizedConstructor.UsingParameterizedConstructor("MoodAnalyzer.MoodAnalyser", "MoodAnalyser123", "Happy");
            Console.WriteLine(analyser6);
            break;
        case 7:
            string analyser7 = MoodAnalyserFactor.Invokeanalysemood("Happy", "12analyseMood");
            Console.WriteLine(analyser7);
            break;
        case 8:
            string analyser8 = MoodAnalyserFactor.SetField("Happy", "msg");
            Console.WriteLine(analyser8);
            break;
        default:
            Console.WriteLine("Please Choose Correct Option");
            break;
    }
}
         


