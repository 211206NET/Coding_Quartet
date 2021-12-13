namespace ToDo;

// This is a class
// classes are blueprints for objects
// It's a data type
// it has members:
// 1. Constructor - This special method creates the object with the class' shape
// 2. Fields - They hold values that pertain to the class
// 3. Properties - They'te wrapper around fields to make it a bit more secure
// 4. Methods - They define behaviors of a class (They are functions that belong in a class)
// classes have access modifiers -> which is something that controls access to that particular class
// Public means that any and everyone can access this class
public class ToDoItem {
    // empty constructor
    public ToDoItem() {}

    // this is a field
    // public bool Done;
    
    // This is called automatic property
    public bool IsDone { get; set; }
    public string Note { get; set; }

    // Method
    // This method does not take any arguments
    public void CompleteItem() {
        // this keyword refers to the particular instance of the class
        this.IsDone = true;
    }

    // Method signiture goes: Access modifier, return type, method name, parameters/arguments
    public string Print() {
        //string concatenation
        // return "Done: " + this.IsDone + " Note: " + this.Note;

        // String Interpolation
        return $"Done: {this.IsDone} Note: {this.Note}";
    }
}
