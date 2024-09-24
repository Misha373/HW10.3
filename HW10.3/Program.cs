Console.OutputEncoding = System.Text.Encoding.UTF8;
string Temp = "Milk, Water, Tea, Coffe, Juice.";
string replaced = Temp.Replace(" ", "");
Console.WriteLine($"Рядок до зміни: {Temp}");
Console.WriteLine($"Рядок після зміни: {replaced}");