

namespace simplemathevaluator
{
    internal class Program
    {
        #region Main 
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter Operation You Want To Do");
                var expr = ExpressionParser.Parse(Console.ReadLine());
                Console.WriteLine($"Left side oprand = {expr.LeftSideOprand} Operator = {expr.Operation} Right side oprand {expr.RightSideOprand}");
                switch (expr.Operation)
                {
                    case MathOperation.Addition:
                        Console.WriteLine($"{expr.LeftSideOprand}+{expr.RightSideOprand}={expr.RightSideOprand + expr.LeftSideOprand}");
                        break;
                    case MathOperation.Subtraction:
                        Console.WriteLine($"{expr.LeftSideOprand}-{expr.RightSideOprand}={expr.RightSideOprand - expr.LeftSideOprand}");
                        break;
                    case MathOperation.Division:
                        Console.WriteLine($"{expr.LeftSideOprand}/{expr.RightSideOprand}={expr.RightSideOprand / expr.LeftSideOprand}");
                        break;
                    case MathOperation.Modulus:
                        Console.WriteLine($"{expr.LeftSideOprand}%{expr.RightSideOprand}={expr.RightSideOprand % expr.LeftSideOprand}");
                        break;
                    case MathOperation.Multiplication:
                        Console.WriteLine($"{expr.LeftSideOprand}*{expr.RightSideOprand}={expr.RightSideOprand * expr.LeftSideOprand}");
                        break;

                }
            }
        }
    }
    #endregion

        #region Parser
    public static class ExpressionParser
    {
        private static string MathSynbols = "*+/%^";
        static bool LeftSide = false;
        public static string token = "";
        public static MathExpression Parse(string input)
        {
            var expr = new MathExpression(); expr.Operation = MathOperation.None; int i = -1;
            foreach (char currentchar in input)
            {
                i++;

                if (char.IsDigit(currentchar))
                {

                    if (((expr.Operation == MathOperation.None)) && LeftSide)
                    {
                        expr.Operation = ParseMethodOperation(token.ToString().Trim().ToLower()); token = "";

                    }

                    token += currentchar;
                }
                else if (MathSynbols.Contains(currentchar))
                {
                    if (!LeftSide)
                    {
                        expr.LeftSideOprand = double.Parse(token);
                        LeftSide = true;
                    }
                    token = "";
                    expr.Operation = ParseMethodOperation(currentchar.ToString());
                }
                else if (currentchar == ' ') { }
                else if (currentchar == '-')
                {
                    if (i > 0 && !LeftSide)
                    {
                        expr.LeftSideOprand = double.Parse(token);
                        token = "";
                        LeftSide = true;
                        if (expr.Operation == MathOperation.None)
                            expr.Operation = ParseMethodOperation(currentchar.ToString());
                    }
                    else
                    {
                        token += currentchar;
                    }
                }
                else if (char.IsLetter(currentchar))
                {
                    if (!LeftSide)
                    {
                        expr.LeftSideOprand = double.Parse(token);
                        token = "";
                        LeftSide = true;
                    }
                    token += currentchar;
                }
            }
            expr.RightSideOprand = double.Parse(token);
            return expr;
        }
        static MathOperation ParseMethodOperation(string currentchar)
        {
            switch (currentchar.ToLower())
            {
                case "+":
                    return MathOperation.Addition;
                case "-":
                    return MathOperation.Subtraction;
                case "*":
                    return MathOperation.Multiplication;
                case "/":
                    return MathOperation.Division;
                case "%":
                case "mod":
                    return MathOperation.Modulus;
                case "^":
                case "pow":
                    return MathOperation.Power;
                case "sin":
                    return MathOperation.Sin;
                case "cos":
                    return MathOperation.Cos;
                case "tan":
                    return MathOperation.Tan;
                default:
                    return MathOperation.None;
            }
        }
    }
    #endregion

        #region enumrator for oprations
    public enum MathOperation
    {
        None,
        Addition,
        Subtraction,
        Multiplication,
        Division,
        Modulus,
        Power,
        Sin,
        Cos,
        Tan
    }
    #endregion
}
