using System; 
public class Program {
  public static void Main(string[] args) {

    string valores = Console.ReadLine();
    string[] divisao = valores.Split();
    int[] numeros = new int[3];
    
    for(int i = 0; i < numeros.Length; i++) {
      numeros[i] = int.Parse(divisao[i]);
    }
    
    int[] numeros1 = (int[])numeros.Clone();
    
    Array.Sort(numeros);
    foreach(int i in numeros) {
      Console.WriteLine(i);
    }
    
    Console.WriteLine();
    
    foreach(int i in numeros1) {
      Console.WriteLine(i);
    }
  }
}