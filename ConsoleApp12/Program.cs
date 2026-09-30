using System;

class Program
{
    static void Main()
    {
        // Q1 --> Generic Class: is a class using a type parameter like <T> instead of any data type.
        //      --> type safety, better performance, code reusability.

        // Q7 --> Struct Constraint: restricts the generic type parameter to be a value type.
        //      --> public class Container<T> where T : struct

        // Q8 --> Class Constraint: the type argument T must be a reference type.
        //      --> public class Container<T> where T : class

        // Q9 --> new() Constraint: allows you to create a new instance of T using new().
        //      --> public class Container<T> where T : new()

        // Q10 --> Interface Constraint: guarantees that T has all the methods and properties
        //       defined by that interface.
        //       --> public class Utility<T> where T : IComparable<T>

        // Q11 --> Base Class Constraint: restricts the type parameter T to be a specific base class.
        //       --> public class Animal
        //       --> public class Container<T> where T : Animal

        // Q12 --> Multiple Constraints: applies more than one constraint on a type parameter.
        //       --> public class Container<T> where T : Animal, new()

        // Q13 --> default: returns null for reference types or 0 for value types.
        //       --> return default;

        // Q15 --> Covariance (out): allows using a more derived type than the original specific type.
        //       It is usually used as a return type / output.
        //       --> interface IProducer<out T>
        //       --> T Get();

        // Q16 --> Contravariance (in): allows using a less derived type than the original specific type.
        //       It is usually used as an input parameter.
        //       --> interface IConsumer<in T>
        //       --> void Consume(T item);

        // Q17 --> Covariance: derived -> base, usually for producers/output.
        //       Contravariance: base -> derived, usually for consumers/input.

        // Q18 --> Static member in generic class: each specific type gets its own static copy.
        //       --> public static int Count;

        // Q19 --> Generic Inheritance: a class can inherit by a specific type parameter.
        //       --> class Box<T>
        //       --> class IntBox : Box<int>
    }
}




