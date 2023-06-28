public class Program
{
    public static void Main()
    {
        Random rnd = new Random();
        int a = rnd.Next(0, 7);
        float cena = rnd.Next(50, 100);
        int srok = rnd.Next(1, 14);
        Console.WriteLine(cena);
        DateTime datet = DateTime.Now.Date;
        DateTime dater = datet.AddDays(-a).Date;
        DateTime datek = dater.AddDays(srok).Date;
        Console.WriteLine($"data iz: {dater}");
        Console.WriteLine($"data end: {dater}");
          if (dater == datet)
        Console.WriteLine($"cina: {cena}");
          else if (datek < DateTime.Now)
            Console.WriteLine($"cina: {cena * 0}");
          else
            Console.WriteLine($"cina: {cena * 0.8}");
      }
}
  
