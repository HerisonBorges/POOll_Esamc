using System;

public class LimiteDiarioException : Exception
{
	public LimiteDiarioException()
	{
	}

	public LimiteDiarioException(string message)
		: base(message)
	{
	}

	public LimiteDiarioException(string message, Exception inner)
		: base(message, inner)
	{
	}
}