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
    [Activity(Label = "ActivityRegistro")]
    class ActivityRegistro : Activity
    {
        Button btnCrearNueva;
        EditText editNombre, editApellido, editUsuarioApodo, editTelefono, editCorreo, editPass, editRepetirPass;
        TextView txtMensaje, txtMensajeNombre, txtMensajeApellido, txtMensajeUsuarioApodo, txtMensajeTelefono, txtMensajeCorreo, txtMensajePass, txtMensajeRepetirPass;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.RegistroU);

            btnCrearNueva = FindViewById<Button>(Resource.Id.btnCrearNueva);
            editNombre = FindViewById<EditText>(Resource.Id.editNombre);
            editApellido = FindViewById<EditText>(Resource.Id.editApellido);
            editUsuarioApodo = FindViewById<EditText>(Resource.Id.editUsuarioApodo);
            editTelefono = FindViewById<EditText>(Resource.Id.editTelefono);
            editCorreo = FindViewById<EditText>(Resource.Id.editCorreo);
            editPass = FindViewById<EditText>(Resource.Id.editPass);
            editRepetirPass = FindViewById<EditText>(Resource.Id.editRepetirPass);
            txtMensaje = FindViewById<TextView>(Resource.Id.txtMensaje);
            txtMensajeNombre = FindViewById<TextView>(Resource.Id.txtMensajeNombre);
            txtMensajeApellido = FindViewById<TextView>(Resource.Id.txtMensajeApellido);
            txtMensajeApellido = FindViewById<TextView>(Resource.Id.txtMensajeApellido);
            txtMensajeUsuarioApodo = FindViewById<TextView>(Resource.Id.txtMensajeUsuarioApodo);
            txtMensajeTelefono = FindViewById<TextView>(Resource.Id.txtMensajeTelefono);
            txtMensajeCorreo = FindViewById<TextView>(Resource.Id.txtMensajeCorreo);
            txtMensajePass = FindViewById<TextView>(Resource.Id.txtMensajePass);
            txtMensajeRepetirPass = FindViewById<TextView>(Resource.Id.txtMensajeRepetirPass);

            btnCrearNueva.Click += BtnCrearNueva_Click;
        }

        private void BtnCrearNueva_Click(object sender, EventArgs e)
        {
            //if (editnombre.text == string.empty && editapellido.text == string.empty
            //    && editusuarioapodo.text == string.empty && edittelefono.text == string.empty && editcorreo.text == string.empty &&
            //    editpass.text == string.empty && editrepetirpass.text == string.empty)
                //{
                //    txtMensaje.Text = "LLENE TODOS LOS CAMPOS";

                //}
                //else
                //{
                //    if (editPass.Text == editRepetirPass.Text)
                //    {
                //        Intent i = new Intent(this, typeof(ActivityLogin));
                //        StartActivity(i);
                //        txtMensaje.Text = "CUENTA CREADA CON EXITO...";
                //    }
                //    else
                //    {
                //        txtMensaje.Text = "CONTRASEÑAS NO COINCIDEN...";
                //    }
                //}
            if (editNombre.Text == String.Empty)
            {
                txtMensajeNombre.Text = "Ingrese sus nombres";
            }
            else if(editApellido.Text == String.Empty)
            {
                txtMensajeApellido.Text = "Ingrese sus apellidos";
            }
            else if (editUsuarioApodo.Text == String.Empty)
            {
                txtMensajeUsuarioApodo.Text = "Ingrese su usuario o apodo";
            }
            else if (editTelefono.Text == String.Empty)
            {
                txtMensajeTelefono.Text = "Ingrese su número telefónico";
            }
            else if (editCorreo.Text == String.Empty)
            {
                txtMensajeCorreo.Text = "Ingrese un correo electrónico";
            }
            else if (editPass.Text == String.Empty)
            {
                txtMensajePass.Text = "Ingrese una contraseña";
            }
            else if (editRepetirPass.Text == String.Empty)
            {
                txtMensajeRepetirPass.Text = "Repita nuevamente la contraseña";
            }
            else
            {
                //if (editNombre.Text != string.Empty && editApellido.Text != string.Empty
                //&& editUsuarioApodo.Text != string.Empty && editTelefono.Text != string.Empty && editCorreo.Text != string.Empty &&
                //editPass.Text != editRepetirPass.Text )
                if(editPass.Text != editRepetirPass.Text)
                {                   
                    txtMensaje.Text = "Contraseñas no coinciden!";
                }
                else
                {
                    var res = new Intent(this, typeof(ActivityLogin));
                    StartActivity(res);
                }
            }
        }

        private void ShowMessage(object sender)
        {
            View view = (View)sender;
            Snackbar.Make(view, $"CAMPOS VACIOS", Snackbar.LengthLong)
                .SetAction("Action", (View.IOnClickListener)null).Show();
        }
    }
}