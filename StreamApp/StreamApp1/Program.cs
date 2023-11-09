using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string inputFilePath = "supplier_b_import.txt";
        string outputFilePath = "result.txt";

        try
        {
            string[] lines = File.ReadAllLines(inputFilePath);
            Regex dateRegex = new Regex(@"(\d{1,2}\s[а-я]+\s\d{4})|\d{4}-\d{2}-\d{2}");

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length >= 5)
                    {
                        string dateStr = dateRegex.Match(parts[4]).Value;

                        if (!string.IsNullOrEmpty(dateStr))
                        {
                            DateTime date = DateTime.Parse(dateStr);
                            parts[4] = date.ToString("dd-MM-yyyy HH:mm");
                        }

                        for (int i = 0; i < parts.Length; i++)
                        {
                            parts[i] = parts[i].Trim();
                            parts[i] = Regex.Replace(parts[i], "[^0-9a-zA-Zа-яА-Я,. ]", "");
                        }

                        if (parts.Length >= 4)
                        {
                            if (parts[3].Contains("в рейтинге"))
                            {
                                string[] ratingParts = parts[3].Split(' ');
                                if (ratingParts.Length >= 3)
                                {
                                    string ratingValue = ratingParts[0];
                                    parts[3] = ratingValue;
                                }
                            }
                            else
                            {
                                parts[3] = parts[3].Replace("Рейтинг =", "");
                            }
                        }

                        string modifiedLine = string.Join(", ", parts);
                        writer.WriteLine(modifiedLine);
                    }
                }
            }

            Console.WriteLine("Задание выполнено успешно. Результаты записаны в файл result.txt");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }

        Console.ReadKey();
    }
}
