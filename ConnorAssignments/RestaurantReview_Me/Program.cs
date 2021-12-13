using RestaurantReview;

Console.WriteLine("Welcome to Restaurant Review!");

Restaurant newResto = new Restaurant();
string name = newResto.Name = "Carl's Jr.";
string city = newResto.City = "Huntington Beach";
string state = newResto.State = "CA";

Console.WriteLine($"Restaurant:\t{name} \nCity:\t\t{city} \nState:\t\t{state}");