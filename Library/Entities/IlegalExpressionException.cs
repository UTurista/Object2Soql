﻿using System;
using System.Linq.Expressions;

namespace Object2Soql.Entities
{
    public class IlegalExpressionException:Exception
    {
        public ExpressionType ExpressionType { get; }

        public IlegalExpressionException(ExpressionType expressionType):base($"The expression type '{expressionType}' is not supported!")
        {
            ExpressionType = expressionType;
        }
    }
}
