using System;
using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Graphics;
using Android.Views;
using Android.Widget;
using AppNotas.Models;

namespace AppNotas.Adapters
{
    public class EstudiantesAdapter : BaseAdapter
    {
        private readonly Activity _contexto;
        private readonly List<Estudiante> _estudiantes;

        public EstudiantesAdapter(Activity contexto, List<Estudiante> estudiantes)
        {
            _contexto = contexto;
            _estudiantes = estudiantes;
        }

        public override int Count => _estudiantes.Count;

        public override Java.Lang.Object GetItem(int position)
        {
            throw new NotImplementedException();
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {

            var item = _estudiantes[position];

            // Formato de la fila
            View view = convertView;

            if (view == null)
            {
                view = _contexto.LayoutInflater.Inflate(Resource.Layout.item_list, null);
            }

            view.FindViewById<ImageView>(Resource.Id.profile_picture).SetImageResource(Resource.Drawable.user_icon);
            view.FindViewById<TextView>(Resource.Id.title).Text = item.Nombre;
            view.FindViewById<TextView>(Resource.Id.subtitle).Text = "Promedio General: " + item.Notas.Average(e => e.NotaFinal).ToString("N2") + " pts.";

            if (position % 2 == 0)
            {
                view.SetBackgroundColor(new Color(236, 236, 236));
            }
            else
                view.SetBackgroundColor(new Color(Android.Resource.Color.White));


            return view;
        }
    }
}