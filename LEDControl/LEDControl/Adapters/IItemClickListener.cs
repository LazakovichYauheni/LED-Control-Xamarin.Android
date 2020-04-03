using Android.Views;

namespace LEDControl.Adapters
{
    public interface IItemClickListener
    {
        void OnClick(View itemView, int position, bool isLongClick);
    }
}