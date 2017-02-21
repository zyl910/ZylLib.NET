using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Reflection;
using ZylLib;

namespace ZylLib.TestConsole {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("ZylLib.TestConsole");

			Assembly assembly = typeof(GacUtil).Assembly;
			string version = FileVersionInfo.GetVersionInfo(assembly.Location).FileVersion;
			Console.WriteLine("ZylLib.NET Version: " + version);
			Console.WriteLine("ZylLib.NET Assembly: " + assembly.FullName);
			Console.WriteLine("Environment.MachineName: " + Environment.MachineName);
			Console.WriteLine("Environment.OSVersion: " + Environment.OSVersion);
			Console.WriteLine("Environment.ProcessorCount: " + Environment.ProcessorCount);
			Console.WriteLine("Environment.Version: " + Environment.Version);
			
		}
	}
}
