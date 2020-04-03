package mono.com.flask.colorpicker;


public class OnColorSelectedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.flask.colorpicker.OnColorSelectedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onColorSelected:(I)V:GetOnColorSelected_IHandler:Com.Flask.Colorpicker.IOnColorSelectedListenerInvoker, Picker\n" +
			"";
		mono.android.Runtime.register ("Com.Flask.Colorpicker.IOnColorSelectedListenerImplementor, Picker", OnColorSelectedListenerImplementor.class, __md_methods);
	}


	public OnColorSelectedListenerImplementor ()
	{
		super ();
		if (getClass () == OnColorSelectedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Flask.Colorpicker.IOnColorSelectedListenerImplementor, Picker", "", this, new java.lang.Object[] {  });
	}


	public void onColorSelected (int p0)
	{
		n_onColorSelected (p0);
	}

	private native void n_onColorSelected (int p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
