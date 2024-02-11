using System.Data.Common;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Text.RegularExpressions;
using Havesh.Model.Contract;
using Havesh.Model.Data;
using Havesh.Model.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TSQL;
using TSQL.Tokens;

namespace Havesh.Model.Interceptors;
public class CustomQueryInterceptor : DbCommandInterceptor
{
    private readonly IConfiguration _configuration;
    private readonly IServiceProvider _provider;
    private readonly User? _actor;

    public CustomQueryInterceptor(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public override InterceptionResult<int> NonQueryExecuting(DbCommand command, CommandEventData eventData, InterceptionResult<int> result)
    {
        return base.NonQueryExecuting(command, eventData, result);
    }
    string InjectConditionToSqlCommand(string sql, string condition, string whereOp = "AND")
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(sql);
        Console.WriteLine("***************************************************************************");

        var tsqlTokens = TSQLTokenizer.ParseTokens(sql);
        var whereTokens = tsqlTokens.Where(t => t.IsKeyword(TSQLKeywords.WHERE)).ToArray();

        var sb = new List<string>();
        var st = 0;
        var i = 0;
        foreach (var token in whereTokens)
        {
            var nextKeywordToken = (
                from x in tsqlTokens
                where x.BeginPosition > token.EndPosition
                let xAsKeyword = x.AsKeyword
                where xAsKeyword != null &&
                      !xAsKeyword.IsKeyword(TSQLKeywords.AND) &&
                      !xAsKeyword.IsKeyword(TSQLKeywords.OR) &&
                      !xAsKeyword.IsKeyword(TSQLKeywords.BETWEEN)
                select x).FirstOrDefault();

            var value = "";
            string part1 = null;
            string part2 = null;
            if (nextKeywordToken == null)
            {
                part1 = sql[st..(token.EndPosition + 1)];
                value = sql[(token.EndPosition + 1)..];
                st = sql.Length;
            }
            else
            {
                part1 = sql[st..(token.EndPosition + 1)];
                value = sql.Substring(token.EndPosition + 1, nextKeywordToken.BeginPosition - token.EndPosition - 1);
                st = nextKeywordToken.BeginPosition;
                if (whereTokens.Last() == token)
                {
                    part2 = sql.Substring(nextKeywordToken.BeginPosition);
                }
            }

            sb.Add(part1);
            sb.Add(value + $" {whereOp.ToUpper()} {condition} ");
            sb.Add(part2);

            i++;
        }

        return string.Join(' ', sb);

    }

    public override InterceptionResult<DbDataReader> ReaderExecuting(
        DbCommand command,
        CommandEventData eventData,
        InterceptionResult<DbDataReader> result)
    {
        var dbContext = (MyDbContext)eventData.Context;
        //var user1 = dbContext.UserSessionService.GetUserOrLoadAsync().GetAwaiter().GetResult();
        var user = dbContext.Actor;

        if (user is null || bool.TryParse(_configuration["ActiveBCode"], out var demo) is false || demo == false)
            return base.ReaderExecuting(command, eventData, result);

        if (eventData.Context?.Model == null)
            return base.ReaderExecuting(command, eventData, result);


        var tuple = ParseSchemaAndTableName(command.CommandText);

        var clrTypeForTable = GetClrTypeForTable(tuple.Schema, tuple.TableName, eventData.Context.Model);
        var excludeTypes = new[] { typeof(ShokouhPardisYearClass) };
        if (!excludeTypes.Contains(clrTypeForTable)
            && clrTypeForTable.BaseType == typeof(BranchBaseModel))
        {
            if (!string.IsNullOrEmpty(user.BCode))
            {
                var BcodeValue = user.BCode;
                command.CommandText = InjectConditionToSqlCommand(command.CommandText, $"BCode LIKE N'{BcodeValue}%' ");
            }
        }

        return base.ReaderExecuting(command, eventData, result);
    }

    private (string Schema, string TableName) ParseSchemaAndTableName(string sqlQuery)
    {
        // Define a regular expression to match the schema and table name in the FROM clause.
        if (sqlQuery.StartsWith("SELECT", StringComparison.OrdinalIgnoreCase))
        {
            var fromPattern = @"FROM\s+\[([^\]]*)\]\.\[([^\]]*)\]";
            var match = Regex.Match(sqlQuery, fromPattern, RegexOptions.IgnoreCase);

            if (match.Success)
            {
                // Extract the schema and table name from the matched groups.
                string schema = match.Groups[1].Value;
                string tableName = match.Groups[2].Value;
                return (schema, tableName);
            }

        }
        else if (sqlQuery.Contains("UPDATE", StringComparison.OrdinalIgnoreCase))
        {
            var updatePattern = @"UPDATE\s+\[([^\]]*)\]\.\[([^\]]*)\]";
            var match = Regex.Match(sqlQuery, updatePattern, RegexOptions.IgnoreCase);

            if (match.Success)
            {
                // Extract the schema and table name from the matched groups.
                string schema = match.Groups[1].Value;
                string tableName = match.Groups[2].Value;
                return (schema, tableName);
            }

        }
        else if (sqlQuery.Contains("INSERT INTO", StringComparison.OrdinalIgnoreCase))
        {
            var insertPattern = @"INSERT INTO\s+\[([^\]]*)\]\.\[([^\]]*)\]";
            var match = Regex.Match(sqlQuery, insertPattern, RegexOptions.IgnoreCase);

            if (match.Success)
            {
                // Extract the schema and table name from the matched groups.
                string schema = match.Groups[1].Value;
                string tableName = match.Groups[2].Value;
                return (schema, tableName);
            }

        }

        // If no match is found, return null or handle the case accordingly.
        throw new InvalidOperationException("Schema and table name not found in the query.");
    }

    public Type GetClrTypeForTable(string schema, string tableName, IModel model)
    {


        foreach (IEntityType entityType in model.GetEntityTypes())
        {
            var tableSchema = entityType.GetSchema();
            var tbl = entityType.GetTableName();

            if (string.Equals(tableSchema, schema, StringComparison.OrdinalIgnoreCase)
                && string.Equals(tableName, tbl, StringComparison.OrdinalIgnoreCase))
            {
                return entityType.ClrType;
            }
        }

        return null; // Table not found
    }


}