using System.Runtime.Serialization;

try
{
	ComplexMethod();
}
catch (ConnectionException)
{
	Console.WriteLine("Check your internet connection.");
	throw;
}
catch (JsonParsingException ex)
{
	Console.WriteLine("Unable to parse JSON. JSON body is: " + ex.JsonBody);
	throw;
}

throw new CustomException();

void ComplexMethod()
{
	// step 1: connecting
	throw new ConnectionException("Cannot connect to a service.");

	// step 2: authorizing
	throw new AuthorizationException("Cannot authorize the user.");

	// step 3: retrieving data as JSON
	throw new DataAccessException("Cannot retrieve data.");

	// step 4: parsing the JSON to some C# type
	throw new JsonParsingException("Cannot parse JSON data.");
}

public class JsonParsingException : Exception
{
	public string? JsonBody { get; }

	public JsonParsingException()
	{
	}

	public JsonParsingException(string? message) : base(message)
	{
	}

	public JsonParsingException(string? message, string jsonBody) : base(message)
	{
		JsonBody = jsonBody;
	}

	public JsonParsingException(string? message, Exception? innerException) : base(message, innerException)
	{
	}

	public JsonParsingException(string? message,
		string jsonBody,
		Exception? innerException) : base(message, innerException)
	{
		JsonBody = jsonBody;
	}
}

public class DataAccessException : Exception
{
	public DataAccessException()
	{
	}

	public DataAccessException(string? message) : base(message)
	{
	}

	public DataAccessException(string? message, Exception? innerException) : base(message, innerException)
	{
	}
}

public class AuthorizationException : Exception
{
	public AuthorizationException()
	{
	}

	public AuthorizationException(string? message) : base(message)
	{
	}

	public AuthorizationException(string? message, Exception? innerException) : base(message, innerException)
	{
	}
}

public class ConnectionException : Exception
{
	public ConnectionException()
	{
	}

	public ConnectionException(string? message) : base(message)
	{
	}

	public ConnectionException(string? message, Exception? innerException) : base(message, innerException)
	{
	}
}

public class CustomException : Exception
{
	public int StatusCode { get; }

	public CustomException()
	{
	}

	public CustomException(string message, int statusCode) : base(message)
	{
		StatusCode = statusCode;
	}

	public CustomException(
		string message,
		int statusCode,
		Exception innerException) : base(message, innerException)
	{
		StatusCode = statusCode;
	}

	public CustomException(string message) : base(message)
	{
	}

	public CustomException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}