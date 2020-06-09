using System;
using System.Linq;

class Typesystem {
    public static void types(){
int i = 2;
// Get the Type
        Type t = i.GetType(); // Methodenaufruf auf int!
        Console.WriteLine(t);
        // Which Methods can be called on this object?
        foreach(var method in t.GetMethods()) {
            Console.Write(method + " ");
        }
        Console.WriteLine();
        // Print Parent classes.
        Type b = t;
        while(b != null) {
            Console.Write(b + " -> ");
            b = b.BaseType;
        } 
    }
}