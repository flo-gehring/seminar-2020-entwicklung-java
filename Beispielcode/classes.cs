using System;
class Base {
    virtual public void ex1() {
        Console.WriteLine("Base, example 1");
    } 
    virtual public void ex2() {
        Console.WriteLine("Base, example 2");
    }
     public void ex3() {
        Console.WriteLine("Base, example 3");
    }
}

class Derived : Base{
    
    new public void ex1() {
        Console.WriteLine("Derived, example 1");
    }
    // sealed: Child classes of Derived can't override ex2
    sealed override public void ex2() {
        Console.WriteLine("Derived, example 2, ");
    }
    
    //    Forbidden:  override public void ex3() ...
    new public void ex3() {
        Console.WriteLine("Derived, example 3");
    }
}

class ClassTest {
    public static void modifierBehavior() {
        Base trueBase = new Base();
        Base actuallyDerived = new Derived();
        Derived trueDerived = new Derived();

        trueBase.ex1(); actuallyDerived.ex1(); trueDerived.ex1();
        trueBase.ex2(); actuallyDerived.ex2(); trueDerived.ex2();
        trueBase.ex3(); actuallyDerived.ex3(); trueDerived.ex3();

    }
}