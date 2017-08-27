using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Direct2U
{
	/// <summary>
	/// Summary description for Globals.
	/// </summary>
	public class Globals
	{
		public static System.Windows.Forms.Cursor HaloArrow = null;

		public static string ServerD2UPath = null;

		public static string ServerUpdateXmlFile = null;

		public static string HaloCE_Path = null;

		public static Globals()
		{
			//pointer = new System.Windows.Forms.Cursor(null);

			// Get HaloCE Path
			RegistryKey rk = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Microsoft Games\\Halo");
			HaloCE_Path = (string)rk.GetValue("EXE Path", "C:\\C:\\Program Files\\Microsoft Games\\Halo Custom Edition") + "\\";
		}

		public static System.Drawing.Image LoadImage(string name)
		{
			return null;
		}

		#region Flags
		/// <summary>
		///   Checks if a flag value is set (turned on). </summary>
		/// <param name="flag">
		///   The flag to check. </param>
		/// <returns>
		///   If the flag is set, the return value is true; otherwise it is false. </returns>
		public static bool HasFlag(int flags, int bit)
		{
			return ((flags & bit) != 0);
		}

		/// <summary>
		///   Adds or removes flags from the behavior. </summary>
		/// <param name="bits">
		///   The bits to be turned on (ORed) or turned off in the internal flags member. </param>
		/// <param name="addOrRemove">
		///   If true the flags are added, otherwise they're removed. </param>
		public static void ModifyFlags(ref int flags, int bits, bool addOrRemove)
		{
			if (addOrRemove)
				flags |= bits;
			else
				flags &= ~bits;
		}
		#endregion
	};
}