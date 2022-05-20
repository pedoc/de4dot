using System.Reflection;

namespace de4dot.mdecrypt {
	public static class ExtensionMethods {
		public static MethodInfo[] GetAllGetMethods(this Module module) {
			var methodInfos = module
				.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic|BindingFlags.InvokeMethod);
			return methodInfos;
		}
	}
}
