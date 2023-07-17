using System; 
public class Program {
  public static void Main(string[] args) {

    int testes = int.Parse(Console.ReadLine());

    for(int i = 1; i <= testes; i++) {
      
      string valores = Console.ReadLine();
      string[] divisao = valores.Split();
      
      double valor1 = double.Parse(divisao[0]);
      double valor2 = double.Parse(divisao[1]);
      double valor3 = double.Parse(divisao[2]);

      double media = ((valor1 * 2) + (valor2 * 3) + (valor3 * 5)) / 10;

      Console.WriteLine($"{media:0.0}");
        
    }
  }
}