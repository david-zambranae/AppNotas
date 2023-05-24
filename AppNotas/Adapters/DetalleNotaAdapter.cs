using Android.App;
using Android.Graphics;
using Android.Views;
using Android.Widget;
using AppNotas.Models;
using Java.Lang;
using System.Collections.Generic;

namespace AppNotas.Adapters
{
    public class DetalleNotaAdapter : BaseAdapter
    {
        private readonly Activity _contexto;
        private readonly List<Nota> _notasEstudiante;
        private const int HeaderType = 0;
        private const int RowType = 1;

        public DetalleNotaAdapter(Activity contexto, List<Nota> notasEstudiante)
        {
            _contexto = contexto;
            _notasEstudiante = notasEstudiante;
        }

        public override int Count => _notasEstudiante.Count;

        public override int GetItemViewType(int position)
        {
            return position == 0 ? HeaderType : RowType;
        }

        public override Object GetItem(int position)
        {
            throw new System.NotImplementedException();
        }

        public override int ViewTypeCount => 1;

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var notas = _notasEstudiante[position];
            View view = convertView;

            if (view == null)
            {
                LayoutInflater layoutInflater = _contexto.LayoutInflater;

                if (position == 0)
                {
                    view = layoutInflater.Inflate(Resource.Layout.table_header, null);
                }
                else
                {
                    view = layoutInflater.Inflate(Resource.Layout.table_row, null);
                }
            }

            if (position == 0)
            {
                view.FindViewById<TextView>(Resource.Id.header1).Text = "Asignatura";
                view.FindViewById<TextView>(Resource.Id.header2).Text = "Nota #1";
                view.FindViewById<TextView>(Resource.Id.header3).Text = "Nota #2";
                view.FindViewById<TextView>(Resource.Id.header4).Text = "Nota Final";     
            }
            else
            {
                view.FindViewById<TextView>(Resource.Id.nombre_asignatura).Text = notas.Asignatura.Titulo;
                view.FindViewById<TextView>(Resource.Id.nota_1).Text = notas.Nota1.ToString();
                view.FindViewById<TextView>(Resource.Id.nota_2).Text = notas.Nota2.ToString();
                view.FindViewById<TextView>(Resource.Id.nota_final).Text = notas.NotaFinal.ToString();

                if (position % 2 == 0)
                {
                    view.SetBackgroundColor(new Color(236, 236, 236));
                }
                else
                    view.SetBackgroundColor(new Color(Android.Resource.Color.White));
            }

            return view;
        }
    }
}