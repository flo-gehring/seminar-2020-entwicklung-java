class UseFunction {

    static int TimesTwo(float f) {
        return (int) (2 * f);
    }
    public static void test() {
        DelegMult timesTwo = UseFunction::TimesTwo;
        DelegMult timesThree = (f) -> (int) (3 * f);
        // timesTwo(2);
        timesTwo.mult(2.0f);
        timesThree.mult(0.12f);
    }

}