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
    [Activity(Label = "ActivityCuenta")]
    class ActivityCuenta : Activity
    {
        EditText editNombreCuenta, editMonto;
        Spinner spinercuenta, spinermoneda;
        Button btnGuardarCuenta;
        TextView txtMensajeNombreCuenta, textMensajeMonto;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Cuentas);

            editNombreCuenta= FindViewById<EditText>(Resource.Id.editNombreCuenta);
            //spinercuenta=FindViewById<Spinner>(Resource.Id.spinercuenta);
            Spinner spinermoneda = FindViewById<Spinner>(Resource.Id.spinnermoneda);
            Spinner spinercuenta = FindViewById<Spinner>(Resource.Id.spinercuenta);

            editMonto = FindViewById<EditText>(Resource.Id.editMonto);
            textMensajeMonto = FindViewById<TextView>(Resource.Id.textMensajeMonto);
            txtMensajeNombreCuenta = FindViewById<TextView>(Resource.Id.txtMensajeNombreCuenta);
            btnGuardarCuenta = FindViewById<Button>(Resource.Id.btnGuardarCuenta);
            //btnGuardarCuenta.Click += BtnGuardarCuenta_Click;


            spinermoneda.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);
            var adapter = ArrayAdapter.CreateFromResource(
                    this, Resource.Array.planets_array, Android.Resource.Layout.SimpleSpinnerItem);

            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinermoneda.Adapter = adapter;

            spinercuenta.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs> (spinner_ItemSelected);

        }

        private void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            //string toast = string.Format("sms", spinner.GetItemAtPosition(e.Position));
            //Toast.MakeText(this, toast, ToastLength.Long).Show();
            //Toast.MakeText(this, "Elija una moneda: " + spinner.GetItemAtPosition(e.Position), ToastLength.Short).Show();
        }

        //private void Spinermoneda_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        //{
        //    var sniper  = (EditText)sender;
        //    Toast.MakeText(this, "Elija una moneda: " + sniper.GetItemAtPosition(e.Position), ToastLength.Short).Show();
        //}

        //private void BtnGuardarCuenta_Click(object sender, EventArgs e)
        //{
        //    if (editNombreCuenta.Text == String.Empty)
        //    {
        //        txtMensajeNombreCuenta.Text = "Ingrese el nombre de la cuenta";
        //    }
        //    else if (spinercuenta.getSelectedItem   Tostring== String.Empty)
        //    {
        //        txtMensajeApellido.Text = "Elija un tipo de cuenta";
        //    }
        //    else if (spinermoneda. == String.Empty)
        //    {
        //        txtMensajeUsuarioApodo.Text = "Elija una moneda";
        //    }
        //    else if (editMonto.Text == String.Empty)
        //    {
        //        textMensajeMonto.Text = "Ingrese un monto de dinero";
        //    }
        //}
    }
}