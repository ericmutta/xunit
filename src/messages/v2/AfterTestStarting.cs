﻿using Xunit.Abstractions;

#if XUNIT_FRAMEWORK
namespace Xunit.v2
#else
namespace Xunit.Runner.v2
#endif
{
	/// <summary>
	/// Default implementation of <see cref="IAfterTestStarting"/>.
	/// </summary>
	public class AfterTestStarting : TestMessage, IAfterTestStarting
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AfterTestStarting"/> class.
		/// </summary>
		public AfterTestStarting(
			ITest test,
			string attributeName)
				: base(test)
		{
			Guard.ArgumentNotNull(nameof(attributeName), attributeName);

			AttributeName = attributeName;
		}

		/// <inheritdoc/>
		public string AttributeName { get; }
	}
}