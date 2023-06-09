using System.Numerics;


public class Fibonacci
{
    public class IsNotIntegerNumberException : Exception
    {
        public IsNotIntegerNumberException(String message) : base(message) { }
    }
    public class OverflowException : Exception
    {
        public OverflowException(String message) : base(message) { }
    }
    public class IsNotPositiveIntegerNumberException : Exception
    {
        public IsNotPositiveIntegerNumberException(String message) : base(message) { }
    }
    public static BigInteger fibonacci(int a)
    {
        if (a < 0)
        {
            throw new IsNotPositiveIntegerNumberException("El numero no puede ser negativo");
        }
        if (a <= 1)
        {
            return a;
        }
        BigInteger v2 = 1;
        BigInteger v1 = 0;
        for (int i = 1; i < a; i++)
        {
            BigInteger temp = v1;
            v1 = v2;
            v2 = temp + v1;
        }
        return v2;




        //LA FUNCION RECURSIVA TIENE TIEMPO COMPUTACIONAL EXPONENCIAL (Por eso se usa un metodo iterativo)


        //if (a < 2){
        //    return 1;
        //}
        //else{
        //    return fibonacci(a-1) + fibonacci(a-2)
        //}
    }
    public static BigInteger fibonacci(string a)
    {
        try
        {
            return fibonacci(int.Parse(a));
        }
        catch (ArgumentException)
        {
            throw new IsNotIntegerNumberException("El dato ingresado no es un numero");
        }
        catch (FormatException)
        {
            throw new IsNotIntegerNumberException("El dato ingresado no es un numero");
        }
        catch (System.OverflowException)
        {
            throw new Fibonacci.OverflowException("El numero es demasiado grande para una variable tipo \"int\" " +
                "\n  [-2,147,483,648 (-2^31) hasta 2,147,483,647 (2^31 - 1)] ");
        }
    }
}
