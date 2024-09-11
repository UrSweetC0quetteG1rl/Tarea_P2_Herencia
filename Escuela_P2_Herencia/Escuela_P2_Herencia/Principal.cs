using Escuela_P2_Herencia.Clases;
using System;

public class Principal
{
    public static void Main(string[] args)
    {
        List<Curso> cursos1 = new List<Curso>
{
    new Curso("Introducción a la programación", 3, 2),
    new Curso("Base de datos I", 6, 3),
    new Curso("Fundamentos del computador", 8, 5)
};

        List<Curso> cursos2 = new List<Curso>
{
    new Curso("Cálculo diferencial", 10, 4),
    new Curso("Algoritmos", 6, 2)
};

        List<Profesor> profesores = new List<Profesor>
{
    new Profesor("Jose Luis Meran", cursos1),
    new Profesor("Wandy Familia", cursos2)

};

        List<Estudiante> Estudiantes = new List<Estudiante>
{
    new Estudiante("Cessar De Jesus", 1),
    new Estudiante("Ashley Binet", 2),
    new Estudiante("Jazhy Pimentel", 3)
};

        SalonDeClase clase1 = new SalonDeClase('A', profesores, Estudiantes);
        Console.WriteLine(clase1);

        Console.ReadKey();
    }

    
}
