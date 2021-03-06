////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.336.100246-prod
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
using System.Linq;

using UnityEngine;

using Albion.Common.Time;

namespace Merlin.API.Direct
{
    /* Internal type: n6 */
    public partial class TileDataFile
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private n6 _internal;
        
        #region Properties
        
        public n6 TileDataFile_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public CompoundTileDescriptor GetCompoundtile(string A_0) => _internal.c((string)A_0);
        public TileDescriptor GetTile(string A_0) => _internal.b((string)A_0);
        public CompoundTileDescriptor ReadCompoundTile(System.Xml.XmlReader A_0) => (CompoundTileDescriptor)_methodReflectionPool[0].Invoke(_internal,new object[]{(System.Xml.XmlReader)A_0});
        public TileDescriptor ReadTile(System.Xml.XmlReader A_0) => (TileDescriptor)_methodReflectionPool[1].Invoke(_internal,new object[]{(System.Xml.XmlReader)A_0});
        
        #endregion
        
        #region Constructor
        
        public TileDataFile(n6 instance)
        {
            _internal = instance;
        }
        
        static TileDataFile()
        {
            _methodReflectionPool.Add(typeof(n6).GetMethod("b", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance, null, new Type[]{typeof(System.Xml.XmlReader)}, null));
            _methodReflectionPool.Add(typeof(n6).GetMethod("d", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance, null, new Type[]{typeof(System.Xml.XmlReader)}, null));
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator n6(TileDataFile instance)
        {
            return instance._internal;
        }
        
        public static implicit operator TileDataFile(n6 instance)
        {
            return new TileDataFile(instance);
        }
        
        public static implicit operator bool(TileDataFile instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
