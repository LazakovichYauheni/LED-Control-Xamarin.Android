using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Flask.Colorpicker {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']"
	[global::Android.Runtime.Register ("com/flask/colorpicker/ColorPickerView", DoNotGenerateAcw=true)]
	public partial class ColorPickerView : global::Android.Views.View {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView.WHEEL_TYPE']"
		[global::Android.Runtime.Register ("com/flask/colorpicker/ColorPickerView$WHEEL_TYPE", DoNotGenerateAcw=true)]
		public sealed partial class WHEEL_TYPE : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView.WHEEL_TYPE']/field[@name='CIRCLE']"
			[Register ("CIRCLE")]
			public static global::Com.Flask.Colorpicker.ColorPickerView.WHEEL_TYPE Circle {
				get {
					const string __id = "CIRCLE.Lcom/flask/colorpicker/ColorPickerView$WHEEL_TYPE;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView.WHEEL_TYPE> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView.WHEEL_TYPE']/field[@name='FLOWER']"
			[Register ("FLOWER")]
			public static global::Com.Flask.Colorpicker.ColorPickerView.WHEEL_TYPE Flower {
				get {
					const string __id = "FLOWER.Lcom/flask/colorpicker/ColorPickerView$WHEEL_TYPE;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView.WHEEL_TYPE> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/flask/colorpicker/ColorPickerView$WHEEL_TYPE", typeof (WHEEL_TYPE));
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

			internal WHEEL_TYPE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView.WHEEL_TYPE']/method[@name='indexOf' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("indexOf", "(I)Lcom/flask/colorpicker/ColorPickerView$WHEEL_TYPE;", "")]
			public static unsafe global::Com.Flask.Colorpicker.ColorPickerView.WHEEL_TYPE IndexOf (int index)
			{
				const string __id = "indexOf.(I)Lcom/flask/colorpicker/ColorPickerView$WHEEL_TYPE;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (index);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView.WHEEL_TYPE> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView.WHEEL_TYPE']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/flask/colorpicker/ColorPickerView$WHEEL_TYPE;", "")]
			public static unsafe global::Com.Flask.Colorpicker.ColorPickerView.WHEEL_TYPE ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/flask/colorpicker/ColorPickerView$WHEEL_TYPE;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView.WHEEL_TYPE> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView.WHEEL_TYPE']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/flask/colorpicker/ColorPickerView$WHEEL_TYPE;", "")]
			public static unsafe global::Com.Flask.Colorpicker.ColorPickerView.WHEEL_TYPE[] Values ()
			{
				const string __id = "values.()[Lcom/flask/colorpicker/ColorPickerView$WHEEL_TYPE;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Flask.Colorpicker.ColorPickerView.WHEEL_TYPE[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Flask.Colorpicker.ColorPickerView.WHEEL_TYPE));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/flask/colorpicker/ColorPickerView", typeof (ColorPickerView));
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

		protected ColorPickerView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/constructor[@name='ColorPickerView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ColorPickerView (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/constructor[@name='ColorPickerView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe ColorPickerView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/constructor[@name='ColorPickerView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe ColorPickerView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/constructor[@name='ColorPickerView' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", "")]
		public unsafe ColorPickerView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr, int defStyleRes)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyleAttr);
				__args [3] = new JniArgumentValue (defStyleRes);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getSelectedColor;
#pragma warning disable 0169
		static Delegate GetGetSelectedColorHandler ()
		{
			if (cb_getSelectedColor == null)
				cb_getSelectedColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSelectedColor);
			return cb_getSelectedColor;
		}

		static int n_GetSelectedColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectedColor;
		}
#pragma warning restore 0169

		static Delegate cb_setSelectedColor_I;
#pragma warning disable 0169
		static Delegate GetSetSelectedColor_IHandler ()
		{
			if (cb_setSelectedColor_I == null)
				cb_setSelectedColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSelectedColor_I);
			return cb_setSelectedColor_I;
		}

		static void n_SetSelectedColor_I (IntPtr jnienv, IntPtr native__this, int previewNumber)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectedColor = previewNumber;
		}
#pragma warning restore 0169

		public virtual unsafe int SelectedColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='getSelectedColor' and count(parameter)=0]"
			[Register ("getSelectedColor", "()I", "GetGetSelectedColorHandler")]
			get {
				const string __id = "getSelectedColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='setSelectedColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSelectedColor", "(I)V", "GetSetSelectedColor_IHandler")]
			set {
				const string __id = "setSelectedColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_addOnColorChangedListener_Lcom_flask_colorpicker_OnColorChangedListener_;
#pragma warning disable 0169
		static Delegate GetAddOnColorChangedListener_Lcom_flask_colorpicker_OnColorChangedListener_Handler ()
		{
			if (cb_addOnColorChangedListener_Lcom_flask_colorpicker_OnColorChangedListener_ == null)
				cb_addOnColorChangedListener_Lcom_flask_colorpicker_OnColorChangedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOnColorChangedListener_Lcom_flask_colorpicker_OnColorChangedListener_);
			return cb_addOnColorChangedListener_Lcom_flask_colorpicker_OnColorChangedListener_;
		}

		static void n_AddOnColorChangedListener_Lcom_flask_colorpicker_OnColorChangedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Flask.Colorpicker.IOnColorChangedListener listener = (global::Com.Flask.Colorpicker.IOnColorChangedListener)global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.IOnColorChangedListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.AddOnColorChangedListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='addOnColorChangedListener' and count(parameter)=1 and parameter[1][@type='com.flask.colorpicker.OnColorChangedListener']]"
		[Register ("addOnColorChangedListener", "(Lcom/flask/colorpicker/OnColorChangedListener;)V", "GetAddOnColorChangedListener_Lcom_flask_colorpicker_OnColorChangedListener_Handler")]
		public virtual unsafe void AddOnColorChangedListener (global::Com.Flask.Colorpicker.IOnColorChangedListener listener)
		{
			const string __id = "addOnColorChangedListener.(Lcom/flask/colorpicker/OnColorChangedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addOnColorSelectedListener_Lcom_flask_colorpicker_OnColorSelectedListener_;
#pragma warning disable 0169
		static Delegate GetAddOnColorSelectedListener_Lcom_flask_colorpicker_OnColorSelectedListener_Handler ()
		{
			if (cb_addOnColorSelectedListener_Lcom_flask_colorpicker_OnColorSelectedListener_ == null)
				cb_addOnColorSelectedListener_Lcom_flask_colorpicker_OnColorSelectedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOnColorSelectedListener_Lcom_flask_colorpicker_OnColorSelectedListener_);
			return cb_addOnColorSelectedListener_Lcom_flask_colorpicker_OnColorSelectedListener_;
		}

		static void n_AddOnColorSelectedListener_Lcom_flask_colorpicker_OnColorSelectedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Flask.Colorpicker.IOnColorSelectedListener listener = (global::Com.Flask.Colorpicker.IOnColorSelectedListener)global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.IOnColorSelectedListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.AddOnColorSelectedListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='addOnColorSelectedListener' and count(parameter)=1 and parameter[1][@type='com.flask.colorpicker.OnColorSelectedListener']]"
		[Register ("addOnColorSelectedListener", "(Lcom/flask/colorpicker/OnColorSelectedListener;)V", "GetAddOnColorSelectedListener_Lcom_flask_colorpicker_OnColorSelectedListener_Handler")]
		public virtual unsafe void AddOnColorSelectedListener (global::Com.Flask.Colorpicker.IOnColorSelectedListener listener)
		{
			const string __id = "addOnColorSelectedListener.(Lcom/flask/colorpicker/OnColorSelectedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_callOnColorChangedListeners_II;
#pragma warning disable 0169
		static Delegate GetCallOnColorChangedListeners_IIHandler ()
		{
			if (cb_callOnColorChangedListeners_II == null)
				cb_callOnColorChangedListeners_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_CallOnColorChangedListeners_II);
			return cb_callOnColorChangedListeners_II;
		}

		static void n_CallOnColorChangedListeners_II (IntPtr jnienv, IntPtr native__this, int oldColor, int newColor)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CallOnColorChangedListeners (oldColor, newColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='callOnColorChangedListeners' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("callOnColorChangedListeners", "(II)V", "GetCallOnColorChangedListeners_IIHandler")]
		protected virtual unsafe void CallOnColorChangedListeners (int oldColor, int newColor)
		{
			const string __id = "callOnColorChangedListeners.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (oldColor);
				__args [1] = new JniArgumentValue (newColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getAllColors;
#pragma warning disable 0169
		static Delegate GetGetAllColorsHandler ()
		{
			if (cb_getAllColors == null)
				cb_getAllColors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllColors);
			return cb_getAllColors;
		}

		static IntPtr n_GetAllColors (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetAllColors ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='getAllColors' and count(parameter)=0]"
		[Register ("getAllColors", "()[Ljava/lang/Integer;", "GetGetAllColorsHandler")]
		public virtual unsafe global::Java.Lang.Integer[] GetAllColors ()
		{
			const string __id = "getAllColors.()[Ljava/lang/Integer;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Integer[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Integer));
			} finally {
			}
		}

		static Delegate cb_setAlphaSlider_Lcom_flask_colorpicker_slider_AlphaSlider_;
#pragma warning disable 0169
		static Delegate GetSetAlphaSlider_Lcom_flask_colorpicker_slider_AlphaSlider_Handler ()
		{
			if (cb_setAlphaSlider_Lcom_flask_colorpicker_slider_AlphaSlider_ == null)
				cb_setAlphaSlider_Lcom_flask_colorpicker_slider_AlphaSlider_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAlphaSlider_Lcom_flask_colorpicker_slider_AlphaSlider_);
			return cb_setAlphaSlider_Lcom_flask_colorpicker_slider_AlphaSlider_;
		}

		static void n_SetAlphaSlider_Lcom_flask_colorpicker_slider_AlphaSlider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_alphaSlider)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Flask.Colorpicker.Slider.AlphaSlider alphaSlider = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.AlphaSlider> (native_alphaSlider, JniHandleOwnership.DoNotTransfer);
			__this.SetAlphaSlider (alphaSlider);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='setAlphaSlider' and count(parameter)=1 and parameter[1][@type='com.flask.colorpicker.slider.AlphaSlider']]"
		[Register ("setAlphaSlider", "(Lcom/flask/colorpicker/slider/AlphaSlider;)V", "GetSetAlphaSlider_Lcom_flask_colorpicker_slider_AlphaSlider_Handler")]
		public virtual unsafe void SetAlphaSlider (global::Com.Flask.Colorpicker.Slider.AlphaSlider alphaSlider)
		{
			const string __id = "setAlphaSlider.(Lcom/flask/colorpicker/slider/AlphaSlider;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((alphaSlider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) alphaSlider).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setAlphaValue_F;
#pragma warning disable 0169
		static Delegate GetSetAlphaValue_FHandler ()
		{
			if (cb_setAlphaValue_F == null)
				cb_setAlphaValue_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetAlphaValue_F);
			return cb_setAlphaValue_F;
		}

		static void n_SetAlphaValue_F (IntPtr jnienv, IntPtr native__this, float alpha)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAlphaValue (alpha);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='setAlphaValue' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setAlphaValue", "(F)V", "GetSetAlphaValue_FHandler")]
		public virtual unsafe void SetAlphaValue (float alpha)
		{
			const string __id = "setAlphaValue.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (alpha);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setColor_IZ;
#pragma warning disable 0169
		static Delegate GetSetColor_IZHandler ()
		{
			if (cb_setColor_IZ == null)
				cb_setColor_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_SetColor_IZ);
			return cb_setColor_IZ;
		}

		static void n_SetColor_IZ (IntPtr jnienv, IntPtr native__this, int color, bool updateText)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetColor (color, updateText);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='setColor' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("setColor", "(IZ)V", "GetSetColor_IZHandler")]
		public virtual unsafe void SetColor (int color, bool updateText)
		{
			const string __id = "setColor.(IZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (color);
				__args [1] = new JniArgumentValue (updateText);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setColorEdit_Landroid_widget_EditText_;
#pragma warning disable 0169
		static Delegate GetSetColorEdit_Landroid_widget_EditText_Handler ()
		{
			if (cb_setColorEdit_Landroid_widget_EditText_ == null)
				cb_setColorEdit_Landroid_widget_EditText_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColorEdit_Landroid_widget_EditText_);
			return cb_setColorEdit_Landroid_widget_EditText_;
		}

		static void n_SetColorEdit_Landroid_widget_EditText_ (IntPtr jnienv, IntPtr native__this, IntPtr native_colorEdit)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.EditText colorEdit = global::Java.Lang.Object.GetObject<global::Android.Widget.EditText> (native_colorEdit, JniHandleOwnership.DoNotTransfer);
			__this.SetColorEdit (colorEdit);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='setColorEdit' and count(parameter)=1 and parameter[1][@type='android.widget.EditText']]"
		[Register ("setColorEdit", "(Landroid/widget/EditText;)V", "GetSetColorEdit_Landroid_widget_EditText_Handler")]
		public virtual unsafe void SetColorEdit (global::Android.Widget.EditText colorEdit)
		{
			const string __id = "setColorEdit.(Landroid/widget/EditText;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((colorEdit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) colorEdit).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setColorEditTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetColorEditTextColor_IHandler ()
		{
			if (cb_setColorEditTextColor_I == null)
				cb_setColorEditTextColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetColorEditTextColor_I);
			return cb_setColorEditTextColor_I;
		}

		static void n_SetColorEditTextColor_I (IntPtr jnienv, IntPtr native__this, int argb)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetColorEditTextColor (argb);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='setColorEditTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setColorEditTextColor", "(I)V", "GetSetColorEditTextColor_IHandler")]
		public virtual unsafe void SetColorEditTextColor (int argb)
		{
			const string __id = "setColorEditTextColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (argb);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setColorPreview_Landroid_widget_LinearLayout_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetColorPreview_Landroid_widget_LinearLayout_Ljava_lang_Integer_Handler ()
		{
			if (cb_setColorPreview_Landroid_widget_LinearLayout_Ljava_lang_Integer_ == null)
				cb_setColorPreview_Landroid_widget_LinearLayout_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetColorPreview_Landroid_widget_LinearLayout_Ljava_lang_Integer_);
			return cb_setColorPreview_Landroid_widget_LinearLayout_Ljava_lang_Integer_;
		}

		static void n_SetColorPreview_Landroid_widget_LinearLayout_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_colorPreview, IntPtr native_selectedColor)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.LinearLayout colorPreview = global::Java.Lang.Object.GetObject<global::Android.Widget.LinearLayout> (native_colorPreview, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer selectedColor = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_selectedColor, JniHandleOwnership.DoNotTransfer);
			__this.SetColorPreview (colorPreview, selectedColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='setColorPreview' and count(parameter)=2 and parameter[1][@type='android.widget.LinearLayout'] and parameter[2][@type='java.lang.Integer']]"
		[Register ("setColorPreview", "(Landroid/widget/LinearLayout;Ljava/lang/Integer;)V", "GetSetColorPreview_Landroid_widget_LinearLayout_Ljava_lang_Integer_Handler")]
		public virtual unsafe void SetColorPreview (global::Android.Widget.LinearLayout colorPreview, global::Java.Lang.Integer selectedColor)
		{
			const string __id = "setColorPreview.(Landroid/widget/LinearLayout;Ljava/lang/Integer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((colorPreview == null) ? IntPtr.Zero : ((global::Java.Lang.Object) colorPreview).Handle);
				__args [1] = new JniArgumentValue ((selectedColor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) selectedColor).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDensity_I;
#pragma warning disable 0169
		static Delegate GetSetDensity_IHandler ()
		{
			if (cb_setDensity_I == null)
				cb_setDensity_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDensity_I);
			return cb_setDensity_I;
		}

		static void n_SetDensity_I (IntPtr jnienv, IntPtr native__this, int density)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDensity (density);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='setDensity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDensity", "(I)V", "GetSetDensity_IHandler")]
		public virtual unsafe void SetDensity (int density)
		{
			const string __id = "setDensity.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (density);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setInitialColor_IZ;
#pragma warning disable 0169
		static Delegate GetSetInitialColor_IZHandler ()
		{
			if (cb_setInitialColor_IZ == null)
				cb_setInitialColor_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_SetInitialColor_IZ);
			return cb_setInitialColor_IZ;
		}

		static void n_SetInitialColor_IZ (IntPtr jnienv, IntPtr native__this, int color, bool updateText)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetInitialColor (color, updateText);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='setInitialColor' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("setInitialColor", "(IZ)V", "GetSetInitialColor_IZHandler")]
		public virtual unsafe void SetInitialColor (int color, bool updateText)
		{
			const string __id = "setInitialColor.(IZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (color);
				__args [1] = new JniArgumentValue (updateText);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setInitialColors_arrayLjava_lang_Integer_I;
#pragma warning disable 0169
		static Delegate GetSetInitialColors_arrayLjava_lang_Integer_IHandler ()
		{
			if (cb_setInitialColors_arrayLjava_lang_Integer_I == null)
				cb_setInitialColors_arrayLjava_lang_Integer_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetInitialColors_arrayLjava_lang_Integer_I);
			return cb_setInitialColors_arrayLjava_lang_Integer_I;
		}

		static void n_SetInitialColors_arrayLjava_lang_Integer_I (IntPtr jnienv, IntPtr native__this, IntPtr native_colors, int selectedColor)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer[] colors = (global::Java.Lang.Integer[]) JNIEnv.GetArray (native_colors, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Integer));
			__this.SetInitialColors (colors, selectedColor);
			if (colors != null)
				JNIEnv.CopyArray (colors, native_colors);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='setInitialColors' and count(parameter)=2 and parameter[1][@type='java.lang.Integer[]'] and parameter[2][@type='int']]"
		[Register ("setInitialColors", "([Ljava/lang/Integer;I)V", "GetSetInitialColors_arrayLjava_lang_Integer_IHandler")]
		public virtual unsafe void SetInitialColors (global::Java.Lang.Integer[] colors, int selectedColor)
		{
			const string __id = "setInitialColors.([Ljava/lang/Integer;I)V";
			IntPtr native_colors = JNIEnv.NewArray (colors);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_colors);
				__args [1] = new JniArgumentValue (selectedColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (colors != null) {
					JNIEnv.CopyArray (native_colors, colors);
					JNIEnv.DeleteLocalRef (native_colors);
				}
			}
		}

		static Delegate cb_setLightness_F;
#pragma warning disable 0169
		static Delegate GetSetLightness_FHandler ()
		{
			if (cb_setLightness_F == null)
				cb_setLightness_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetLightness_F);
			return cb_setLightness_F;
		}

		static void n_SetLightness_F (IntPtr jnienv, IntPtr native__this, float lightness)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLightness (lightness);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='setLightness' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setLightness", "(F)V", "GetSetLightness_FHandler")]
		public virtual unsafe void SetLightness (float lightness)
		{
			const string __id = "setLightness.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (lightness);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setLightnessSlider_Lcom_flask_colorpicker_slider_LightnessSlider_;
#pragma warning disable 0169
		static Delegate GetSetLightnessSlider_Lcom_flask_colorpicker_slider_LightnessSlider_Handler ()
		{
			if (cb_setLightnessSlider_Lcom_flask_colorpicker_slider_LightnessSlider_ == null)
				cb_setLightnessSlider_Lcom_flask_colorpicker_slider_LightnessSlider_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLightnessSlider_Lcom_flask_colorpicker_slider_LightnessSlider_);
			return cb_setLightnessSlider_Lcom_flask_colorpicker_slider_LightnessSlider_;
		}

		static void n_SetLightnessSlider_Lcom_flask_colorpicker_slider_LightnessSlider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_lightnessSlider)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Flask.Colorpicker.Slider.LightnessSlider lightnessSlider = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.LightnessSlider> (native_lightnessSlider, JniHandleOwnership.DoNotTransfer);
			__this.SetLightnessSlider (lightnessSlider);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='setLightnessSlider' and count(parameter)=1 and parameter[1][@type='com.flask.colorpicker.slider.LightnessSlider']]"
		[Register ("setLightnessSlider", "(Lcom/flask/colorpicker/slider/LightnessSlider;)V", "GetSetLightnessSlider_Lcom_flask_colorpicker_slider_LightnessSlider_Handler")]
		public virtual unsafe void SetLightnessSlider (global::Com.Flask.Colorpicker.Slider.LightnessSlider lightnessSlider)
		{
			const string __id = "setLightnessSlider.(Lcom/flask/colorpicker/slider/LightnessSlider;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((lightnessSlider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) lightnessSlider).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRenderer_Lcom_flask_colorpicker_renderer_ColorWheelRenderer_;
#pragma warning disable 0169
		static Delegate GetSetRenderer_Lcom_flask_colorpicker_renderer_ColorWheelRenderer_Handler ()
		{
			if (cb_setRenderer_Lcom_flask_colorpicker_renderer_ColorWheelRenderer_ == null)
				cb_setRenderer_Lcom_flask_colorpicker_renderer_ColorWheelRenderer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRenderer_Lcom_flask_colorpicker_renderer_ColorWheelRenderer_);
			return cb_setRenderer_Lcom_flask_colorpicker_renderer_ColorWheelRenderer_;
		}

		static void n_SetRenderer_Lcom_flask_colorpicker_renderer_ColorWheelRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_renderer)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Flask.Colorpicker.Renderer.IColorWheelRenderer renderer = (global::Com.Flask.Colorpicker.Renderer.IColorWheelRenderer)global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Renderer.IColorWheelRenderer> (native_renderer, JniHandleOwnership.DoNotTransfer);
			__this.SetRenderer (renderer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='setRenderer' and count(parameter)=1 and parameter[1][@type='com.flask.colorpicker.renderer.ColorWheelRenderer']]"
		[Register ("setRenderer", "(Lcom/flask/colorpicker/renderer/ColorWheelRenderer;)V", "GetSetRenderer_Lcom_flask_colorpicker_renderer_ColorWheelRenderer_Handler")]
		public virtual unsafe void SetRenderer (global::Com.Flask.Colorpicker.Renderer.IColorWheelRenderer renderer)
		{
			const string __id = "setRenderer.(Lcom/flask/colorpicker/renderer/ColorWheelRenderer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((renderer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) renderer).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setShowBorder_Z;
#pragma warning disable 0169
		static Delegate GetSetShowBorder_ZHandler ()
		{
			if (cb_setShowBorder_Z == null)
				cb_setShowBorder_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShowBorder_Z);
			return cb_setShowBorder_Z;
		}

		static void n_SetShowBorder_Z (IntPtr jnienv, IntPtr native__this, bool showBorder)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShowBorder (showBorder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='setShowBorder' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setShowBorder", "(Z)V", "GetSetShowBorder_ZHandler")]
		public virtual unsafe void SetShowBorder (bool showBorder)
		{
			const string __id = "setShowBorder.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (showBorder);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Flask.Colorpicker.IOnColorChangedListener"
		public event EventHandler<global::Com.Flask.Colorpicker.ColorChangedEventArgs> ColorChanged {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Flask.Colorpicker.IOnColorChangedListener, global::Com.Flask.Colorpicker.IOnColorChangedListenerImplementor>(
						ref weak_implementor_AddOnColorChangedListener,
						__CreateIOnColorChangedListenerImplementor,
						AddOnColorChangedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Flask.Colorpicker.IOnColorChangedListener, global::Com.Flask.Colorpicker.IOnColorChangedListenerImplementor>(
						ref weak_implementor_AddOnColorChangedListener,
						global::Com.Flask.Colorpicker.IOnColorChangedListenerImplementor.__IsEmpty,
						__v => {throw new NotSupportedException ("Cannot unregister from Com.Flask.Colorpicker.IOnColorChangedListener.AddOnColorChangedListener");},
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnColorChangedListener;

		global::Com.Flask.Colorpicker.IOnColorChangedListenerImplementor __CreateIOnColorChangedListenerImplementor ()
		{
			return new global::Com.Flask.Colorpicker.IOnColorChangedListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Flask.Colorpicker.IOnColorSelectedListener"
		public event EventHandler<global::Com.Flask.Colorpicker.ColorSelectedEventArgs> ColorSelected {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Flask.Colorpicker.IOnColorSelectedListener, global::Com.Flask.Colorpicker.IOnColorSelectedListenerImplementor>(
						ref weak_implementor_AddOnColorSelectedListener,
						__CreateIOnColorSelectedListenerImplementor,
						AddOnColorSelectedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Flask.Colorpicker.IOnColorSelectedListener, global::Com.Flask.Colorpicker.IOnColorSelectedListenerImplementor>(
						ref weak_implementor_AddOnColorSelectedListener,
						global::Com.Flask.Colorpicker.IOnColorSelectedListenerImplementor.__IsEmpty,
						__v => {throw new NotSupportedException ("Cannot unregister from Com.Flask.Colorpicker.IOnColorSelectedListener.AddOnColorSelectedListener");},
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnColorSelectedListener;

		global::Com.Flask.Colorpicker.IOnColorSelectedListenerImplementor __CreateIOnColorSelectedListenerImplementor ()
		{
			return new global::Com.Flask.Colorpicker.IOnColorSelectedListenerImplementor (this);
		}
#endregion
	}
}
