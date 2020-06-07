using System;
class DelegateDemonstration {
    // Deklaration eines neuen Datentyps! 
    public delegate int DelegMult(float f);

    public static int TimesTwo(float f) {
        return (int)f * 2;
    }
    public static int TimesThree(float f) {
        return (int)f * 3;
    }

    public static void demonstrate_delegates() {
        DelegMult deleg = TimesTwo;
        Console.WriteLine(deleg(2));
    }

    public static void as_parameters() {
        DelegMult d1 = TimesTwo;
        DelegMult d2 = TimesThree;
        demonstrate_invocation_list(d1, d2);
    }
    public static void demonstrate_invocation_list(DelegMult d1,
         DelegMult d2){
     d1 += d2;
     System.Console.WriteLine(d1(2));
    }
}