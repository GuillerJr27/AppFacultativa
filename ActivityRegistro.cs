using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.DrawerLayout.Widget;
using Google.Android.Material.Snackbar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppFacultativa
{
    [Activity(Label = "ActivityRegistro")]
    class ActivityRegistro : Activity
    {
        com.somee.webhmoneyws.WebHmoneyWS web = new com.somee.webhmoneyws.WebHmoneyWS();

        Button btnCrearNueva;
        EditText editCorreo, editPass, editRepetirPass;
        //TextView txtMensaje, txtMensajeCorreo, txtMensajePass, txtMensajeRepetirPass;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.RegistroU);

            btnCrearNueva = FindViewById<Button>(Resource.Id.btnCrearNueva);
            editCorreo = FindViewById<EditText>(Resource.Id.editCorreo);
            editPass = FindViewById<EditText>(Resource.Id.editPass);
            editRepetirPass = FindViewById<EditText>(Resource.Id.editRepetirPass);
            //txtMensaje = FindViewById<TextView>(Resource.Id.txtMensaje);
            //txtMensajeCorreo = FindViewById<TextView>(Resource.Id.txtMensajeCorreo);
            //txtMensajePass = FindViewById<TextView>(Resource.Id.txtMensajePass);
            //txtMensajeRepetirPass = FindViewById<TextView>(Resource.Id.txtMensajeRepetirPass);

            btnCrearNueva.Click += BtnCrearNueva_Click;
        }

        private void BtnCrearNueva_Click(object sender, EventArgs e)
        {
            //if (editCorreo.Text == String.Empty)
            //{
            //    //txtMensajeCorreo.Text = "Ingrese un correo electrónico";
            //    Toast.MakeText(Application.Context, "Ingrese un correo electrónico", ToastLength.Short).Show();
            //}
            //else if (editPass.Text == String.Empty)
            //{
            //    //txtMensajePass.Text = "Ingrese una contraseña";
            //    Toast.MakeText(Application.Context, "Ingrese una contraseña", ToastLength.Short).Show();
            //}
            //else if (editRepetirPass.Text == String.Empty)
            //{
            //    //txtMensajeRepetirPass.Text = "Repita nuevamente la contraseña";
            //    Toast.MakeText(Application.Context, "Repita nuevamente la contraseña", ToastLength.Short).Show();
            //}
            //else
            //{

            //    if(editPass.Text != editRepetirPass.Text)
            //    {
            //        //txtMensaje.Text = "Contraseñas no coinciden!";
            //        Toast.MakeText(Application.Context, "Contraseñas no coinciden!", ToastLength.Short).Show();
            //    }
            //    else
            //    {
            //        Android.App.AlertDialog.Builder alert = new Android.App.AlertDialog.Builder(this);
            //        alert.SetTitle("");
            //        alert.SetMessage("Cuenta creada con éxito").SetPositiveButton("Ok", (senderAlert, args) =>
            //        {
            //            ISharedPreferences preferencia = Application.GetSharedPreferences("informacion", FileCreationMode.Private);
            //            ISharedPreferencesEditor editor = preferencia.Edit();
            //            editor.Clear();
            //            editor.Apply();
            //            this.Finish();

            //            var res = new Intent(this, typeof(ActivityLogin));
            //            StartActivity(res);
            //        }).SetNegativeButton("", (senderAlert, args) => { }).Show();

            //    }

            //    DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            //}
            try
            {
                if (validarVacios())
                {
                    var resultado = web.CrearUsuario(editCorreo.Text.Trim(), editPass.Text);
                    if (resultado.respuesta)
                    {                       
                        ClassGlobal.Usuario.correo = editCorreo.Text.Trim();
                        ClassGlobal.Usuario.clave = editPass.Text;

                        Toast.MakeText(Application.Context, resultado.mensaje, ToastLength.Short).Show();
                        this.Finish();

                        //Intent res = new Intent(this, typeof(MainActivity));
                        //StartActivity(res);
                        //Android.App.AlertDialog.Builder alert = new Android.App.AlertDialog.Builder(this);
                        //alert.SetTitle("");
                        //alert.SetMessage("Cuenta creada con éxito").SetPositiveButton("Ok", (senderAlert, args) =>
                        //{
                        //    ISharedPreferences preferencia = Application.GetSharedPreferences("informacion", FileCreationMode.Private);
                        //    ISharedPreferencesEditor editor = preferencia.Edit();
                        //    editor.Clear();
                        //    editor.Apply();
                        //    this.Finish();

                        //    var res = new Intent(this, typeof(ActivityLogin));
                        //    StartActivity(res);
                        //}).SetNegativeButton("", (senderAlert, args) => { }).Show();
                        var res = new Intent(this, typeof(ActivityLogin));
                        StartActivity(res);


                    }
                    //DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
                    else
                    {
                        Toast.MakeText(Application.Context, resultado.mensaje, ToastLength.Short).Show();
                    }
                }

            }
            catch
            {
                Toast.MakeText(Application.Context, "Verifique su conexión a internet", ToastLength.Short).Show();
            }
        }

        private bool validarVacios()
        {
            if (editCorreo.Text == String.Empty)
            {
                Toast.MakeText(Application.Context, "Ingrese un correo eléctrónico", ToastLength.Short).Show();
                return false;
            }
            else if (editPass.Text == String.Empty)
            {
                Toast.MakeText(Application.Context, "Ingrese una contraseña", ToastLength.Short).Show();
                return false;
            }
            else if (editRepetirPass.Text == String.Empty)
            {
                Toast.MakeText(Application.Context, "Repita nuevamente la contraseña", ToastLength.Short).Show();
                return false;
            }
            else if (editPass.Text != editRepetirPass.Text)
            {
                Toast.MakeText(Application.Context, "Contraseñas no coinciden", ToastLength.Short).Show();
                return false;
            }


            return true;
        }

        //private void ShowMessage(object sender)
        //{
        //    View view = (View)sender;
        //    Snackbar.Make(view, $"CAMPOS VACIOS", Snackbar.LengthLong)
        //        .SetAction("Action", (View.IOnClickListener)null).Show();
        //}
    }
}