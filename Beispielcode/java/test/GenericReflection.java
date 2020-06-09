package test;

import java.util.ArrayList;
import java.util.List;
import java.lang.reflect.Method;
import java.lang.reflect.ParameterizedType;
import java.lang.reflect.Type;

// http://tutorials.jenkov.com/java-reflection/generics.html
public class GenericReflection {

    public static List<String> getParameterizedList() {
        return new ArrayList<String>();
    }

    public static <T>  List<T> getGenericList(T elem) {
        List<T> l = new ArrayList<T>(1);
        // l.add(elem);
        return l;
    }

    public static void init() {
        List<String> l = new ArrayList<String>();
        GenericTest<Integer, Boolean> gc1 = new GenericTest<Integer, Boolean>();
        Method method;

        try {

            // From Object Instance
            Type rt = gc1.getClass().getMethod("createObject", Class.class).getGenericReturnType();
            if(rt instanceof ParameterizedType) {
                ParameterizedType type = (ParameterizedType) rt;
                Type[] typeArgs = type.getActualTypeArguments();
                for(Type typeArgument : typeArgs){
                    Class typeArgClass = (Class) typeArgument;
                    System.out.println("typeArgClass = " + typeArgClass);
                }
            }

            method = GenericReflection.class.getMethod("getParameterizedList");
            Type returnType = method.getGenericReturnType();

            if(returnType instanceof ParameterizedType) {
                ParameterizedType type = (ParameterizedType) returnType;
                Type[] typeArgs = type.getActualTypeArguments();
                System.out.println("Type Argument;");
                for(Type typeArgument : typeArgs){
                    Class typeArgClass = (Class) typeArgument;
                    System.out.println("typeArgClass = " + typeArgClass);
                }
            }
            else {
                System.out.println("Type not Parameterized;");
                System.out.println(returnType.toString());

            }
        } catch (NoSuchMethodException | SecurityException e) {
            System.out.println("Excption Occured" +  e.toString());
            e.printStackTrace();
        }
        



    }
}