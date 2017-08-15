////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.327.94396-live
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

using UnityEngine;

using Albion.Common.Time;

using NUnit.Framework;

namespace Merlin.API.Direct.Tests
{
    /* Internal type: bp */
    [TestFixture]
    public class ItemDescriptorTests
    {
        #region Conversion
        
        [Test]
        public void DescriptionTag_ReflectionTest()
        {
            PropertyInfo property = typeof(bp).GetProperty("an");
            Assert.Null(property,"Property ItemDescriptor.DescriptionTag(bp.an) is null");
        }
        
        [Test]
        public void NameTag_ReflectionTest()
        {
            PropertyInfo property = typeof(bp).GetProperty("am");
            Assert.Null(property,"Property ItemDescriptor.NameTag(bp.am) is null");
        }
        
        
        #endregion
    }
}