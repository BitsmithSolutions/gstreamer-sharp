// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GES {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Global {

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_add_missing_uri_relocation_uri(IntPtr uri, bool recurse);

		public static bool AddMissingUriRelocationUri(string uri, bool recurse) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			bool raw_ret = ges_add_missing_uri_relocation_uri(native_uri, recurse);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_uri);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void ges_deinit();

		public static void Deinit() {
			ges_deinit();
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_edge_name(int edge);

		public static string EdgeName(GES.Edge edge) {
			IntPtr raw_ret = ges_edge_name((int) edge);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_init();

		public static bool Init() {
			bool raw_ret = ges_init();
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_is_initialized();

		public static bool IsInitialized { 
			get {
				bool raw_ret = ges_is_initialized();
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_list_assets(IntPtr filter);

		public static GES.Asset[] ListAssets(GLib.GType filter) {
			IntPtr raw_ret = ges_list_assets(filter.Val);
			GES.Asset[] ret = (GES.Asset[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), false, true, typeof(GES.Asset));
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_play_sink_convert_frame(IntPtr playsink, IntPtr caps);

		public static Gst.Sample PlaySinkConvertFrame(Gst.Element playsink, Gst.Caps caps) {
			IntPtr raw_ret = ges_play_sink_convert_frame(playsink == null ? IntPtr.Zero : playsink.Handle, caps == null ? IntPtr.Zero : caps.Handle);
			Gst.Sample ret = raw_ret == IntPtr.Zero ? null : (Gst.Sample) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Sample), true);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_pspec_equal(IntPtr key_spec_1, IntPtr key_spec_2);

		public static bool PspecEqual(IntPtr key_spec_1, IntPtr key_spec_2) {
			bool raw_ret = ges_pspec_equal(key_spec_1, key_spec_2);
			bool ret = raw_ret;
			return ret;
		}

		public static bool PspecEqual() {
			return PspecEqual (IntPtr.Zero, IntPtr.Zero);
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern uint ges_pspec_hash(IntPtr key_spec);

		public static uint PspecHash(IntPtr key_spec) {
			uint raw_ret = ges_pspec_hash(key_spec);
			uint ret = raw_ret;
			return ret;
		}

		public static uint PspecHash() {
			return PspecHash (IntPtr.Zero);
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_track_type_name(int type);

		public static string TrackTypeName(GES.TrackType type) {
			IntPtr raw_ret = ges_track_type_name((int) type);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_validate_register_action_types();

		public static bool ValidateRegisterActionTypes() {
			bool raw_ret = ges_validate_register_action_types();
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void ges_version(out uint major, out uint minor, out uint micro, out uint nano);

		public static void Version(out uint major, out uint minor, out uint micro, out uint nano) {
			ges_version(out major, out minor, out micro, out nano);
		}

#endregion
	}
}
