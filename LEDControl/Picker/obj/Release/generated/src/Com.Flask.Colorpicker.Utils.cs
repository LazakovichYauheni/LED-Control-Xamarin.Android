using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Flask.Colorpicker {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='Utils']"
	[global::Android.Runtime.Register ("com/flask/colorpicker/Utils", DoNotGenerateAcw=true)]
	public partial class Utils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/flask/colorpicker/Utils", typeof (Utils));
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

		protected Utils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='Utils']/constructor[@name='Utils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Utils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='Utils']/method[@name='adjustAlpha' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='int']]"
		[Register ("adjustAlpha", "(FI)I", "")]
		public static unsafe int AdjustAlpha (float alpha, int color)
		{
			const string __id = "adjustAlpha.(FI)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (alpha);
				__args [1] = new JniArgumentValue (color);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='Utils']/method[@name='alphaValueAsInt' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("alphaValueAsInt", "(F)I", "")]
		public static unsafe int AlphaValueAsInt (float alpha)
		{
			const string __id = "alphaValueAsInt.(F)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (alpha);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='Utils']/method[@name='colorAtLightness' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
		[Register ("colorAtLightness", "(IF)I", "")]
		public static unsafe int ColorAtLightness (int color, float lightness)
		{
			const string __id = "colorAtLightness.(IF)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (color);
				__args [1] = new JniArgumentValue (lightness);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='Utils']/method[@name='getAlphaPercent' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getAlphaPercent", "(I)F", "")]
		public static unsafe float GetAlphaPercent (int argb)
		{
			const string __id = "getAlphaPercent.(I)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (argb);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='Utils']/method[@name='getHexString' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("getHexString", "(IZ)Ljava/lang/String;", "")]
		public static unsafe string GetHexString (int color, bool showAlpha)
		{
			const string __id = "getHexString.(IZ)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (color);
				__args [1] = new JniArgumentValue (showAlpha);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='Utils']/method[@name='lightnessOfColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("lightnessOfColor", "(I)F", "")]
		public static unsafe float LightnessOfColor (int color)
		{
			const string __id = "lightnessOfColor.(I)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
