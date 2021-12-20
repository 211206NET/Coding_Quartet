namespace RestaurantReview;

public class Restaurant {
    // In a restaurant, store name, city, state

    // This is property, a type member
    // Access modifier controls the visibility of type and type members
    // There are four access modifiers: Public, Private, Internal, Protected
    // Public is the most visible, private is the least visible
    // By default, class member has access modifier set to private
    // Class, by default, are internal unless you explicitely say otherwise


    public Restaurant() {
        this.Reviews = new List<Review>();
    }
    public Restaurant(string name) {
        this.Reviews = new List<Review>();
        this.Name = name;
    }
    public string Name { get; set; }

    // private string _name;

    // our own custom getter and setter for the private backing field
    // // private string GetName() {
    //     Restaurant this._name;
    // }

    // private void SetName(string name) {
    //     this._name = name;
    // }

    public string City { get; set; }
    public string State { get; set; }
    public List<Review> Reviews { get; }
}