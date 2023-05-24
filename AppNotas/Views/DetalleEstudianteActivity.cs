
using Android.App;
using Android.OS;
using Android.Widget;
using AppNotas.Adapters;
using AppNotas.Models;
using System.Linq;

namespace AppNotas.Views
{
    [Activity(Label = "Reporte del Usuario")]
    public class DetalleEstudianteActivity : Activity
    {
        private Estudiante estudiante;
        private TextView NombreEstudiante;
        private ListView DetalleNotas;
        private TextView PromedioEstudiante;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_detalle_estudiante);

            // Recuper el extra enviado
            int id = Intent.GetIntExtra("Id", 0);
            estudiante = Estudiante.ObtenerEstudiantes().Find(e => e.EstudianteID == id);

            NombreEstudiante = FindViewById<TextView>(Resource.Id.nombre_estudiante);
            NombreEstudiante.Text = estudiante.Nombre;

            DetalleNotas = FindViewById<ListView>(Resource.Id.detalle_notas);
            DetalleNotas.Adapter = new DetalleNotaAdapter(this, estudiante.Notas);

            PromedioEstudiante = FindViewById<TextView>(Resource.Id.promedio);
            PromedioEstudiante.Text = "Promedio... " + estudiante.Notas.Average(e => e.NotaFinal).ToString("N2") + " pts.";
        }
    }
}