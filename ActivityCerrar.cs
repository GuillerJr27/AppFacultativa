using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppFacultativa
{
    [Activity(Label = "ActivityCerrar")]
    class ActivityCerrar : Activity
    {
        Button Cerrar;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.CerrarSesion);

            Cerrar = FindViewById<Button>(Resource.Id.btnCerrar);
            Cerrar.Click += Cerrar_Click;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
       
        } 
    }
}