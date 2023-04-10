using System; 
public class Program {
  public static void Main(string[] args) {

    string valores = Console.ReadLine();
    string[] divisao = valores.Split();
    int inicio = int.Parse(divisao[0]);
    int final = int.Parse(divisao[1]);
    int duracao = 0;

    if(final > inicio) {
      duracao = final - inicio;
    }
    else {
      duracao = (24 - inicio) + final;
    }

    Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
    
  }
}