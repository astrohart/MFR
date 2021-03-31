using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace MFR.GUI.Properties
{
	[CompilerGenerated]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	internal class Resources
	{
		private static System.Resources.ResourceManager resourceMan;

		private static CultureInfo resourceCulture;

		internal static string AppIdle
		{
			get
			{
				return Resources.ResourceManager.GetString("AppIdle", Resources.resourceCulture);
			}
		}

		internal static string ConfigFilename
		{
			get
			{
				return Resources.ResourceManager.GetString("ConfigFilename", Resources.resourceCulture);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		internal static string Error_ConfigFileNotFound
		{
			get
			{
				return Resources.ResourceManager.GetString("Error_ConfigFileNotFound", Resources.resourceCulture);
			}
		}

		internal static string Error_FindWhatRequired
		{
			get
			{
				return Resources.ResourceManager.GetString("Error_FindWhatRequired", Resources.resourceCulture);
			}
		}

		internal static string Error_ReplaceWithBlank
		{
			get
			{
				return Resources.ResourceManager.GetString("Error_ReplaceWithBlank", Resources.resourceCulture);
			}
		}

		internal static string Error_RootDirectoryNotFound
		{
			get
			{
				return Resources.ResourceManager.GetString("Error_RootDirectoryNotFound", Resources.resourceCulture);
			}
		}

		internal static string FolderSelectDialogFIlters
		{
			get
			{
				return Resources.ResourceManager.GetString("FolderSelectDialogFIlters", Resources.resourceCulture);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new System.Resources.ResourceManager("MFR.GUI.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		internal static Bitmap SwitchUpDown_16x
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("SwitchUpDown_16x", Resources.resourceCulture);
			}
		}

		internal Resources()
		{
		}
	}
}