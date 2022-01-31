// <auto-generated/>
#pragma warning disable
using Marten.Internal.CompiledQueries;
using Marten.Linq;
using Marten.Linq.QueryHandlers;
using Marten.Testing.Linq.Compiled;
using System;

namespace Marten.Generated.DocumentStorage
{
    // START: UserNameContainsInsensitiveCompiledQuery1912749890
    public class UserNameContainsInsensitiveCompiledQuery1912749890 : Marten.Internal.CompiledQueries.ClonedCompiledQuery<System.Collections.Generic.IEnumerable<Marten.Testing.Documents.User>, Marten.Testing.Linq.Compiled.compiled_query_by_string_fragments.UserNameContainsInsensitive>
    {
        private readonly Marten.Linq.QueryHandlers.IMaybeStatefulHandler _inner;
        private readonly Marten.Testing.Linq.Compiled.compiled_query_by_string_fragments.UserNameContainsInsensitive _query;
        private readonly Marten.Linq.QueryStatistics _statistics;
        private readonly Marten.Internal.CompiledQueries.HardCodedParameters _hardcoded;

        public UserNameContainsInsensitiveCompiledQuery1912749890(Marten.Linq.QueryHandlers.IMaybeStatefulHandler inner, Marten.Testing.Linq.Compiled.compiled_query_by_string_fragments.UserNameContainsInsensitive query, Marten.Linq.QueryStatistics statistics, Marten.Internal.CompiledQueries.HardCodedParameters hardcoded) : base(inner, query, statistics, hardcoded)
        {
            _inner = inner;
            _query = query;
            _statistics = statistics;
            _hardcoded = hardcoded;
        }



        public override void ConfigureCommand(Weasel.Postgresql.CommandBuilder builder, Marten.Internal.IMartenSession session)
        {
            var parameters = builder.AppendWithParameters(@"select d.id, d.data from public.mt_doc_user as d where d.data ->> 'UserName' ILIKE ?");

            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;
            parameters[0].Value = ContainsString(_query.Fragment);
        }

    }

    // END: UserNameContainsInsensitiveCompiledQuery1912749890
    
    
    // START: UserNameContainsInsensitiveCompiledQuerySource1912749890
    public class UserNameContainsInsensitiveCompiledQuerySource1912749890 : Marten.Internal.CompiledQueries.CompiledQuerySource<System.Collections.Generic.IEnumerable<Marten.Testing.Documents.User>, Marten.Testing.Linq.Compiled.compiled_query_by_string_fragments.UserNameContainsInsensitive>
    {
        private readonly Marten.Internal.CompiledQueries.HardCodedParameters _hardcoded;
        private readonly Marten.Linq.QueryHandlers.IMaybeStatefulHandler _maybeStatefulHandler;

        public UserNameContainsInsensitiveCompiledQuerySource1912749890(Marten.Internal.CompiledQueries.HardCodedParameters hardcoded, Marten.Linq.QueryHandlers.IMaybeStatefulHandler maybeStatefulHandler)
        {
            _hardcoded = hardcoded;
            _maybeStatefulHandler = maybeStatefulHandler;
        }



        public override Marten.Linq.QueryHandlers.IQueryHandler<System.Collections.Generic.IEnumerable<Marten.Testing.Documents.User>> BuildHandler(Marten.Testing.Linq.Compiled.compiled_query_by_string_fragments.UserNameContainsInsensitive query, Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.UserNameContainsInsensitiveCompiledQuery1912749890(_maybeStatefulHandler, query, null, _hardcoded);
        }

    }

    // END: UserNameContainsInsensitiveCompiledQuerySource1912749890
    
    
}
