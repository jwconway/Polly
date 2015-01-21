using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polly
{
	/// <summary>
	/// Contract for a Transient Exception Handling Policy
	/// </summary>
	public interface IPolicy
	{
		/// <summary>
		/// Executes the specified action within the policy.
		/// </summary>
		/// <param name="action">The action to perform.</param>
		[DebuggerStepThrough]
		void Execute(Action action);

		/// <summary>
		/// Executes the specified action within the policy and returns the result.
		/// </summary>
		/// <typeparam name="TResult">The type of the result.</typeparam>
		/// <param name="action">The action to perform.</param>
		/// <returns>The value returned by the action</returns>
		[DebuggerStepThrough]
		TResult Execute<TResult>(Func<TResult> action);
	}

	
}
