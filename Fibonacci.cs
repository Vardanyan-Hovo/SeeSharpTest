using System;
class HelloWorld {
  private void fibonachi(int n)
  {
    int last, save, next;
    last = 0;
    next = 1;
    
    for(int i = 0; i < n; ++i)
    {
        Console.Write(last + " ");
        save = last + next;
        last = next;
        next = save;
    }
  }
  static void Main() {
    HelloWorld H = new HelloWorld();
    H.fibonachi(10);
  }
}
