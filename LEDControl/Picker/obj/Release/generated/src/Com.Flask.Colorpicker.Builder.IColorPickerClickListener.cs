using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Flask.Colorpicker.Builder {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.flask.colorpicker.builder']/interface[@name='ColorPickerClickListener']"
	[Register ("com/flask/colorpicker/builder/ColorPickerClickListener", "", "Com.Flask.Colorpicker.Builder.IColorPickerClickListenerInvoker")]
	public partial interface IColorPickerClickListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/interface[@name='ColorPickerClickListener']/method[@name='onClick' and count(parameter)=3 and parameter[1][@type='android.content.DialogInterface'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Integer[]']]"
		[Register ("onClick", "(Landroid/content/DialogInterface;I[Ljava/lang/Integer;)V", "GetOnClick_Landroid_content_DialogInterface_IarrayLjava_lang_Integer_Handler:Com.Flask.Colorpicker.Builder.IColorPickerClickListenerInvoker, Picker")]
		void OnClick (global::Android.Content.IDialogInterface p0, int p1, global::Java.Lang.Integer[] p2);

	}

	[global::Android.Runtime.Register ("com/flask/colorpicker/builder/ColorPickerClickListener", DoNotGenerateAcw=true)]
	internal partial class IColorPickerClickListenerInvoker : global::Java.Lang.Object, IColorPickerClickListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/flask/colorpicker/builder/ColorPickerClickListener", typeof (IColorPickerClickListenerInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IColorPickerClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IColorPickerClickListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.flask.colorpicker.builder.ColorPickerClickListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IColorPickerClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onClick_Landroid_content_DialogInterface_IarrayLjava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetOnClick_Landroid_content_DialogInterface_IarrayLjava_lang_Integer_Handler ()
		{
			if (cb_onClick_Landroid_content_DialogInterface_IarrayLjava_lang_Integer_ == null)
				cb_onClick_Landroid_content_DialogInterface_IarrayLjava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnClick_Landroid_content_DialogInterface_IarrayLjava_lang_Integer_);
			return cb_onClick_Landroid_content_DialogInterface_IarrayLjava_lang_Integer_;
		}

		static void n_OnClick_Landroid_content_DialogInterface_IarrayLjava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Flask.Colorpicker.Builder.IColorPickerClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.IColorPickerClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.IDialogInterface p0 = (global::Android.Content.IDialogInterface)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterface> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer[] p2 = (global::Java.Lang.Integer[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Integer));
			__this.OnClick (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_onClick_Landroid_content_DialogInterface_IarrayLjava_lang_Integer_;
		public unsafe void OnClick (global::Android.Content.IDialogInterface p0, int p1, global::Java.Lang.Integer[] p2)
		{
			if (id_onClick_Landroid_content_DialogInterface_IarrayLjava_lang_Integer_ == IntPtr.Zero)
				id_onClick_Landroid_content_DialogInterface_IarrayLjava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "onClick", "(Landroid/content/DialogInterface;I[Ljava/lang/Integer;)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClick_Landroid_content_DialogInterface_IarrayLjava_lang_Integer_, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}

	// event args for com.flask.colorpicker.builder.ColorPickerClickListener.onClick
	public partial class ColorPickerClickEventArgs : global::System.EventArgs {

		public ColorPickerClickEventArgs (global::Android.Content.IDialogInterface p0, int p1, global::Java.Lang.Integer[] p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::Android.Content.IDialogInterface p0;
		public global::Android.Content.IDialogInterface P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}

		global::Java.Lang.Integer[] p2;
		public global::Java.Lang.Integer[] P2 {
			get { return p2; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/flask/colorpicker/builder/ColorPickerClickListenerImplementor")]
	internal sealed partial class IColorPickerClickListenerImplementor : global::Java.Lang.Object, IColorPickerClickListener {

		object sender;

		public IColorPickerClickListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/flask/colorpicker/builder/ColorPickerClickListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ColorPickerClickEventArgs> Handler;
#pragma warning restore 0649

		public void OnClick (global::Android.Content.IDialogInterface p0, int p1, global::Java.Lang.Integer[] p2)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ColorPickerClickEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (IColorPickerClickListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
