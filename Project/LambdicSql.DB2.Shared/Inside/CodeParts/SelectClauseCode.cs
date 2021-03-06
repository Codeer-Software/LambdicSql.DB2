﻿using LambdicSql.BuilderServices;
using LambdicSql.BuilderServices.CodeParts;

namespace LambdicSql.DB2.Inside.CodeParts
{
    class SelectClauseCode : ITopQueryCode
    {
        public ICode Core { get; }

        internal SelectClauseCode(ICode core)
        {
            Core = core;
        }

        public bool IsEmpty => Core.IsEmpty;

        public bool IsSingleLine(BuildingContext context) => Core.IsSingleLine(context);

        public string ToString(BuildingContext context) => Core.ToString(context);

        public ICode Accept(ICodeCustomizer customizer)
        {
            var dst = customizer.Visit(this);
            if (!ReferenceEquals(this, dst)) return dst;
            return new SelectClauseCode(Core.Accept(customizer));
        }

        public ITopQueryCode Create(ICode core)
            => new SelectQueryCode(core);
    }
}
