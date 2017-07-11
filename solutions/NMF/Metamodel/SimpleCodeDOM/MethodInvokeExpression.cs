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
    /// The default implementation of the MethodInvokeExpression class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/LiveContest/SimpleCodeDOM")]
    [XmlNamespacePrefixAttribute("codeDom")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/LiveContest/SimpleCodeDOM#//Method" +
        "InvokeExpression")]
    public partial class MethodInvokeExpression : Expression, IMethodInvokeExpression, IModelElement
    {
        
        /// <summary>
        /// The backing field for the MethodName property
        /// </summary>
        private string _methodName;
        
        private static Lazy<ITypedElement> _methodNameAttribute = new Lazy<ITypedElement>(RetrieveMethodNameAttribute);
        
        private static Lazy<ITypedElement> _targetObjectReference = new Lazy<ITypedElement>(RetrieveTargetObjectReference);
        
        /// <summary>
        /// The backing field for the TargetObject property
        /// </summary>
        private IExpression _targetObject;
        
        private static Lazy<ITypedElement> _argumentsReference = new Lazy<ITypedElement>(RetrieveArgumentsReference);
        
        /// <summary>
        /// The backing field for the Arguments property
        /// </summary>
        private ObservableCompositionOrderedSet<IExpression> _arguments;
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        public MethodInvokeExpression()
        {
            this._arguments = new ObservableCompositionOrderedSet<IExpression>(this);
            this._arguments.CollectionChanging += this.ArgumentsCollectionChanging;
            this._arguments.CollectionChanged += this.ArgumentsCollectionChanged;
        }
        
        /// <summary>
        /// The MethodName property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public string MethodName
        {
            get
            {
                return this._methodName;
            }
            set
            {
                if ((this._methodName != value))
                {
                    string old = this._methodName;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnMethodNameChanging(e);
                    this.OnPropertyChanging("MethodName", e, _methodNameAttribute);
                    this._methodName = value;
                    this.OnMethodNameChanged(e);
                    this.OnPropertyChanged("MethodName", e, _methodNameAttribute);
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
        /// The Arguments property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        public IOrderedSetExpression<IExpression> Arguments
        {
            get
            {
                return this._arguments;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new MethodInvokeExpressionChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new MethodInvokeExpressionReferencedElementsCollection(this));
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
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/LiveContest/SimpleCodeDOM#//Method" +
                            "InvokeExpression")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the MethodName property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MethodNameChanging;
        
        /// <summary>
        /// Gets fired when the MethodName property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MethodNameChanged;
        
        /// <summary>
        /// Gets fired before the TargetObject property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TargetObjectChanging;
        
        /// <summary>
        /// Gets fired when the TargetObject property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TargetObjectChanged;
        
        private static ITypedElement RetrieveMethodNameAttribute()
        {
            return ((ITypedElement)(((ModelElement)(TTC2017.LiveContest.SimpleCodeDOM.MethodInvokeExpression.ClassInstance)).Resolve("MethodName")));
        }
        
        /// <summary>
        /// Raises the MethodNameChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMethodNameChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MethodNameChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the MethodNameChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMethodNameChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MethodNameChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveTargetObjectReference()
        {
            return ((ITypedElement)(((ModelElement)(TTC2017.LiveContest.SimpleCodeDOM.MethodInvokeExpression.ClassInstance)).Resolve("TargetObject")));
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
        
        private static ITypedElement RetrieveArgumentsReference()
        {
            return ((ITypedElement)(((ModelElement)(TTC2017.LiveContest.SimpleCodeDOM.MethodInvokeExpression.ClassInstance)).Resolve("Arguments")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Arguments property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ArgumentsCollectionChanging(object sender, NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("Arguments", e, _argumentsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Arguments property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ArgumentsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Arguments", e, _argumentsReference);
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
            int argumentsIndex = ModelHelper.IndexOfReference(this.Arguments, element);
            if ((argumentsIndex != -1))
            {
                return ModelHelper.CreatePath("Arguments", argumentsIndex);
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
            if ((reference == "ARGUMENTS"))
            {
                if ((index < this.Arguments.Count))
                {
                    return this.Arguments[index];
                }
                else
                {
                    return null;
                }
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
            if ((attribute == "METHODNAME"))
            {
                return this.MethodName;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "ARGUMENTS"))
            {
                return this._arguments;
            }
            return base.GetCollectionForFeature(feature);
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
            if ((feature == "METHODNAME"))
            {
                this.MethodName = ((string)(value));
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
        /// Gets the property name for the given container
        /// </summary>
        /// <returns>The name of the respective container reference</returns>
        /// <param name="container">The container object</param>
        protected override string GetCompositionName(object container)
        {
            if ((container == this._arguments))
            {
                return "Arguments";
            }
            return base.GetCompositionName(container);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override NMF.Models.Meta.IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/LiveContest/SimpleCodeDOM#//Method" +
                        "InvokeExpression")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the MethodInvokeExpression class
        /// </summary>
        public class MethodInvokeExpressionChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private MethodInvokeExpression _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public MethodInvokeExpressionChildrenCollection(MethodInvokeExpression parent)
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
                    count = (count + this._parent.Arguments.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.TargetObjectChanged += this.PropagateValueChanges;
                this._parent.Arguments.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.TargetObjectChanged -= this.PropagateValueChanges;
                this._parent.Arguments.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
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
                IExpression argumentsCasted = item.As<IExpression>();
                if ((argumentsCasted != null))
                {
                    this._parent.Arguments.Add(argumentsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.TargetObject = null;
                this._parent.Arguments.Clear();
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
                if (this._parent.Arguments.Contains(item))
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
                IEnumerator<IModelElement> argumentsEnumerator = this._parent.Arguments.GetEnumerator();
                try
                {
                    for (
                    ; argumentsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = argumentsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    argumentsEnumerator.Dispose();
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
                IExpression expressionItem = item.As<IExpression>();
                if (((expressionItem != null) 
                            && this._parent.Arguments.Remove(expressionItem)))
                {
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.TargetObject).Concat(this._parent.Arguments).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the MethodInvokeExpression class
        /// </summary>
        public class MethodInvokeExpressionReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private MethodInvokeExpression _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public MethodInvokeExpressionReferencedElementsCollection(MethodInvokeExpression parent)
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
                    count = (count + this._parent.Arguments.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.TargetObjectChanged += this.PropagateValueChanges;
                this._parent.Arguments.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.TargetObjectChanged -= this.PropagateValueChanges;
                this._parent.Arguments.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
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
                IExpression argumentsCasted = item.As<IExpression>();
                if ((argumentsCasted != null))
                {
                    this._parent.Arguments.Add(argumentsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.TargetObject = null;
                this._parent.Arguments.Clear();
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
                if (this._parent.Arguments.Contains(item))
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
                IEnumerator<IModelElement> argumentsEnumerator = this._parent.Arguments.GetEnumerator();
                try
                {
                    for (
                    ; argumentsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = argumentsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    argumentsEnumerator.Dispose();
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
                IExpression expressionItem = item.As<IExpression>();
                if (((expressionItem != null) 
                            && this._parent.Arguments.Remove(expressionItem)))
                {
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.TargetObject).Concat(this._parent.Arguments).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the MethodName property
        /// </summary>
        private sealed class MethodNameProxy : ModelPropertyChange<IMethodInvokeExpression, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public MethodNameProxy(IMethodInvokeExpression modelElement) : 
                    base(modelElement, "MethodName")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.MethodName;
                }
                set
                {
                    this.ModelElement.MethodName = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the TargetObject property
        /// </summary>
        private sealed class TargetObjectProxy : ModelPropertyChange<IMethodInvokeExpression, IExpression>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TargetObjectProxy(IMethodInvokeExpression modelElement) : 
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

