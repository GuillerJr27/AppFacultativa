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
    [Activity(Label = "ActivityListaCuentas")]
    class ActivityListaCuentas : Activity
    {
        //List<string> listaCuentas;

        public static readonly string LLAVE_NOMBRE = "Nombre";
        public static readonly string LLAVE_MONTO = "Monto";

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ListaCuentas);

            var editNombreCuenta = FindViewById<EditText>(Resource.Id.editNombreCuenta);
            var editMonto = FindViewById<EditText>(Resource.Id.editMonto);

            var listaCuentas = new List<string>();
            var listaMonto = new List<string>();
        }

    }
}