using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Flask.Colorpicker.Builder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='ColorPickerDialogBuilder']"
	[global::Android.Runtime.Register ("com/flask/colorpicker/builder/ColorPickerDialogBuilder", DoNotGenerateAcw=true)]
	public partial class ColorPickerDialogBuilder : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/flask/colorpicker/builder/ColorPickerDialogBuilder", typeof (ColorPickerDialogBuilder));
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

		protected ColorPickerDialogBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_alphaSliderOnly;
#pragma warning disable 0169
		static Delegate GetAlphaSliderOnlyHandler ()
		{
			if (cb_alphaSliderOnly == null)
				cb_alphaSliderOnly = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AlphaSliderOnly);
			return cb_alphaSliderOnly;
		}

		static IntPtr n_AlphaSliderOnly (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AlphaSliderOnly ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='ColorPickerDialogBuilder']/method[@name='alphaSliderOnly' and count(parameter)=0]"
		[Register ("alphaSliderOnly", "()Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;", "GetAlphaSliderOnlyHandler")]
		public virtual unsafe global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder AlphaSliderOnly ()
		{
			const string __id = "alphaSliderOnly.()Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_density_I;
#pragma warning disable 0169
		static Delegate GetDensity_IHandler ()
		{
			if (cb_density_I == null)
				cb_density_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Density_I);
			return cb_density_I;
		}

		static IntPtr n_Density_I (IntPtr jnienv, IntPtr native__this, int density)
		{
			global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Density (density));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='ColorPickerDialogBuilder']/method[@name='density' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("density", "(I)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;", "GetDensity_IHandler")]
		public virtual unsafe global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder Density (int density)
		{
			const string __id = "density.(I)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (density);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_initialColor_I;
#pragma warning disable 0169
		static Delegate GetInitialColor_IHandler ()
		{
			if (cb_initialColor_I == null)
				cb_initialColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_InitialColor_I);
			return cb_initialColor_I;
		}

		static IntPtr n_InitialColor_I (IntPtr jnienv, IntPtr native__this, int initialColor)
		{
			global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InitialColor (initialColor));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='ColorPickerDialogBuilder']/method[@name='initialColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("initialColor", "(I)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;", "GetInitialColor_IHandler")]
		public virtual unsafe global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder InitialColor (int initialColor)
		{
			const string __id = "initialColor.(I)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (initialColor);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_initialColors_arrayI;
#pragma warning disable 0169
		static Delegate GetInitialColors_arrayIHandler ()
		{
			if (cb_initialColors_arrayI == null)
				cb_initialColors_arrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InitialColors_arrayI);
			return cb_initialColors_arrayI;
		}

		static IntPtr n_InitialColors_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_initialColor)
		{
			global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] initialColor = (int[]) JNIEnv.GetArray (native_initialColor, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InitialColors (initialColor));
			if (initialColor != null)
				JNIEnv.CopyArray (initialColor, native_initialColor);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='ColorPickerDialogBuilder']/method[@name='initialColors' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("initialColors", "([I)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;", "GetInitialColors_arrayIHandler")]
		public virtual unsafe global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder InitialColors (int[] initialColor)
		{
			const string __id = "initialColors.([I)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;";
			IntPtr native_initialColor = JNIEnv.NewArray (initialColor);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_initialColor);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (initialColor != null) {
					JNIEnv.CopyArray (native_initialColor, initialColor);
					JNIEnv.DeleteLocalRef (native_initialColor);
				}
			}
		}

		static Delegate cb_lightnessSliderOnly;
#pragma warning disable 0169
		static Delegate GetLightnessSliderOnlyHandler ()
		{
			if (cb_lightnessSliderOnly == null)
				cb_lightnessSliderOnly = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_LightnessSliderOnly);
			return cb_lightnessSliderOnly;
		}

		static IntPtr n_LightnessSliderOnly (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LightnessSliderOnly ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='ColorPickerDialogBuilder']/method[@name='lightnessSliderOnly' and count(parameter)=0]"
		[Register ("lightnessSliderOnly", "()Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;", "GetLightnessSliderOnlyHandler")]
		public virtual unsafe global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder LightnessSliderOnly ()
		{
			const string __id = "lightnessSliderOnly.()Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_noSliders;
#pragma warning disable 0169
		static Delegate GetNoSlidersHandler ()
		{
			if (cb_noSliders == null)
				cb_noSliders = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NoSliders);
			return cb_noSliders;
		}

		static IntPtr n_NoSliders (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NoSliders ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='ColorPickerDialogBuilder']/method[@name='noSliders' and count(parameter)=0]"
		[Register ("noSliders", "()Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;", "GetNoSlidersHandler")]
		public virtual unsafe global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder NoSliders ()
		{
			const string __id = "noSliders.()Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setColorEditTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetColorEditTextColor_IHandler ()
		{
			if (cb_setColorEditTextColor_I == null)
				cb_setColorEditTextColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetColorEditTextColor_I);
			return cb_setColorEditTextColor_I;
		}

		static IntPtr n_SetColorEditTextColor_I (IntPtr jnienv, IntPtr native__this, int argb)
		{
			global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetColorEditTextColor (argb));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='ColorPickerDialogBuilder']/method[@name='setColorEditTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setColorEditTextColor", "(I)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;", "GetSetColorEditTextColor_IHandler")]
		public virtual unsafe global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder SetColorEditTextColor (int argb)
		{
			const string __id = "setColorEditTextColor.(I)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (argb);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setNegativeButton_ILandroid_content_DialogInterface_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetSetNegativeButton_ILandroid_content_DialogInterface_OnClickListener_Handler ()
		{
			if (cb_setNegativeButton_ILandroid_content_DialogInterface_OnClickListener_ == null)
				cb_setNegativeButton_ILandroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SetNegativeButton_ILandroid_content_DialogInterface_OnClickListener_);
			return cb_setNegativeButton_ILandroid_content_DialogInterface_OnClickListener_;
		}

		static IntPtr n_SetNegativeButton_ILandroid_content_DialogInterface_OnClickListener_ (IntPtr jnienv, IntPtr native__this, int textId, IntPtr native_onClickListener)
		{
			global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.IDialogInterfaceOnClickListener onClickListener = (global::Android.Content.IDialogInterfaceOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnClickListener> (native_onClickListener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetNegativeButton (textId, onClickListener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='ColorPickerDialogBuilder']/method[@name='setNegativeButton' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.DialogInterface.OnClickListener']]"
		[Register ("setNegativeButton", "(ILandroid/content/DialogInterface$OnClickListener;)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;", "GetSetNegativeButton_ILandroid_content_DialogInterface_OnClickListener_Handler")]
		public virtual unsafe global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder SetNegativeButton (int textId, global::Android.Content.IDialogInterfaceOnClickListener onClickListener)
		{
			const string __id = "setNegativeButton.(ILandroid/content/DialogInterface$OnClickListener;)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (textId);
				__args [1] = new JniArgumentValue ((onClickListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onClickListener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setNegativeButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetSetNegativeButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_Handler ()
		{
			if (cb_setNegativeButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ == null)
				cb_setNegativeButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetNegativeButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_);
			return cb_setNegativeButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;
		}

		static IntPtr n_SetNegativeButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text, IntPtr native_onClickListener)
		{
			global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence text = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_text, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.IDialogInterfaceOnClickListener onClickListener = (global::Android.Content.IDialogInterfaceOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnClickListener> (native_onClickListener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetNegativeButton (text, onClickListener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='ColorPickerDialogBuilder']/method[@name='setNegativeButton' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='android.content.DialogInterface.OnClickListener']]"
		[Register ("setNegativeButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;", "GetSetNegativeButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_Handler")]
		public virtual unsafe global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder SetNegativeButton (global::Java.Lang.ICharSequence text, global::Android.Content.IDialogInterfaceOnClickListener onClickListener)
		{
			const string __id = "setNegativeButton.(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;";
			IntPtr native_text = CharSequence.ToLocalJniHandle (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue ((onClickListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onClickListener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		public global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder SetNegativeButton (string text, global::Android.Content.IDialogInterfaceOnClickListener onClickListener)
		{
			global::Java.Lang.String jls_text = text == null ? null : new global::Java.Lang.String (text);
			global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder __result = SetNegativeButton (jls_text, onClickListener);
			var __rsval = __result;
			jls_text?.Dispose ();
			return __rsval;
		}

		static Delegate cb_setOnColorChangedListener_Lcom_flask_colorpicker_OnColorChangedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnColorChangedListener_Lcom_flask_colorpicker_OnColorChangedListener_Handler ()
		{
			if (cb_setOnColorChangedListener_Lcom_flask_colorpicker_OnColorChangedListener_ == null)
				cb_setOnColorChangedListener_Lcom_flask_colorpicker_OnColorChangedListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOnColorChangedListener_Lcom_flask_colorpicker_OnColorChangedListener_);
			return cb_setOnColorChangedListener_Lcom_flask_colorpicker_OnColorChangedListener_;
		}

		static IntPtr n_SetOnColorChangedListener_Lcom_flask_colorpicker_OnColorChangedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onColorChangedListener)
		{
			global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Flask.Colorpicker.IOnColorChangedListener onColorChangedListener = (global::Com.Flask.Colorpicker.IOnColorChangedListener)global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.IOnColorChangedListener> (native_onColorChangedListener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOnColorChangedListener (onColorChangedListener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='ColorPickerDialogBuilder']/method[@name='setOnColorChangedListener' and count(parameter)=1 and parameter[1][@type='com.flask.colorpicker.OnColorChangedListener']]"
		[Register ("setOnColorChangedListener", "(Lcom/flask/colorpicker/OnColorChangedListener;)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;", "GetSetOnColorChangedListener_Lcom_flask_colorpicker_OnColorChangedListener_Handler")]
		public virtual unsafe global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder SetOnColorChangedListener (global::Com.Flask.Colorpicker.IOnColorChangedListener onColorChangedListener)
		{
			const string __id = "setOnColorChangedListener.(Lcom/flask/colorpicker/OnColorChangedListener;)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onColorChangedListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onColorChangedListener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setOnColorSelectedListener_Lcom_flask_colorpicker_OnColorSelectedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnColorSelectedListener_Lcom_flask_colorpicker_OnColorSelectedListener_Handler ()
		{
			if (cb_setOnColorSelectedListener_Lcom_flask_colorpicker_OnColorSelectedListener_ == null)
				cb_setOnColorSelectedListener_Lcom_flask_colorpicker_OnColorSelectedListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOnColorSelectedListener_Lcom_flask_colorpicker_OnColorSelectedListener_);
			return cb_setOnColorSelectedListener_Lcom_flask_colorpicker_OnColorSelectedListener_;
		}

		static IntPtr n_SetOnColorSelectedListener_Lcom_flask_colorpicker_OnColorSelectedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onColorSelectedListener)
		{
			global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Flask.Colorpicker.IOnColorSelectedListener onColorSelectedListener = (global::Com.Flask.Colorpicker.IOnColorSelectedListener)global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.IOnColorSelectedListener> (native_onColorSelectedListener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOnColorSelectedListener (onColorSelectedListener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='ColorPickerDialogBuilder']/method[@name='setOnColorSelectedListener' and count(parameter)=1 and parameter[1][@type='com.flask.colorpicker.OnColorSelectedListener']]"
		[Register ("setOnColorSelectedListener", "(Lcom/flask/colorpicker/OnColorSelectedListener;)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;", "GetSetOnColorSelectedListener_Lcom_flask_colorpicker_OnColorSelectedListener_Handler")]
		public virtual unsafe global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder SetOnColorSelectedListener (global::Com.Flask.Colorpicker.IOnColorSelectedListener onColorSelectedListener)
		{
			const string __id = "setOnColorSelectedListener.(Lcom/flask/colorpicker/OnColorSelectedListener;)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onColorSelectedListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onColorSelectedListener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPickerCount_I;
#pragma warning disable 0169
		static Delegate GetSetPickerCount_IHandler ()
		{
			if (cb_setPickerCount_I == null)
				cb_setPickerCount_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetPickerCount_I);
			return cb_setPickerCount_I;
		}

		static IntPtr n_SetPickerCount_I (IntPtr jnienv, IntPtr native__this, int pickerCount)
		{
			global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetPickerCount (pickerCount));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='ColorPickerDialogBuilder']/method[@name='setPickerCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPickerCount", "(I)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;", "GetSetPickerCount_IHandler")]
		public virtual unsafe global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder SetPickerCount (int pickerCount)
		{
			const string __id = "setPickerCount.(I)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (pickerCount);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPositiveButton_ILcom_flask_colorpicker_builder_ColorPickerClickListener_;
#pragma warning disable 0169
		static Delegate GetSetPositiveButton_ILcom_flask_colorpicker_builder_ColorPickerClickListener_Handler ()
		{
			if (cb_setPositiveButton_ILcom_flask_colorpicker_builder_ColorPickerClickListener_ == null)
				cb_setPositiveButton_ILcom_flask_colorpicker_builder_ColorPickerClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SetPositiveButton_ILcom_flask_colorpicker_builder_ColorPickerClickListener_);
			return cb_setPositiveButton_ILcom_flask_colorpicker_builder_ColorPickerClickListener_;
		}

		static IntPtr n_SetPositiveButton_ILcom_flask_colorpicker_builder_ColorPickerClickListener_ (IntPtr jnienv, IntPtr native__this, int textId, IntPtr native_onClickListener)
		{
			global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Flask.Colorpicker.Builder.IColorPickerClickListener onClickListener = (global::Com.Flask.Colorpicker.Builder.IColorPickerClickListener)global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.IColorPickerClickListener> (native_onClickListener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPositiveButton (textId, onClickListener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='ColorPickerDialogBuilder']/method[@name='setPositiveButton' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.flask.colorpicker.builder.ColorPickerClickListener']]"
		[Register ("setPositiveButton", "(ILcom/flask/colorpicker/builder/ColorPickerClickListener;)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;", "GetSetPositiveButton_ILcom_flask_colorpicker_builder_ColorPickerClickListener_Handler")]
		public virtual unsafe global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder SetPositiveButton (int textId, global::Com.Flask.Colorpicker.Builder.IColorPickerClickListener onClickListener)
		{
			const string __id = "setPositiveButton.(ILcom/flask/colorpicker/builder/ColorPickerClickListener;)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (textId);
				__args [1] = new JniArgumentValue ((onClickListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onClickListener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPositiveButton_Ljava_lang_CharSequence_Lcom_flask_colorpicker_builder_ColorPickerClickListener_;
#pragma warning disable 0169
		static Delegate GetSetPositiveButton_Ljava_lang_CharSequence_Lcom_flask_colorpicker_builder_ColorPickerClickListener_Handler ()
		{
			if (cb_setPositiveButton_Ljava_lang_CharSequence_Lcom_flask_colorpicker_builder_ColorPickerClickListener_ == null)
				cb_setPositiveButton_Ljava_lang_CharSequence_Lcom_flask_colorpicker_builder_ColorPickerClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPositiveButton_Ljava_lang_CharSequence_Lcom_flask_colorpicker_builder_ColorPickerClickListener_);
			return cb_setPositiveButton_Ljava_lang_CharSequence_Lcom_flask_colorpicker_builder_ColorPickerClickListener_;
		}

		static IntPtr n_SetPositiveButton_Ljava_lang_CharSequence_Lcom_flask_colorpicker_builder_ColorPickerClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text, IntPtr native_onClickListener)
		{
			global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence text = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_text, JniHandleOwnership.DoNotTransfer);
			global::Com.Flask.Colorpicker.Builder.IColorPickerClickListener onClickListener = (global::Com.Flask.Colorpicker.Builder.IColorPickerClickListener)global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.IColorPickerClickListener> (native_onClickListener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPositiveButton (text, onClickListener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='ColorPickerDialogBuilder']/method[@name='setPositiveButton' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='com.flask.colorpicker.builder.ColorPickerClickListener']]"
		[Register ("setPositiveButton", "(Ljava/lang/CharSequence;Lcom/flask/colorpicker/builder/ColorPickerClickListener;)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;", "GetSetPositiveButton_Ljava_lang_CharSequence_Lcom_flask_colorpicker_builder_ColorPickerClickListener_Handler")]
		public virtual unsafe global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder SetPositiveButton (global::Java.Lang.ICharSequence text, global::Com.Flask.Colorpicker.Builder.IColorPickerClickListener onClickListener)
		{
			const string __id = "setPositiveButton.(Ljava/lang/CharSequence;Lcom/flask/colorpicker/builder/ColorPickerClickListener;)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;";
			IntPtr native_text = CharSequence.ToLocalJniHandle (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue ((onClickListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onClickListener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		public global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder SetPositiveButton (string text, global::Com.Flask.Colorpicker.Builder.IColorPickerClickListener onClickListener)
		{
			global::Java.Lang.String jls_text = text == null ? null : new global::Java.Lang.String (text);
			global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder __result = SetPositiveButton (jls_text, onClickListener);
			var __rsval = __result;
			jls_text?.Dispose ();
			return __rsval;
		}

		static Delegate cb_setTitle_I;
#pragma warning disable 0169
		static Delegate GetSetTitle_IHandler ()
		{
			if (cb_setTitle_I == null)
				cb_setTitle_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetTitle_I);
			return cb_setTitle_I;
		}

		static IntPtr n_SetTitle_I (IntPtr jnienv, IntPtr native__this, int titleId)
		{
			global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetTitle (titleId));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='ColorPickerDialogBuilder']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTitle", "(I)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;", "GetSetTitle_IHandler")]
		public virtual unsafe global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder SetTitle (int titleId)
		{
			const string __id = "setTitle.(I)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (titleId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setTitle_Ljava_lang_String_ == null)
				cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_String_);
			return cb_setTitle_Ljava_lang_String_;
		}

		static IntPtr n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string title = JNIEnv.GetString (native_title, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTitle (title));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='ColorPickerDialogBuilder']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTitle", "(Ljava/lang/String;)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;", "GetSetTitle_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder SetTitle (string title)
		{
			const string __id = "setTitle.(Ljava/lang/String;)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;";
			IntPtr native_title = JNIEnv.NewString (title);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_title);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_title);
			}
		}

		static Delegate cb_showAlphaSlider_Z;
#pragma warning disable 0169
		static Delegate GetShowAlphaSlider_ZHandler ()
		{
			if (cb_showAlphaSlider_Z == null)
				cb_showAlphaSlider_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_ShowAlphaSlider_Z);
			return cb_showAlphaSlider_Z;
		}

		static IntPtr n_ShowAlphaSlider_Z (IntPtr jnienv, IntPtr native__this, bool showAlpha)
		{
			global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShowAlphaSlider (showAlpha));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='ColorPickerDialogBuilder']/method[@name='showAlphaSlider' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showAlphaSlider", "(Z)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;", "GetShowAlphaSlider_ZHandler")]
		public virtual unsafe global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder ShowAlphaSlider (bool showAlpha)
		{
			const string __id = "showAlphaSlider.(Z)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (showAlpha);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_showBorder_Z;
#pragma warning disable 0169
		static Delegate GetShowBorder_ZHandler ()
		{
			if (cb_showBorder_Z == null)
				cb_showBorder_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_ShowBorder_Z);
			return cb_showBorder_Z;
		}

		static IntPtr n_ShowBorder_Z (IntPtr jnienv, IntPtr native__this, bool showBorder)
		{
			global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShowBorder (showBorder));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='ColorPickerDialogBuilder']/method[@name='showBorder' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showBorder", "(Z)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;", "GetShowBorder_ZHandler")]
		public virtual unsafe global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder ShowBorder (bool showBorder)
		{
			const string __id = "showBorder.(Z)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (showBorder);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_showColorEdit_Z;
#pragma warning disable 0169
		static Delegate GetShowColorEdit_ZHandler ()
		{
			if (cb_showColorEdit_Z == null)
				cb_showColorEdit_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_ShowColorEdit_Z);
			return cb_showColorEdit_Z;
		}

		static IntPtr n_ShowColorEdit_Z (IntPtr jnienv, IntPtr native__this, bool showEdit)
		{
			global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShowColorEdit (showEdit));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='ColorPickerDialogBuilder']/method[@name='showColorEdit' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showColorEdit", "(Z)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;", "GetShowColorEdit_ZHandler")]
		public virtual unsafe global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder ShowColorEdit (bool showEdit)
		{
			const string __id = "showColorEdit.(Z)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (showEdit);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_showColorPreview_Z;
#pragma warning disable 0169
		static Delegate GetShowColorPreview_ZHandler ()
		{
			if (cb_showColorPreview_Z == null)
				cb_showColorPreview_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_ShowColorPreview_Z);
			return cb_showColorPreview_Z;
		}

		static IntPtr n_ShowColorPreview_Z (IntPtr jnienv, IntPtr native__this, bool showPreview)
		{
			global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShowColorPreview (showPreview));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='ColorPickerDialogBuilder']/method[@name='showColorPreview' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showColorPreview", "(Z)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;", "GetShowColorPreview_ZHandler")]
		public virtual unsafe global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder ShowColorPreview (bool showPreview)
		{
			const string __id = "showColorPreview.(Z)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (showPreview);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_showLightnessSlider_Z;
#pragma warning disable 0169
		static Delegate GetShowLightnessSlider_ZHandler ()
		{
			if (cb_showLightnessSlider_Z == null)
				cb_showLightnessSlider_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_ShowLightnessSlider_Z);
			return cb_showLightnessSlider_Z;
		}

		static IntPtr n_ShowLightnessSlider_Z (IntPtr jnienv, IntPtr native__this, bool showLightness)
		{
			global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShowLightnessSlider (showLightness));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='ColorPickerDialogBuilder']/method[@name='showLightnessSlider' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showLightnessSlider", "(Z)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;", "GetShowLightnessSlider_ZHandler")]
		public virtual unsafe global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder ShowLightnessSlider (bool showLightness)
		{
			const string __id = "showLightnessSlider.(Z)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (showLightness);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_wheelType_Lcom_flask_colorpicker_ColorPickerView_WHEEL_TYPE_;
#pragma warning disable 0169
		static Delegate GetWheelType_Lcom_flask_colorpicker_ColorPickerView_WHEEL_TYPE_Handler ()
		{
			if (cb_wheelType_Lcom_flask_colorpicker_ColorPickerView_WHEEL_TYPE_ == null)
				cb_wheelType_Lcom_flask_colorpicker_ColorPickerView_WHEEL_TYPE_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WheelType_Lcom_flask_colorpicker_ColorPickerView_WHEEL_TYPE_);
			return cb_wheelType_Lcom_flask_colorpicker_ColorPickerView_WHEEL_TYPE_;
		}

		static IntPtr n_WheelType_Lcom_flask_colorpicker_ColorPickerView_WHEEL_TYPE_ (IntPtr jnienv, IntPtr native__this, IntPtr native_wheelType)
		{
			global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Flask.Colorpicker.ColorPickerView.WHEEL_TYPE wheelType = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView.WHEEL_TYPE> (native_wheelType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WheelType (wheelType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='ColorPickerDialogBuilder']/method[@name='wheelType' and count(parameter)=1 and parameter[1][@type='com.flask.colorpicker.ColorPickerView.WHEEL_TYPE']]"
		[Register ("wheelType", "(Lcom/flask/colorpicker/ColorPickerView$WHEEL_TYPE;)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;", "GetWheelType_Lcom_flask_colorpicker_ColorPickerView_WHEEL_TYPE_Handler")]
		public virtual unsafe global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder WheelType (global::Com.Flask.Colorpicker.ColorPickerView.WHEEL_TYPE wheelType)
		{
			const string __id = "wheelType.(Lcom/flask/colorpicker/ColorPickerView$WHEEL_TYPE;)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((wheelType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) wheelType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='ColorPickerDialogBuilder']/method[@name='with' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("with", "(Landroid/content/Context;)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;", "")]
		public static unsafe global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder With (global::Android.Content.Context context)
		{
			const string __id = "with.(Landroid/content/Context;)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='ColorPickerDialogBuilder']/method[@name='with' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("with", "(Landroid/content/Context;I)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;", "")]
		public static unsafe global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder With (global::Android.Content.Context context, int theme)
		{
			const string __id = "with.(Landroid/content/Context;I)Lcom/flask/colorpicker/builder/ColorPickerDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (theme);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.ColorPickerDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
