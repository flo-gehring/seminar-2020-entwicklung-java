using System;
class DelegateDemonstration {
    // Deklaration eines neuen Datentyps! 
    public delegate int DelegMult(float f);

    public static int TimesTwo(float f) {
         Console.WriteLine(f + " * 2 as Delegate"); 
         return (int)f * 2;
    }
    public static int TimesThree(float f) {
        Console.WriteLine(f + " * 3 as Delegate");
         return (int)f * 3;
    }

    public static void demonstrate_delegates() {
        DelegMult deleg = TimesTwo;
        Console.WriteLine(deleg(2));
    }

    public static void as_parameters() {
        DelegMult d1 = TimesTwo;
        DelegMult d2 = TimesThree;
        multicast_delegates(d1, d2);
    }
    public static void multicast_delegates(DelegMult d1,
         DelegMult d2){
     Console.WriteLine("Length of Invocation List: " 
        +  d1.GetInvocationList().Length); // 1
     d1 += d2; // d1 is now a MultiCast Delegate 
     Console.WriteLine("Length of Invocation List: " 
        + d1.GetInvocationList().Length); // 2
     d1(2);
    }

    public static void different_initializers(DelegMult param){
        DelegMult as_param = param;
        DelegMult named_function = new DelegMult(TimesTwo);
        DelegMult anonymous_function =  delegate(float f) 
                { return 2 * (int) f; };
        DelegMult lambda = (f) => { return 2 * (int)f;};
    }
}