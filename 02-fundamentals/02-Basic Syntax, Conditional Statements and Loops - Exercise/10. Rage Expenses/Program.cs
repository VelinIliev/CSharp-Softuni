 int lostGames = int.Parse(Console.ReadLine());
 double headsetPrice = double.Parse(Console.ReadLine());
 double mousePrice = double.Parse(Console.ReadLine());
 double keyboardPrice = double.Parse(Console.ReadLine());
 double displayrice = double.Parse(Console.ReadLine());
 
 double dum = 0;
 
 int headsets = lostGames / 2;
 int mouses = lostGames / 3;
 int keyboards = lostGames / 6;
 int displays = lostGames / 12;

 double expenses = headsets * headsetPrice + mouses * mousePrice + keyboards * keyboardPrice + displays * displayrice;

 Console.WriteLine($"Rage expenses: {expenses:f2} lv.");