using System;

class MainClass {
  public static void Main (string[] args) {
    //http://codepad.org/VwIDTKG8
    //tiny.cc/miniprojaed

        Plataforma p1 = new Plataforma("JLG", 40.23, "1250AJP", 227);

        Cliente cliente1 = new Cliente("Valerio", "147147147069", 24, p1);

        Console.WriteLine(cliente1.exibe());

    
  }
}