using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Flask.Colorpicker {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.flask.colorpicker']/interface[@name='OnColorSelectedListener']"
	[Register ("com/flask/colorpicker/OnColorSelectedListener", "", "Com.Flask.Colorpicker.IOnColorSelectedListenerInvoker")]
	public partial interface IOnColorSelectedListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/interface[@name='OnColorSelectedListener']/method[@name='onColorSelected' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onColorSelected", "(I)V", "GetOnColorSelected_IHandler:Com.Flask.Colorpicker.IOnColorSelectedListenerInvoker, Picker")]
		void OnColorSelected (int p0);

	}

	[global::Android.Runtime.Register ("com/flask/colorpicker/OnColorSelectedListener", DoNotGenerateAcw=true)]
	internal partial class IOnColorSelectedListenerInvoker : global::Java.Lang.Object, IOnColorSelectedListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/flask/colorpicker/OnColorSelectedListener", typeof (IOnColorSelectedListenerInvoker));

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

		public static IOnColorSelectedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnColorSelectedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.flask.colorpicker.OnColorSelectedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnColorSelectedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onColorSelected_I;
#pragma warning disable 0169
		static Delegate GetOnColorSelected_IHandler ()
		{
			if (cb_onColorSelected_I == null)
				cb_onColorSelected_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnColorSelected_I);
			return cb_onColorSelected_I;
		}

		static void n_OnColorSelected_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Flask.Colorpicker.IOnColorSelectedListener __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.IOnColorSelectedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnColorSelected (p0);
		}
#pragma warning restore 0169

		IntPtr id_onColorSelected_I;
		public unsafe void OnColorSelected (int p0)
		{
			if (id_onColorSelected_I == IntPtr.Zero)
				id_onColorSelected_I = JNIEnv.GetMethodID (class_ref, "onColorSelected", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onColorSelected_I, __args);
		}

	}

	// event args for com.flask.colorpicker.OnColorSelectedListener.onColorSelected
	public partial class ColorSelectedEventArgs : global::System.EventArgs {

		public ColorSelectedEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/flask/colorpicker/OnColorSelectedListenerImplementor")]
	internal sealed partial class IOnColorSelectedListenerImplementor : global::Java.Lang.Object, IOnColorSelectedListener {

		object sender;

		public IOnColorSelectedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/flask/colorpicker/OnColorSelectedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ColorSelectedEventArgs> Handler;
#pragma warning restore 0649

		public void OnColorSelected (int p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ColorSelectedEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnColorSelectedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
