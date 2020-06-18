import java.util.function.Function;

public class GenericFunctionalInterfaces {
    
    static Boolean compare(Number n) {
        return (Boolean) ((int) (n.doubleValue()) == 2 );
    }

    public static void test() {
        Function<Integer, 
            ? extends Number> getNumber;
        getNumber = (Integer i) -> {return (Double) i.doubleValue(); };
        Number n = getNumber.apply(100);

        Function<? super Integer, Boolean> numberComparer;
        numberComparer = GenericFunctionalInterfaces::compare;
        Boolean b = numberComparer.apply(1);
    }
}