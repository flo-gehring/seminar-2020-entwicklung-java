package test;

import java.lang.reflect.Constructor;
import java.lang.reflect.InvocationTargetException;
import java.util.*;

class GenericTest<T, U> {

    T tMember;
    U uMember;

    public static void genericListType(Object o) {
        // if (o instanceof List<String>); Nicht möglich
        if (o instanceof List) {
            Object member = ((List) o).get(0);
            System.out.println(member instanceof String);
        }
    }
    // The following Methods create an error
    /*
     * public void genericTypeMethod(T arg) { System.out.println("Type T"); }
     * 
     * public void genericTypeMethod(U arg) { System.out.println("Type U"); }
     */

    // Problem: Klasse muss bekannt sein.
    public T createObject(Class<T> clazz)
            throws InstantiationException, IllegalAccessException, IllegalArgumentException, InvocationTargetException,
            NoSuchMethodException, SecurityException {
        // Falls bekannt, dass tMember nicht null ist:
        // tMember.getClass()
        Constructor<T> c = clazz.getConstructor(); 
        // Konstruktor vorhanden?
        return c.newInstance();
    }

    
    /*
    public static void statMethod(T param) {

    }
    */

    public T getTMember() {
        return tMember;
    }

    public U getUMember() {
        return uMember;
    }

    public static void varianceBehavior() {
        Object no; 
        Number n;
        Integer ni;
        
        ArrayList<? super Number> nl = new ArrayList<Object>();
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