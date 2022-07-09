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
    [Activity(Label = "ActivityCompartir")]
    class ActivityCompartir : Activity
    {
        Button btnCompartir;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Compartir);

            btnCompartir=FindViewById<Button>(Resource.Id.btnCompartir);
            btnCompartir.Click += BtnCompartir_Click;
        }

        private void BtnCompartir_Click(object sender, EventArgs e)
        {
            string texto = FindViewById<TextView>(Resource.Id.btnCompartir).Text;
            Intent i = new Intent(Intent.ActionSend);
            i.SetType("text/plain");
            i.PutExtra(Intent.ExtraText, texto);
            StartActivity(Intent.CreateChooser(i, "Compartir"));
        }
    }
}