using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Google.Android.Material.Snackbar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppFacultativa
{
    [Activity(Label = "H'MONEY", MainLauncher = true)]

    class ActivityLogin : Activity
    {

        com.somee.webhmoneyws.WebHmoneyWS web = new com.somee.webhmoneyws.WebHmoneyWS();


        Button btnIniciarSesion, btnCrearCuenta;
        EditText editEmail, editPass;
        //TextView txtMensaje, txtMensajeEmail, txtMensajePass;
        //string Email = "admin@hmoney.com", Pass = "admin123";

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Login);

            btnIniciarSesion = FindViewById<Button>(Resource.Id.btnIniciarSesion);
            btnCrearCuenta = FindViewById<Button>(Resource.Id.btnCrearCuenta);
            editEmail = FindViewById<EditText>(Resource.Id.editEmail);
            editPass = FindViewById<EditText>(Resource.Id.editPass);
            btnIniciarSesion.Click += BtnIniciarSesion_Click;
            btnCrearCuenta.Click += BtnCrearCuenta_Click;

        }

        private void BtnCrearCuenta_Click(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(ActivityRegistro));
            StartActivity(i);
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            //if (editEmail.Text == String.Empty)
            //{
            //    //txtMensajeEmail.Text = "Ingrese una dirección de correo";
            //    Toast.MakeText(Application.Context, "Ingrese una dirección de correo electrónico", ToastLength.Short).Show();
            //}
            //else if (editPass.Text == String.Empty)
            //{
            //    //txtMensajePass.Text = "Ingrese una contraseña";
            //    Toast.MakeText(Application.Context, "Ingrese una contraseña", ToastLength.Short).Show();
            //}
            //else
            //{
            //    if (editEmail.Text == Email && editPass.Text == Pass)
            //    {
            //        var res = new Intent(this, typeof(MainActivity));
            //        StartActivity(res);
            //        this.Finish();
            //    }
            //    else
            //    {
            //        //txtMensaje.Text = "Email o Contraseña incorrecta";
            //        Toast.MakeText(Application.Context, "Email o Contraseña incorrecta", ToastLength.Short).Show();
            //    }
            //}
            string correo = editEmail.Text.Trim();
            string clave = editPass.Text;
            if (correo.Length == 0 && clave.Length == 0)
            {
                Toast.MakeText(Application.Context, "Debe de llenar ambos campos\npara poder iniciar seisón", ToastLength.Short).Show();
            }

            else
            {
                try
                {
                    if (web.Login(correo, clave))
                    {                       
                        ClassGlobal.Usuario.correo = correo;
                        ClassGlobal.Usuario.clave = clave;

                        var res = new Intent(this, typeof(MainActivity));
                        StartActivity(res);
                        this.Finish();
                    }
                    else
                    {
                        Toast.MakeText(Application.Context, "No se ha podido verificar su cuenta\ningrese sus datos nuevamente", ToastLength.Short).Show();
                    }

                }
                catch
                {
                    Toast.MakeText(Application.Context, "Verifique su conexión a internet", ToastLength.Short).Show();
                }

            }
        }

    }
}