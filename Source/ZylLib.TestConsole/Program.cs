using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using ZylLib;

namespace ZylLib.TestConsole {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("ZylLib.TestConsole");

			string version = FileVersionInfo.GetVersionInfo(typeof(GacUtil).Assembly.Location).FileVersion;
			Console.WriteLine("Json.NET Version: " + version);
		}
	}
}
