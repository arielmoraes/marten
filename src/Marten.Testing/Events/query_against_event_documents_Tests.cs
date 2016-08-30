﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Marten.Events;
using Marten.Services;
using Marten.Util;
using Shouldly;
using Xunit;

namespace Marten.Testing.Events
{
    public class query_against_event_documents_Tests : DocumentSessionFixture<NulloIdentityMap>
    {
        private MembersJoined joined1 = new MembersJoined { Members = new string[] { "Rand", "Matt", "Perrin", "Thom" } };
        private MembersDeparted departed1 = new MembersDeparted { Members = new[] { "Thom" } };

        private MembersJoined joined2 = new MembersJoined { Members = new string[] { "Nynaeve", "Egwene" } };
        private MembersDeparted departed2 = new MembersDeparted { Members = new[] { "Matt" } };

        // SAMPLE: query-against-event-data
        [Fact]
        public void can_query_against_event_type()
        {
            theSession.Events.StartStream<Quest>(joined1, departed1);
            theSession.Events.StartStream<Quest>(joined2, departed2);

            theSession.SaveChanges();

            theSession.Events.QueryRawEventDataOnly<MembersJoined>().Count().ShouldBe(2);
            theSession.Events.QueryRawEventDataOnly<MembersJoined>().ToArray().SelectMany(x => x.Members).Distinct()
                .OrderBy(x => x)
                .ShouldHaveTheSameElementsAs("Egwene", "Matt", "Nynaeve", "Perrin", "Rand", "Thom");

            theSession.Events.QueryRawEventDataOnly<MembersDeparted>().Where(x => x.Members.Contains("Matt"))
                .Single().Id.ShouldBe(departed2.Id);
        }
        // ENDSAMPLE

        [Fact]
        public void will_not_blow_up_if_searching_for_events_before_event_store_is_warmed_up()
        {
            theSession.Events.QueryRawEventDataOnly<MembersJoined>().Any().ShouldBeFalse();
        }

        [Fact]
        public void can_query_against_event_type_with_different_schema_name()
        {
            StoreOptions(_ =>
            {
                _.DatabaseSchemaName = "test";
                _.Events.DatabaseSchemaName = "events";

                _.Events.AddEventType(typeof(MembersDeparted));
            });

            theStore.Schema.MappingFor(typeof(MembersDeparted)).ToQueryableDocument()
                .Table.Schema.ShouldBe("events");

            theSession.Events.StartStream<Quest>(joined1, departed1);
            theSession.Events.StartStream<Quest>(joined2, departed2);

            theSession.SaveChanges();

            theSession.Events.QueryRawEventDataOnly<MembersJoined>().Count().ShouldBe(2);
            theSession.Events.QueryRawEventDataOnly<MembersJoined>().ToArray().SelectMany(x => x.Members).Distinct()
                .OrderBy(x => x)
                .ShouldHaveTheSameElementsAs("Egwene", "Matt", "Nynaeve", "Perrin", "Rand", "Thom");

            theSession.Events.QueryRawEventDataOnly<MembersDeparted>().Where(x => x.Members.Contains("Matt"))
                .Single().Id.ShouldBe(departed2.Id);
        }

        [Fact]
        public void can_fetch_all_events()
        {
            theSession.Events.StartStream<Quest>(joined1, departed1);
            theSession.Events.StartStream<Quest>(joined2, departed2);

            theSession.SaveChanges();

            var results = theSession.Events.QueryAllRawEvents().ToList();

            results.Count.ShouldBe(4);
        }

        [Fact]
        public void can_fetch_all_events_after_now()
        {
            var now = DateTimeOffset.UtcNow;

            theSession.Events.StartStream<Quest>(joined1, departed1);
            theSession.Events.StartStream<Quest>(joined2, departed2);

            theSession.SaveChanges();

            var past = now.AddSeconds(-1);

            var results = theSession.Events.QueryAllRawEvents().Where(x => x.Timestamp > past).ToList();
                

            results.Count.ShouldBe(4);
        }

        [Fact]
        public void can_fetch_all_events_before_now()
        {
            theSession.Events.StartStream<Quest>(joined1, departed1);
            theSession.Events.StartStream<Quest>(joined2, departed2);

            theSession.SaveChanges();

            

            var dbNow = (DateTime)theSession.Connection.CreateCommand().Sql("select now();").ExecuteScalar();
            var now = new DateTimeOffset(dbNow).AddSeconds(5);
           

            var all = theSession.Events.QueryAllRawEvents().ToList();

            var results = theSession.Events.QueryAllRawEvents()
                .Where(x => x.Timestamp < now).ToList();

            results.Count.ShouldBe(4);
        }


        [Fact]
        public void can_fetch_events_by_sequence()
        {
            theSession.Events.StartStream<Quest>(joined1, departed1);
            theSession.Events.StartStream<Quest>(joined2, departed2);

            theSession.SaveChanges();

            theSession.Events.QueryAllRawEvents()
                .Count(x => x.Sequence <= 2).ShouldBe(2);
        }

        [Fact]
        public void can_fetch_by_version()
        {
            theSession.Events.StartStream<Quest>(joined1, departed1);
            theSession.Events.StartStream<Quest>(joined2, departed2);

            theSession.SaveChanges();

            theSession.Events.QueryAllRawEvents()
                .Count(x => x.Version == 1).ShouldBe(2);
        }

        [Fact]
        public void can_search_by_stream()
        {
            var stream1 = theSession.Events.StartStream<Quest>(joined1, departed1);
            var stream2 = theSession.Events.StartStream<Quest>(joined2, departed2);

            theSession.SaveChanges();

            theSession.Events.QueryAllRawEvents()
                .Count(x => x.StreamId == stream1).ShouldBe(2);
        }

        /*
         * MORE!!!
         * Async everything
         */
    }
}