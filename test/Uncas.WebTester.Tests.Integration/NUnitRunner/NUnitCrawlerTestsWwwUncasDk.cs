﻿namespace Uncas.WebTester.NUnitRunner.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using NUnit.Framework;

    [TestFixture]
    public class NUnitCrawlerTestsWwwUncasDk : NUnitCrawler
    {
        protected override int? MaxLinks
        {
            get
            {
                return 10;
            }
        }

        protected override IList<HttpStatusCode> AcceptableStatusCodes
        {
            get
            {
                var result = base.AcceptableStatusCodes;
                result.Add(HttpStatusCode.NotFound);
                return result;
            }
        }

        protected override IList<Uri> GetBaseUrls()
        {
            var result = new List<Uri>();
            result.Add(new Uri("http://www.uncas.dk"));
            return result;
        }
    }
}