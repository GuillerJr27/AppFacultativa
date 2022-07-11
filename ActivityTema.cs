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
    [Activity(Label = "ActivityTema")]
    class ActivityTema : Activity
    {
        ////Button nav_tema;
        ////AlertDialog alertDialogLayout1;
        RadioButton radioButtonPredeterminado, radioButtonCeleste, radioButtonClaro, radioButtonOscuro, radioButtonRojo;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Temas);

            radioButtonPredeterminado = FindViewById<RadioButton>(Resource.Id.radioButtonPredeterminado);
            radioButtonCeleste = FindViewById<RadioButton>(Resource.Id.radioButtonCeleste);
            radioButtonClaro = FindViewById<RadioButton>(Resource.Id.radioButtonClaro);
            radioButtonOscuro = FindViewById<RadioButton>(Resource.Id.radioButtonOscuro);
            radioButtonRojo = FindViewById<RadioButton>(Resource.Id.radioButtonRojo);

            radioButtonPredeterminado.Click += RadioButtonPredeterminado_Click;
        }

        private void Nav_tema_Click(object sender, EventArgs e)
        {
            
        }

        private void RadioButtonPredeterminado_Click(object sender, EventArgs e)
        {
           
        }
    }
}