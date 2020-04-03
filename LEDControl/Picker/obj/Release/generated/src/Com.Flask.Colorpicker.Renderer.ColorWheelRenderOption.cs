using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Flask.Colorpicker.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='ColorWheelRenderOption']"
	[global::Android.Runtime.Register ("com/flask/colorpicker/renderer/ColorWheelRenderOption", DoNotGenerateAcw=true)]
	public partial class ColorWheelRenderOption : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='ColorWheelRenderOption']/field[@name='alpha']"
		[Register ("alpha")]
		public float Alpha {
			get {
				const string __id = "alpha.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "alpha.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='ColorWheelRenderOption']/field[@name='cSize']"
		[Register ("cSize")]
		public float CSize {
			get {
				const string __id = "cSize.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "cSize.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='ColorWheelRenderOption']/field[@name='density']"
		[Register ("density")]
		public int Density {
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='ColorWheelRenderOption']/field[@name='lightness']"
		[Register ("lightness")]
		public float Lightness {
			get {
				const string __id = "lightness.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "lightness.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='ColorWheelRenderOption']/field[@name='maxRadius']"
		[Register ("maxRadius")]
		public float MaxRadius {
			get {
				const string __id = "maxRadius.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "maxRadius.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='ColorWheelRenderOption']/field[@name='strokeWidth']"
		[Register ("strokeWidth")]
		public float StrokeWidth {
			get {
				const string __id = "strokeWidth.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "strokeWidth.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='ColorWheelRenderOption']/field[@name='targetCanvas']"
		[Register ("targetCanvas")]
		public global::Android.Graphics.Canvas TargetCanvas {
			get {
				const string __id = "targetCanvas.Landroid/graphics/Canvas;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "targetCanvas.Landroid/graphics/Canvas;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/flask/colorpicker/renderer/ColorWheelRenderOption", typeof (ColorWheelRenderOption));
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

		protected ColorWheelRenderOption (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='ColorWheelRenderOption']/constructor[@name='ColorWheelRenderOption' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ColorWheelRenderOption ()
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

	}
}
