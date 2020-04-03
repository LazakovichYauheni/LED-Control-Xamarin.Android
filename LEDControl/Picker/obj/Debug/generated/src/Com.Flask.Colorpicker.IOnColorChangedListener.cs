using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Flask.Colorpicker {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.flask.colorpicker']/interface[@name='OnColorChangedListener']"
	[Register ("com/flask/colorpicker/OnColorChangedListener", "", "Com.Flask.Colorpicker.IOnColorChangedListenerInvoker")]
	public partial interface IOnColorChangedListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/interface[@name='OnColorChangedListener']/method[@name='onColorChanged' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onColorChanged", "(I)V", "GetOnColorChanged_IHandler:Com.Flask.Colorpicker.IOnColorChangedListenerInvoker, Picker")]
		void OnColorChanged (int p0);

	}

	[global::Android.Runtime.Register ("com/flask/colorpicker/OnColorChangedListener", DoNotGenerateAcw=true)]
	internal partial class IOnColorChangedListenerInvoker : global::Java.Lang.Object, IOnColorChangedListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/flask/colorpicker/OnColorChangedListener", typeof (IOnColorChangedListenerInvoker));

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

		public static IOnColorChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnColorChangedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.flask.colorpicker.OnColorChangedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnColorChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onColorChanged_I;
#pragma warning disable 0169
		static Delegate GetOnColorChanged_IHandler ()
		{
			if (cb_onColorChanged_I == null)
				cb_onColorChanged_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnColorChanged_I);
			return cb_onColorChanged_I;
		}

		static void n_OnColorChanged_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Flask.Colorpicker.IOnColorChangedListener __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.IOnColorChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnColorChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_onColorChanged_I;
		public unsafe void OnColorChanged (int p0)
		{
			if (id_onColorChanged_I == IntPtr.Zero)
				id_onColorChanged_I = JNIEnv.GetMethodID (class_ref, "onColorChanged", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onColorChanged_I, __args);
		}

	}

	// event args for com.flask.colorpicker.OnColorChangedListener.onColorChanged
	public partial class ColorChangedEventArgs : global::System.EventArgs {

		public ColorChangedEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/flask/colorpicker/OnColorChangedListenerImplementor")]
	internal sealed partial class IOnColorChangedListenerImplementor : global::Java.Lang.Object, IOnColorChangedListener {

		object sender;

		public IOnColorChangedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/flask/colorpicker/OnColorChangedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ColorChangedEventArgs> Handler;
#pragma warning restore 0649

		public void OnColorChanged (int p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ColorChangedEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnColorChangedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
