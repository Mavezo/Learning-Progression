﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class Context
    {
        Dictionary<string, int> variables = new Dictionary<string, int>();
        public int GetVariable(string name)
        {
            return variables[name];
        }

        public void SetVariable(string name, int value)
        {
            if (variables.ContainsKey(name))
            {
                variables[name] = value;
            }
            else variables.Add(name, value);
        }
    }
}
