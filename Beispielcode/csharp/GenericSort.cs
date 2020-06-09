using System.Collections.Generic;
class GenericTest<T, U> where T: new() {
    public void genericTypeMethod(T arg) {
        System.Console.WriteLine("Type T");
    }
    public void genericTypeMethod(U arg) {
        System.Console.WriteLine("Type U");
    }

    public static void genericListType(object o) {
        if (o.GetType() == typeof(List<string>)){
            System.Console.WriteLine(
                "Generic Typeinformation is available at Runtime");
        }
        else {
            System.Console.WriteLine("This is not a list of Strings");
        }
    }

    public T createObject() { // new constraint
        return new T();
    }


    public static int typeCounter = 0;
    public static void statMethod(T param) {
        typeCounter += 1;
        System.Console.WriteLine("This Works! " + param.ToString());
    }
    public static void staticMethodDemo() {
        GenericTest<int, string>.statMethod(1);
        GenericTest<int, string>.statMethod(2);

        GenericTest<int, bool>.statMethod(3);

        System.Console.WriteLine("<int, string>    typeCounter: " +
             GenericTest<int, string>.typeCounter);
        System.Console.WriteLine("<int, bool>      typeCounter: " + 
            GenericTest<int, bool>.typeCounter);
    }
    
}