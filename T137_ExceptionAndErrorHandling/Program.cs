
try
{
	var dataFromWeb = SendHttpRequest("www.someAddress.com/get/someResource");
}
catch (HttpRequestException ex) when (ex.Message == "403")
{
	Console.WriteLine("It was forbidden to access the resource.");
	throw;
}
catch (HttpRequestException ex) when (ex.Message == "404")
{
	Console.WriteLine("The resource was not found.");
	throw;
}
catch (HttpRequestException ex) when (ex.Message.StartsWith("4"))
{
	Console.WriteLine("Some kind of client error.");
	throw;
}
catch (HttpRequestException ex) when (ex.Message == "500")
{
	Console.WriteLine("The server has experienced an internal error.");
	throw;
}

object SendHttpRequest(string v)
{
	throw new NotImplementedException();
}