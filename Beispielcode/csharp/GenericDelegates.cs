class GenericDeletages
{
    public delegate R Function<in T, out R>(T arg);    

    static bool largeShape(Shape s) {
        return s.Area > 100;
    }
    public static void test() 
    {
        Function<double, Shape> shapeWithArea;
        shapeWithArea = (double d) => {return new Circle(d);};
        Shape shape = shapeWithArea(2);

        Function<Circle, bool> circleComparer;
        circleComparer =  GenericDeletages.largeShape;
    }
}