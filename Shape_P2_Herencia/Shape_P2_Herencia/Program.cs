

using Shape_P2_Herencia.Clases;


public class Program
{
    public static void Main(string[] args)
    {
        Shape[] listaDeFormas = new Shape[]
        {
            new Rectangle(12, 6),
            new Triangle(10, 25),
            new Circle(4)
        };

        double[] areasCalculadas = new double[listaDeFormas.Length];

        for (int i = 0; i < listaDeFormas.Length; i++)
        {
            areasCalculadas[i] = listaDeFormas[i].CalculateSurface();
        }

        Console.WriteLine("Las áreas de las figuras son: \n");
        for (int i = 0; i < areasCalculadas.Length; i++)
        {
            Console.WriteLine($"[{i + 1}] {areasCalculadas[i]}");
        }
        Console.ReadKey();
    }
}