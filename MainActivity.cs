﻿using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using Quiz_App.Activities;
using Android.Views;

namespace Quiz_App
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class MainActivity : AppCompatActivity
    {
        Android.Support.V7.Widget.Toolbar toolbar;
        Android.Support.V4.Widget.DrawerLayout drawerLayout;
        Android.Support.Design.Widget.NavigationView navigationView;
        
        LinearLayout historyLayout;
        LinearLayout geographyLayout;
        LinearLayout spaceLayout;
        LinearLayout engineerLayout;
        LinearLayout programmingLayout;
        LinearLayout businessLayout;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            toolbar = (Android.Support.V7.Widget.Toolbar)FindViewById(Resource.Id.toolbar);
            drawerLayout = (Android.Support.V4.Widget.DrawerLayout)FindViewById(Resource.Id.drawerLayout);
            navigationView = (Android.Support.Design.Widget.NavigationView)FindViewById(Resource.Id.navview);
            navigationView.NavigationItemSelected += NavigationView_NavigationItemSelected;
            //setup toolbar
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "topic";
            Android.Support.V7.App.ActionBar actionBar = SupportActionBar;
            actionBar.SetHomeAsUpIndicator(Resource.Drawable.menuaction);
            actionBar.SetDisplayHomeAsUpEnabled(true);
            //View Setups
            historyLayout = (LinearLayout)FindViewById(Resource.Id.historyLayout);
            geographyLayout = (LinearLayout)FindViewById(Resource.Id.geographyLayout);
            spaceLayout = (LinearLayout)FindViewById(Resource.Id.spaceLayout);
            engineerLayout = (LinearLayout)FindViewById(Resource.Id.engineerLayout);
            programmingLayout = (LinearLayout)FindViewById(Resource.Id.programmingLayout);
            businessLayout = (LinearLayout)FindViewById(Resource.Id.businessLayout);

            //Click Event Handlers
            historyLayout.Click += HistoryLayout_Click;
            geographyLayout.Click += GeographyLayout_Click;
            spaceLayout.Click += SpaceLayout_Click;
            engineerLayout.Click += EngineerLayout_Click;
            programmingLayout.Click += ProgrammingLayout_Click;
            businessLayout.Click += BusinessLayout_Click;

        }

        private void NavigationView_NavigationItemSelected(object sender, Android.Support.Design.Widget.NavigationView.NavigationItemSelectedEventArgs e)
        {
           if(e.MenuItem.ItemId == Resource.Id.navHistory)
            {
                InitHistory();
                drawerLayout.CloseDrawers();

            }
           else if(e.MenuItem.ItemId == Resource.Id.navGeography)
            {
                InitGeography();
                drawerLayout.CloseDrawers();
            }
            else if (e.MenuItem.ItemId == Resource.Id.navSpace)
            {
                InitSpace();
                drawerLayout.CloseDrawers();
            }
            else if (e.MenuItem.ItemId == Resource.Id.navEngineering)
            {
                InitEngineer();
                drawerLayout.CloseDrawers();
            }
            else if (e.MenuItem.ItemId == Resource.Id.navProgramming)
            {
                InitProgramming();
                drawerLayout.CloseDrawers();
            }
           else if(e.MenuItem.ItemId == Resource.Id.navBusiness)
            {
                InitBusiness();
                drawerLayout.CloseDrawers();
            }
        }

        private void BusinessLayout_Click(object sender, System.EventArgs e)
        {
            InitBusiness();
        }

        private void ProgrammingLayout_Click(object sender, System.EventArgs e)
        {
            InitProgramming();
        }

        private void EngineerLayout_Click(object sender, System.EventArgs e)
        {
            InitEngineer();
        }

        private void SpaceLayout_Click(object sender, System.EventArgs e)
        {
            InitSpace();
        }

        private void GeographyLayout_Click(object sender, System.EventArgs e)
        {
            InitGeography();
        }
        
        private void HistoryLayout_Click(object sender, System.EventArgs e)
        {
            InitHistory();
        }

        void InitBusiness()
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "Business");
            StartActivity(intent);
        }

        void InitProgramming()
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "Programming");
            StartActivity(intent);
        }

        void InitEngineer()
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "Engineer");
            StartActivity(intent);
        }

        void InitSpace()
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "Space");
            StartActivity(intent);
        }
        void InitGeography()
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "Geography");
            StartActivity(intent);
        }
        void InitHistory()
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "History");
            StartActivity(intent);
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    drawerLayout.OpenDrawer((int) GravityFlags.Left);
                    return true;
                default:
                    return base.OnOptionsItemSelected(item);
            }
         
        }
    }
}