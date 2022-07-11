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
    [Activity(Label = "ActivityIngreso")]
    class ActivityIngreso : Activity
    {
        Button btnCancelar;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Ingreso);

            btnCancelar = FindViewById<Button>(Resource.Id.btnCancelar);
            btnCancelar.Click += BtnCancelar_Click;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            var res = new Intent(this, typeof(MainActivity));
            StartActivity(res);
            Toast.MakeText(Application.Context, "Registro cancelado", ToastLength.Short).Show();
        }
    }
}