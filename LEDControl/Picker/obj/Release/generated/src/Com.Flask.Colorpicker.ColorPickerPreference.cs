using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Flask.Colorpicker {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerPreference']"
	[global::Android.Runtime.Register ("com/flask/colorpicker/ColorPickerPreference", DoNotGenerateAcw=true)]
	public partial class ColorPickerPreference : global::Android.Preferences.Preference {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerPreference']/field[@name='alphaSlider']"
		[Register ("alphaSlider")]
		protected bool AlphaSlider {
			get {
				const string __id = "alphaSlider.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "alphaSlider.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerPreference']/field[@name='border']"
		[Register ("border")]
		protected bool Border {
			get {
				const string __id = "border.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "border.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerPreference']/field[@name='colorIndicator']"
		[Register ("colorIndicator")]
		protected global::Android.Widget.ImageView ColorIndicator {
			get {
				const string __id = "colorIndicator.Landroid/widget/ImageView;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "colorIndicator.Landroid/widget/ImageView;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerPreference']/field[@name='density']"
		[Register ("density")]
		protected int Density {
			get {
				const string __id = "density.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "density.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerPreference']/field[@name='lightSlider']"
		[Register ("lightSlider")]
		protected bool LightSlider {
			get {
				const string __id = "lightSlider.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "lightSlider.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerPreference']/field[@name='selectedColor']"
		[Register ("selectedColor")]
		protected int SelectedColor {
			get {
				const string __id = "selectedColor.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "selectedColor.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerPreference']/field[@name='wheelType']"
		[Register ("wheelType")]
		protected global::Com.Flask.Colorpicker.ColorPickerView.WHEEL_TYPE WheelType {
			get {
				const string __id = "wheelType.Lcom/flask/colorpicker/ColorPickerView$WHEEL_TYPE;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView.WHEEL_TYPE> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "wheelType.Lcom/flask/colorpicker/ColorPickerView$WHEEL_TYPE;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/flask/colorpicker/ColorPickerPreference", typeof (ColorPickerPreference));
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

		protected ColorPickerPreference (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerPreference']/constructor[@name='ColorPickerPreference' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ColorPickerPreference (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerPreference']/constructor[@name='ColorPickerPreference' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe ColorPickerPreference (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerPreference']/constructor[@name='ColorPickerPreference' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe ColorPickerPreference (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyleAttr);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerPreference']/method[@name='darken' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
		[Register ("darken", "(IF)I", "")]
		public static unsafe int Darken (int color, float factor)
		{
			const string __id = "darken.(IF)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (color);
				__args [1] = new JniArgumentValue (factor);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setValue_I;
#pragma warning disable 0169
		static Delegate GetSetValue_IHandler ()
		{
			if (cb_setValue_I == null)
				cb_setValue_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetValue_I);
			return cb_setValue_I;
		}

		static void n_SetValue_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::Com.Flask.Colorpicker.ColorPickerPreference __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetValue (value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerPreference']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setValue", "(I)V", "GetSetValue_IHandler")]
		public virtual unsafe void SetValue (int value)
		{
			const string __id = "setValue.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
