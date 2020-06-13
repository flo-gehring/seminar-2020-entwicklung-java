class GenericDemo<A, B> {
    public static void test() {
        GenericTest<int, int> test1;
        var t2 = new GenericTest<int, float>();
        // string doesn't have a parameterless constructor:
        // GenericTest<string, int> t3 =      
        //      new GenericTest<string, int>();
        GenericTest<int, B> t4 = new GenericTest<int, B>();
    }
}