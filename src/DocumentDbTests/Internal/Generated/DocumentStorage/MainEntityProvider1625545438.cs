// <auto-generated/>
#pragma warning disable
using DocumentDbTests.Bugs;
using Marten.Internal;
using Marten.Internal.Storage;
using Marten.Schema;
using Marten.Schema.Arguments;
using Npgsql;
using System;
using System.Collections.Generic;
using Weasel.Core;
using Weasel.Postgresql;

namespace Marten.Generated.DocumentStorage
{
    // START: UpsertMainEntityOperation1625545438
    public class UpsertMainEntityOperation1625545438 : Marten.Internal.Operations.StorageOperation<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity, long>
    {
        private readonly DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity _document;
        private readonly long _id;
        private readonly System.Collections.Generic.Dictionary<long, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpsertMainEntityOperation1625545438(DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document, long id, System.Collections.Generic.Dictionary<long, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_upsert_bug_717_permutation_of_linq_queries_mainentity(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Bigint;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Bigint;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }


        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Upsert;
        }

    }

    // END: UpsertMainEntityOperation1625545438
    
    
    // START: InsertMainEntityOperation1625545438
    public class InsertMainEntityOperation1625545438 : Marten.Internal.Operations.StorageOperation<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity, long>
    {
        private readonly DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity _document;
        private readonly long _id;
        private readonly System.Collections.Generic.Dictionary<long, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public InsertMainEntityOperation1625545438(DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document, long id, System.Collections.Generic.Dictionary<long, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_insert_bug_717_permutation_of_linq_queries_mainentity(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Bigint;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Bigint;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }


        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Insert;
        }

    }

    // END: InsertMainEntityOperation1625545438
    
    
    // START: UpdateMainEntityOperation1625545438
    public class UpdateMainEntityOperation1625545438 : Marten.Internal.Operations.StorageOperation<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity, long>
    {
        private readonly DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity _document;
        private readonly long _id;
        private readonly System.Collections.Generic.Dictionary<long, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpdateMainEntityOperation1625545438(DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document, long id, System.Collections.Generic.Dictionary<long, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_update_bug_717_permutation_of_linq_queries_mainentity(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Bigint;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Bigint;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
            postprocessUpdate(reader, exceptions);
        }


        public override async System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            await postprocessUpdateAsync(reader, exceptions, token);
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Update;
        }

    }

    // END: UpdateMainEntityOperation1625545438
    
    
    // START: QueryOnlyMainEntitySelector1625545438
    public class QueryOnlyMainEntitySelector1625545438 : Marten.Internal.CodeGeneration.DocumentSelectorWithOnlySerializer, Marten.Linq.Selectors.ISelector<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public QueryOnlyMainEntitySelector1625545438(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity Resolve(System.Data.Common.DbDataReader reader)
        {

            DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document;
            document = _serializer.FromJson<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity>(reader, 0);
            return document;
        }


        public async System.Threading.Tasks.Task<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {

            DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document;
            document = await _serializer.FromJsonAsync<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity>(reader, 0, token).ConfigureAwait(false);
            return document;
        }

    }

    // END: QueryOnlyMainEntitySelector1625545438
    
    
    // START: LightweightMainEntitySelector1625545438
    public class LightweightMainEntitySelector1625545438 : Marten.Internal.CodeGeneration.DocumentSelectorWithVersions<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity, long>, Marten.Linq.Selectors.ISelector<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public LightweightMainEntitySelector1625545438(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<long>(0);

            DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document;
            document = _serializer.FromJson<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }


        public async System.Threading.Tasks.Task<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<long>(0, token);

            DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document;
            document = await _serializer.FromJsonAsync<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }

    }

    // END: LightweightMainEntitySelector1625545438
    
    
    // START: IdentityMapMainEntitySelector1625545438
    public class IdentityMapMainEntitySelector1625545438 : Marten.Internal.CodeGeneration.DocumentSelectorWithIdentityMap<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity, long>, Marten.Linq.Selectors.ISelector<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public IdentityMapMainEntitySelector1625545438(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<long>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document;
            document = _serializer.FromJson<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }


        public async System.Threading.Tasks.Task<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<long>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document;
            document = await _serializer.FromJsonAsync<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }

    }

    // END: IdentityMapMainEntitySelector1625545438
    
    
    // START: DirtyTrackingMainEntitySelector1625545438
    public class DirtyTrackingMainEntitySelector1625545438 : Marten.Internal.CodeGeneration.DocumentSelectorWithDirtyChecking<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity, long>, Marten.Linq.Selectors.ISelector<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public DirtyTrackingMainEntitySelector1625545438(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<long>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document;
            document = _serializer.FromJson<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }


        public async System.Threading.Tasks.Task<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<long>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document;
            document = await _serializer.FromJsonAsync<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }

    }

    // END: DirtyTrackingMainEntitySelector1625545438
    
    
    // START: QueryOnlyMainEntityDocumentStorage1625545438
    public class QueryOnlyMainEntityDocumentStorage1625545438 : Marten.Internal.Storage.QueryOnlyDocumentStorage<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity, long>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public QueryOnlyMainEntityDocumentStorage1625545438(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override long AssignIdentity(DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id <= 0) _setter(document, database.Sequences.SequenceFor(typeof(DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity)).NextLong());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateMainEntityOperation1625545438
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity, long>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertMainEntityOperation1625545438
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity, long>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertMainEntityOperation1625545438
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity, long>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override long Identity(DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.QueryOnlyMainEntitySelector1625545438(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(long id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Int64[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: QueryOnlyMainEntityDocumentStorage1625545438
    
    
    // START: LightweightMainEntityDocumentStorage1625545438
    public class LightweightMainEntityDocumentStorage1625545438 : Marten.Internal.Storage.LightweightDocumentStorage<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity, long>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public LightweightMainEntityDocumentStorage1625545438(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override long AssignIdentity(DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id <= 0) _setter(document, database.Sequences.SequenceFor(typeof(DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity)).NextLong());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateMainEntityOperation1625545438
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity, long>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertMainEntityOperation1625545438
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity, long>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertMainEntityOperation1625545438
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity, long>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override long Identity(DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.LightweightMainEntitySelector1625545438(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(long id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Int64[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: LightweightMainEntityDocumentStorage1625545438
    
    
    // START: IdentityMapMainEntityDocumentStorage1625545438
    public class IdentityMapMainEntityDocumentStorage1625545438 : Marten.Internal.Storage.IdentityMapDocumentStorage<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity, long>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public IdentityMapMainEntityDocumentStorage1625545438(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override long AssignIdentity(DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id <= 0) _setter(document, database.Sequences.SequenceFor(typeof(DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity)).NextLong());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateMainEntityOperation1625545438
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity, long>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertMainEntityOperation1625545438
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity, long>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertMainEntityOperation1625545438
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity, long>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override long Identity(DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.IdentityMapMainEntitySelector1625545438(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(long id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Int64[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: IdentityMapMainEntityDocumentStorage1625545438
    
    
    // START: DirtyTrackingMainEntityDocumentStorage1625545438
    public class DirtyTrackingMainEntityDocumentStorage1625545438 : Marten.Internal.Storage.DirtyCheckedDocumentStorage<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity, long>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public DirtyTrackingMainEntityDocumentStorage1625545438(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override long AssignIdentity(DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id <= 0) _setter(document, database.Sequences.SequenceFor(typeof(DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity)).NextLong());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateMainEntityOperation1625545438
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity, long>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertMainEntityOperation1625545438
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity, long>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertMainEntityOperation1625545438
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity, long>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override long Identity(DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.DirtyTrackingMainEntitySelector1625545438(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(long id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Int64[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: DirtyTrackingMainEntityDocumentStorage1625545438
    
    
    // START: MainEntityBulkLoader1625545438
    public class MainEntityBulkLoader1625545438 : Marten.Internal.CodeGeneration.BulkLoader<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity, long>
    {
        private readonly Marten.Internal.Storage.IDocumentStorage<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity, long> _storage;

        public MainEntityBulkLoader1625545438(Marten.Internal.Storage.IDocumentStorage<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity, long> storage) : base(storage)
        {
            _storage = storage;
        }


        public const string MAIN_LOADER_SQL = "COPY public.mt_doc_bug_717_permutation_of_linq_queries_mainentity(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string TEMP_LOADER_SQL = "COPY mt_doc_bug_717_permutation_of_linq_queries_mainentity_temp(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string COPY_NEW_DOCUMENTS_SQL = "insert into public.mt_doc_bug_717_permutation_of_linq_queries_mainentity (\"id\", \"data\", \"mt_version\", \"mt_dotnet_type\", mt_last_modified) (select mt_doc_bug_717_permutation_of_linq_queries_mainentity_temp.\"id\", mt_doc_bug_717_permutation_of_linq_queries_mainentity_temp.\"data\", mt_doc_bug_717_permutation_of_linq_queries_mainentity_temp.\"mt_version\", mt_doc_bug_717_permutation_of_linq_queries_mainentity_temp.\"mt_dotnet_type\", transaction_timestamp() from mt_doc_bug_717_permutation_of_linq_queries_mainentity_temp left join public.mt_doc_bug_717_permutation_of_linq_queries_mainentity on mt_doc_bug_717_permutation_of_linq_queries_mainentity_temp.id = public.mt_doc_bug_717_permutation_of_linq_queries_mainentity.id where public.mt_doc_bug_717_permutation_of_linq_queries_mainentity.id is null)";

        public const string OVERWRITE_SQL = "update public.mt_doc_bug_717_permutation_of_linq_queries_mainentity target SET data = source.data, mt_version = source.mt_version, mt_dotnet_type = source.mt_dotnet_type, mt_last_modified = transaction_timestamp() FROM mt_doc_bug_717_permutation_of_linq_queries_mainentity_temp source WHERE source.id = target.id";

        public const string CREATE_TEMP_TABLE_FOR_COPYING_SQL = "create temporary table mt_doc_bug_717_permutation_of_linq_queries_mainentity_temp as select * from public.mt_doc_bug_717_permutation_of_linq_queries_mainentity limit 0";


        public override void LoadRow(Npgsql.NpgsqlBinaryImporter writer, DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer)
        {
            writer.Write(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar);
            writer.Write(document.Id, NpgsqlTypes.NpgsqlDbType.Bigint);
            writer.Write(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb);
        }


        public override async System.Threading.Tasks.Task LoadRowAsync(Npgsql.NpgsqlBinaryImporter writer, DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer, System.Threading.CancellationToken cancellation)
        {
            await writer.WriteAsync(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar, cancellation);
            await writer.WriteAsync(document.Id, NpgsqlTypes.NpgsqlDbType.Bigint, cancellation);
            await writer.WriteAsync(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb, cancellation);
        }


        public override string MainLoaderSql()
        {
            return MAIN_LOADER_SQL;
        }


        public override string TempLoaderSql()
        {
            return TEMP_LOADER_SQL;
        }


        public override string CreateTempTableForCopying()
        {
            return CREATE_TEMP_TABLE_FOR_COPYING_SQL;
        }


        public override string CopyNewDocumentsFromTempTable()
        {
            return COPY_NEW_DOCUMENTS_SQL;
        }


        public override string OverwriteDuplicatesFromTempTable()
        {
            return OVERWRITE_SQL;
        }

    }

    // END: MainEntityBulkLoader1625545438
    
    
    // START: MainEntityProvider1625545438
    public class MainEntityProvider1625545438 : Marten.Internal.Storage.DocumentProvider<DocumentDbTests.Bugs.Bug_717_permutation_of_Linq_queries.MainEntity>
    {
        private readonly Marten.Schema.DocumentMapping _mapping;

        public MainEntityProvider1625545438(Marten.Schema.DocumentMapping mapping) : base(new MainEntityBulkLoader1625545438(new QueryOnlyMainEntityDocumentStorage1625545438(mapping)), new QueryOnlyMainEntityDocumentStorage1625545438(mapping), new LightweightMainEntityDocumentStorage1625545438(mapping), new IdentityMapMainEntityDocumentStorage1625545438(mapping), new DirtyTrackingMainEntityDocumentStorage1625545438(mapping))
        {
            _mapping = mapping;
        }


    }

    // END: MainEntityProvider1625545438
    
    
}
