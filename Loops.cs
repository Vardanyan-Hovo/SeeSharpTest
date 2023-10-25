using System;

class Loops
{
    public void printUntilTen()
    {
        int i = 0; 
        while(++i <= 10)
            Console.WriteLine(i);
    }
}
class Test {
    static void Main() {

        Loops test = new Loops();
        test.printUntilTen();
    }
}
