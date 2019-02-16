using System;

// Simple logging struct based on the environemnt variable
namespace MonoGame
{
	struct Log
	{
		static bool isDebug = Environment.GetEnvironmentVariable("BUILD") == "Debug";

		public static void Clear()
		{
			Console.Clear();
		}

		public static void Print(string message)
		{
			if (isDebug) {
				Console.Write(message);
			}
		}
	}
}