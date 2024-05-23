var countryToCurrencyMapping = new Dictionary<string, string>();
countryToCurrencyMapping.Add("USA", "USD");
countryToCurrencyMapping.Add("India", "INR");
countryToCurrencyMapping.Add("Spain", "EUR");
countryToCurrencyMapping.Add("Italy", "EUR");

Console.WriteLine("Currency in Spain is " + countryToCurrencyMapping["Spain"]);

countryToCurrencyMapping["Poland"] = "PLN";
//countryToCurrencyMapping.Add("Poland", "EUR");
countryToCurrencyMapping["Poland"] = "EUR";

Console.WriteLine("Currency in Poland is " + countryToCurrencyMapping["Poland"]);

var initializedCountryToCurrencyMapping = new Dictionary<string, string>()
{
	["SRB"] = "RSD",
	["HU"] = "HUF",
	["MK"] = "MKD"
};

foreach (var countryCurrencyPair in initializedCountryToCurrencyMapping)
{
	Console.WriteLine(
		$"Country: {countryCurrencyPair.Key}, currency: {countryCurrencyPair.Value}");
}