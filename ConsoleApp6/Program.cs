using ConsoleApp6;

internal class Program
{
    static void Main()
    {
        List<Kifejezes> kifejezesek = new List<Kifejezes>();

        StreamReader sr = new StreamReader("kifejezesek.txt");
        sr.ReadLine();
            while (!sr.EndOfStream)
            {
                var mezok = sr.ReadLine().Split(" ");

            Kifejezes uj = new Kifejezes(
            int.Parse(mezok[0]),
            mezok[1],
            int.Parse(mezok[2]));
            kifejezesek.Add(uj);
            }
        sr.Close();

        Console.WriteLine(kifejezesek.Count);
    }
}