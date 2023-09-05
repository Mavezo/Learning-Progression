using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class NumberExpression : IExpression
    {
        string name;
        public NumberExpression(string variableName)
        {
            name = variableName;
        }
        public int Interpret(Context context)
        {
            return context.GetVariable(name);
        }
    }
}
