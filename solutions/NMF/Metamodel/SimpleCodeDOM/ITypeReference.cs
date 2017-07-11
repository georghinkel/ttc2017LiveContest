//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace TTC2017.LiveContest.SimpleCodeDOM
{
    
    
    /// <summary>
    /// The public interface for TypeReference
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(TypeReference))]
    [XmlDefaultImplementationTypeAttribute(typeof(TypeReference))]
    public interface ITypeReference : IModelElement
    {
        
        /// <summary>
        /// The BaseName property
        /// </summary>
        string BaseName
        {
            get;
            set;
        }
        
        /// <summary>
        /// The GenericTypeArguments property
        /// </summary>
        IOrderedSetExpression<ITypeReference> GenericTypeArguments
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the BaseName property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BaseNameChanging;
        
        /// <summary>
        /// Gets fired when the BaseName property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BaseNameChanged;
    }
}

