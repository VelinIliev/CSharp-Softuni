﻿Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Where(x => char.IsUpper(x[0]))
    .ToList()
    .ForEach(Console.WriteLine);