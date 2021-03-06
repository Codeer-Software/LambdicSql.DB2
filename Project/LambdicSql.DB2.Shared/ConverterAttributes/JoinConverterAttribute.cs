﻿using LambdicSql.BuilderServices.CodeParts;
using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using System.Linq.Expressions;
using static LambdicSql.DB2.Inside.PartsUtils;

namespace LambdicSql.DB2.ConverterAttributes
{
    /// <summary>
    /// Converter for XXX JOIN clause conversion.
    /// </summary>
    public class JoinConverterAttribute : MethodConverterAttribute
    {
        ICode _nameCode;
        string _name;

        /// <summary>
        /// Name.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                _nameCode = value.ToCode();
            }
        }

        /// <summary>
        /// Convert expression to code.
        /// </summary>
        /// <param name="expression">Expression.</param>
        /// <param name="converter">Expression converter.</param>
        /// <returns>Parts.</returns>
        public override ICode Convert(MethodCallExpression expression, ExpressionConverter converter)
        {
            //TODO これちょっとおかしい
            var startIndex = expression.SkipMethodChain(0);
            var table = FromConverterAttribute.ConvertTable(converter, expression.Arguments[startIndex]);
            if (table.IsEmpty) return string.Empty.ToCode();

            var condition = ((startIndex + 1) < expression.Arguments.Count) ? converter.ConvertToCode(expression.Arguments[startIndex + 1]) : null;

            var join = new HCode() { AddIndentNewLine = true, Separator = " ", Indent = 1 };
            join.Add(_nameCode);
            join.Add(table);
            if (condition != null)
            {
                join.Add("ON".ToCode());
                join.Add(condition);
            }
            return join;
        }
    }
}
