using System;

namespace Common.Attributes
{
	[AttributeUsage(AttributeTargets.All)]
	public sealed class PartialPathAttribute : Attribute
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

		public PartialPathAttribute(string path, int index)
		{
			this.path = path;
			this.index = index;
		}
	}
}
