using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace de4dot.common {
	public static class RuntimeExtensions {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsX64() => IntPtr.Size == 8;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ProcessorArchitecture GetEntryAssemblyProcessorArchitecture() {
			var assembly = Assembly.GetEntryAssembly()!.GetName();
			return assembly.ProcessorArchitecture;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static string GetRuntimeInfo() {
			return $"{RuntimeInformation.FrameworkDescription} {RuntimeInformation.ProcessArchitecture}";
		}
	}
}
