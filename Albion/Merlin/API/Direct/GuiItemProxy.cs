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
    /* Internal type: a7m */
    public partial class GuiItemProxy
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private a7m _internal;
        
        #region Properties
        
        public a7m GuiItemProxy_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public GuiItemProxy(a7m instance)
        {
            _internal = instance;
        }
        
        static GuiItemProxy()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator a7m(GuiItemProxy instance)
        {
            return instance._internal;
        }
        
        public static implicit operator GuiItemProxy(a7m instance)
        {
            return new GuiItemProxy(instance);
        }
        
        public static implicit operator bool(GuiItemProxy instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
