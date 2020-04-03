using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Flask.Colorpicker.Slider {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']"
	[global::Android.Runtime.Register ("com/flask/colorpicker/slider/AbsCustomSlider", DoNotGenerateAcw=true)]
	public abstract partial class AbsCustomSlider : global::Android.Views.View {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/field[@name='bar']"
		[Register ("bar")]
		protected global::Android.Graphics.Bitmap Bar {
			get {
				const string __id = "bar.Landroid/graphics/Bitmap;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "bar.Landroid/graphics/Bitmap;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/field[@name='barCanvas']"
		[Register ("barCanvas")]
		protected global::Android.Graphics.Canvas BarCanvas {
			get {
				const string __id = "barCanvas.Landroid/graphics/Canvas;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "barCanvas.Landroid/graphics/Canvas;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/field[@name='barHeight']"
		[Register ("barHeight")]
		protected int BarHeight {
			get {
				const string __id = "barHeight.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "barHeight.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/field[@name='barOffsetX']"
		[Register ("barOffsetX")]
		protected int BarOffsetX {
			get {
				const string __id = "barOffsetX.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "barOffsetX.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/field[@name='bitmap']"
		[Register ("bitmap")]
		protected global::Android.Graphics.Bitmap Bitmap {
			get {
				const string __id = "bitmap.Landroid/graphics/Bitmap;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "bitmap.Landroid/graphics/Bitmap;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/field[@name='bitmapCanvas']"
		[Register ("bitmapCanvas")]
		protected global::Android.Graphics.Canvas BitmapCanvas {
			get {
				const string __id = "bitmapCanvas.Landroid/graphics/Canvas;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "bitmapCanvas.Landroid/graphics/Canvas;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/field[@name='handleRadius']"
		[Register ("handleRadius")]
		protected int HandleRadius {
			get {
				const string __id = "handleRadius.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "handleRadius.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/field[@name='onValueChangedListener']"
		[Register ("onValueChangedListener")]
		protected global::Com.Flask.Colorpicker.Slider.IOnValueChangedListener OnValueChangedListener {
			get {
				const string __id = "onValueChangedListener.Lcom/flask/colorpicker/slider/OnValueChangedListener;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.IOnValueChangedListener> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "onValueChangedListener.Lcom/flask/colorpicker/slider/OnValueChangedListener;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/field[@name='showBorder']"
		[Register ("showBorder")]
		protected bool ShowBorder {
			get {
				const string __id = "showBorder.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "showBorder.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/field[@name='value']"
		[Register ("value")]
		protected float Value {
			get {
				const string __id = "value.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "value.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/flask/colorpicker/slider/AbsCustomSlider", typeof (AbsCustomSlider));
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

		protected AbsCustomSlider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/constructor[@name='AbsCustomSlider' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AbsCustomSlider (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/constructor[@name='AbsCustomSlider' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe AbsCustomSlider (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/constructor[@name='AbsCustomSlider' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe AbsCustomSlider (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
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

		static Delegate cb_createBitmaps;
#pragma warning disable 0169
		static Delegate GetCreateBitmapsHandler ()
		{
			if (cb_createBitmaps == null)
				cb_createBitmaps = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CreateBitmaps);
			return cb_createBitmaps;
		}

		static void n_CreateBitmaps (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flask.Colorpicker.Slider.AbsCustomSlider __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.AbsCustomSlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CreateBitmaps ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/method[@name='createBitmaps' and count(parameter)=0]"
		[Register ("createBitmaps", "()V", "GetCreateBitmapsHandler")]
		protected virtual unsafe void CreateBitmaps ()
		{
			const string __id = "createBitmaps.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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

		static void n_DrawBar_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Flask.Colorpicker.Slider.AbsCustomSlider __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.AbsCustomSlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DrawBar (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/method[@name='drawBar' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("drawBar", "(Landroid/graphics/Canvas;)V", "GetDrawBar_Landroid_graphics_Canvas_Handler")]
		protected abstract void DrawBar (global::Android.Graphics.Canvas p0);

		static Delegate cb_drawHandle_Landroid_graphics_Canvas_FF;
#pragma warning disable 0169
		static Delegate GetDrawHandle_Landroid_graphics_Canvas_FFHandler ()
		{
			if (cb_drawHandle_Landroid_graphics_Canvas_FF == null)
				cb_drawHandle_Landroid_graphics_Canvas_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, float>) n_DrawHandle_Landroid_graphics_Canvas_FF);
			return cb_drawHandle_Landroid_graphics_Canvas_FF;
		}

		static void n_DrawHandle_Landroid_graphics_Canvas_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, float p2)
		{
			global::Com.Flask.Colorpicker.Slider.AbsCustomSlider __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.AbsCustomSlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DrawHandle (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/method[@name='drawHandle' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("drawHandle", "(Landroid/graphics/Canvas;FF)V", "GetDrawHandle_Landroid_graphics_Canvas_FFHandler")]
		protected abstract void DrawHandle (global::Android.Graphics.Canvas p0, float p1, float p2);

		static Delegate cb_getDimension_I;
#pragma warning disable 0169
		static Delegate GetGetDimension_IHandler ()
		{
			if (cb_getDimension_I == null)
				cb_getDimension_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetDimension_I);
			return cb_getDimension_I;
		}

		static int n_GetDimension_I (IntPtr jnienv, IntPtr native__this, int id)
		{
			global::Com.Flask.Colorpicker.Slider.AbsCustomSlider __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.AbsCustomSlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetDimension (id);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/method[@name='getDimension' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDimension", "(I)I", "GetGetDimension_IHandler")]
		protected virtual unsafe int GetDimension (int id)
		{
			const string __id = "getDimension.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (id);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
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

		static void n_OnValueChanged_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Flask.Colorpicker.Slider.AbsCustomSlider __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.AbsCustomSlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnValueChanged (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/method[@name='onValueChanged' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("onValueChanged", "(F)V", "GetOnValueChanged_FHandler")]
		protected abstract void OnValueChanged (float p0);

		static Delegate cb_setOnValueChangedListener_Lcom_flask_colorpicker_slider_OnValueChangedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnValueChangedListener_Lcom_flask_colorpicker_slider_OnValueChangedListener_Handler ()
		{
			if (cb_setOnValueChangedListener_Lcom_flask_colorpicker_slider_OnValueChangedListener_ == null)
				cb_setOnValueChangedListener_Lcom_flask_colorpicker_slider_OnValueChangedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnValueChangedListener_Lcom_flask_colorpicker_slider_OnValueChangedListener_);
			return cb_setOnValueChangedListener_Lcom_flask_colorpicker_slider_OnValueChangedListener_;
		}

		static void n_SetOnValueChangedListener_Lcom_flask_colorpicker_slider_OnValueChangedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onValueChangedListener)
		{
			global::Com.Flask.Colorpicker.Slider.AbsCustomSlider __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.AbsCustomSlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Flask.Colorpicker.Slider.IOnValueChangedListener onValueChangedListener = (global::Com.Flask.Colorpicker.Slider.IOnValueChangedListener)global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.IOnValueChangedListener> (native_onValueChangedListener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnValueChangedListener (onValueChangedListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/method[@name='setOnValueChangedListener' and count(parameter)=1 and parameter[1][@type='com.flask.colorpicker.slider.OnValueChangedListener']]"
		[Register ("setOnValueChangedListener", "(Lcom/flask/colorpicker/slider/OnValueChangedListener;)V", "GetSetOnValueChangedListener_Lcom_flask_colorpicker_slider_OnValueChangedListener_Handler")]
		public virtual unsafe void SetOnValueChangedListener (global::Com.Flask.Colorpicker.Slider.IOnValueChangedListener onValueChangedListener)
		{
			const string __id = "setOnValueChangedListener.(Lcom/flask/colorpicker/slider/OnValueChangedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onValueChangedListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onValueChangedListener).Handle);
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
			global::Com.Flask.Colorpicker.Slider.AbsCustomSlider __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.AbsCustomSlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShowBorder (showBorder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/method[@name='setShowBorder' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_updateBar;
#pragma warning disable 0169
		static Delegate GetUpdateBarHandler ()
		{
			if (cb_updateBar == null)
				cb_updateBar = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdateBar);
			return cb_updateBar;
		}

		static void n_UpdateBar (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flask.Colorpicker.Slider.AbsCustomSlider __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.AbsCustomSlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateBar ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/method[@name='updateBar' and count(parameter)=0]"
		[Register ("updateBar", "()V", "GetUpdateBarHandler")]
		protected virtual unsafe void UpdateBar ()
		{
			const string __id = "updateBar.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

#region "Event implementation for Com.Flask.Colorpicker.Slider.IOnValueChangedListener"
		public event EventHandler<global::Com.Flask.Colorpicker.Slider.ValueChangedEventArgs> ValueChanged {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Flask.Colorpicker.Slider.IOnValueChangedListener, global::Com.Flask.Colorpicker.Slider.IOnValueChangedListenerImplementor>(
						ref weak_implementor_SetOnValueChangedListener,
						__CreateIOnValueChangedListenerImplementor,
						SetOnValueChangedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Flask.Colorpicker.Slider.IOnValueChangedListener, global::Com.Flask.Colorpicker.Slider.IOnValueChangedListenerImplementor>(
						ref weak_implementor_SetOnValueChangedListener,
						global::Com.Flask.Colorpicker.Slider.IOnValueChangedListenerImplementor.__IsEmpty,
						__v => SetOnValueChangedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnValueChangedListener;

		global::Com.Flask.Colorpicker.Slider.IOnValueChangedListenerImplementor __CreateIOnValueChangedListenerImplementor ()
		{
			return new global::Com.Flask.Colorpicker.Slider.IOnValueChangedListenerImplementor (this);
		}
#endregion
	}

	[global::Android.Runtime.Register ("com/flask/colorpicker/slider/AbsCustomSlider", DoNotGenerateAcw=true)]
	internal partial class AbsCustomSliderInvoker : AbsCustomSlider {

		public AbsCustomSliderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/flask/colorpicker/slider/AbsCustomSlider", typeof (AbsCustomSliderInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/method[@name='drawBar' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("drawBar", "(Landroid/graphics/Canvas;)V", "GetDrawBar_Landroid_graphics_Canvas_Handler")]
		protected override unsafe void DrawBar (global::Android.Graphics.Canvas p0)
		{
			const string __id = "drawBar.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/method[@name='drawHandle' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("drawHandle", "(Landroid/graphics/Canvas;FF)V", "GetDrawHandle_Landroid_graphics_Canvas_FFHandler")]
		protected override unsafe void DrawHandle (global::Android.Graphics.Canvas p0, float p1, float p2)
		{
			const string __id = "drawHandle.(Landroid/graphics/Canvas;FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/method[@name='onValueChanged' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("onValueChanged", "(F)V", "GetOnValueChanged_FHandler")]
		protected override unsafe void OnValueChanged (float p0)
		{
			const string __id = "onValueChanged.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

}
