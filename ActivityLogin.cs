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
    [Activity(Label = "ActivityLogin", MainLauncher = true)]

    class ActivityLogin : Activity
    {
        Button btnIniciarSesion, btnCrearCuenta;
        EditText editEmail, editPass;
        TextView txtMensaje, txtMensajeEmail, txtMensajePass;
        string Email = "admin@hmoney.com", Pass = "admin123";

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Login);

            btnIniciarSesion = FindViewById<Button>(Resource.Id.btnIniciarSesion);
            btnCrearCuenta = FindViewById<Button>(Resource.Id.btnCrearCuenta);
            editEmail = FindViewById<EditText>(Resource.Id.editEmail);
            editPass = FindViewById<EditText>(Resource.Id.editPass);
            txtMensajeEmail = FindViewById<TextView>(Resource.Id.txtMensajeEmail);
            txtMensajePass = FindViewById<TextView>(Resource.Id.txtMensajePass);
            txtMensaje = FindViewById<TextView>(Resource.Id.txtMensaje);
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
            if (editEmail.Text == String.Empty)
            {
                txtMensajeEmail.Text = "Ingrese una dirección de correo";
            }
            else if (editPass.Text == String.Empty)
            {
                txtMensajePass.Text = "Ingrese una contraseña";
            }
            else
            {
                if (editEmail.Text == Email && editPass.Text == Pass)
                {
                    var res = new Intent(this, typeof(MainActivity));
                    StartActivity(res);
                }
                else
                {
                    txtMensaje.Text = "Email o Contraseña incorrecta";
                }
            }
            //if (editEmail.Text != string.Empty && editPass.Text != string.Empty)
            //{
            //    Intent i = new Intent(this, typeof(MainActivity));
            //    StartActivity(i);
            //}
            //else
            //    txtMensaje.Text = "CAMPOS VACIOS";
        }


        private void ShowMessage(object sender)
        {
            View view = (View)sender;
            Snackbar.Make(view, $"CAMPOS VACIOS", Snackbar.LengthLong)
                .SetAction("Action", (View.IOnClickListener)null).Show();
        }

        public void Login(string usuario, string password)
        {
            var servicio = new UsuariosExtra.UsuariosExtra();
            var resultado = servicio.Login(usuario, password);
            if (resultado)
            {
                UserInfo.Nombre = usuario;
            }
        }
    }
}