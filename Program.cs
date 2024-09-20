// See https://aka.ms/new-console-template for more information
using TombokProjekt;

Console.WriteLine("Hello, World!");

int[] tomb = new int[] { 0, 1, 1, 0, 0, 0, 1 };
int[] tomb2 = new int[] { 1, 2, 4, 5, 10, 3, 6 };
int[] tomb3 = new int[] { 9, 3, 16, 4, 2, 6, 36 };
Console.WriteLine(TombMuveletek.GetEgyesekSzama(tomb));
Console.WriteLine(TombMuveletek.GetDbElozoKetSzamKetszerese(tomb2));
Console.WriteLine(TombMuveletek.GetDbElozoKetSzamNegyzete(tomb3));