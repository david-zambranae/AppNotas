using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using AppNotas.Adapters;
using AppNotas.Models;
using Android.Content;

namespace AppNotas.Views
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private ListView listViewEstudiantes;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            listViewEstudiantes = FindViewById<ListView>(Resource.Id.listado_estudiantes);
            listViewEstudiantes.Adapter = new EstudiantesAdapter(this, Estudiante.ObtenerEstudiantes());
            listViewEstudiantes.ItemClick += ListViewEstudiantes_ItemClick;
        }

        private void ListViewEstudiantes_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent intent = new Intent(this, typeof(DetalleEstudianteActivity));

            // Obtener el estudiante seleccionado
            var estudianteId = Estudiante.ObtenerEstudiantes()[e.Position].EstudianteID;
            intent.PutExtra("Id", estudianteId);
            // Lanzar Activity
            StartActivity(intent);
        }
    }
}