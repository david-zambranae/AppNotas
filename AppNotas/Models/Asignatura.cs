using System.Collections.Generic;

namespace AppNotas.Models
{
    public class Asignatura
    {
        public byte AsignaturaID { get; set; }
        public string Titulo { get; set; }

        public static List<Asignatura> ObtetenerAsignaturas()
        {
            return new List<Asignatura>()
            {
                new Asignatura
                {
                    AsignaturaID = 1,
                    Titulo = "Matemáticas"
                },
                new Asignatura
                {
                    AsignaturaID = 2,
                    Titulo = "Economía"
                },
                new Asignatura
                {
                    AsignaturaID = 3,
                    Titulo = "Historia"
                },
                new Asignatura
                {
                    AsignaturaID = 4,
                    Titulo = "Informática"
                },
                new Asignatura
                {
                    AsignaturaID = 5,
                    Titulo = "Lengua y Literatura"
                },
                new Asignatura
                {
                    AsignaturaID = 6,
                    Titulo = "Inglés"
                },
            };
        }
    }
}