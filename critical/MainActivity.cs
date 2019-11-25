using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Media;
using Android.Views;

namespace critical
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private ImageView imageViewDice;
        private TextView textview;
        private Random rng = new Random();
        int sound1, sound2, sound3;
        private SoundPool MySoundPool = new SoundPool(3, 0, 5);

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            sound1 = MySoundPool.Load(this, Resource.Raw.diceroll, 1);
            sound2 = MySoundPool.Load(this, Resource.Raw.firstsound, 1);
            sound3 = MySoundPool.Load(this, Resource.Raw.finalsound, 1);
            imageViewDice = FindViewById<ImageView>(Resource.Id.image_view_dice);
            textview = FindViewById<TextView>(Resource.Id.textView);
            imageViewDice.Click += (sender, args) =>
            {
                MySoundPool.Play(sound1, 1, 1, 0, 0, 1);
                rollDice();
            };
        }

        private void rollDice()
        {
            int randomNumber = rng.Next(20) + 1;
            switch (randomNumber)
            {
                case 1:
                    imageViewDice.SetImageResource(Resource.Drawable.dice1);
                    textview.SetText(Resource.String.text_criticalM);
                    textview.SetTextColor(Android.Graphics.Color.Blue);
                    MySoundPool.Play(sound2, 1, 1, 0, 0, 1);
                    break;
                case 2:
                    imageViewDice.SetImageResource(Resource.Drawable.dice2);
                    textview.SetText(Resource.String.plain);
                    break;
                case 3:
                    imageViewDice.SetImageResource(Resource.Drawable.dice3);
                    textview.SetText(Resource.String.plain);
                    break;
                case 4:
                    imageViewDice.SetImageResource(Resource.Drawable.dice4);
                    textview.SetText(Resource.String.plain);
                    break;
                case 5:
                    imageViewDice.SetImageResource(Resource.Drawable.dice5);
                    textview.SetText(Resource.String.plain);
                    break;
                case 6:
                    imageViewDice.SetImageResource(Resource.Drawable.dice6);
                    textview.SetText(Resource.String.plain);
                    break;
                case 7:
                    imageViewDice.SetImageResource(Resource.Drawable.dice7);
                    textview.SetText(Resource.String.plain);
                    break;
                case 8:
                    imageViewDice.SetImageResource(Resource.Drawable.dice8);
                    textview.SetText(Resource.String.plain);
                    break;
                case 9:
                    imageViewDice.SetImageResource(Resource.Drawable.dice9);
                    textview.SetText(Resource.String.plain);
                    break;
                case 10:
                    imageViewDice.SetImageResource(Resource.Drawable.dice10);
                    textview.SetText(Resource.String.plain);
                    break;
                case 11:
                    imageViewDice.SetImageResource(Resource.Drawable.dice11);
                    textview.SetText(Resource.String.plain);
                    break;
                case 12:
                    imageViewDice.SetImageResource(Resource.Drawable.dice12);
                    textview.SetText(Resource.String.plain);
                    break;
                case 13:
                    imageViewDice.SetImageResource(Resource.Drawable.dice13);
                    textview.SetText(Resource.String.plain);
                    break;
                case 14:
                    imageViewDice.SetImageResource(Resource.Drawable.dice14);
                    textview.SetText(Resource.String.plain);
                    break;
                case 15:
                    imageViewDice.SetImageResource(Resource.Drawable.dice15);
                    textview.SetText(Resource.String.plain);
                    break;
                case 16:
                    imageViewDice.SetImageResource(Resource.Drawable.dice16);
                    textview.SetText(Resource.String.plain);
                    break;
                case 17:
                    imageViewDice.SetImageResource(Resource.Drawable.dice17);
                    textview.SetText(Resource.String.plain);
                    break;
                case 18:
                    imageViewDice.SetImageResource(Resource.Drawable.dice18);
                    textview.SetText(Resource.String.plain);
                    break;
                case 19:
                    imageViewDice.SetImageResource(Resource.Drawable.dice19);
                    textview.SetText(Resource.String.plain);
                    break;
                case 20:
                    imageViewDice.SetImageResource(Resource.Drawable.dice20);
                    textview.SetText(Resource.String.text_criticalH);
                    textview.SetTextColor(Android.Graphics.Color.Red);
                    MySoundPool.Play(sound3, 1, 1, 0, 0, 1);
                    break;
            }

        }







    }
}