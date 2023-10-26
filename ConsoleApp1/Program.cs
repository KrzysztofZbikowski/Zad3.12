class Zad
{
    static void Main(string[] args)
    {
        int suma = 0, liczba;
        do
        {
            Console.WriteLine("Podaj liczbę całkowitą: ");
            liczba = int.Parse(Console.ReadLine());
            suma = suma + liczba;
        } while (liczba != 0);
        Console.WriteLine("Suma wprowadzonych liczb wynosi " + suma);
        Console.ReadKey();
    }
}