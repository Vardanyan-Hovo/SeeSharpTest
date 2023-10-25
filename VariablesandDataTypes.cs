using System;
class Test {

  private int parsingToInt()
  {
    string s;
    int res = 0;

    // s = Console.ReadLine();
    s = "42";
    for(int i = 0; i < s.Length; ++i)
    {
        int x = s[i] - '0';
        res = res * 10 + x;
    }
    return res;
  }

  static void Main() {
    Test test = new Test();
    Console.WriteLine(test.parsingToInt());
  }
}
