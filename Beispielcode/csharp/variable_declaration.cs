using System;
using System.Linq;
class VariableDeclaration {
    static void variable_declarations () {
        // Declaration only:
        float temperature;
        string name;
        Beispielcode.Hello hello;
    

        // Declaration with initializers (four examples):
        char firstLetter = 'C';
        var limit = 3;
        int[] source = { 0, 1, 2, 3, 4, 5 };
        var query = from item in source
                where item <= limit
                select item;
    }
}
