using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Flask.Colorpicker.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='FlowerColorWheelRenderer']"
	[global::Android.Runtime.Register ("com/flask/colorpicker/renderer/FlowerColorWheelRenderer", DoNotGenerateAcw=true)]
	public partial class FlowerColorWheelRenderer : global::Com.Flask.Colorpicker.Renderer.AbsColorWheelRenderer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/flask/colorpicker/renderer/FlowerColorWheelRenderer", typeof (FlowerColorWheelRenderer));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected FlowerColorWheelRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='FlowerColorWheelRenderer']/constructor[@name='FlowerColorWheelRenderer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FlowerColorWheelRenderer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_draw;
#pragma warning disable 0169
		static Delegate GetDrawHandler ()
		{
			if (cb_draw == null)
				cb_draw = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Draw);
			return cb_draw;
		}

		static void n_Draw (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flask.Colorpicker.Renderer.FlowerColorWheelRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Renderer.FlowerColorWheelRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Draw ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='FlowerColorWheelRenderer']/method[@name='draw' and count(parameter)=0]"
		[Register ("draw", "()V", "GetDrawHandler")]
		public override unsafe void Draw ()
		{
			const string __id = "draw.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
