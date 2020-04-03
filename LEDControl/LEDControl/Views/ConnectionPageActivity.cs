using System;
using Android.OS;
using System.Linq;
using Android.App;
using Android.Views;
using Android.Widget;
using Android.Content;
using Android.Graphics;
using Android.Bluetooth;
using Android.Support.V7.App;
using System.Collections.Generic;

namespace LEDControl.Views
{
    [Activity(Label = "ConnectionPageActivity", Theme = "@/style/AppTheme.NoActionBar", MainLauncher = false)]
    public class ConnectionPageActivity : AppCompatActivity
    {
        public static BluetoothSocket _socket;
        private BluetoothAdapter _bluetoothAdapter;
        private NumberPicker _numberPicker;
        private TextView _headerText;
        private int _selectedNumber;
        private TextView _setupText;
        private Button _nextButton;
        private Spinner _spinner;
        private Button _button;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.connectionpage);

            _bluetoothAdapter = BluetoothAdapter.DefaultAdapter;

            #region define items on View
            _spinner = FindViewById<Spinner>(Resource.Id.spinner);
            _setupText = FindViewById<TextView>(Resource.Id.setup);
            _headerText = FindViewById<TextView>(Resource.Id.connect);
            _nextButton = FindViewById<Button>(Resource.Id.nextbutton);
            _button = FindViewById<Button>(Resource.Id.connectbuttonid);
            _numberPicker = FindViewById<NumberPicker>(Resource.Id.numberPicker);


            Typeface _montserratTypeface = Typeface.CreateFromAsset(Assets, "MontserratSemiBold.ttf");
            Typeface _typeface = Typeface.CreateFromAsset(Assets, "Orbitron.ttf");

            _nextButton.SetTypeface(_montserratTypeface, TypefaceStyle.Normal);
            _button.SetTypeface(_montserratTypeface, TypefaceStyle.Normal);
            _headerText.SetTypeface(_typeface, TypefaceStyle.Normal);
            _setupText.SetTypeface(_typeface, TypefaceStyle.Normal);

            _numberPicker.MinValue = 0;
            _numberPicker.MaxValue = 120;

            #endregion

            var bluetoothDevices = GetBluetoothDevices();

            var _adapter = new ArrayAdapter(this, Resource.Layout.SpinnerItem);

            if (bluetoothDevices != null)
            {
                _adapter = new ArrayAdapter<string>(this, Resource.Layout.SpinnerItem, bluetoothDevices);
            }

            _spinner.Adapter = _adapter;

            _button.Click += DisplayToast_Click;
            _nextButton.Click += GoToControlPage;
            _numberPicker.ValueChanged += NumberChanged;
        }

        private List<string> GetBluetoothDevices()
        {
            if (_bluetoothAdapter != null && _bluetoothAdapter.Enable())
            {
                ICollection<BluetoothDevice> _devices = _bluetoothAdapter.BondedDevices;

                List<string> _names = new List<string>();

                foreach (var device in _devices)
                {
                    _names.Add(device.Name);
                }
                return _names;
            }
            else
            {
                Intent enableBTIntent = new Intent(BluetoothAdapter.ActionRequestEnable);
                StartActivityForResult(enableBTIntent, 0);
            }
            return null;
        }
        protected override void OnResume()
        {
            base.OnResume();
            FullScreencall();
        }

        private async void DisplayToast_Click(object sender, EventArgs e)
        {
            string _selectedName = _spinner.SelectedItem.ToString();

            var device = _bluetoothAdapter.BondedDevices.Where(x => x.Name == _selectedName).FirstOrDefault();

            _socket = device.CreateRfcommSocketToServiceRecord(device.GetUuids()[0].Uuid);

            await _socket.ConnectAsync();

            if (_socket.IsConnected)
                Toast.MakeText(this, "Connected", ToastLength.Long).Show();
        }

        private void NumberChanged(object sender, EventArgs e)
        {
            _selectedNumber = _numberPicker.Value;
        }

        private void GoToControlPage(object sender, EventArgs e)
        {
            var secondActivity = new Intent(this, typeof(LedControlPageActivity));
            secondActivity.PutExtra("SelectedNumber", _selectedNumber);
            StartActivity(secondActivity);
        }

        private void FullScreencall()
        {
            View decorView = Window.DecorView;
            var uiOptions = View.SystemUiFlagHideNavigation | View.SystemUiFlagImmersiveSticky;
            decorView.SystemUiVisibility = (StatusBarVisibility)uiOptions;
        }
    }
}