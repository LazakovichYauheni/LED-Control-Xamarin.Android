using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Flask.Colorpicker.Builder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='PaintBuilder']"
	[global::Android.Runtime.Register ("com/flask/colorpicker/builder/PaintBuilder", DoNotGenerateAcw=true)]
	public partial class PaintBuilder : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='PaintBuilder.PaintHolder']"
		[global::Android.Runtime.Register ("com/flask/colorpicker/builder/PaintBuilder$PaintHolder", DoNotGenerateAcw=true)]
		public partial class PaintHolder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/flask/colorpicker/builder/PaintBuilder$PaintHolder", typeof (PaintHolder));
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

			protected PaintHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_antiAlias_Z;
#pragma warning disable 0169
			static Delegate GetAntiAlias_ZHandler ()
			{
				if (cb_antiAlias_Z == null)
					cb_antiAlias_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_AntiAlias_Z);
				return cb_antiAlias_Z;
			}

			static IntPtr n_AntiAlias_Z (IntPtr jnienv, IntPtr native__this, bool flag)
			{
				global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AntiAlias (flag));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='PaintBuilder.PaintHolder']/method[@name='antiAlias' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("antiAlias", "(Z)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;", "GetAntiAlias_ZHandler")]
			public virtual unsafe global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder AntiAlias (bool flag)
			{
				const string __id = "antiAlias.(Z)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (flag);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='PaintBuilder.PaintHolder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Landroid/graphics/Paint;", "GetBuildHandler")]
			public virtual unsafe global::Android.Graphics.Paint Build ()
			{
				const string __id = "build.()Landroid/graphics/Paint;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_color_I;
#pragma warning disable 0169
			static Delegate GetColor_IHandler ()
			{
				if (cb_color_I == null)
					cb_color_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Color_I);
				return cb_color_I;
			}

			static IntPtr n_Color_I (IntPtr jnienv, IntPtr native__this, int color)
			{
				global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Color (color));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='PaintBuilder.PaintHolder']/method[@name='color' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("color", "(I)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;", "GetColor_IHandler")]
			public virtual unsafe global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder Color (int color)
			{
				const string __id = "color.(I)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (color);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_mode_Landroid_graphics_PorterDuff_Mode_;
#pragma warning disable 0169
			static Delegate GetMode_Landroid_graphics_PorterDuff_Mode_Handler ()
			{
				if (cb_mode_Landroid_graphics_PorterDuff_Mode_ == null)
					cb_mode_Landroid_graphics_PorterDuff_Mode_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Mode_Landroid_graphics_PorterDuff_Mode_);
				return cb_mode_Landroid_graphics_PorterDuff_Mode_;
			}

			static IntPtr n_Mode_Landroid_graphics_PorterDuff_Mode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mode)
			{
				global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.PorterDuff.Mode mode = global::Java.Lang.Object.GetObject<global::Android.Graphics.PorterDuff.Mode> (native_mode, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Mode (mode));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='PaintBuilder.PaintHolder']/method[@name='mode' and count(parameter)=1 and parameter[1][@type='android.graphics.PorterDuff.Mode']]"
			[Register ("mode", "(Landroid/graphics/PorterDuff$Mode;)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;", "GetMode_Landroid_graphics_PorterDuff_Mode_Handler")]
			public virtual unsafe global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder Mode (global::Android.Graphics.PorterDuff.Mode mode)
			{
				const string __id = "mode.(Landroid/graphics/PorterDuff$Mode;)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((mode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mode).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_shader_Landroid_graphics_Shader_;
#pragma warning disable 0169
			static Delegate GetShader_Landroid_graphics_Shader_Handler ()
			{
				if (cb_shader_Landroid_graphics_Shader_ == null)
					cb_shader_Landroid_graphics_Shader_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Shader_Landroid_graphics_Shader_);
				return cb_shader_Landroid_graphics_Shader_;
			}

			static IntPtr n_Shader_Landroid_graphics_Shader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_shader)
			{
				global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Shader shader = global::Java.Lang.Object.GetObject<global::Android.Graphics.Shader> (native_shader, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Shader (shader));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='PaintBuilder.PaintHolder']/method[@name='shader' and count(parameter)=1 and parameter[1][@type='android.graphics.Shader']]"
			[Register ("shader", "(Landroid/graphics/Shader;)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;", "GetShader_Landroid_graphics_Shader_Handler")]
			public virtual unsafe global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder Shader (global::Android.Graphics.Shader shader)
			{
				const string __id = "shader.(Landroid/graphics/Shader;)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((shader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) shader).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_stroke_F;
#pragma warning disable 0169
			static Delegate GetStroke_FHandler ()
			{
				if (cb_stroke_F == null)
					cb_stroke_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_Stroke_F);
				return cb_stroke_F;
			}

			static IntPtr n_Stroke_F (IntPtr jnienv, IntPtr native__this, float width)
			{
				global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Stroke (width));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='PaintBuilder.PaintHolder']/method[@name='stroke' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("stroke", "(F)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;", "GetStroke_FHandler")]
			public virtual unsafe global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder Stroke (float width)
			{
				const string __id = "stroke.(F)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (width);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_style_Landroid_graphics_Paint_Style_;
#pragma warning disable 0169
			static Delegate GetStyle_Landroid_graphics_Paint_Style_Handler ()
			{
				if (cb_style_Landroid_graphics_Paint_Style_ == null)
					cb_style_Landroid_graphics_Paint_Style_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Style_Landroid_graphics_Paint_Style_);
				return cb_style_Landroid_graphics_Paint_Style_;
			}

			static IntPtr n_Style_Landroid_graphics_Paint_Style_ (IntPtr jnienv, IntPtr native__this, IntPtr native_style)
			{
				global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Paint.Style style = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Style> (native_style, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Style (style));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='PaintBuilder.PaintHolder']/method[@name='style' and count(parameter)=1 and parameter[1][@type='android.graphics.Paint.Style']]"
			[Register ("style", "(Landroid/graphics/Paint$Style;)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;", "GetStyle_Landroid_graphics_Paint_Style_Handler")]
			public virtual unsafe global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder Style (global::Android.Graphics.Paint.Style style)
			{
				const string __id = "style.(Landroid/graphics/Paint$Style;)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((style == null) ? IntPtr.Zero : ((global::Java.Lang.Object) style).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_xPerMode_Landroid_graphics_PorterDuff_Mode_;
#pragma warning disable 0169
			static Delegate GetXPerMode_Landroid_graphics_PorterDuff_Mode_Handler ()
			{
				if (cb_xPerMode_Landroid_graphics_PorterDuff_Mode_ == null)
					cb_xPerMode_Landroid_graphics_PorterDuff_Mode_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_XPerMode_Landroid_graphics_PorterDuff_Mode_);
				return cb_xPerMode_Landroid_graphics_PorterDuff_Mode_;
			}

			static IntPtr n_XPerMode_Landroid_graphics_PorterDuff_Mode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mode)
			{
				global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.PorterDuff.Mode mode = global::Java.Lang.Object.GetObject<global::Android.Graphics.PorterDuff.Mode> (native_mode, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.XPerMode (mode));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='PaintBuilder.PaintHolder']/method[@name='xPerMode' and count(parameter)=1 and parameter[1][@type='android.graphics.PorterDuff.Mode']]"
			[Register ("xPerMode", "(Landroid/graphics/PorterDuff$Mode;)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;", "GetXPerMode_Landroid_graphics_PorterDuff_Mode_Handler")]
			public virtual unsafe global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder XPerMode (global::Android.Graphics.PorterDuff.Mode mode)
			{
				const string __id = "xPerMode.(Landroid/graphics/PorterDuff$Mode;)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((mode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mode).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/flask/colorpicker/builder/PaintBuilder", typeof (PaintBuilder));
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

		protected PaintBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='PaintBuilder']/constructor[@name='PaintBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PaintBuilder ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='PaintBuilder']/method[@name='createAlphaPatternShader' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("createAlphaPatternShader", "(I)Landroid/graphics/Shader;", "")]
		public static unsafe global::Android.Graphics.Shader CreateAlphaPatternShader (int size)
		{
			const string __id = "createAlphaPatternShader.(I)Landroid/graphics/Shader;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (size);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Shader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='PaintBuilder']/method[@name='newPaint' and count(parameter)=0]"
		[Register ("newPaint", "()Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;", "")]
		public static unsafe global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder NewPaint ()
		{
			const string __id = "newPaint.()Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
