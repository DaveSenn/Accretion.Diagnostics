﻿using Microsoft.CodeAnalysis.CSharp;

namespace Accretion.Diagnostics.ExpressionLogger
{
    internal static class Identifiers
    {
        public const string LogMethodName = "Log";
        public const string ExpressionLoggerClassName = "ExpressionLogger";
        public const string ExpressionLoggerClassNamespace = "Accretion.Diagnostics.ExpressionLogger";
        public const string FullyQualifiedLogMethodName = ExpressionLoggerClassNamespace + "." + ExpressionLoggerClassName + "." + LogMethodName;

        public const string ExpressionParameterName = "expression";
        public const string LineNumberParameterName = "lineNumber";
        public const string FilePathParameterName = "filePath";
        public const string MemberNameParameterName = "member";

        public static string AsLiteral(this string source) => 
            SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(source ?? "null")).ToString();
    }
}
