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
    class ActivityIngreso : Activity, Android.App.DatePickerDialog.IOnDateSetListener
    {
        Button btnCancelar, btnGuardarIngreso, btnFecha;
        EditText editNombreCuenta, editMonto, editFecha;
        Spinner spinercuenta;
        private int year, month, date;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Ingreso);

            editNombreCuenta = FindViewById<EditText>(Resource.Id.editNombreCuenta);
            editMonto = FindViewById<EditText>(Resource.Id.editMonto);
            editFecha = FindViewById<EditText>(Resource.Id.editFecha);

            btnFecha = FindViewById<Button>(Resource.Id.btnFecha);
            btnFecha.Click += BtnFecha_Click;

            btnCancelar = FindViewById<Button>(Resource.Id.btnCancelar);
            btnCancelar.Click += BtnCancelar_Click;

            btnGuardarIngreso = FindViewById<Button>(Resource.Id.btnGuardarIngreso);
            btnGuardarIngreso.Click += BtnGuardarIngreso_Click;
            //////////////////////////////////////////////////////////////////
            spinercuenta = FindViewById<Spinner>(Resource.Id.spinnercuenta);
            //spinercuenta.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);
            var adapter1 = ArrayAdapter.CreateFromResource(
                    this, Resource.Array.TipoCuentas, Android.Resource.Layout.SimpleSpinnerItem);

            adapter1.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinercuenta.Adapter = adapter1;
        }

        private void BtnFecha_Click(object sender, EventArgs e)
        {
            int DatePickerDialogId = 1;
            ShowDialog(DatePickerDialogId);
        }
        protected override Dialog OnCreateDialog(int id)
        {
            if (id == 1)
            {
                return new Android.App.DatePickerDialog(this, this, year, month, date);
            }

            return null;
        }

        public void OnDateSet(DatePicker view, int year, int month, int dayOfMonth)
        {
            this.year = year;
            this.month = month;
            this.date = dayOfMonth;
            editFecha.Text = "La fecha es: " + dayOfMonth + "/" + month + "/" + year;
        }

        private void BtnGuardarIngreso_Click(object sender, EventArgs e)
        {
            if (editNombreCuenta.Text == String.Empty)
            {
                //txtMensajeNombreCuenta.Text = "Ingrese el nombre de la cuenta";
                Toast.MakeText(Application.Context, "Ingrese el nombre del ingreso", ToastLength.Short).Show();
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
                    Toast.MakeText(Application.Context, "Elija un tipo de cuenta registrada", ToastLength.Short).Show();
                }
                else
                {
                    Android.App.AlertDialog.Builder alert = new Android.App.AlertDialog.Builder(this);
                    alert.SetTitle("");
                    alert.SetMessage("El ingreso se registró con éxito").SetPositiveButton("Ok", (senderAlert, args) =>
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
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            var res = new Intent(this, typeof(MainActivity));
            StartActivity(res);
            Toast.MakeText(Application.Context, "Registro cancelado", ToastLength.Short).Show();
        }
    }
}