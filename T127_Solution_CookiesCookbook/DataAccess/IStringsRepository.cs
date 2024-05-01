﻿namespace T127_Solution_CookiesCookbook.DataAccess;

public interface IStringsRepository
{
	List<string> Read(string filePath);
	void Write(string filePath, List<string> strings);
}