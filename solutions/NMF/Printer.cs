using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using TTC2017.LiveContest.SimpleCodeDOM;

namespace TTC2017.LiveContest
{
    public class Printer
    {
        private int indent = 4;

        public void Print(Package p, string path)
        {
            using (var sw = new StreamWriter(path))
            {
                sw.WriteLine($"package {p.Name}:");
                sw.WriteLine();
                foreach (var t in p.Types.OrderBy(c => c.Name))
                {
                    PrintClass(t, sw);
                }
            }
        }

        public void Reset()
        {
            indent = 4;
        }

        private void PrintClass(IClass t, StreamWriter sw)
        {
            if (t.IsInterface)
            {
                sw.Write($"interface {t.Name}");
            }
            else
            {
                sw.Write($"class {t.Name}");
            }
            if (t.BaseTypes.Any())
            {
                sw.Write(" : " + string.Join(", ", t.BaseTypes.Select(Print)));
            }
            sw.WriteLine();
            foreach (var member in t.Members.OrderBy(m => m.Name))
            {
                PrintMember((dynamic)member, sw);
                sw.WriteLine();
            }
        }

        private string AbstractMark(bool isAbstract)
        {
            return isAbstract ? "abstract " : "";
        }

        private void PrintMember(IProperty property, StreamWriter sw)
        {
            sw.WriteLine($"  {AbstractMark(property.IsAbstract)}property {property.Name} : {Print(property.PropertyType)}");
            if (!property.IsAbstract)
            {
                sw.WriteLine($"    get: {PrintExpression((dynamic)property.Getter)}");
                sw.WriteLine($"    set: {PrintExpression((dynamic)property.Setter)}");
            }
        }

        private void PrintMember(IField field, StreamWriter sw)
        {
            sw.Write($"  field {field.Name} : {Print(field.FieldType)}");
            if (field.InitValue != null)
            {
                sw.Write(" = " + PrintExpression((dynamic)field.InitValue));
            }
        }

        private void PrintMember(IMethod method, StreamWriter sw)
        {
            sw.Write($"  {AbstractMark(method.IsAbstract)}method {method.Name}({string.Join(", ", method.Parameters.Select(Print))})");
            if (method.ReturnType != null)
            {
                sw.Write($" : {Print(method.ReturnType)}");
            }
            sw.WriteLine();
            if (!method.IsAbstract)
            {
                sw.WriteLine("    " + PrintExpression((dynamic)method.BodyExpression));
            }
        }

        private string PrintExpression(IsTypeExpression expression)
        {
            return PrintExpression((dynamic)expression.Inner) + " is " + Print(expression.Type);
        }

        private string PrintExpression(FieldReferenceExpression expression)
        {
            return PrintExpression((dynamic)expression.TargetObject) + "." + expression.FieldName;
        }

        private string PrintExpression(MethodInvokeExpression expression)
        {
            var prefix = "";
            if (expression.TargetObject != null)
            {
                prefix = PrintExpression((dynamic)expression.TargetObject) + ".";
            }
            return string.Concat(prefix, expression.MethodName, "(", string.Join(", ", expression.Arguments.Select(a => (string)PrintExpression((dynamic)a))), ")");
        }

        private string PrintExpression(ParameterReferenceExpression expression)
        {
            return expression.Parameter.Name;
        }

        private string PrintExpression(SetValueExpression expression)
        {
            return "value";
        }

        private string PrintExpression(ConditionalExpression expression)
        {
            return $"if {PrintExpression((dynamic)expression.Test)} then {PrintExpression((dynamic)expression.TrueExpression)} else {PrintExpression((dynamic)expression.FalseExpression)}";
        }

        private string PrintExpression(BinaryExpression expression)
        {
            return $"({PrintExpression((dynamic)expression.LeftOperand)} {GetOperatorSymbol(expression.Operator)} {PrintExpression((dynamic)expression.RightOperand)})";
        }

        private object GetOperatorSymbol(BinaryOperator @operator)
        {
            switch (@operator)
            {
                case BinaryOperator.Add:
                    return "+";
                case BinaryOperator.Subtract:
                    return "-";
                case BinaryOperator.Multiply:
                    return "*";
                case BinaryOperator.Divide:
                    return "/";
                case BinaryOperator.Equals:
                    return "==";
                case BinaryOperator.NotEquals:
                    return "!=";
                case BinaryOperator.GreatherThan:
                    return ">";
                case BinaryOperator.LessThan:
                    return "<";
                case BinaryOperator.GreatherThanOrEqual:
                    return ">=";
                case BinaryOperator.LessThanOrEqual:
                    return "<=";
                case BinaryOperator.Assign:
                    return "=";
                default:
                    return null;
            }
        }

        private string PrintExpression(IntegerLiteralExpression expression)
        {
            return expression.Value.ToString();
        }

        private string PrintExpression(ExpressionBlock expression)
        {
            var sb = new StringBuilder();
            sb.AppendLine("{");
            indent += 2;
            foreach (var exp in expression.Inner)
            {
                sb.Append(new string(' ', indent));
                sb.AppendLine(PrintExpression((dynamic)exp));
            }
            indent -= 2;
            sb.Append(new string(' ', indent));
            sb.Append("}");
            return sb.ToString();
        }

        private string PrintExpression(NullReferenceException expression)
        {
            return "null";
        }

        private string PrintExpression(BooleanLiteralExpression expression)
        {
            return expression.Value ? "true" : "false";
        }

        private string PrintExpression(ThisReferenceExpression expression)
        {
            return "this";
        }

        private string PrintExpression(StringLiteralExpression expression)
        {
            return "'" + expression.Value + "'";
        }

        private string Print(ITypeReference typeReference)
        {
            var suffix = "";
            if (typeReference.GenericTypeArguments.Count > 0)
            {
                suffix = "<" + string.Join(", ", typeReference.GenericTypeArguments.Select(Print)) + ">";
            }
            return typeReference.BaseName + suffix;
        }

        private string Print(IParameter parameter)
        {
            return $"{parameter.Name} : {Print(parameter.Type)}";
        }
    }
}
