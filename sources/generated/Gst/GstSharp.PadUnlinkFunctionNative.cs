// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GstSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate void PadUnlinkFunctionNative(IntPtr pad, IntPtr parent);

	internal class PadUnlinkFunctionInvoker {

		PadUnlinkFunctionNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~PadUnlinkFunctionInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal PadUnlinkFunctionInvoker (PadUnlinkFunctionNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal PadUnlinkFunctionInvoker (PadUnlinkFunctionNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal PadUnlinkFunctionInvoker (PadUnlinkFunctionNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gst.PadUnlinkFunction Handler {
			get {
				return new Gst.PadUnlinkFunction(InvokeNative);
			}
		}

		void InvokeNative (Gst.Pad pad, Gst.Object parent)
		{
			native_cb (pad == null ? IntPtr.Zero : pad.Handle, parent == null ? IntPtr.Zero : parent.Handle);
		}
	}

	internal class PadUnlinkFunctionWrapper {

		public void NativeCallback (IntPtr pad, IntPtr parent)
		{
			try {
				managed (GLib.Object.GetObject(pad) as Gst.Pad, GLib.Object.GetObject(parent) as Gst.Object);
				if (release_on_call)
					gch.Free ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal PadUnlinkFunctionNative NativeDelegate;
		Gst.PadUnlinkFunction managed;

		public PadUnlinkFunctionWrapper (Gst.PadUnlinkFunction managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new PadUnlinkFunctionNative (NativeCallback);
		}

		public static Gst.PadUnlinkFunction GetManagedDelegate (PadUnlinkFunctionNative native)
		{
			if (native == null)
				return null;
			PadUnlinkFunctionWrapper wrapper = (PadUnlinkFunctionWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
