﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Octokit.GraphQL.Core;
using Octokit.GraphQL.Core.Builders;
using Octokit.GraphQL.Core.Utilities;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Octokit.GraphQL.UnitTests
{
    public class ExpressionRewiterTests
    {
        [Fact]
        public void RepositoryOwner_Repository_Query()
        {
            var expression = new Query()
                .RepositoryOwner("foo")
                .Repository("bar")
                .Select((Repository x) => new
                {
                    x.Id,
                    x.Name,
                    Owner = x.Owner.Select(o => new
                    {
                        o.Login
                    }),
                    x.IsFork,
                    x.IsPrivate,
                });

            Expression<Func<JObject, IEnumerable<object>>> expected = data =>
                ExpressionMethods.SelectEntity(
                    data["data"]["repositoryOwner"]["repository"],
                    x => new
                    {
                        Id = x["id"].ToObject<string>(),
                        Name = x["name"].ToObject<string>(),
                        Owner = ExpressionMethods.SelectEntity(x["owner"], o => new { Login = o["login"].ToObject<string>() }),
                        IsFork = x["isFork"].ToObject<string>(),
                        IsPrivate = x["isPrivate"].ToObject<string>(),
                    });

            var query = new QueryBuilder().Build(expression);
            Assert.Equal(expected.ToString(), query.Expression.ToString());
        }

        [Fact]
        public void RepositoryOwner_Repositories_Query()
        {
            var expression = new Query()
                .RepositoryOwner(login: "foo")
                .Repositories(first: 30)
                .Edges
                .Select(x => x.Node)
                .Select(x => new
                {
                    x.Id,
                    x.Name,
                    Owner = x.Owner.Select(o => new
                    {
                        o.Login
                    }),
                    x.IsFork,
                    x.IsPrivate,
                });

            Expression<Func<JObject, IEnumerable<object>>> expected = data =>
                ExpressionMethods.Select(
                    ExpressionMethods.SelectEntity(
                        data["data"]["repositoryOwner"]["repositories"]["edges"],
                        x => x["node"]),
                    x => new
                    {
                        Id = x["id"].ToObject<string>(),
                        Name = x["name"].ToObject<string>(),
                        Owner = ExpressionMethods.SelectEntity(x["owner"], o => new { Login = o["login"].ToObject<string>() }),
                        IsFork = x["isFork"].ToObject<string>(),
                        IsPrivate = x["isPrivate"].ToObject<string>(),
                    });

            var query = new QueryBuilder().Build(expression);
            Assert.Equal(expected.ToString(), query.Expression.ToString());
        }

        [Fact(Skip = "Not yet working")]
        public void Search_User_Name_Via_Edges()
        {
            var expression = new Query()
                .Search("foo", SearchType.User, 30)
                .Edges.Select(x => x.Node)
                .Select(x => x.User.Name);

            Expression<Func<JObject, IEnumerable<object>>> expected = data =>
                ExpressionMethods.Select(
                    ExpressionMethods.ChildrenOfType(data["data"]["search"]["edges"], "User"),
                    x => x["name"].ToObject<string>());

            var query = new QueryBuilder().Build(expression);
            Assert.Equal(expected.ToString(), query.Expression.ToString());
        }
    }
}
