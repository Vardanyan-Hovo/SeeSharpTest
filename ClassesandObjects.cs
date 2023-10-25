using System;

class Rectangle{
   int _Length;
   int _Width;
   public Rectangle(int Length,int Width)
   {
       _Length = Length;
       _Width = Width;
   }
   public void Colculet()
   {
       Console.WriteLine(_Length * _Width);
   }
}

class HelloWorld {
  static void Main() {
   
    Rectangle R = new Rectangle(5, 3);
    R.Colculet();
  }
}
