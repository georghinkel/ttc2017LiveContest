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
    /// The default implementation of the FieldReferenceExpression class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/LiveContest/SimpleCodeDOM")]
    [XmlNamespacePrefixAttribute("codeDom")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/LiveContest/SimpleCodeDOM#//FieldR" +
        "eferenceExpression")]
    public partial class FieldReferenceExpression : Expression, IFieldReferenceExpression, IModelElement
    {
        
        /// <summary>
        /// The backing field for the FieldName property
        /// </summary>
        private string _fieldName;
        
        private static Lazy<ITypedElement> _fieldNameAttribute = new Lazy<ITypedElement>(RetrieveFieldNameAttribute);
        
        private static Lazy<ITypedElement> _targetObjectReference = new Lazy<ITypedElement>(RetrieveTargetObjectReference);
        
        /// <summary>
        /// The backing field for the TargetObject property
        /// </summary>
        private IExpression _targetObject;
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        /// <summary>
        /// The FieldName property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public string FieldName
        {
            get
            {
                return this._fieldName;
            }
            set
            {
                if ((this._fieldName != value))
                {
                    string old = this._fieldName;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnFieldNameChanging(e);
                    this.OnPropertyChanging("FieldName", e, _fieldNameAttribute);
                    this._fieldName = value;
                    this.OnFieldNameChanged(e);
                    this.OnPropertyChanged("FieldName", e, _fieldNameAttribute);
                }
            }
        }
        
        /// <summary>
        /// The TargetObject property
        /// </summary>
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        public IExpression TargetObject
        {
            get
            {
                return this._targetObject;
            }
            set
            {
                if ((this._targetObject != value))
                {
                    IExpression old = this._targetObject;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTargetObjectChanging(e);
                    this.OnPropertyChanging("TargetObject", e, _targetObjectReference);
                    this._targetObject = value;
                    if ((old != null))
                    {
                        old.Parent = null;
                        old.ParentChanged -= this.OnResetTargetObject;
                    }
                    if ((value != null))
                    {
                        value.Parent = this;
                        value.ParentChanged += this.OnResetTargetObject;
                    }
                    this.OnTargetObjectChanged(e);
                    this.OnPropertyChanged("TargetObject", e, _targetObjectReference);
                }
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new FieldReferenceExpressionChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new FieldReferenceExpressionReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/LiveContest/SimpleCodeDOM#//FieldR" +
                            "eferenceExpression")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the FieldName property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> FieldNameChanging;
        
        /// <summary>
        /// Gets fired when the FieldName property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> FieldNameChanged;
        
        /// <summary>
        /// Gets fired before the TargetObject property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TargetObjectChanging;
        
        /// <summary>
        /// Gets fired when the TargetObject property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TargetObjectChanged;
        
        private static ITypedElement RetrieveFieldNameAttribute()
        {
            return ((ITypedElement)(((ModelElement)(TTC2017.LiveContest.SimpleCodeDOM.FieldReferenceExpression.ClassInstance)).Resolve("FieldName")));
        }
        
        /// <summary>
        /// Raises the FieldNameChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnFieldNameChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.FieldNameChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the FieldNameChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnFieldNameChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.FieldNameChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveTargetObjectReference()
        {
            return ((ITypedElement)(((ModelElement)(TTC2017.LiveContest.SimpleCodeDOM.FieldReferenceExpression.ClassInstance)).Resolve("TargetObject")));
        }
        
        /// <summary>
        /// Raises the TargetObjectChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTargetObjectChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TargetObjectChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TargetObjectChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTargetObjectChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TargetObjectChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the TargetObject property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetTargetObject(object sender, System.EventArgs eventArgs)
        {
            this.TargetObject = null;
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            if ((element == this.TargetObject))
            {
                return ModelHelper.CreatePath("TargetObject");
            }
            return base.GetRelativePathForNonIdentifiedChild(element);
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "TARGETOBJECT"))
            {
                return this.TargetObject;
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "FIELDNAME"))
            {
                return this.FieldName;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "TARGETOBJECT"))
            {
                this.TargetObject = ((IExpression)(value));
                return;
            }
            if ((feature == "FIELDNAME"))
            {
                this.FieldName = ((string)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given attribute
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="attribute">The requested attribute in upper case</param>
        protected override NMF.Expressions.INotifyExpression<object> GetExpressionForAttribute(string attribute)
        {
            if ((attribute == "TargetObject"))
            {
                return new TargetObjectProxy(this);
            }
            return base.GetExpressionForAttribute(attribute);
        }
        
        /// <summary>
        /// Gets the property expression for the given reference
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="reference">The requested reference in upper case</param>
        protected override NMF.Expressions.INotifyExpression<NMF.Models.IModelElement> GetExpressionForReference(string reference)
        {
            if ((reference == "TargetObject"))
            {
                return new TargetObjectProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override NMF.Models.Meta.IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/LiveContest/SimpleCodeDOM#//FieldR" +
                        "eferenceExpression")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the FieldReferenceExpression class
        /// </summary>
        public class FieldReferenceExpressionChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private FieldReferenceExpression _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public FieldReferenceExpressionChildrenCollection(FieldReferenceExpression parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    if ((this._parent.TargetObject != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.TargetObjectChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.TargetObjectChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.TargetObject == null))
                {
                    IExpression targetObjectCasted = item.As<IExpression>();
                    if ((targetObjectCasted != null))
                    {
                        this._parent.TargetObject = targetObjectCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.TargetObject = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.TargetObject))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                if ((this._parent.TargetObject != null))
                {
                    array[arrayIndex] = this._parent.TargetObject;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.TargetObject == item))
                {
                    this._parent.TargetObject = null;
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.TargetObject).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the FieldReferenceExpression class
        /// </summary>
        public class FieldReferenceExpressionReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private FieldReferenceExpression _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public FieldReferenceExpressionReferencedElementsCollection(FieldReferenceExpression parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    if ((this._parent.TargetObject != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.TargetObjectChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.TargetObjectChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.TargetObject == null))
                {
                    IExpression targetObjectCasted = item.As<IExpression>();
                    if ((targetObjectCasted != null))
                    {
                        this._parent.TargetObject = targetObjectCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.TargetObject = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.TargetObject))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                if ((this._parent.TargetObject != null))
                {
                    array[arrayIndex] = this._parent.TargetObject;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.TargetObject == item))
                {
                    this._parent.TargetObject = null;
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.TargetObject).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the FieldName property
        /// </summary>
        private sealed class FieldNameProxy : ModelPropertyChange<IFieldReferenceExpression, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public FieldNameProxy(IFieldReferenceExpression modelElement) : 
                    base(modelElement, "FieldName")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.FieldName;
                }
                set
                {
                    this.ModelElement.FieldName = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the TargetObject property
        /// </summary>
        private sealed class TargetObjectProxy : ModelPropertyChange<IFieldReferenceExpression, IExpression>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TargetObjectProxy(IFieldReferenceExpression modelElement) : 
                    base(modelElement, "TargetObject")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IExpression Value
            {
                get
                {
                    return this.ModelElement.TargetObject;
                }
                set
                {
                    this.ModelElement.TargetObject = value;
                }
            }
        }
    }
}

