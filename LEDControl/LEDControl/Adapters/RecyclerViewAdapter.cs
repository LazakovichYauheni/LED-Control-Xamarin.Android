using System.Collections.Generic;
using Android.Support.V7.Widget;
using LEDControl.Views;
using Android.Graphics;
using Android.Content;
using Android.Widget;
using Android.Views;

namespace LEDControl.Adapters
{
    public class RecyclerViewHolder : RecyclerView.ViewHolder, View.IOnClickListener, View.IOnLongClickListener
    {
        private IItemClickListener _itemClickListener;

        public ImageView Button { get; set; }

        public ImageView ButtonSmall { get; set; }

        public RecyclerViewHolder(View itemView) : base(itemView)
        {
            Button = itemView.FindViewById<ImageView>(Resource.Id.imgView);
            ButtonSmall = itemView.FindViewById<ImageView>(Resource.Id.imgViewSmall);

            itemView.SetOnClickListener(this);
            itemView.SetOnLongClickListener(this);
        }

        public void SetItemClickListener(IItemClickListener itemClickListener)
        {
            _itemClickListener = itemClickListener;
        }

        public bool OnLongClick(View v)
        {
            _itemClickListener.OnClick(v, AdapterPosition, true);
            return true;
        }

        public void OnClick(View v)
        {
            _itemClickListener.OnClick(v, AdapterPosition, false);
        }
    }

    public class RecyclerViewAdapter : RecyclerView.Adapter, IItemClickListener
    {
        private List<ImageView> _btnList = new List<ImageView>();
        private RecyclerViewHolder viewHolder;
        private Context _context;
        private int _selectedItem;
        private int _color;
        private int _blue;
        private int _green;
        private int _red;

        public override int ItemCount
        {
            get
            {
                return _btnList.Count;
            }
        }

        public RecyclerViewAdapter(List<ImageView> btnList, Context context, int selectedItem, int selectedColor)
        {
            _btnList = btnList;
            _context = context;
            _selectedItem = selectedItem;
            _color = selectedColor;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            viewHolder = holder as RecyclerViewHolder;
            Color color;

            if (_btnList.Count < 61)
            {
                if (_btnList[position] == null)
                {
                    viewHolder.Button.SetBackgroundResource(Resource.Drawable.circleimage);
                }
                if (_btnList[position] != null)
                {
                    var a = _btnList[position].Background;
                    viewHolder.Button.Background = a;
                }
            }
            else
            {
                if (_btnList[position] == null)
                {
                    viewHolder.ButtonSmall.SetBackgroundResource(Resource.Drawable.circleimagesmall);
                }
                if (_btnList[position] != null)
                {
                    var a = _btnList[position].Background;
                    viewHolder.ButtonSmall.Background = a;
                }

            }

            viewHolder.SetItemClickListener(this);


            if (position == _selectedItem)
            {
                _blue = _color & 255;
                _green = (_color >> 8) & 255;
                _red = (_color >> 16) & 255;
                color = Color.Rgb(_red, _green, _blue);

                if (viewHolder.Button != null)
                    viewHolder.Button.SetBackgroundColor(color);
                if (viewHolder.ButtonSmall != null)
                    viewHolder.ButtonSmall.SetBackgroundColor(color);
            }
        }

        public void OnClick(View itemView, int position, bool isLongClick)
        {
            Context context = itemView.Context;

            Intent intent = new Intent(context, typeof(ColorPickerActivity));

            intent.PutExtra("selected", position);

            NotifyItemChanged(position);

            ((LedControlPageActivity)context).StartActivityForResult(intent, 1);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {

            LayoutInflater inflater = LayoutInflater.From(parent.Context);
            if (_btnList.Count < 61)
            {
                View itemView = inflater.Inflate(Resource.Layout.imglayout, parent, false);
                GridLayout.LayoutParams layoutParams = new GridLayout.LayoutParams();
                layoutParams.SetMargins(20, 20, 20, 20);
                layoutParams.Width = 100;
                layoutParams.Height = 100;
                itemView.LayoutParameters = layoutParams;
                return new RecyclerViewHolder(itemView);
            }
            else
            {
                View itemViewSmall = inflater.Inflate(Resource.Layout.imglayoutsmall, parent, false);
                GridLayout.LayoutParams layoutParams = new GridLayout.LayoutParams();
                layoutParams.SetMargins(15, 15, 15, 15);
                layoutParams.Width = 65;
                layoutParams.Height = 65;
                itemViewSmall.LayoutParameters = layoutParams;
                return new RecyclerViewHolder(itemViewSmall);
            }
        }
    }
}