﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GitSharp.Core;
using GitSharp.Core.Transport;
using NUnit.Framework;

namespace GitSharp.Core.Tests.Transport
{
    [TestFixture]
    public class OperationResultTests
    {
        [Test]
        public void ShouldReturnNullForAnInvalidRef()
        {
            var result = new PushResult();

            Assert.IsNull(result.GetAdvertisedRef("invalid ref"));
        }

        [Test]
        public void ShouldReturnValueForAValidRef()
        {
            var result = new PushResult();
            var r = new Unpeeled(null, "ref", ObjectId.ZeroId);

            result.AdvertisedRefs.Add("ref", r);

            Assert.AreEqual(r, result.GetAdvertisedRef("ref"));
        }
    }
}
