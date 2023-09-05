using Interpreter;
using System.Reflection.Metadata;

//  Develop a program to calculate
//  the simplest addition and subtraction operations with the help of
//  variables: x + y - z.For this purpose, we can define the following
//  grammar:

//  IExpression::= NumberExpression | Constant | AddExpression |
//  SubtractExpression
//  AddExpression::= IExpression + IExpression
//  SubtractExpression::= IExpression - IExpression
//  NumberExpression::= [A - Z, a - z] +
//  Constant::= [1 - 9] +

int x = 5;
int y = 6;
int z = 7;

Context context = new Context();
context.SetVariable("x", x);
context.SetVariable("y", y);
context.SetVariable("z", z);
// x + y - z
// 5 + 6 - 7 = 4

IExpression expression1 = new SubtractExpression(
    new AddExpression(
        new NumberExpression("x"),
        new NumberExpression("y")),
    new NumberExpression("z"));

IExpression expression2 = new AddExpression(
   new NumberExpression("x"),
   new SubtractExpression(
       new NumberExpression("y"), 
       new NumberExpression("z")));

Console.WriteLine(expression1.Interpret(context));
Console.WriteLine(expression2.Interpret(context));
