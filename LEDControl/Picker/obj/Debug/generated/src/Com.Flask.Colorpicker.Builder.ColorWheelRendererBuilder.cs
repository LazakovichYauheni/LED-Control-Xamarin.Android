using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Flask.Colorpicker.Builder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='ColorWheelRendererBuilder']"
	[global::Android.Runtime.Register ("com/flask/colorpicker/builder/ColorWheelRendererBuilder", DoNotGenerateAcw=true)]
	public partial class ColorWheelRendererBuilder : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/flask/colorpicker/builder/ColorWheelRendererBuilder", typeof (ColorWheelRendererBuilder));
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

		protected ColorWheelRendererBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='ColorWheelRendererBuilder']/constructor[@name='ColorWheelRendererBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ColorWheelRendererBuilder ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='ColorWheelRendererBuilder']/method[@name='getRenderer' and count(parameter)=1 and parameter[1][@type='com.flask.colorpicker.ColorPickerView.WHEEL_TYPE']]"
		[Register ("getRenderer", "(Lcom/flask/colorpicker/ColorPickerView$WHEEL_TYPE;)Lcom/flask/colorpicker/renderer/ColorWheelRenderer;", "")]
		public static unsafe global::Com.Flask.Colorpicker.Renderer.IColorWheelRenderer GetRenderer (global::Com.Flask.Colorpicker.ColorPickerView.WHEEL_TYPE wheelType)
		{
			const string __id = "getRenderer.(Lcom/flask/colorpicker/ColorPickerView$WHEEL_TYPE;)Lcom/flask/colorpicker/renderer/ColorWheelRenderer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((wheelType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) wheelType).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Renderer.IColorWheelRenderer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
