using System;
class Test {

  private int[] parsToArray(int x1,int x2,int x3,int x4,int x5)
  {
      int[] arr = new int[5];
      arr[0] = x1;
      arr[1] = x2;
      arr[2] = x3;
      arr[3] = x4;
      arr[4] = x5;
      return arr;
  }
  private int[] parsToArrayUseParams(params int[] arr)
  {
      return arr;
  }

  static void Main() {
    Test test = new Test();
    int[] res = test.parsToArrayUseParams( 2, 4, 6, 8, 10);
    
    foreach(int x in res)
    {
        Console.WriteLine(x);
    }
  }
}
