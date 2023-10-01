string исходнаяСтрока = "Один\nна\nсуше\nдругой\nна\nморе";
string[] подстроки = исходнаяСтрока.Split('\n');
string новаяСтрока = string.Join(":", подстроки);
Console.WriteLine(новаяСтрока); 