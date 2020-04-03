package mono.com.flask.colorpicker.builder;


public class ColorPickerClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.flask.colorpicker.builder.ColorPickerClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onClick:(Landroid/content/DialogInterface;I[Ljava/lang/Integer;)V:GetOnClick_Landroid_content_DialogInterface_IarrayLjava_lang_Integer_Handler:Com.Flask.Colorpicker.Builder.IColorPickerClickListenerInvoker, Picker\n" +
			"";
		mono.android.Runtime.register ("Com.Flask.Colorpicker.Builder.IColorPickerClickListenerImplementor, Picker", ColorPickerClickListenerImplementor.class, __md_methods);
	}


	public ColorPickerClickListenerImplementor ()
	{
		super ();
		if (getClass () == ColorPickerClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Flask.Colorpicker.Builder.IColorPickerClickListenerImplementor, Picker", "", this, new java.lang.Object[] {  });
	}


	public void onClick (android.content.DialogInterface p0, int p1, java.lang.Integer[] p2)
	{
		n_onClick (p0, p1, p2);
	}

	private native void n_onClick (android.content.DialogInterface p0, int p1, java.lang.Integer[] p2);

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
