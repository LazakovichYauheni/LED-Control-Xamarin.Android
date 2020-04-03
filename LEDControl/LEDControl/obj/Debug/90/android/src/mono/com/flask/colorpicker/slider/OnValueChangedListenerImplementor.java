package mono.com.flask.colorpicker.slider;


public class OnValueChangedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.flask.colorpicker.slider.OnValueChangedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onValueChanged:(F)V:GetOnValueChanged_FHandler:Com.Flask.Colorpicker.Slider.IOnValueChangedListenerInvoker, Picker\n" +
			"";
		mono.android.Runtime.register ("Com.Flask.Colorpicker.Slider.IOnValueChangedListenerImplementor, Picker", OnValueChangedListenerImplementor.class, __md_methods);
	}


	public OnValueChangedListenerImplementor ()
	{
		super ();
		if (getClass () == OnValueChangedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Flask.Colorpicker.Slider.IOnValueChangedListenerImplementor, Picker", "", this, new java.lang.Object[] {  });
	}


	public void onValueChanged (float p0)
	{
		n_onValueChanged (p0);
	}

	private native void n_onValueChanged (float p0);

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
