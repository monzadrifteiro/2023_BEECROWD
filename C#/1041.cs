using System; 
public class Program {
  public static void Main(string[] args) {

    string valores = Console.ReadLine();
    string[] aeb = valores.Split();
    double a = double.Parse(aeb[0]);
    double b = double.Parse(aeb[1]);

    if(a == 0 && b == 0) {
      Console.WriteLine("Origem");
    }
    if(a == 0 && b != 0) {
      Console.WriteLine("Eixo Y");
    }
    if(a != 0 && b == 0) {
      Console.WriteLine("Eixo X");
    }
    if(a > 0 && b > 0) {
      Console.WriteLine("Q1");
    }
    if(a < 0 && b > 0) {
      Console.WriteLine("Q2");
    }
    if(a < 0 && b < 0) {
      Console.WriteLine("Q3");
    }
    if(a > 0 && b < 0) {
      Console.WriteLine("Q4");
    }
  }
}