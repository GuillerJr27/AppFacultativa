using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.App;
using AndroidX.AppCompat.Widget;
using AndroidX.Core.View;
using AndroidX.DrawerLayout.Widget;
using Google.Android.Material.FloatingActionButton;
using Google.Android.Material.Navigation;
using Google.Android.Material.Snackbar;

namespace AppFacultativa
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar")]
    public class MainActivity : AppCompatActivity, NavigationView.IOnNavigationItemSelectedListener
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //if (string.IsNullOrEmpty(UserInfo.Nombre))
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            //FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            //fab.Click += FabOnClick;

            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(this, drawer, toolbar, Resource.String.navigation_drawer_open, Resource.String.navigation_drawer_close);
            drawer.AddDrawerListener(toggle);
            toggle.SyncState();

            NavigationView navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
            navigationView.SetNavigationItemSelectedListener(this);
        }

        public override void OnBackPressed()
        {
            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            if (drawer.IsDrawerOpen(GravityCompat.Start))
            {
                drawer.CloseDrawer(GravityCompat.Start);
            }
            else
            {
                base.OnBackPressed();
            }
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        //public override bool OnOptionsItemSelected(IMenuItem item)
        //{
        //    int id = item.ItemId;
        //    if (id == Resource.Id.action_settings)
        //    {
        //        return true;
        //    }

        //    return base.OnOptionsItemSelected(item);
        //}

        //private void FabOnClick(object sender, EventArgs eventArgs)
        //{
        //    View view = (View)sender;
        //    Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
        //        .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        //}

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            int id = item.ItemId;

            if (id == Resource.Id.nav_cuenta)
            {
                var res = new Intent(this, typeof(ActivityCuenta));
                StartActivity(res);

            }
            else if (id == Resource.Id.nav_categorias)
            {
                var res = new Intent(this, typeof(ActivityCategorias));
                StartActivity(res);
            }
            else if (id == Resource.Id.nav_estado)
            {
                var res = new Intent(this, typeof(ActivityEstado));
                StartActivity(res);
            }
            else if (id == Resource.Id.nav_share)
            {
                var res = new Intent(this, typeof(ActivityCompartir));
                StartActivity(res);
            }
            else if (id == Resource.Id.nav_valoranos)
            {

            }
            else if (id == Resource.Id.nav_tema)
            {
                var res = new Intent(this, typeof(ActivityTema));
                StartActivity(res);
            }

            else if (id == Resource.Id.nav_notificaciones)
            {

            }
            else if (id == Resource.Id.nav_cerrarsesion)
            {
                Android.App.AlertDialog.Builder alert = new Android.App.AlertDialog.Builder(this);
                alert.SetTitle("Cerrar sesión");
                alert.SetMessage("¿Desea cerrar sesión?").SetPositiveButton("Sí", (senderAlert, args) =>
                {
                    ISharedPreferences preferencia = Application.GetSharedPreferences("informacion", FileCreationMode.Private);
                    ISharedPreferencesEditor editor = preferencia.Edit();
                    editor.Clear();
                    editor.Apply();
                    this.Finish();

                    Intent intent = new Intent(this, typeof(ActivityLogin));
                    StartActivity(intent);
                }).SetNegativeButton("No", (senderAlert, args) => { }).Show();

            }

            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            drawer.CloseDrawer(GravityCompat.Start);
            return true;
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}

