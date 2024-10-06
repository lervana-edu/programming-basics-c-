namespace Task_2_9;

// Create a program that displays the truth tables below, the result of each calculation is to be written
// as a logical operation. The task can only use such elements as: variables, Console.WriteLine, logical
// operators and Convert.ToInt32:
// a) a∨b
// b) a∧b
// c) (∼a∨c)∨(∼b∨c)
// d) [(∼a∨∼c)∨(∼a∨ b)]∧∼b
// e) [(∼a∧∼b)∨(a∧ b)]∨(a∧∼c)

class Program
{
    static void Main(string[] args)
    {
        bool a, b, c;

        // a) a OR b
        Console.WriteLine("Truth Table for a OR b:");
        Console.WriteLine("| a | b | a ∨ b |");
        Console.WriteLine("------------------");
        foreach (var values in new[] { (false, false), (false, true), (true, false), (true, true) })
        {
            a = values.Item1;
            b = values.Item2;
            Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} | {Convert.ToInt32(a || b)} |");
        }

        Console.WriteLine("\n");

        // b) a AND b
        Console.WriteLine("Truth Table for a AND b:");
        Console.WriteLine("| a | b | a ∧ b |");
        Console.WriteLine("------------------");
        foreach (var values in new[] { (false, false), (false, true), (true, false), (true, true) })
        {
            a = values.Item1;
            b = values.Item2;
            Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} | {Convert.ToInt32(a && b)} |");
        }

        Console.WriteLine("\n");

        // c) (~a OR c) OR (~b OR c)
        Console.WriteLine("Truth Table for (~a OR c) OR (~b OR c):");
        Console.WriteLine("| a | b | c | (~a ∨ c) ∨ (~b ∨ c) |");
        Console.WriteLine("------------------------------------");
        foreach (var values in new[] { (false, false, false), (false, false, true), (false, true, false), (false, true, true), (true, false, false), (true, false, true), (true, true, false), (true, true, true) })
        {
            a = values.Item1;
            b = values.Item2;
            c = values.Item3;
            bool result = (!a || c) || (!b || c);
            Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} | {Convert.ToInt32(c)} | {Convert.ToInt32(result)} |");
        }

        Console.WriteLine("\n");

        // d) [(~a OR ~c) OR (~a OR b)] AND ~b
        Console.WriteLine("Truth Table for [(~a OR ~c) OR (~a OR b)] AND ~b:");
        Console.WriteLine("| a | b | c | [(~a ∨ ~c) ∨ (~a ∨ b)] ∧ ~b |");
        Console.WriteLine("-------------------------------------------");
        foreach (var values in new[] { (false, false, false), (false, false, true), (false, true, false), (false, true, true), (true, false, false), (true, false, true), (true, true, false), (true, true, true) })
        {
            a = values.Item1;
            b = values.Item2;
            c = values.Item3;
            bool result = ((!a || !c) || (!a || b)) && !b;
            Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} | {Convert.ToInt32(c)} | {Convert.ToInt32(result)} |");
        }

        Console.WriteLine("\n");

        // e) [(~a AND ~b) OR (a AND b)] OR (a AND ~c)
        Console.WriteLine("Truth Table for [(~a ∧ ~b) ∨ (a ∧ b)] ∨ (a ∧ ~c):");
        Console.WriteLine("| a | b | c | [(~a ∧ ~b) ∨ (a ∧ b)] ∨ (a ∧ ~c) |");
        Console.WriteLine("-----------------------------------------------");
        foreach (var values in new[] { (false, false, false), (false, false, true), (false, true, false), (false, true, true), (true, false, false), (true, false, true), (true, true, false), (true, true, true) })
        {
            a = values.Item1;
            b = values.Item2;
            c = values.Item3;
            bool result = ((!a && !b) || (a && b)) || (a && !c);
            Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} | {Convert.ToInt32(c)} | {Convert.ToInt32(result)} |");
        }
    }
}