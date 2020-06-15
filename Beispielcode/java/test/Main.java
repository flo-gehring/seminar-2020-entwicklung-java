package test;

import java.util.ArrayList;
import java.util.List;

public class Main {

    
    public static void main(String[] args) {
        virtualMethodBehave();
/*
        GenericTest<Integer, String> gt = new GenericTest<Integer,String>();
        List<Integer> list = new ArrayList<Integer>(1);
        list.add(1);
        GenericTest.genericListType(list);

        DemoFunctionalInterface dfi = new DemoFunctionalInterface() {
            public int demo(float f) {
                return (int) Math.pow(10, f);
            }
        }; 
        DemoFunctionalInterface lambda = (f) -> (int)Math.pow(10, f);
        System.out.println(dfi.demo(2.498f));
        System.out.println(lambda.demo(2.498f));

*/
    }

    public static void varianceBehavior() {
        Object no; 
        Number n;
        Integer ni;
        ArrayList<? super Number> nl = new ArrayList<Number>();

        nl.add((Number) 1);
        nl.add((Integer)1);
        // nl.add(new Object());
        no = nl.get(0);
        // n = nl.get(0);
        // ni = (Integer) nl.get(0);

        ArrayList<? extends Number> il = new ArrayList<Integer>();
        // il.add((Integer) 1);
        // il.add((Number) 1);
        // il.add(new Object());
        no = il.get(0);
        n = il.get(0);
        // ni = il.get(0);

    }

}