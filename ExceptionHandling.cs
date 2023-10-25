using System;

class ExceptionHandling
{
    public void ExceHandling()
    {
        try
        {
            int x = 10;
            int y = 0;
            int k = x/y;
            Console.WriteLine(k);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

class HelloWorld {
  static void Main() {
      
    ExceptionHandling Exec = new ExceptionHandling();
    Exec.ExceHandling();
  }
}
