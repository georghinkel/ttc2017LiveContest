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
    /// The public interface for Method
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Method))]
    [XmlDefaultImplementationTypeAttribute(typeof(Method))]
    public interface IMethod : IModelElement, IMember
    {
        
        /// <summary>
        /// The IsAbstract property
        /// </summary>
        bool IsAbstract
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Parameters property
        /// </summary>
        IOrderedSetExpression<IParameter> Parameters
        {
            get;
        }
        
        /// <summary>
        /// The ReturnType property
        /// </summary>
        ITypeReference ReturnType
        {
            get;
            set;
        }
        
        /// <summary>
        /// The BodyExpression property
        /// </summary>
        IExpression BodyExpression
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the IsAbstract property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IsAbstractChanging;
        
        /// <summary>
        /// Gets fired when the IsAbstract property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IsAbstractChanged;
        
        /// <summary>
        /// Gets fired before the ReturnType property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReturnTypeChanging;
        
        /// <summary>
        /// Gets fired when the ReturnType property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReturnTypeChanged;
        
        /// <summary>
        /// Gets fired before the BodyExpression property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BodyExpressionChanging;
        
        /// <summary>
        /// Gets fired when the BodyExpression property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BodyExpressionChanged;
    }
}

