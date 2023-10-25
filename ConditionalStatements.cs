using System;
class Test {
    void ConditionalStatements(int x)
    {
        if (x > 0)
        {
            Console.WriteLine("Positive");
        }
        else if (x < 0)
        {
            Console.WriteLine("Negative");
        }
        else
        {
            Console.WriteLine("Zero");
        }
    }
    static void Main() {
        int input;
    
        Test test = new Test();
        input = Int32.Parse(Console.ReadLine());
        test.ConditionalStatements(input);
    }
}
