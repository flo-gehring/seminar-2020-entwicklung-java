package test;

public class Main {

    
    public static void main(String[] args) {
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