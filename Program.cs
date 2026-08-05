
using Herencia.Clases;

Persona objPersona1 = new Persona("0926826505", "Eduardo", "Manosalvas", new DateOnly(1993, 9, 6));

Console.WriteLine("Persona 1");
objPersona1.saludar();

Console.WriteLine();
Console.WriteLine("Estudiante 1");
Estudiante objEstudiante1 = new Estudiante("0926826505", "Eduardo", "Manosalvas", new DateOnly(1993, 9, 6), "Desarrollo de Software", 2);
objEstudiante1.saludar();
objEstudiante1.estudiar();

Console.WriteLine();
Console.WriteLine("Docente 1");
Docente objDocente1 = new Docente("0926826505", "Eduardo", "Manosalvas", new DateOnly(1993, 9, 6), "Programación", 5);
objDocente1.saludar();
objDocente1.enseñar();


Console.WriteLine();
Console.WriteLine("Director 1");
DirectorCarrera objDirectorCarrera = new DirectorCarrera("0926826505", "Eduardo", "Manosalvas", new DateOnly(1993, 9, 6), "Programación", 5, "Ingeniería de Software");
objDirectorCarrera.saludar();
objDirectorCarrera.enseñar();
objDirectorCarrera.dirigir();


Console.ReadLine();

