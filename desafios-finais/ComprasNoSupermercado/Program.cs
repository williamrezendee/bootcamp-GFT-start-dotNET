using System.Collections.Generic;
using System;

class MinhaClasse {
  public static void Main (string[] args) {
    var totalDeCasosDeTeste = int.Parse(Console.ReadLine());
    for (int i = 0; i < totalDeCasosDeTeste; i++)
    {
        string[] itens = Console.ReadLine().Split(' ');
        var set = CriarConjuntoNaoRepetido(itens);
        Console.WriteLine(string.Join(" ",set));
    }
  }
  static SortedSet<string> CriarConjuntoNaoRepetido(string[] itens)
  {
    var sortedSet = new SortedSet<string>();
    foreach (var item in itens)
    {
      sortedSet.Add(item);
    }
    return sortedSet;
  }
}
