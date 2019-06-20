using System;

namespace Common.Attributes
{
	[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
	public sealed class ExternalPathAttribute : Attribute
	{
		private readonly string path;
		private readonly int index;

		public string Path
		{
			get { return path; }
		}

		public int Index
		{
			get { return index; }
		}

		public ExternalPathAttribute(string path, int index)
		{
			this.path = path;
			this.index = index;
		}
	}
}
