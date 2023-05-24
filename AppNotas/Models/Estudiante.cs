using System.Collections.Generic;

namespace AppNotas.Models
{
    public class Estudiante
    {
        public int EstudianteID { get; set; }
        public string Nombre { get; set; }
        public List<Nota> Notas { get; set; }

        public static List<Estudiante> ObtenerEstudiantes()
        {
            // Obtenemos las asignaturas 
            var asignatura = Asignatura.ObtetenerAsignaturas();
            // Creamos los estudiantes
            List<Estudiante> estudiantes = new List<Estudiante>()
            {
                new Estudiante()
                {
                    EstudianteID = 1,
                    Nombre = "Gerardo Abel Aballay",
                    Notas = new List<Nota>()
                    {
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 1),
                            Nota1 = 7,
                            Nota2 = 7
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 2),
                            Nota1 = 8,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 3),
                            Nota1 = 5,
                            Nota2 = 8
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 4),
                            Nota1 = 6,
                            Nota2 = 9
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 5),
                            Nota1 = 7,
                            Nota2 = 8
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 6),
                            Nota1 = 10,
                            Nota2 = 6
                        },
                    }
                },
                new Estudiante()
                {
                    EstudianteID = 2,
                    Nombre = "Ricardo Aballay",
                    Notas = new List<Nota>()
                    {
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 1),
                            Nota1 = 8,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 2),
                            Nota1 = 4,
                            Nota2 = 6
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 3),
                            Nota1 = 6,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 4),
                            Nota1 = 8,
                            Nota2 = 7
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 5),
                            Nota1 = 6,
                            Nota2 = 7.5m
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 6),
                            Nota1 = 7.5m,
                            Nota2 = 9
                        },
                    }
                },
                new Estudiante()
                {
                    EstudianteID = 3,
                    Nombre = "Roberto Arredondo",
                    Notas = new List<Nota>()
                    {
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 1),
                            Nota1 = 7,
                            Nota2 = 7
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 2),
                            Nota1 = 8,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 3),
                            Nota1 = 5,
                            Nota2 = 8
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 4),
                            Nota1 = 6,
                            Nota2 = 9
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 5),
                            Nota1 = 7,
                            Nota2 = 8
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 6),
                            Nota1 = 10,
                            Nota2 = 6
                        },
                    }
                },
                new Estudiante()
                {
                    EstudianteID = 4,
                    Nombre = "Matías Martín Carrizo",
                    Notas = new List<Nota>()
                    {
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 1),
                            Nota1 = 8,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 2),
                            Nota1 = 4,
                            Nota2 = 6
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 3),
                            Nota1 = 6,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 4),
                            Nota1 = 8,
                            Nota2 = 7
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 5),
                            Nota1 = 6,
                            Nota2 = 7.5m
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 6),
                            Nota1 = 7.5m,
                            Nota2 = 9
                        },
                    }
                },
                new Estudiante()
                {
                    EstudianteID = 5,
                    Nombre = "Leonardo Mairo Castro",
                    Notas = new List<Nota>()
                    {
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 1),
                            Nota1 = 7,
                            Nota2 = 7
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 2),
                            Nota1 = 8,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 3),
                            Nota1 = 5,
                            Nota2 = 8
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 4),
                            Nota1 = 6,
                            Nota2 = 9
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 5),
                            Nota1 = 7,
                            Nota2 = 8
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 6),
                            Nota1 = 10,
                            Nota2 = 6
                        },
                    }

                },
                new Estudiante()
                {
                    EstudianteID = 6,
                    Nombre = "Germán Cruz Molina",
                    Notas = new List<Nota>()
                    {
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 1),
                            Nota1 = 8,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 2),
                            Nota1 = 4,
                            Nota2 = 6
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 3),
                            Nota1 = 6,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 4),
                            Nota1 = 8,
                            Nota2 = 7
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 5),
                            Nota1 = 6,
                            Nota2 = 7.5m
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 6),
                            Nota1 = 7.5m,
                            Nota2 = 9
                        },
                    }
                },
                new Estudiante()
                {
                    EstudianteID = 7,
                    Nombre = "Damián Gonzalo Díaz",
                    Notas = new List<Nota>()
                    {
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 1),
                            Nota1 = 7,
                            Nota2 = 7
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 2),
                            Nota1 = 8,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 3),
                            Nota1 = 5,
                            Nota2 = 8
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 4),
                            Nota1 = 6,
                            Nota2 = 9
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 5),
                            Nota1 = 7,
                            Nota2 = 8
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 6),
                            Nota1 = 10,
                            Nota2 = 6
                        },
                    }
                },
                new Estudiante()
                {
                    EstudianteID = 8,
                    Nombre = "Jose Luis Godoy",
                    Notas = new List<Nota>()
                    {
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 1),
                            Nota1 = 8,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 2),
                            Nota1 = 4,
                            Nota2 = 6
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 3),
                            Nota1 = 6,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 4),
                            Nota1 = 8,
                            Nota2 = 7
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 5),
                            Nota1 = 6,
                            Nota2 = 7.5m
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 6),
                            Nota1 = 7.5m,
                            Nota2 = 9
                        },
                    }
                },
                new Estudiante()
                {
                    EstudianteID = 9,
                    Nombre = "Miguel José Gutierrez Oro",
                    Notas = new List<Nota>()
                    {
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 1),
                            Nota1 = 7,
                            Nota2 = 7
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 2),
                            Nota1 = 8,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 3),
                            Nota1 = 5,
                            Nota2 = 8
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 4),
                            Nota1 = 6,
                            Nota2 = 9
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 5),
                            Nota1 = 7,
                            Nota2 = 8
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 6),
                            Nota1 = 10,
                            Nota2 = 6
                        },
                    }
                },
                new Estudiante()
                {
                    EstudianteID = 10,
                    Nombre = "Juan Sebastián López",
                    Notas = new List<Nota>()
                    {
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 1),
                            Nota1 = 8,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 2),
                            Nota1 = 4,
                            Nota2 = 6
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 3),
                            Nota1 = 6,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 4),
                            Nota1 = 8,
                            Nota2 = 7
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 5),
                            Nota1 = 6,
                            Nota2 = 7.5m
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 6),
                            Nota1 = 7.5m,
                            Nota2 = 9
                        },
                    }
                },
                new Estudiante()
                {
                    EstudianteID = 11,
                    Nombre = "David Leandro Mallea",
                    Notas = new List<Nota>()
                    {
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 1),
                            Nota1 = 7,
                            Nota2 = 7
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 2),
                            Nota1 = 8,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 3),
                            Nota1 = 5,
                            Nota2 = 8
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 4),
                            Nota1 = 6,
                            Nota2 = 9
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 5),
                            Nota1 = 7,
                            Nota2 = 8
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 6),
                            Nota1 = 10,
                            Nota2 = 6
                        },
                    }
                },
                new Estudiante()
                {
                    EstudianteID = 12,
                    Nombre = "Paulo Gabriel Mercado",
                    Notas = new List<Nota>()
                    {
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 1),
                            Nota1 = 8,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 2),
                            Nota1 = 4,
                            Nota2 = 6
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 3),
                            Nota1 = 6,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 4),
                            Nota1 = 8,
                            Nota2 = 7
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 5),
                            Nota1 = 6,
                            Nota2 = 7.5m
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 6),
                            Nota1 = 7.5m,
                            Nota2 = 9
                        },
                    }
                },
                new Estudiante()
                {
                    EstudianteID = 13,
                    Nombre = "Matías Ontiveros",
                    Notas = new List<Nota>()
                    {
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 1),
                            Nota1 = 7,
                            Nota2 = 7
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 2),
                            Nota1 = 8,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 3),
                            Nota1 = 5,
                            Nota2 = 8
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 4),
                            Nota1 = 6,
                            Nota2 = 9
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 5),
                            Nota1 = 7,
                            Nota2 = 8
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 6),
                            Nota1 = 10,
                            Nota2 = 6
                        },
                    }
                },
                new Estudiante()
                {
                    EstudianteID = 14,
                    Nombre = "Abel Gastón Parada",
                    Notas = new List<Nota>()
                    {
                         new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 1),
                            Nota1 = 8,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 2),
                            Nota1 = 4,
                            Nota2 = 6
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 3),
                            Nota1 = 6,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 4),
                            Nota1 = 8,
                            Nota2 = 7
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 5),
                            Nota1 = 6,
                            Nota2 = 7.5m
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 6),
                            Nota1 = 7.5m,
                            Nota2 = 9
                        },
                    }
                },
                new Estudiante()
                {
                    EstudianteID = 15,
                    Nombre = "Pedro Roel Ahumada",
                    Notas = new List<Nota>()
                    {
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 1),
                            Nota1 = 7,
                            Nota2 = 7
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 2),
                            Nota1 = 8,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 3),
                            Nota1 = 5,
                            Nota2 = 8
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 4),
                            Nota1 = 6,
                            Nota2 = 9
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 5),
                            Nota1 = 7,
                            Nota2 = 8
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 6),
                            Nota1 = 10,
                            Nota2 = 6
                        },
                    }
                },
                new Estudiante()
                {
                    EstudianteID = 16,
                    Nombre = "Ricardo Gabriel Silva",
                    Notas = new List<Nota>()
                    {
                         new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 1),
                            Nota1 = 8,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 2),
                            Nota1 = 4,
                            Nota2 = 6
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 3),
                            Nota1 = 6,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 4),
                            Nota1 = 8,
                            Nota2 = 7
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 5),
                            Nota1 = 6,
                            Nota2 = 7.5m
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 6),
                            Nota1 = 7.5m,
                            Nota2 = 9
                        },
                    }
                },
                new Estudiante()
                {
                    EstudianteID = 17,
                    Nombre = "Edgardo Renzo Tello",
                    Notas = new List<Nota>()
                    {
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 1),
                            Nota1 = 7,
                            Nota2 = 7
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 2),
                            Nota1 = 8,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 3),
                            Nota1 = 5,
                            Nota2 = 8
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 4),
                            Nota1 = 6,
                            Nota2 = 9
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 5),
                            Nota1 = 7,
                            Nota2 = 8
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 6),
                            Nota1 = 10,
                            Nota2 = 6
                        },
                    }
                },
                new Estudiante()
                {
                    EstudianteID = 18,
                    Nombre = "Natalia Paola Canizo",
                    Notas = new List<Nota>()
                    {
                         new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 1),
                            Nota1 = 8,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 2),
                            Nota1 = 4,
                            Nota2 = 6
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 3),
                            Nota1 = 6,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 4),
                            Nota1 = 8,
                            Nota2 = 7
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 5),
                            Nota1 = 6,
                            Nota2 = 7.5m
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 6),
                            Nota1 = 7.5m,
                            Nota2 = 9
                        },
                    }
                },
                new Estudiante()
                {
                    EstudianteID = 19,
                    Nombre = "Eugenia Carrizo",
                    Notas = new List<Nota>()
                    {
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 1),
                            Nota1 = 7,
                            Nota2 = 7
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 2),
                            Nota1 = 8,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 3),
                            Nota1 = 5,
                            Nota2 = 8
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 4),
                            Nota1 = 6,
                            Nota2 = 9
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 5),
                            Nota1 = 7,
                            Nota2 = 8
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 6),
                            Nota1 = 10,
                            Nota2 = 6
                        },
                    }
                },
                new Estudiante()
                {
                    EstudianteID = 20,
                    Nombre = "Yanina Anahi Castro",
                    Notas = new List<Nota>()
                    {
                         new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 1),
                            Nota1 = 8,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 2),
                            Nota1 = 4,
                            Nota2 = 6
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 3),
                            Nota1 = 6,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 4),
                            Nota1 = 8,
                            Nota2 = 7
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 5),
                            Nota1 = 6,
                            Nota2 = 7.5m
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 6),
                            Nota1 = 7.5m,
                            Nota2 = 9
                        },
                    }
                },
                new Estudiante()
                {
                    EstudianteID = 21,
                    Nombre = "Daniela González",
                    Notas = new List<Nota>()
                    {
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 1),
                            Nota1 = 7,
                            Nota2 = 7
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 2),
                            Nota1 = 8,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 3),
                            Nota1 = 5,
                            Nota2 = 8
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 4),
                            Nota1 = 6,
                            Nota2 = 9
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 5),
                            Nota1 = 7,
                            Nota2 = 8
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 6),
                            Nota1 = 10,
                            Nota2 = 6
                        },
                    }
                },
                new Estudiante()
                {
                    EstudianteID = 22,
                    Nombre = "Pamela Esmeralda Molina",
                    Notas = new List<Nota>()
                    {
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 1),
                            Nota1 = 8,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 2),
                            Nota1 = 4,
                            Nota2 = 6
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 3),
                            Nota1 = 6,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 4),
                            Nota1 = 8,
                            Nota2 = 7
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 5),
                            Nota1 = 6,
                            Nota2 = 7.5m
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 6),
                            Nota1 = 7.5m,
                            Nota2 = 9
                        },
                    }
                },
                new Estudiante()
                {
                    EstudianteID = 23,
                    Nombre = "Carolina Ormeño",
                    Notas = new List<Nota>()
                    {
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 1),
                            Nota1 = 7,
                            Nota2 = 7
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 2),
                            Nota1 = 8,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 3),
                            Nota1 = 5,
                            Nota2 = 8
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 4),
                            Nota1 = 6,
                            Nota2 = 9
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 5),
                            Nota1 = 7,
                            Nota2 = 8
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 6),
                            Nota1 = 10,
                            Nota2 = 6
                        },
                    }
                },
                new Estudiante()
                {
                    EstudianteID = 24,
                    Nombre = "Eliana Palacio Guardia",
                    Notas = new List<Nota>()
                    {
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 1),
                            Nota1 = 8,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 2),
                            Nota1 = 4,
                            Nota2 = 6
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 3),
                            Nota1 = 6,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 4),
                            Nota1 = 8,
                            Nota2 = 7
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 5),
                            Nota1 = 6,
                            Nota2 = 7.5m
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 6),
                            Nota1 = 7.5m,
                            Nota2 = 9
                        },
                    }
                },
                new Estudiante()
                {
                    EstudianteID = 25,
                    Nombre = "Susana Bello Quiroga",
                    Notas = new List<Nota>()
                    {
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 1),
                            Nota1 = 7,
                            Nota2 = 7
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 2),
                            Nota1 = 8,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 3),
                            Nota1 = 5,
                            Nota2 = 8
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 4),
                            Nota1 = 6,
                            Nota2 = 9
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 5),
                            Nota1 = 7,
                            Nota2 = 8
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 6),
                            Nota1 = 10,
                            Nota2 = 6
                        },
                    }
                },
                new Estudiante()
                {
                    EstudianteID = 26,
                    Nombre = "Silviana Torres",
                    Notas = new List<Nota>()
                    {
                         new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 1),
                            Nota1 = 8,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 2),
                            Nota1 = 4,
                            Nota2 = 6
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 3),
                            Nota1 = 6,
                            Nota2 = 5
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 4),
                            Nota1 = 8,
                            Nota2 = 7
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 5),
                            Nota1 = 6,
                            Nota2 = 7.5m
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 6),
                            Nota1 = 7.5m,
                            Nota2 = 9
                        },
                    }
                },
                new Estudiante()
                {
                    EstudianteID = 27,
                    Nombre = "Luis Molina",
                    Notas = new List<Nota>()
                    {
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 1),
                            Nota1 = 5,
                            Nota2 = 8.5m
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 2),
                            Nota1 = 7,
                            Nota2 = 6.5m
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 3),
                            Nota1 = 8,
                            Nota2 = 9.5m
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 4),
                            Nota1 = 6.5m,
                            Nota2 = 7.5m
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 5),
                            Nota1 = 9,
                            Nota2 = 7.5m
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 6),
                            Nota1 = 8.5m,
                            Nota2 = 6
                        },
                    }
                },
                new Estudiante()
                {
                    EstudianteID = 28,
                    Nombre = "María López",
                    Notas = new List<Nota>()
                    {
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 1),
                            Nota1 = 6.5m,
                            Nota2 = 7.5m
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 2),
                            Nota1 = 9,
                            Nota2 = 7.5m
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 3),
                            Nota1 = 8.5m,
                            Nota2 = 6
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 4),
                            Nota1 = 7,
                            Nota2 = 5.5m
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 5),
                            Nota1 = 6,
                            Nota2 = 7.5m
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 6),
                            Nota1 = 5,
                            Nota2 = 9
                        },
                    }
                },
                new Estudiante()
                {
                    EstudianteID = 29,
                    Nombre = "Cintia Molina",
                    Notas = new List<Nota>()
                    {
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 1),
                            Nota1 = 5.5m,
                            Nota2 = 6.5m
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 2),
                            Nota1 = 7.5m,
                            Nota2 = 8
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 3),
                            Nota1 = 6.5m,
                            Nota2 = 8
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 4),
                            Nota1 = 5.5m,
                            Nota2 = 7
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 5),
                            Nota1 = 6.5m,
                            Nota2 = 7.5m
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 6),
                            Nota1 = 8,
                            Nota2 = 7
                        },
                    }
                },
                new Estudiante()
                {
                    EstudianteID = 32,
                    Nombre = "Mario Muñoz",
                    Notas = new List<Nota>()
                    {
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 1),
                            Nota1 = 7,
                            Nota2 = 8.5m
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 2),
                            Nota1 = 9,
                            Nota2 = 7.5m
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 3),
                            Nota1 = 9.5m,
                            Nota2 = 6
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 4),
                            Nota1 = 7,
                            Nota2 = 5.5m
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 5),
                            Nota1 = 6.5m,
                            Nota2 = 8
                        },
                        new Nota
                        {
                            Asignatura = asignatura.Find(a => a.AsignaturaID == 6),
                            Nota1 = 5.5m,
                            Nota2 = 7
                        },
                    }
                }
            };

            // Asignar Las notas a cada estudiante
            foreach (var estudiante in estudiantes)
            {
                foreach (var notas in estudiante.Notas)
                {
                    notas.Estudiante = estudiante;
                }
            }

            return estudiantes;
        }
    }
}