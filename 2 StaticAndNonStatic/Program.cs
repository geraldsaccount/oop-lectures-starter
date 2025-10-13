namespace _2_StaticAndNonStatic;

class Program {
    static void Main(string[] args) {
        Counter obj1 = new Counter("Object 1");
        Counter obj2 = new Counter("Object 2");

        obj1.DisplayInfo();
        obj2.DisplayInfo();
        Counter.DisplayCount();
        Counter.DisplayCount();
    }
}
