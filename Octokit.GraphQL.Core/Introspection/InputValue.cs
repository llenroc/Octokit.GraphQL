﻿using System;
using System.Linq;
using Octokit.GraphQL.Core.Builders;

namespace Octokit.GraphQL.Core.Introspection
{
    public class InputValue : QueryEntity
    {
        public InputValue(IQueryProvider provider)
            : base(provider)
        {
        }

        public string Name { get; }
        public string Description { get; }
        public SchemaType Type => this.CreateProperty(x => x.Type, SchemaType.Create);
        public string DefaultValue { get; }
    }
}
