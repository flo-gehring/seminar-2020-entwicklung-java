import java.util.List;

public class BoxDemo {
    static void demo() {

        Box<Number> numberBox; 
        // Fehler: Box<Integer> ist kein
        // Subtype von Box<Number>
        // numberBox = new Box<Integer>();

        Box<? extends Number> wildcardBox = new Box<Integer>();
        Box<? super Integer> nBox = new Box<Number>();
    }
   
    public static double sumOfList(List<? extends Number> list) {
        double s = 0.0;
        for (Number n : list)
            s += n.doubleValue();
        return s;
    }
    // https://docs.oracle.com/javase/tutorial/java/generics/upperBounded.html

    
}