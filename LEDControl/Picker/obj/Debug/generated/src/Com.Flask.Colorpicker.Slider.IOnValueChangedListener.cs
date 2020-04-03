using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Flask.Colorpicker.Slider {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.flask.colorpicker.slider']/interface[@name='OnValueChangedListener']"
	[Register ("com/flask/colorpicker/slider/OnValueChangedListener", "", "Com.Flask.Colorpicker.Slider.IOnValueChangedListenerInvoker")]
	public partial interface IOnValueChangedListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.slider']/interface[@name='OnValueChangedListener']/method[@name='onValueChanged' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("onValueChanged", "(F)V", "GetOnValueChanged_FHandler:Com.Flask.Colorpicker.Slider.IOnValueChangedListenerInvoker, Picker")]
		void OnValueChanged (float p0);

	}

	[global::Android.Runtime.Register ("com/flask/colorpicker/slider/OnValueChangedListener", DoNotGenerateAcw=true)]
	internal partial class IOnValueChangedListenerInvoker : global::Java.Lang.Object, IOnValueChangedListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/flask/colorpicker/slider/OnValueChangedListener", typeof (IOnValueChangedListenerInvoker));

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

		public static IOnValueChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnValueChangedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.flask.colorpicker.slider.OnValueChangedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnValueChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onValueChanged_F;
#pragma warning disable 0169
		static Delegate GetOnValueChanged_FHandler ()
		{
			if (cb_onValueChanged_F == null)
				cb_onValueChanged_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_OnValueChanged_F);
			return cb_onValueChanged_F;
		}

		static void n_OnValueChanged_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Flask.Colorpicker.Slider.IOnValueChangedListener __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.IOnValueChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnValueChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_onValueChanged_F;
		public unsafe void OnValueChanged (float p0)
		{
			if (id_onValueChanged_F == IntPtr.Zero)
				id_onValueChanged_F = JNIEnv.GetMethodID (class_ref, "onValueChanged", "(F)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onValueChanged_F, __args);
		}

	}

	// event args for com.flask.colorpicker.slider.OnValueChangedListener.onValueChanged
	public partial class ValueChangedEventArgs : global::System.EventArgs {

		public ValueChangedEventArgs (float p0)
		{
			this.p0 = p0;
		}

		float p0;
		public float P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/flask/colorpicker/slider/OnValueChangedListenerImplementor")]
	internal sealed partial class IOnValueChangedListenerImplementor : global::Java.Lang.Object, IOnValueChangedListener {

		object sender;

		public IOnValueChangedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/flask/colorpicker/slider/OnValueChangedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ValueChangedEventArgs> Handler;
#pragma warning restore 0649

		public void OnValueChanged (float p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ValueChangedEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnValueChangedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
