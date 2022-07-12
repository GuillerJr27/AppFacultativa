using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.Core.View;
using AndroidX.DrawerLayout.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppFacultativa
{
    [Activity(Label = "ActivityCuenta")]
    class ActivityCuenta : Activity
    {
        EditText editNombreCuenta, editMonto, editFecha;
        Spinner spinercuenta, spinermoneda;
        Button btnGuardarCuenta, btnCancelar, btnLista;
        //TextView txtMensajeNombreCuenta, textMensajeMonto, txtMensajeTipoCuenta, txtMensajeTipoMoneda, textMensajeFecha;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Cuentas);

            editNombreCuenta= FindViewById<EditText>(Resource.Id.editNombreCuenta);
            //txtMensajeNombreCuenta = FindViewById<TextView>(Resource.Id.txtMensajeNombreCuenta);

            spinercuenta = FindViewById<Spinner>(Resource.Id.spinnercuenta);
            spinercuenta.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);
            var adapter1 = ArrayAdapter.CreateFromResource(
                    this, Resource.Array.TipoCuentas, Android.Resource.Layout.SimpleSpinnerItem);

            adapter1.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinercuenta.Adapter = adapter1;

            //txtMensajeTipoCuenta = FindViewById<TextView>(Resource.Id.txtMensajeTipoCuenta);
            ///////////////////////////////////////////////////////////////////////////
            spinermoneda = FindViewById<Spinner>(Resource.Id.spinnermoneda);
            spinermoneda.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);
            var adapter = ArrayAdapter.CreateFromResource(
                    this, Resource.Array.TipoMoneda, Android.Resource.Layout.SimpleSpinnerItem);

            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinermoneda.Adapter = adapter;

            //txtMensajeTipoMoneda = FindViewById<TextView>(Resource.Id.txtMensajeTipoMoneda);
            /////////////////////////////////////////////////////////
            editMonto = FindViewById<EditText>(Resource.Id.editMonto);
            //textMensajeMonto = FindViewById<TextView>(Resource.Id.textMensajeMonto);

            editFecha = FindViewById<EditText>(Resource.Id.editFecha);
            //textMensajeFecha = FindViewById<TextView>(Resource.Id.textMensajeFecha);

            btnGuardarCuenta = FindViewById<Button>(Resource.Id.btnGuardarCuenta);
            btnGuardarCuenta.Click += BtnGuardarCuenta_Click1;

            btnCancelar = FindViewById<Button>(Resource.Id.btnCancelar);
            btnCancelar.Click += BtnCancelar_Click;

            btnLista = FindViewById<Button>(Resource.Id.btnLista);
            btnLista.Click += BtnLista_Click;
        }

        private void BtnLista_Click(object sender, EventArgs e)
        {
            var res = new Intent(this, typeof(ActivityListaCuentas));
            StartActivity(res);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            var res = new Intent(this, typeof(MainActivity));
            StartActivity(res);
            Toast.MakeText(Application.Context, "Registro cancelado", ToastLength.Short).Show();
        }

        private void BtnGuardarCuenta_Click1(object sender, EventArgs e)
        {
            if (editNombreCuenta.Text == String.Empty)
            {
                //txtMensajeNombreCuenta.Text = "Ingrese el nombre de la cuenta";
                Toast.MakeText(Application.Context, "Ingrese el nombre de la cuenta", ToastLength.Short).Show();
            }
            else if (editMonto.Text == String.Empty)
            {
                //textMensajeMonto.Text = "Ingrese un monto de dinero";
                Toast.MakeText(Application.Context, "Ingrese un monto de dinero", ToastLength.Short).Show();
            }
            else if (editFecha.Text == String.Empty)
            {
                //textMensajeFecha.Text = "Ingrese una fecha";
                Toast.MakeText(Application.Context, "Ingrese una fecha", ToastLength.Short).Show();
            }
            else
            {
                if (spinercuenta.SelectedItemPosition.ToString() == String.Empty)
                {
                    //txtMensajeTipoCuenta.Text = "Elija un tipo de cuenta";
                    Toast.MakeText(Application.Context, "Elija un tipo de cuenta", ToastLength.Short).Show();
                }
                else if (spinermoneda.SelectedItemPosition.ToString() == String.Empty)
                {
                    //txtMensajeTipoMoneda.Text = "Elija una moneda";
                    Toast.MakeText(Application.Context, "Elija una moneda", ToastLength.Short).Show();
                }
                else
                {
                    Android.App.AlertDialog.Builder alert = new Android.App.AlertDialog.Builder(this);
                    alert.SetTitle("");
                    alert.SetMessage("Registro Exitoso").SetPositiveButton("Ok", (senderAlert, args) =>
                    {
                        ISharedPreferences preferencia = Application.GetSharedPreferences("informacion", FileCreationMode.Private);
                        ISharedPreferencesEditor editor = preferencia.Edit();
                        editor.Clear();
                        editor.Apply();
                        this.Finish();

                        Intent res = new Intent(this, typeof(MainActivity));
                        StartActivity(res);
                    }).SetNegativeButton("", (senderAlert, args) => { }).Show();
                    
                }

                DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
                //drawer.CloseDrawer(GravityCompat.Start);
                //return true;
            }
        }

        private void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner snipermoneda = (Spinner)sender;
            Spinner spinercuenta = (Spinner)sender;
        }
    }
}