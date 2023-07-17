using System; 
public class Program {
  public static void Main(string[] args) {

    double salario = double.Parse(Console.ReadLine());
    double imposto = 0;

    if(salario > 0 && salario <= 2000) {
      Console.WriteLine("Isento");
    }
        
    else if(salario > 2000 && salario <= 3000) {
      imposto = (salario - 2000) * 0.08;
      Console.WriteLine($"R$ {imposto:0.00}");
    }

    else if(salario > 3000 && salario <= 4500) {
      imposto = ((salario - 3000) * 0.18) + 80;
      Console.WriteLine($"R$ {imposto:0.00}");
    }

    else if(salario > 4500) {
      imposto = ((salario - 4500) * 0.28) + 350;
      Console.WriteLine($"R$ {imposto:0.00}");
    }
    
  }
}