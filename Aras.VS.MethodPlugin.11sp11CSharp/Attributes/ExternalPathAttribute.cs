using System;

namespace Common.Attributes
{
	[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
	public sealed class ExternalPathAttribute : Attribute
	{
		private readonly string path;

		public string Path
		{
			get { return path; }
		}

		public ExternalPathAttribute(string path)
		{
			this.path = path;
		}
	}
}
