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
    /* Internal type: hv.a */
    public partial class HarvestableChargeDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private hv.a _internal;
        
        #region Properties
        
        public hv.a HarvestableChargeDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public HarvestableChargeDescriptor(hv.a instance)
        {
            _internal = instance;
        }
        
        static HarvestableChargeDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator hv.a(HarvestableChargeDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator HarvestableChargeDescriptor(hv.a instance)
        {
            return new HarvestableChargeDescriptor(instance);
        }
        
        public static implicit operator bool(HarvestableChargeDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
