using System;
using Android.OS;
using Android.App;
using Android.Views;
using Android.Widget;
using Android.Content;
using Android.Graphics;
using Android.Bluetooth;
using LEDControl.Adapters;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using System.Collections.Generic;

namespace LEDControl.Views
{
    [Activity(Label = "LedControlPageActivity", Theme = "@/style/AppTheme.NoActionBar", MainLauncher = false)]
    public class LedControlPageActivity : AppCompatActivity
    {
        private RecyclerView.LayoutManager _layoutManager;
        private RecyclerViewAdapter _adapter;
        private List<ImageView> _btnList;
        private BluetoothSocket _socket;
        private RecyclerView _recycler;
        private int _selectedItem = -1; // -1 for zero item in RecyclerView, because can't to set nullable value
        private int _selectedColor;
        private ImageView _imgView;
        private int _progress;
        private int _number;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ledcontrolpage);
            _number = Intent.GetIntExtra("SelectedNumber", 0);
            _socket = ConnectionPageActivity._socket;
            _btnList = new List<ImageView>();

            #region define items on View
            var seekBar = FindViewById<SeekBar>(Resource.Id.seekbar);

            var button1 = FindViewById<Button>(Resource.Id.mode1);
            var button2 = FindViewById<Button>(Resource.Id.mode2);
            var button3 = FindViewById<Button>(Resource.Id.mode3);
            var button4 = FindViewById<Button>(Resource.Id.mode4);
            var button5 = FindViewById<Button>(Resource.Id.mode5);
            var button6 = FindViewById<Button>(Resource.Id.mode6);
            var button7 = FindViewById<Button>(Resource.Id.mode7);
            var button8 = FindViewById<Button>(Resource.Id.mode8);
            var button9 = FindViewById<Button>(Resource.Id.mode9);
            _imgView = FindViewById<ImageView>(Resource.Id.imgView);
            _recycler = FindViewById<RecyclerView>(Resource.Id.recyclerview);

            Typeface _buttonTypeFace = Typeface.CreateFromAsset(Assets, "Montserrat.ttf");
            button1.SetTypeface(_buttonTypeFace, TypefaceStyle.Normal);
            button2.SetTypeface(_buttonTypeFace, TypefaceStyle.Normal);
            button3.SetTypeface(_buttonTypeFace, TypefaceStyle.Normal);
            button4.SetTypeface(_buttonTypeFace, TypefaceStyle.Normal);
            button5.SetTypeface(_buttonTypeFace, TypefaceStyle.Normal);
            button6.SetTypeface(_buttonTypeFace, TypefaceStyle.Normal);
            button7.SetTypeface(_buttonTypeFace, TypefaceStyle.Normal);
            button8.SetTypeface(_buttonTypeFace, TypefaceStyle.Normal);
            button9.SetTypeface(_buttonTypeFace, TypefaceStyle.Normal);

            seekBar.Progress = 100;
            #endregion

            seekBar.StopTrackingTouch += (s, e) =>
            {
                var dataToSend = new Java.Lang.String("p" + _progress);
                SendData(dataToSend);
            };

            seekBar.ProgressChanged += (s, e) =>
            {
                _progress = e.Progress;
            };

            #region button clicks
            button1.Click += ModeOneClick;
            button2.Click += ModeTwoClick;
            button3.Click += ModeThreeClick;
            button4.Click += ModeFourClick;
            button5.Click += ModeFiveClick;
            button6.Click += ModeSixClick;
            button7.Click += ModeSevenClick;
            button8.Click += ModeEightClick;
            button9.Click += ModeNineClick;
            button5.LongClick += ModeFiveLongClick;
            #endregion

            for (int i = 0; i < _number; i++)
            {
                _btnList.Add(_imgView);
            }

            _recycler.HasFixedSize = true;
            _layoutManager = new GridLayoutManager(this, 10);
            _recycler.SetLayoutManager(_layoutManager);

        }

        protected override void OnResume()
        {
            base.OnResume();
            FullScreencall();

            ImageView _imageView = new ImageView(this);
            _imageView.SetBackgroundResource(Resource.Drawable.circleimage);
            _imageView.SetBackgroundColor(Color.Red);
            if (_selectedItem > -1)
            {
                _btnList.RemoveAt(_selectedItem);
                _btnList.Insert(_selectedItem, _imageView);
            }

            _adapter = new RecyclerViewAdapter(_btnList, this, _selectedItem, _selectedColor);
            _recycler.SetAdapter(_adapter);
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            _selectedColor = data.GetIntExtra("selectedColor", 0);
            _selectedItem = data.GetIntExtra("selectedItem", 0);

        }

        #region button methods
        public void ModeOneClick(object sender, EventArgs e)
        {
            var dataToSend = new Java.Lang.String("w");
            SendData(dataToSend);
        }
        public void ModeTwoClick(object sender, EventArgs e)
        {
            var dataToSend = new Java.Lang.String("r");
            SendData(dataToSend);
        }
        public void ModeThreeClick(object sender, EventArgs e)
        {
            var dataToSend = new Java.Lang.String("g");
            SendData(dataToSend);
        }
        public void ModeFourClick(object sender, EventArgs e)
        {
            var dataToSend = new Java.Lang.String("b");
            SendData(dataToSend);
        }
        public void ModeFiveClick(object sender, EventArgs e)
        {
            var dataToSend = new Java.Lang.String("m");
            SendData(dataToSend);
        }
        public void ModeFiveLongClick(object sender, EventArgs e)
        {
            var thirdActivity = new Intent(this, typeof(ColorPickerActivity));
            StartActivity(thirdActivity);
        }
        public void ModeSixClick(object sender, EventArgs e)
        {
            var dataToSend = new Java.Lang.String("s");
            SendData(dataToSend);
        }
        public void ModeSevenClick(object sender, EventArgs e)
        {
            var dataToSend = new Java.Lang.String("a");
            SendData(dataToSend);
        }
        public void ModeEightClick(object sender, EventArgs e)
        {
            var dataToSend = new Java.Lang.String("c");
            SendData(dataToSend);
        }
        public void ModeNineClick(object sender, EventArgs e)
        {
            var dataToSend = new Java.Lang.String("d");
            SendData(dataToSend);
        }
        #endregion

        private void SendData(Java.Lang.String data)
        {
            if (_socket != null)
            {
                byte[] buffer = data.GetBytes();
                _socket.OutputStream.Write(buffer, 0, buffer.Length);
            }
        }
        private void FullScreencall()
        {
            View decorView = Window.DecorView;
            var uiOptions = View.SystemUiFlagHideNavigation | View.SystemUiFlagImmersiveSticky;
            decorView.SystemUiVisibility = (StatusBarVisibility)uiOptions;
        }
    }
}