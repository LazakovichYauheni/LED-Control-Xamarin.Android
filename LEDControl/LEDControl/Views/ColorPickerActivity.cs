using Android.OS;
using Android.App;
using Android.Widget;
using Android.Content;
using Android.Bluetooth;
using Com.Flask.Colorpicker;
using Android.Support.V7.App;

namespace LEDControl.Views
{
    [Activity(Label = "ColorPickerActivity", Theme = "@/style/AppTheme.NoActionBar", MainLauncher = false)]
    public class ColorPickerActivity : AppCompatActivity
    {
        private ColorPickerView _colorPickerView;
        private BluetoothSocket _socket;
        private Button _okButton;
        private Intent _intent;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.pickerlayout);

            _okButton = FindViewById<Button>(Resource.Id.okbutton);

            _colorPickerView = FindViewById<ColorPickerView>(Resource.Id.color_picker_view);

            _socket = ConnectionPageActivity._socket;
        }

        protected override void OnResume()
        {
            base.OnResume();
            var selectedItem = Intent.GetIntExtra("selected", -1);
            _okButton.Click += (s, e) =>
            {
                var blue = _colorPickerView.SelectedColor & 255;
                var green = (_colorPickerView.SelectedColor >> 8) & 255;
                var red = (_colorPickerView.SelectedColor >> 16) & 255;
                var color = Android.Graphics.Color.Rgb(red, green, blue);

                var selectedItemToSend = new Java.Lang.String("item" + selectedItem + "," + blue + "," + green + "," + red);
                SendData(selectedItemToSend);

                _intent = new Intent(this, typeof(LedControlPageActivity));
                _intent.PutExtra("selectedColor", _colorPickerView.SelectedColor);
                _intent.PutExtra("selectedItem", selectedItem);
                SetResult(Result.Ok, _intent);
                Finish();
            };
        }

        private void SendData(Java.Lang.String data)
        {
            if (_socket != null)
            {
                var buffer = data.GetBytes();
                _socket.OutputStream.Write(buffer, 0, buffer.Length);
            }
        }
    }
}