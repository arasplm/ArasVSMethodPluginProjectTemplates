using System;

namespace Common.Attributes
{
	[AttributeUsage(AttributeTargets.All)]
	public sealed class PartialPathAttribute : Attribute
	{
		private readonly string path;

		public string Path
		{
			get { return path; }
		}

		public PartialPathAttribute(string path)
		{
			this.path = path;
		}
	}
}
