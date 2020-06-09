package test;

import java.util.ArrayList;
import java.util.List;

public class Main {

    
    public static void main(String[] args) {
        
        GenericTest<Integer, String> gt = new GenericTest<Integer,String>();
        List<Integer> list = new ArrayList<Integer>(1);
        list.add(1);
        gt.testMethod(list);

        DemoFunctionalInterface dfi = new DemoFunctionalInterface() {
            public int demo(float f) {
                return (int) Math.pow(10, f);
            }
        }; 
        DemoFunctionalInterface lambda = (f) -> (int)Math.pow(10, f);
        System.out.println(dfi.demo(2.498f));
        System.out.println(lambda.demo(2.498f));


    }

}