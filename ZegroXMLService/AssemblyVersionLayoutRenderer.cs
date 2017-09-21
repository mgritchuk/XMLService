using NLog;
using NLog.Common;
using NLog.Config;
using NLog.LayoutRenderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ZegroXMLService
{
	
	[LayoutRenderer("asmver")]
	[ThreadAgnostic]
	public class AssemblyVersionLayoutRenderer : LayoutRenderer
	{
		/// &lt;summary>
		/// Specifies the assembly name for which the version will be displayed.
		/// By default the calling assembly is used.
		/// &lt;/summary>
		public String AssemblyName { get; set; }

		private String asmver;
		private String GetAssemblyVersion()
		{
			if (asmver != null)
			{
				return asmver;
			}

			InternalLogger.Debug("Assembly name '{0}' not yet loaded: ", AssemblyName);
			if (!String.IsNullOrEmpty(AssemblyName))
			{
				// try to get assembly based on its name
				asmver = AppDomain.CurrentDomain.GetAssemblies()
										.Where(a => String.Equals(a.GetName().Name,
										AssemblyName, StringComparison.InvariantCultureIgnoreCase))
										.Select(a => a.GetName().Name + " v" +
										a.GetName().Version).FirstOrDefault();
				return asmver == null ? String.Format("&lt;{0} not loaded>",
				AssemblyName) : asmver;
			}
			// get entry assembly
			var entry = Assembly.GetEntryAssembly();
			asmver = entry.GetName().Name + " v" + entry.GetName().Version;
			return asmver;
		}

		/// &lt;summary>
		/// Renders the current trace activity ID.
		/// &lt;/summary>
		/// &lt;param name="builder">The &lt;see cref="StringBuilder"/> 
		/// to append the rendered data to.&lt;/param>
		/// &lt;param name="logEvent">Logging event.&lt;/param>
		protected override void Append(StringBuilder builder, LogEventInfo logEvent)
		{
			builder.Append(GetAssemblyVersion());
		}
	}
	
}
