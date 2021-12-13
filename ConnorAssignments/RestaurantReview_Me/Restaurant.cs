namespace RestaurantReview;

public class Restaurant {
    // In a restaurant, store name, city, state

    // This is property, a type member
    // Access modifier controls the visibility of type and type members
    // There are four access modifiers: Public, Private, Internal, Protected
    // Public is the most visible, private is the least visible
    // By default, class member has access modifier set to private
    // Class, by default, are internal unless you explicitely say otherwise
    public string Name { get; set; }
    
}