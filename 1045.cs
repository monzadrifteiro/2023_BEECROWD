using System; 
public class Program {
  public static void Main(string[] args) {

    string valores = Console.ReadLine();
    string[] divisao = valores.Split();
    double[] numeros = new double[3];
    
    for(int i = 0; i < numeros.Length; i++){
      numeros[i] = double.Parse(divisao[i]);
    }

    Array.Sort(numeros);
    Array.Reverse(numeros);

    double a = numeros[0];
    double b = numeros[1];
    double c = numeros[2];

    if(a >= b + c) {
      Console.WriteLine("NAO FORMA TRIANGULO");
    }
    
    else{

      if(Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2)) {
        Console.WriteLine("TRIANGULO RETANGULO");
      }

      if(Math.Pow(a, 2) > Math.Pow(b, 2) + Math.Pow(c, 2)) {
        Console.WriteLine("TRIANGULO OBTUSANGULO");
      }

      if(Math.Pow(a, 2) < Math.Pow(b, 2) + Math.Pow(c, 2)) {
        Console.WriteLine("TRIANGULO ACUTANGULO");
      }

      if(a == b && a == c && b == c) {
        Console.WriteLine("TRIANGULO EQUILATERO");
      }

      if(a == b && a != c || a == c && a != b || c == b && b !=a) {
        Console.WriteLine("TRIANGULO ISOSCELES");
      }
      
    }
  }
}