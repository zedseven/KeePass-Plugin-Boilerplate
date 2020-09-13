using DemoPlugin.Properties;
using KeePass.Plugins;
using KeePass.Util;
using System.Drawing;
using System.Windows.Forms;

namespace DemoPlugin
{
	public sealed class DemoPluginExt : Plugin
	{
		private IPluginHost _host;

		public override Image SmallIcon
		{
			get { return Resources.MenuIcon; }
		}

		public override string UpdateUrl
		{
			get { return "<updateUrl>"; }
		}

		public override bool Initialize(IPluginHost host)
		{
			if (host == null) return false;

			_host = host;

			//Set the version information file signature
			UpdateCheckEx.SetFileSigKey(UpdateUrl, Resources.DemoPluginExt_UpdateCheckFileSigKey);

			return true;
		}

		public override void Terminate()
		{
		}

		public override ToolStripMenuItem GetMenuItem(PluginMenuType t)
		{
			if (t != PluginMenuType.Main)
				return null;

			ToolStripMenuItem strip = new ToolStripMenuItem
			{
				Text = Resources.DemoPluginExt_GetMenuItem_DemoPlugin
			};

			return strip;
		}
	}
}