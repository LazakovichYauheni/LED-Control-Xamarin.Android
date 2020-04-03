using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Flask.Colorpicker.Renderer {

	[Register ("com/flask/colorpicker/renderer/ColorWheelRenderer", DoNotGenerateAcw=true)]
	public abstract class ColorWheelRenderer : Java.Lang.Object {

		internal ColorWheelRenderer ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.renderer']/interface[@name='ColorWheelRenderer']/field[@name='GAP_PERCENTAGE']"
		[Register ("GAP_PERCENTAGE")]
		public const float GapPercentage = (float) 0.025;
	}

	[Register ("com/flask/colorpicker/renderer/ColorWheelRenderer", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'ColorWheelRenderer' type. This type will be removed in a future release.", error: true)]
	public abstract class ColorWheelRendererConsts : ColorWheelRenderer {

		private ColorWheelRendererConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.flask.colorpicker.renderer']/interface[@name='ColorWheelRenderer']"
	[Register ("com/flask/colorpicker/renderer/ColorWheelRenderer", "", "Com.Flask.Colorpicker.Renderer.IColorWheelRendererInvoker")]
	public partial interface IColorWheelRenderer : IJavaObject, IJavaPeerable {

		global::System.Collections.Generic.IList<global::Com.Flask.Colorpicker.ColorCircle> ColorCircleList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.renderer']/interface[@name='ColorWheelRenderer']/method[@name='getColorCircleList' and count(parameter)=0]"
			[Register ("getColorCircleList", "()Ljava/util/List;", "GetGetColorCircleListHandler:Com.Flask.Colorpicker.Renderer.IColorWheelRendererInvoker, Picker")] get;
		}

		global::Com.Flask.Colorpicker.Renderer.ColorWheelRenderOption RenderOption {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.renderer']/interface[@name='ColorWheelRenderer']/method[@name='getRenderOption' and count(parameter)=0]"
			[Register ("getRenderOption", "()Lcom/flask/colorpicker/renderer/ColorWheelRenderOption;", "GetGetRenderOptionHandler:Com.Flask.Colorpicker.Renderer.IColorWheelRendererInvoker, Picker")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.renderer']/interface[@name='ColorWheelRenderer']/method[@name='draw' and count(parameter)=0]"
		[Register ("draw", "()V", "GetDrawHandler:Com.Flask.Colorpicker.Renderer.IColorWheelRendererInvoker, Picker")]
		void Draw ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.renderer']/interface[@name='ColorWheelRenderer']/method[@name='initWith' and count(parameter)=1 and parameter[1][@type='com.flask.colorpicker.renderer.ColorWheelRenderOption']]"
		[Register ("initWith", "(Lcom/flask/colorpicker/renderer/ColorWheelRenderOption;)V", "GetInitWith_Lcom_flask_colorpicker_renderer_ColorWheelRenderOption_Handler:Com.Flask.Colorpicker.Renderer.IColorWheelRendererInvoker, Picker")]
		void InitWith (global::Com.Flask.Colorpicker.Renderer.ColorWheelRenderOption p0);

	}

	[global::Android.Runtime.Register ("com/flask/colorpicker/renderer/ColorWheelRenderer", DoNotGenerateAcw=true)]
	internal partial class IColorWheelRendererInvoker : global::Java.Lang.Object, IColorWheelRenderer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/flask/colorpicker/renderer/ColorWheelRenderer", typeof (IColorWheelRendererInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IColorWheelRenderer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IColorWheelRenderer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.flask.colorpicker.renderer.ColorWheelRenderer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IColorWheelRendererInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Flask.Colorpicker.Renderer.IColorWheelRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Renderer.IColorWheelRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Flask.Colorpicker.ColorCircle>.ToLocalJniHandle (__this.ColorCircleList);
		}
#pragma warning restore 0169

		IntPtr id_getColorCircleList;
		public unsafe global::System.Collections.Generic.IList<global::Com.Flask.Colorpicker.ColorCircle> ColorCircleList {
			get {
				if (id_getColorCircleList == IntPtr.Zero)
					id_getColorCircleList = JNIEnv.GetMethodID (class_ref, "getColorCircleList", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Flask.Colorpicker.ColorCircle>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getColorCircleList), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Flask.Colorpicker.Renderer.IColorWheelRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Renderer.IColorWheelRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RenderOption);
		}
#pragma warning restore 0169

		IntPtr id_getRenderOption;
		public unsafe global::Com.Flask.Colorpicker.Renderer.ColorWheelRenderOption RenderOption {
			get {
				if (id_getRenderOption == IntPtr.Zero)
					id_getRenderOption = JNIEnv.GetMethodID (class_ref, "getRenderOption", "()Lcom/flask/colorpicker/renderer/ColorWheelRenderOption;");
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Renderer.ColorWheelRenderOption> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRenderOption), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Flask.Colorpicker.Renderer.IColorWheelRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Renderer.IColorWheelRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Draw ();
		}
#pragma warning restore 0169

		IntPtr id_draw;
		public unsafe void Draw ()
		{
			if (id_draw == IntPtr.Zero)
				id_draw = JNIEnv.GetMethodID (class_ref, "draw", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_draw);
		}

		static Delegate cb_initWith_Lcom_flask_colorpicker_renderer_ColorWheelRenderOption_;
#pragma warning disable 0169
		static Delegate GetInitWith_Lcom_flask_colorpicker_renderer_ColorWheelRenderOption_Handler ()
		{
			if (cb_initWith_Lcom_flask_colorpicker_renderer_ColorWheelRenderOption_ == null)
				cb_initWith_Lcom_flask_colorpicker_renderer_ColorWheelRenderOption_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InitWith_Lcom_flask_colorpicker_renderer_ColorWheelRenderOption_);
			return cb_initWith_Lcom_flask_colorpicker_renderer_ColorWheelRenderOption_;
		}

		static void n_InitWith_Lcom_flask_colorpicker_renderer_ColorWheelRenderOption_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Flask.Colorpicker.Renderer.IColorWheelRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Renderer.IColorWheelRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Flask.Colorpicker.Renderer.ColorWheelRenderOption p0 = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Renderer.ColorWheelRenderOption> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InitWith (p0);
		}
#pragma warning restore 0169

		IntPtr id_initWith_Lcom_flask_colorpicker_renderer_ColorWheelRenderOption_;
		public unsafe void InitWith (global::Com.Flask.Colorpicker.Renderer.ColorWheelRenderOption p0)
		{
			if (id_initWith_Lcom_flask_colorpicker_renderer_ColorWheelRenderOption_ == IntPtr.Zero)
				id_initWith_Lcom_flask_colorpicker_renderer_ColorWheelRenderOption_ = JNIEnv.GetMethodID (class_ref, "initWith", "(Lcom/flask/colorpicker/renderer/ColorWheelRenderOption;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initWith_Lcom_flask_colorpicker_renderer_ColorWheelRenderOption_, __args);
		}

	}

}
