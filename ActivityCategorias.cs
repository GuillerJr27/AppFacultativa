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
    [Activity(Label = "ActivityCategorias")]
    class ActivityCategorias : Activity
    {
        Button btnGasto, btnIngreso;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Categorias);

            btnGasto = FindViewById<Button>(Resource.Id.btnGasto);
            btnIngreso = FindViewById<Button>(Resource.Id.btnIngreso);

            btnGasto.Click += BtnGasto_Click;
            btnIngreso.Click += BtnIngreso_Click;
        }

        private void BtnIngreso_Click(object sender, EventArgs e)
        {
            var res = new Intent(this, typeof(ActivityIngreso));
            StartActivity(res);
        }

        private void BtnGasto_Click(object sender, EventArgs e)
        {
            var res = new Intent(this, typeof(ActivityGasto));
            StartActivity(res);
        }
    }
}