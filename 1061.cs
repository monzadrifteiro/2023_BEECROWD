using System; 
public class Program {
  public static void Main(string[] args) {

    string dataIn = Console.ReadLine();
    string[] inicio = dataIn.Split();
    int diaIn = int.Parse(inicio[1]); 

    string hIn = Console.ReadLine();
    string[] horariosi = hIn.Split(':');
    int horaIn = int.Parse(horariosi[0]);
    int minIn = int.Parse(horariosi[1]);
    int segIn = int.Parse(horariosi[2]);

    string dataFin = Console.ReadLine();
    string[] final = dataFin.Split();
    int diaFin = int.Parse(final[1]); 

    string hf = Console.ReadLine();
    string[] horariosf = hf.Split(':');
    int horaFin = int.Parse(horariosf[0]);
    int minFin = int.Parse(horariosf[1]);
    int segFin = int.Parse(horariosf[2]);

    int diaTot = diaFin - diaIn;
    int horaTot = horaFin - horaIn;
    int minTot = minFin - minIn;
    int segTot = segFin - segIn;

    if(segTot < 0) {
      segTot += 60;
      minTot -= 1;
    }
    if(minTot < 0) {
      minTot += 60;
      horaTot -= 1;
    }
    if(horaTot < 0) {
      horaTot += 24;
      diaTot -= 1;
    }

    Console.WriteLine($"{diaTot} dia(s)");
    Console.WriteLine($"{horaTot} hora(s)");
    Console.WriteLine($"{minTot} minuto(s)");
    Console.WriteLine($"{segTot} segundo(s)");
  }
}