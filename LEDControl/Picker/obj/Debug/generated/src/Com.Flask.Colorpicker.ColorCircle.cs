using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Flask.Colorpicker {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorCircle']"
	[global::Android.Runtime.Register ("com/flask/colorpicker/ColorCircle", DoNotGenerateAcw=true)]
	public partial class ColorCircle : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/flask/colorpicker/ColorCircle", typeof (ColorCircle));
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

		protected ColorCircle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorCircle']/constructor[@name='ColorCircle' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float[]']]"
		[Register (".ctor", "(FF[F)V", "")]
		public unsafe ColorCircle (float x, float y, float[] hsv)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FF[F)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_hsv = JNIEnv.NewArray (hsv);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				__args [2] = new JniArgumentValue (native_hsv);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (hsv != null) {
					JNIEnv.CopyArray (native_hsv, hsv);
					JNIEnv.DeleteLocalRef (native_hsv);
				}
			}
		}

		static Delegate cb_getColor;
#pragma warning disable 0169
		static Delegate GetGetColorHandler ()
		{
			if (cb_getColor == null)
				cb_getColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetColor);
			return cb_getColor;
		}

		static int n_GetColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flask.Colorpicker.ColorCircle __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorCircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Color;
		}
#pragma warning restore 0169

		public virtual unsafe int Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorCircle']/method[@name='getColor' and count(parameter)=0]"
			[Register ("getColor", "()I", "GetGetColorHandler")]
			get {
				const string __id = "getColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getHsv;
#pragma warning disable 0169
		static Delegate GetGetHsvHandler ()
		{
			if (cb_getHsv == null)
				cb_getHsv = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHsv);
			return cb_getHsv;
		}

		static IntPtr n_GetHsv (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flask.Colorpicker.ColorCircle __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorCircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetHsv ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorCircle']/method[@name='getHsv' and count(parameter)=0]"
		[Register ("getHsv", "()[F", "GetGetHsvHandler")]
		public virtual unsafe float[] GetHsv ()
		{
			const string __id = "getHsv.()[F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_getHsvWithLightness_F;
#pragma warning disable 0169
		static Delegate GetGetHsvWithLightness_FHandler ()
		{
			if (cb_getHsvWithLightness_F == null)
				cb_getHsvWithLightness_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_GetHsvWithLightness_F);
			return cb_getHsvWithLightness_F;
		}

		static IntPtr n_GetHsvWithLightness_F (IntPtr jnienv, IntPtr native__this, float lightness)
		{
			global::Com.Flask.Colorpicker.ColorCircle __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorCircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetHsvWithLightness (lightness));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorCircle']/method[@name='getHsvWithLightness' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("getHsvWithLightness", "(F)[F", "GetGetHsvWithLightness_FHandler")]
		public virtual unsafe float[] GetHsvWithLightness (float lightness)
		{
			const string __id = "getHsvWithLightness.(F)[F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (lightness);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_getX;
#pragma warning disable 0169
		static Delegate GetGetXHandler ()
		{
			if (cb_getX == null)
				cb_getX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetX);
			return cb_getX;
		}

		static float n_GetX (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flask.Colorpicker.ColorCircle __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorCircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetX ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorCircle']/method[@name='getX' and count(parameter)=0]"
		[Register ("getX", "()F", "GetGetXHandler")]
		public virtual unsafe float GetX ()
		{
			const string __id = "getX.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getY;
#pragma warning disable 0169
		static Delegate GetGetYHandler ()
		{
			if (cb_getY == null)
				cb_getY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetY);
			return cb_getY;
		}

		static float n_GetY (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flask.Colorpicker.ColorCircle __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorCircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetY ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorCircle']/method[@name='getY' and count(parameter)=0]"
		[Register ("getY", "()F", "GetGetYHandler")]
		public virtual unsafe float GetY ()
		{
			const string __id = "getY.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_set_FFarrayF;
#pragma warning disable 0169
		static Delegate GetSet_FFarrayFHandler ()
		{
			if (cb_set_FFarrayF == null)
				cb_set_FFarrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, IntPtr>) n_Set_FFarrayF);
			return cb_set_FFarrayF;
		}

		static void n_Set_FFarrayF (IntPtr jnienv, IntPtr native__this, float x, float y, IntPtr native_hsv)
		{
			global::Com.Flask.Colorpicker.ColorCircle __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorCircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] hsv = (float[]) JNIEnv.GetArray (native_hsv, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.Set (x, y, hsv);
			if (hsv != null)
				JNIEnv.CopyArray (hsv, native_hsv);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorCircle']/method[@name='set' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float[]']]"
		[Register ("set", "(FF[F)V", "GetSet_FFarrayFHandler")]
		public virtual unsafe void Set (float x, float y, float[] hsv)
		{
			const string __id = "set.(FF[F)V";
			IntPtr native_hsv = JNIEnv.NewArray (hsv);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				__args [2] = new JniArgumentValue (native_hsv);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (hsv != null) {
					JNIEnv.CopyArray (native_hsv, hsv);
					JNIEnv.DeleteLocalRef (native_hsv);
				}
			}
		}

		static Delegate cb_sqDist_FF;
#pragma warning disable 0169
		static Delegate GetSqDist_FFHandler ()
		{
			if (cb_sqDist_FF == null)
				cb_sqDist_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, double>) n_SqDist_FF);
			return cb_sqDist_FF;
		}

		static double n_SqDist_FF (IntPtr jnienv, IntPtr native__this, float x, float y)
		{
			global::Com.Flask.Colorpicker.ColorCircle __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorCircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SqDist (x, y);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorCircle']/method[@name='sqDist' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("sqDist", "(FF)D", "GetSqDist_FFHandler")]
		public virtual unsafe double SqDist (float x, float y)
		{
			const string __id = "sqDist.(FF)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
