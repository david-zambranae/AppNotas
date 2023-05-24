using System.Collections.Generic;

namespace AppNotas.Models
{
    public class Nota
    {
        public Estudiante Estudiante { get; set; }
        public Asignatura Asignatura { get; set; }
        public decimal Nota1 { get; set; }
        public decimal Nota2 { get; set; }
        public decimal NotaFinal
        {
            get
            {
                return (Nota1 + Nota2) / CantidadEvaluaciones;
            }
        }

        private const int CantidadEvaluaciones = 2;
 
    }
}