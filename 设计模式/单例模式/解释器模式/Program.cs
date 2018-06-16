using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 解释器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator("1+2+3");
            Console.WriteLine(calculator.Calculate());
            Console.ReadKey();
        }
    }
    /// <summary>
    /// 环境
    /// </summary>
    public class Context
    {
        #region  Dictionary
        private Dictionary<char, double> variable;
        public Dictionary<char, double> Variable
        {
            get
            {
                if (this.variable == null)
                {
                    this.variable = new Dictionary<char, double>();
                }
                return this.variable;
            }
        }
        #endregion
    }

    /// <summary>
    /// 抽象表达式
    /// </summary>
    public abstract class Expression
    {
        public abstract double Interpret(Context context);
    }

    /// <summary>
    /// 变量，终结符表达式
    /// </summary>
    public class VariableExpression : Expression
    {
        private char key;
        public VariableExpression(char key)
        {
            this.key = key;
        }
        /// <summary>
        /// 获取double
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override double Interpret(Context context)
        {
            return context.Variable[this.key];
        }
    }

    /// <summary>
    /// 操作符，非终结符表达式
    /// </summary>
    public abstract class OperatorExpression : Expression
    {
        protected Expression left;
        protected Expression right;

        public OperatorExpression(Expression left, Expression right)
        {
            this.left = left;
            this.right = right;
        }
    }

    public class AddExpression : OperatorExpression
    {
        public AddExpression(Expression left, Expression right)
            : base(left, right)
        {

        }

        public override double Interpret(Context context)
        {
            return this.left.Interpret(context) + this.right.Interpret(context);
        }
    }

    public class SubExpression : OperatorExpression
    {
        public SubExpression(Expression left, Expression right)
            : base(left, right)
        {

        }

        public override double Interpret(Context context)
        {
            return this.left.Interpret(context) - this.right.Interpret(context);
        }
    }

    public class MulExpression : OperatorExpression
    {
        public MulExpression(Expression left, Expression right)
            : base(left, right)
        {

        }

        public override double Interpret(Context context)
        {
            return this.left.Interpret(context) * this.right.Interpret(context);
        }
    }

    public class DivExpression : OperatorExpression
    {
        public DivExpression(Expression left, Expression right)
            : base(left, right)
        {

        }

        public override double Interpret(Context context)
        {
            return this.left.Interpret(context) / this.right.Interpret(context);
        }
    }

    public class Calculator
    {
        private string expression;
        private Context context;

        public Calculator(string expression)
        {
            this.expression = expression;
            this.context = new Context();
        }

        public double Calculate()
        {
            char[] vars = this.expression.ToCharArray();
            foreach (char c in vars)
            {
                if (c == '+' || c == '-' || c == '*' || c == '/')
                {
                    continue;
                }
                if (!this.context.Variable.ContainsKey(c))
                {
                    Console.Write(c + "=");
                    this.context.Variable.Add(c, double.Parse(Console.ReadLine()));
                }
            }
            Expression left = new VariableExpression(vars[0]);
            Expression right = null;
            Stack<Expression> stack = new Stack<Expression>();
            stack.Push(left);
            for (int i = 1; i < vars.Length; i += 2)
            {
                left = stack.Pop();
                right = new VariableExpression(vars[i + 1]);
                switch (vars[i])
                {
                    case '+':
                        stack.Push(new AddExpression(left, right));
                        break;
                    case '-':
                        stack.Push(new SubExpression(left, right));
                        break;
                    case '*':
                        stack.Push(new MulExpression(left, right));
                        break;
                    case '/':
                        stack.Push(new DivExpression(left, right));
                        break;
                }
            }
            double value = stack.Pop().Interpret(this.context);
            stack.Clear();
            return value;
        }
    }
}
