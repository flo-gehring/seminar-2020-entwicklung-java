using System;
using System.Linq;

class Typesystem {
    public static void types(){
        int i = 2;
        // Get the Type
        Type t = i.GetType(); // Methodenaufruf auf int!
        Console.WriteLine(t);
        // Print Parent classes.
        Type b = t;
        while(b != null) {
            Console.Write(b + " -> ");
            b = b.BaseType;
        } 
    }
}