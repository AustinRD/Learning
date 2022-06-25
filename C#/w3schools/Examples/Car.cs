public class Car {
    /*
        Access Modifiers - used to set access levels for classes, fields, methods, and properties
        public      - accessible for all classes
        private     - accessible within the same class
        protected   - accessible within the same class, or in a class that is inherited from that class
        internal    - accessible within its own assembly
        protected internal
        private protected

        The default access modifier is "private".

        Encapsulation - access modifiers may be used to make sure that sensitive data is hidden from users.
        public get and set methods are also used to provide some level of encapsulation.

        Benefits of Encapsulation - 
        1. Better control of class members (reduce the chance of messing up some code)
        2. Fields can be made read-only, or write-only
        3. Flexible - allowing programmers to change a single part of the code without affecting others.
        4. Increased security of data.

        Inheritance (Derived and Base Classes)
    */

    /* Fields */
    public int maxSpeed;
    public int year;
    public int quantity;
    public string model;

    private string color;

    /* Properties */
    public string Color {
        get { return color; }   // Get method
        set { color = value; }  // Set method
    }

    /* Automatic Properties */
    public string Model { get; set; }


    /*
        All C# classes have a default constructor.
    */
    // Class "constructor"
    public Car() {
        quantity = 1;
    }

    // Constructor with a parameter.
    public Car(modelName) {
        model = modelName;
    }

    // Class "member" method
    public void fullThrottle() {
        Console.WriteLine("The car is going as fast as it can!");
    }

}