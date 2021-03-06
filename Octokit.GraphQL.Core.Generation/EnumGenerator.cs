﻿using System;
using System.Globalization;
using System.Text;
using Octokit.GraphQL.Core.Utilities;
using Octokit.GraphQL.Core.Generation.Models;
using Octokit.GraphQL.Core.Generation.Utilities;

namespace Octokit.GraphQL.Core.Generation
{
    public static class EnumGenerator
    {
        public static string Generate(TypeModel type, string rootNamespace)
        {
            var enumName = TypeUtilities.GetClassName(type);

            return $@"using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace {rootNamespace}
{{
    {GenerateDocComments(type)}[JsonConverter(typeof(StringEnumConverter))]
    public enum {enumName}
    {{{GenerateEnumValues(type)}    }}
}}";
        }

        private static string GenerateDocComments(TypeModel type)
        {
            if (!string.IsNullOrWhiteSpace(type.Description))
            {
                return $@"/// <summary>
    /// {type.Description}
    /// </summary>
    ";
            }
            else
            {
                return null;
            }
        }

        private static string GenerateDocComments(EnumValueModel value)
        {
            if (!string.IsNullOrWhiteSpace(value.Description))
            {
                return $@"        /// <summary>
        /// {value.Description}
        /// </summary>
";
            }
            else
            {
                return null;
            }
        }

        private static string GenerateEnumValues(TypeModel type)
        {
            var builder = new StringBuilder();

            if (type.EnumValues?.Count > 0)
            {
                foreach (var value in type.EnumValues)
                {
                    builder.AppendLine();
                    builder.Append(GenerateDocComments(value));
                    builder.AppendLine(GenerateEnumValue(value));
                }
            }
            else
            {
                builder.AppendLine();
            }

            return builder.ToString();
        }

        private static string GenerateEnumValue(EnumValueModel value)
        {
            return $@"        [EnumMember(Value = ""{value.Name}"")]
        {value.Name.SnakeCaseToPascalCase()},";
        }
    }
}
