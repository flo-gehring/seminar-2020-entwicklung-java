package test;


class test {

    public static void test_method(String[] args) {

int i = 2;
// i.getClass();
Integer o = (Integer) i;
System.out.println(o.getClass());
// System.out.println((i instanceof Integer));
System.out.println((o instanceof Integer));
// System.out.println((o instanceof int));


Base trueBase = new Base();
Base actuallyDerived = new Derived();
actuallyDerived.ex1();

    }
}