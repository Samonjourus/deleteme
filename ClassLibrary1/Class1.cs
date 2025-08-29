namespace ClassLibrary1
{
    public class Cube
    {
        double length;
        public static double getSideCount() { return 4; }
        public double getArea() { return 5; }
        public double getPerimiter() { return 10; }
    }

    public class whocares
    {
        public double getSideCount()
        {
            Cube x = new Cube();
            x.getArea();
            Cube.getSideCount();

            return 0;
        }
    }
}

