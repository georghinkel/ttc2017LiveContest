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

namespace TTC2017.LiveContest.RefinementsEcore
{
    
    
    /// <summary>
    /// The public interface for EEnumLiteral
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(EEnumLiteral))]
    [XmlDefaultImplementationTypeAttribute(typeof(EEnumLiteral))]
    public interface IEEnumLiteral : IModelElement, IENamedElement
    {
        
        /// <summary>
        /// The value property
        /// </summary>
        Nullable<int> Value
        {
            get;
            set;
        }
        
        /// <summary>
        /// The literal property
        /// </summary>
        string Literal
        {
            get;
            set;
        }
        
        /// <summary>
        /// The eEnum property
        /// </summary>
        IEEnum EEnum
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Value property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ValueChanging;
        
        /// <summary>
        /// Gets fired when the Value property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ValueChanged;
        
        /// <summary>
        /// Gets fired before the Literal property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LiteralChanging;
        
        /// <summary>
        /// Gets fired when the Literal property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LiteralChanged;
        
        /// <summary>
        /// Gets fired before the EEnum property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EEnumChanging;
        
        /// <summary>
        /// Gets fired when the EEnum property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EEnumChanged;
    }
}

