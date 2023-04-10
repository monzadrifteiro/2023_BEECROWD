using System; 
public class Program {
  public static void Main(string[] args) {

    double salario = double.Parse(Console.ReadLine());
    double reajuste = 0;
    double percentual = 0;

    if(salario > 0 && salario <= 400) {
      reajuste = (salario * 15) / 100;
      percentual = 15;
      salario += reajuste;
      Console.WriteLine($"Novo salario: {salario:0.00}");
      Console.WriteLine($"Reajuste ganho: {reajuste:0.00}");
      Console.WriteLine($"Em percentual: {percentual} %");
    }
        
    else if(salario > 400 && salario <= 800) {
      reajuste = (salario * 12) / 100;
      percentual = 12;
      salario += reajuste;
      Console.WriteLine($"Novo salario: {salario:0.00}");
      Console.WriteLine($"Reajuste ganho: {reajuste:0.00}");
      Console.WriteLine($"Em percentual: {percentual} %");
    }

    else if(salario > 800 && salario <= 1200) {
      reajuste = (salario * 10) / 100;
      percentual = 10;
      salario += reajuste;
      Console.WriteLine($"Novo salario: {salario:0.00}");
      Console.WriteLine($"Reajuste ganho: {reajuste:0.00}");
      Console.WriteLine($"Em percentual: {percentual} %");
    }

    else if(salario > 1200 && salario <= 2000) {
      reajuste = (salario * 7) / 100;
      percentual = 7;
      salario += reajuste;
      Console.WriteLine($"Novo salario: {salario:0.00}");
      Console.WriteLine($"Reajuste ganho: {reajuste:0.00}");
      Console.WriteLine($"Em percentual: {percentual} %");
    }

    else if(salario > 2000) {
      reajuste = (salario * 4) / 100;
      percentual = 4;
      salario += reajuste;
      Console.WriteLine($"Novo salario: {salario:0.00}");
      Console.WriteLine($"Reajuste ganho: {reajuste:0.00}");
      Console.WriteLine($"Em percentual: {percentual} %");
    }
    
  }
}