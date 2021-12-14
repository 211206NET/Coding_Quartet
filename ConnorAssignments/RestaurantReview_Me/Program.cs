using RestaurantReview;

// Initialize my list of restaurants
List<Restaurant> allRestaurants = new List<Restaurant>();
bool exit = false;
Console.WriteLine("Welcome to Restaurant Review!");

while(!exit) {
    Console.WriteLine();
    Console.WriteLine("What would you like to do today?");
    Console.WriteLine("1. Create a new Restaurant");
    Console.WriteLine("2. View All Restaurant");
    Console.WriteLine("3. Leave a review");
    Console.WriteLine("x. Exit");
    string input = Console.ReadLine();
    int counter = 0;

    switch(input) {
        case "1":
            Console.WriteLine();
            Console.WriteLine("Create a new restaurant:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("City: ");
            string city = Console.ReadLine();
            Console.Write("State: ");
            string state = Console.ReadLine();

            //Initializing the class using empty constructor
            // Restaurant newRestaurant = new Restaurant();
            // newRestaurant.Name = name;
            // newRestaurant.City = city;
            // newRestaurant.State = state;

            //another way to initialize a class
            //using object initializer
            Restaurant newRestaurant = new Restaurant {
                Name = name,
                City = city,
                State = state
            };

            allRestaurants.Add(newRestaurant);
        break;
        case "2":
            if (allRestaurants.Count == 0) {
                Console.WriteLine("\nThere are no restaurants listed.");
            }
            else {
                Console.WriteLine();
                Console.WriteLine("Here are all your restaurants!");
                foreach(Restaurant resto in allRestaurants)
                {
                    Console.WriteLine($"Name: {resto.Name} \nCity: {resto.City} \nState: {resto.State}");
                    Console.WriteLine("======Reviews======");
                    foreach(Review review in resto.Reviews)
                    {
                        Console.WriteLine($"Rating: {review.Rating} \t Note: {review.Note}\n");
                    }
                }
                Console.WriteLine();
            }
        break;
        case "3":
            if (allRestaurants.Count == 0) {
                Console.WriteLine("\nThere are no restaurants listed for review");
            } else {
                Console.WriteLine("\nSelect a restaurant to leave reviews for");
                for(int i = 0; i < allRestaurants.Count; i++)
                {
                    Console.WriteLine($"\n[{i}] Name: {allRestaurants[i].Name} \nCity: {allRestaurants[i].City} \nState: {allRestaurants[i].State}");
                    counter++;
                }
                int selection = Int32.Parse(Console.ReadLine());
                while (selection < 0 || selection > counter) {
                    Console.WriteLine("Please select a restaurant from the list.");
                    selection = Int32.Parse(Console.ReadLine());
                }

                Restaurant selectedRestaurant = allRestaurants[selection];

                //now I want to collect information about the review
                Console.WriteLine("Give a rating: ");
                int rating = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Leave a Review: ");
                string note = Console.ReadLine();

                Review newReview = new Review(rating, note);

                selectedRestaurant.Reviews.Add(newReview);
                Console.WriteLine("Your review has been successfully added!");
            }
        break;
        case "x":
            exit = true;
            Console.WriteLine("Goodbye!");
        break;
    }
    // Restaurant newResto = new Restaurant();
    // string name = newResto.Name = "Carl's Jr.";
    // string city = newResto.City = "Huntington Beach";
    // string state = newResto.State = "CA";

    // Console.WriteLine($"Restaurant:\t{name} \nCity:\t\t{city} \nState:\t\t{state}");
}