using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Flask.Colorpicker.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='AbsColorWheelRenderer']"
	[global::Android.Runtime.Register ("com/flask/colorpicker/renderer/AbsColorWheelRenderer", DoNotGenerateAcw=true)]
	public abstract partial class AbsColorWheelRenderer : global::Java.Lang.Object, global::Com.Flask.Colorpicker.Renderer.IColorWheelRenderer {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='AbsColorWheelRenderer']/field[@name='colorWheelRenderOption']"
		[Register ("colorWheelRenderOption")]
		protected global::Com.Flask.Colorpicker.Renderer.ColorWheelRenderOption ColorWheelRenderOption {
			get {
				const string __id = "colorWheelRenderOption.Lcom/flask/colorpicker/renderer/ColorWheelRenderOption;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Renderer.ColorWheelRenderOption> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "colorWheelRenderOption.Lcom/flask/colorpicker/renderer/ColorWheelRenderOption;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public static class InterfaceConsts {

			// The following are fields from: com.flask.colorpicker.renderer.ColorWheelRenderer

			// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.renderer']/interface[@name='ColorWheelRenderer']/field[@name='GAP_PERCENTAGE']"
			[Register ("GAP_PERCENTAGE")]
			public const float GapPercentage = (float) 0.025;
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/flask/colorpicker/renderer/AbsColorWheelRenderer", typeof (AbsColorWheelRenderer));
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

		protected AbsColorWheelRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='AbsColorWheelRenderer']/constructor[@name='AbsColorWheelRenderer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AbsColorWheelRenderer ()
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

		static Delegate cb_getAlphaValueAsInt;
#pragma warning disable 0169
		static Delegate GetGetAlphaValueAsIntHandler ()
		{
			if (cb_getAlphaValueAsInt == null)
				cb_getAlphaValueAsInt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAlphaValueAsInt);
			return cb_getAlphaValueAsInt;
		}

		static int n_GetAlphaValueAsInt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flask.Colorpicker.Renderer.AbsColorWheelRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Renderer.AbsColorWheelRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AlphaValueAsInt;
		}
#pragma warning restore 0169

		protected virtual unsafe int AlphaValueAsInt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='AbsColorWheelRenderer']/method[@name='getAlphaValueAsInt' and count(parameter)=0]"
			[Register ("getAlphaValueAsInt", "()I", "GetGetAlphaValueAsIntHandler")]
			get {
				const string __id = "getAlphaValueAsInt.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getColorCircleList;
#pragma warning disable 0169
		static Delegate GetGetColorCircleListHandler ()
		{
			if (cb_getColorCircleList == null)
				cb_getColorCircleList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetColorCircleList);
			return cb_getColorCircleList;
		}

		static IntPtr n_GetColorCircleList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flask.Colorpicker.Renderer.AbsColorWheelRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Renderer.AbsColorWheelRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Flask.Colorpicker.ColorCircle>.ToLocalJniHandle (__this.ColorCircleList);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Flask.Colorpicker.ColorCircle> ColorCircleList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='AbsColorWheelRenderer']/method[@name='getColorCircleList' and count(parameter)=0]"
			[Register ("getColorCircleList", "()Ljava/util/List;", "GetGetColorCircleListHandler")]
			get {
				const string __id = "getColorCircleList.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Flask.Colorpicker.ColorCircle>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRenderOption;
#pragma warning disable 0169
		static Delegate GetGetRenderOptionHandler ()
		{
			if (cb_getRenderOption == null)
				cb_getRenderOption = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRenderOption);
			return cb_getRenderOption;
		}

		static IntPtr n_GetRenderOption (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flask.Colorpicker.Renderer.AbsColorWheelRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Renderer.AbsColorWheelRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RenderOption);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Flask.Colorpicker.Renderer.ColorWheelRenderOption RenderOption {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='AbsColorWheelRenderer']/method[@name='getRenderOption' and count(parameter)=0]"
			[Register ("getRenderOption", "()Lcom/flask/colorpicker/renderer/ColorWheelRenderOption;", "GetGetRenderOptionHandler")]
			get {
				const string __id = "getRenderOption.()Lcom/flask/colorpicker/renderer/ColorWheelRenderOption;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Renderer.ColorWheelRenderOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_calcTotalCount_FF;
#pragma warning disable 0169
		static Delegate GetCalcTotalCount_FFHandler ()
		{
			if (cb_calcTotalCount_FF == null)
				cb_calcTotalCount_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, int>) n_CalcTotalCount_FF);
			return cb_calcTotalCount_FF;
		}

		static int n_CalcTotalCount_FF (IntPtr jnienv, IntPtr native__this, float radius, float size)
		{
			global::Com.Flask.Colorpicker.Renderer.AbsColorWheelRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Renderer.AbsColorWheelRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CalcTotalCount (radius, size);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='AbsColorWheelRenderer']/method[@name='calcTotalCount' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("calcTotalCount", "(FF)I", "GetCalcTotalCount_FFHandler")]
		protected virtual unsafe int CalcTotalCount (float radius, float size)
		{
			const string __id = "calcTotalCount.(FF)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (radius);
				__args [1] = new JniArgumentValue (size);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_initWith_Lcom_flask_colorpicker_renderer_ColorWheelRenderOption_;
#pragma warning disable 0169
		static Delegate GetInitWith_Lcom_flask_colorpicker_renderer_ColorWheelRenderOption_Handler ()
		{
			if (cb_initWith_Lcom_flask_colorpicker_renderer_ColorWheelRenderOption_ == null)
				cb_initWith_Lcom_flask_colorpicker_renderer_ColorWheelRenderOption_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InitWith_Lcom_flask_colorpicker_renderer_ColorWheelRenderOption_);
			return cb_initWith_Lcom_flask_colorpicker_renderer_ColorWheelRenderOption_;
		}

		static void n_InitWith_Lcom_flask_colorpicker_renderer_ColorWheelRenderOption_ (IntPtr jnienv, IntPtr native__this, IntPtr native_colorWheelRenderOption)
		{
			global::Com.Flask.Colorpicker.Renderer.AbsColorWheelRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Renderer.AbsColorWheelRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Flask.Colorpicker.Renderer.ColorWheelRenderOption colorWheelRenderOption = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Renderer.ColorWheelRenderOption> (native_colorWheelRenderOption, JniHandleOwnership.DoNotTransfer);
			__this.InitWith (colorWheelRenderOption);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='AbsColorWheelRenderer']/method[@name='initWith' and count(parameter)=1 and parameter[1][@type='com.flask.colorpicker.renderer.ColorWheelRenderOption']]"
		[Register ("initWith", "(Lcom/flask/colorpicker/renderer/ColorWheelRenderOption;)V", "GetInitWith_Lcom_flask_colorpicker_renderer_ColorWheelRenderOption_Handler")]
		public virtual unsafe void InitWith (global::Com.Flask.Colorpicker.Renderer.ColorWheelRenderOption colorWheelRenderOption)
		{
			const string __id = "initWith.(Lcom/flask/colorpicker/renderer/ColorWheelRenderOption;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((colorWheelRenderOption == null) ? IntPtr.Zero : ((global::Java.Lang.Object) colorWheelRenderOption).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.Flask.Colorpicker.Renderer.AbsColorWheelRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Renderer.AbsColorWheelRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Draw ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.renderer']/interface[@name='ColorWheelRenderer']/method[@name='draw' and count(parameter)=0]"
		[Register ("draw", "()V", "GetDrawHandler")]
		public abstract void Draw ();

	}

	[global::Android.Runtime.Register ("com/flask/colorpicker/renderer/AbsColorWheelRenderer", DoNotGenerateAcw=true)]
	internal partial class AbsColorWheelRendererInvoker : AbsColorWheelRenderer {

		public AbsColorWheelRendererInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/flask/colorpicker/renderer/AbsColorWheelRenderer", typeof (AbsColorWheelRendererInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.renderer']/interface[@name='ColorWheelRenderer']/method[@name='draw' and count(parameter)=0]"
		[Register ("draw", "()V", "GetDrawHandler")]
		public override unsafe void Draw ()
		{
			const string __id = "draw.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

}
