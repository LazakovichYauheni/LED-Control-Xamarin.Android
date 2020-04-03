using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Flask.Colorpicker.Slider {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='LightnessSlider']"
	[global::Android.Runtime.Register ("com/flask/colorpicker/slider/LightnessSlider", DoNotGenerateAcw=true)]
	public partial class LightnessSlider : global::Com.Flask.Colorpicker.Slider.AbsCustomSlider {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/flask/colorpicker/slider/LightnessSlider", typeof (LightnessSlider));
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

		protected LightnessSlider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='LightnessSlider']/constructor[@name='LightnessSlider' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe LightnessSlider (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='LightnessSlider']/constructor[@name='LightnessSlider' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe LightnessSlider (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='LightnessSlider']/constructor[@name='LightnessSlider' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe LightnessSlider (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
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

		static Delegate cb_drawBar_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDrawBar_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_drawBar_Landroid_graphics_Canvas_ == null)
				cb_drawBar_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DrawBar_Landroid_graphics_Canvas_);
			return cb_drawBar_Landroid_graphics_Canvas_;
		}

		static void n_DrawBar_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_barCanvas)
		{
			global::Com.Flask.Colorpicker.Slider.LightnessSlider __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.LightnessSlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas barCanvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_barCanvas, JniHandleOwnership.DoNotTransfer);
			__this.DrawBar (barCanvas);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='LightnessSlider']/method[@name='drawBar' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("drawBar", "(Landroid/graphics/Canvas;)V", "GetDrawBar_Landroid_graphics_Canvas_Handler")]
		protected override unsafe void DrawBar (global::Android.Graphics.Canvas barCanvas)
		{
			const string __id = "drawBar.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((barCanvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object) barCanvas).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_drawHandle_Landroid_graphics_Canvas_FF;
#pragma warning disable 0169
		static Delegate GetDrawHandle_Landroid_graphics_Canvas_FFHandler ()
		{
			if (cb_drawHandle_Landroid_graphics_Canvas_FF == null)
				cb_drawHandle_Landroid_graphics_Canvas_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, float>) n_DrawHandle_Landroid_graphics_Canvas_FF);
			return cb_drawHandle_Landroid_graphics_Canvas_FF;
		}

		static void n_DrawHandle_Landroid_graphics_Canvas_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_canvas, float x, float y)
		{
			global::Com.Flask.Colorpicker.Slider.LightnessSlider __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.LightnessSlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			__this.DrawHandle (canvas, x, y);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='LightnessSlider']/method[@name='drawHandle' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("drawHandle", "(Landroid/graphics/Canvas;FF)V", "GetDrawHandle_Landroid_graphics_Canvas_FFHandler")]
		protected override unsafe void DrawHandle (global::Android.Graphics.Canvas canvas, float x, float y)
		{
			const string __id = "drawHandle.(Landroid/graphics/Canvas;FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((canvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object) canvas).Handle);
				__args [1] = new JniArgumentValue (x);
				__args [2] = new JniArgumentValue (y);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onValueChanged_F;
#pragma warning disable 0169
		static Delegate GetOnValueChanged_FHandler ()
		{
			if (cb_onValueChanged_F == null)
				cb_onValueChanged_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_OnValueChanged_F);
			return cb_onValueChanged_F;
		}

		static void n_OnValueChanged_F (IntPtr jnienv, IntPtr native__this, float value)
		{
			global::Com.Flask.Colorpicker.Slider.LightnessSlider __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.LightnessSlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnValueChanged (value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='LightnessSlider']/method[@name='onValueChanged' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("onValueChanged", "(F)V", "GetOnValueChanged_FHandler")]
		protected override unsafe void OnValueChanged (float value)
		{
			const string __id = "onValueChanged.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setColor_I;
#pragma warning disable 0169
		static Delegate GetSetColor_IHandler ()
		{
			if (cb_setColor_I == null)
				cb_setColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetColor_I);
			return cb_setColor_I;
		}

		static void n_SetColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Flask.Colorpicker.Slider.LightnessSlider __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.LightnessSlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='LightnessSlider']/method[@name='setColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setColor", "(I)V", "GetSetColor_IHandler")]
		public virtual unsafe void SetColor (int color)
		{
			const string __id = "setColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setColorPicker_Lcom_flask_colorpicker_ColorPickerView_;
#pragma warning disable 0169
		static Delegate GetSetColorPicker_Lcom_flask_colorpicker_ColorPickerView_Handler ()
		{
			if (cb_setColorPicker_Lcom_flask_colorpicker_ColorPickerView_ == null)
				cb_setColorPicker_Lcom_flask_colorpicker_ColorPickerView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColorPicker_Lcom_flask_colorpicker_ColorPickerView_);
			return cb_setColorPicker_Lcom_flask_colorpicker_ColorPickerView_;
		}

		static void n_SetColorPicker_Lcom_flask_colorpicker_ColorPickerView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_colorPicker)
		{
			global::Com.Flask.Colorpicker.Slider.LightnessSlider __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.LightnessSlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Flask.Colorpicker.ColorPickerView colorPicker = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (native_colorPicker, JniHandleOwnership.DoNotTransfer);
			__this.SetColorPicker (colorPicker);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='LightnessSlider']/method[@name='setColorPicker' and count(parameter)=1 and parameter[1][@type='com.flask.colorpicker.ColorPickerView']]"
		[Register ("setColorPicker", "(Lcom/flask/colorpicker/ColorPickerView;)V", "GetSetColorPicker_Lcom_flask_colorpicker_ColorPickerView_Handler")]
		public virtual unsafe void SetColorPicker (global::Com.Flask.Colorpicker.ColorPickerView colorPicker)
		{
			const string __id = "setColorPicker.(Lcom/flask/colorpicker/ColorPickerView;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((colorPicker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) colorPicker).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
