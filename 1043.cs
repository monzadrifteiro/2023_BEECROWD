using System; 
public class Program {
  public static void Main(string[] args) {

    string valores = Console.ReadLine();
    string[] divisao = valores.Split();
    double a = double.Parse(divisao[0]);
    double b = double.Parse(divisao[1]);
    double c = double.Parse(divisao[2]);

    if(a < b + c && b < a + c && c < a + b) {
      double perimetro = a + b + c;
      Console.WriteLine($"Perimetro = {perimetro:0.0}");
    }
    else{
      double area = ((a + b) * c) / 2;
      Console.WriteLine($"Area = {area:00.0}");
    }
  }
}