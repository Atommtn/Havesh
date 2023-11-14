using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Text.RegularExpressions;
using Havesh.Model.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Havesh.Model.Interceptors;
public class CustomQueryInterceptor : DbCommandInterceptor
{
    public override InterceptionResult<int> NonQueryExecuting(DbCommand command, CommandEventData eventData, InterceptionResult<int> result)
    {
        return base.NonQueryExecuting(command, eventData, result);
    }

    public override InterceptionResult<DbDataReader> ReaderExecuting(
        DbCommand command,
        CommandEventData eventData,
        InterceptionResult<DbDataReader> result)
    {
        // Check if the SQL command contains a WHERE clause.
        var regex = new Regex(@"\bWHERE\b", RegexOptions.IgnoreCase);
        var hasWhere = regex.IsMatch(command.CommandText);

        // Define your custom WHERE condition.
        var customCondition = "IsDeleted = 0";
        var tuple = ParseSchemaAndTableName(command.CommandText);

        if (eventData.Context?.Model != null)
        {
            var clrTypeForTable = GetClrTypeForTable(tuple.Schema, tuple.TableName, eventData.Context.Model);
            if (clrTypeForTable.IsAssignableFrom(typeof(BranchBaseModel)))
            {

            }
        }

        /*// Append your custom WHERE condition appropriately based on the existing SQL.
        if (hasWhere)
        {
            command.CommandText = regex.Replace(command.CommandText, $"WHERE {customCondition} AND");
        }
        else
        {
            // You can choose the appropriate location for the WHERE condition based on your query.
            // For example, you can place it after the last JOIN clause.
            command.CommandText = command.CommandText.Replace("JOIN", $"JOIN {customCondition} WHERE");
            // Or, place it after the GROUP BY or ORDER BY clauses if necessary.
        }*/

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