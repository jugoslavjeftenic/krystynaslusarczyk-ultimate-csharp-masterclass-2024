var dataDownloader = new SlowDataDownloader();

Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id2"));
Console.WriteLine(dataDownloader.DownloadData("id3"));
Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id4"));
Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id2"));

public interface IDataDownloader
{
	string DownloadData(string resourceId);
}

public class SlowDataDownloader : IDataDownloader
{
	public string DownloadData(string resourceId)
	{
		Thread.Sleep(1000);
		return $"Some data for {resourceId}";
	}
}