package test;

import java.lang.reflect.Type;

class test {

    public static void main(String[] args) {

int i = 2;
// i.getClass();
Object o = i; // <==> Object o = new Integer(i);
System.out.println(o.getClass());
// System.out.println((i instanceof Integer));
System.out.println((o instanceof Integer));
// System.out.println((o instanceof int));


Base trueBase = new Base();
Base actuallyDerived = new Derived();
actuallyDerived.ex1();

    }
}