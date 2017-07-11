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
    /// The default implementation of the ExpressionBlock class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/LiveContest/SimpleCodeDOM")]
    [XmlNamespacePrefixAttribute("codeDom")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/LiveContest/SimpleCodeDOM#//Expres" +
        "sionBlock")]
    public partial class ExpressionBlock : Expression, IExpressionBlock, IModelElement
    {
        
        private static Lazy<ITypedElement> _innerReference = new Lazy<ITypedElement>(RetrieveInnerReference);
        
        /// <summary>
        /// The backing field for the Inner property
        /// </summary>
        private ObservableCompositionOrderedSet<IExpression> _inner;
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        public ExpressionBlock()
        {
            this._inner = new ObservableCompositionOrderedSet<IExpression>(this);
            this._inner.CollectionChanging += this.InnerCollectionChanging;
            this._inner.CollectionChanged += this.InnerCollectionChanged;
        }
        
        /// <summary>
        /// The Inner property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        public IOrderedSetExpression<IExpression> Inner
        {
            get
            {
                return this._inner;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new ExpressionBlockChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ExpressionBlockReferencedElementsCollection(this));
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
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/LiveContest/SimpleCodeDOM#//Expres" +
                            "sionBlock")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrieveInnerReference()
        {
            return ((ITypedElement)(((ModelElement)(TTC2017.LiveContest.SimpleCodeDOM.ExpressionBlock.ClassInstance)).Resolve("Inner")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Inner property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void InnerCollectionChanging(object sender, NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("Inner", e, _innerReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Inner property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void InnerCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Inner", e, _innerReference);
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            int innerIndex = ModelHelper.IndexOfReference(this.Inner, element);
            if ((innerIndex != -1))
            {
                return ModelHelper.CreatePath("Inner", innerIndex);
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
            if ((reference == "INNER"))
            {
                if ((index < this.Inner.Count))
                {
                    return this.Inner[index];
                }
                else
                {
                    return null;
                }
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "INNER"))
            {
                return this._inner;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Gets the property name for the given container
        /// </summary>
        /// <returns>The name of the respective container reference</returns>
        /// <param name="container">The container object</param>
        protected override string GetCompositionName(object container)
        {
            if ((container == this._inner))
            {
                return "Inner";
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
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/LiveContest/SimpleCodeDOM#//Expres" +
                        "sionBlock")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ExpressionBlock class
        /// </summary>
        public class ExpressionBlockChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ExpressionBlock _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ExpressionBlockChildrenCollection(ExpressionBlock parent)
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
                    count = (count + this._parent.Inner.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Inner.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Inner.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IExpression innerCasted = item.As<IExpression>();
                if ((innerCasted != null))
                {
                    this._parent.Inner.Add(innerCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Inner.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Inner.Contains(item))
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
                IEnumerator<IModelElement> innerEnumerator = this._parent.Inner.GetEnumerator();
                try
                {
                    for (
                    ; innerEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = innerEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    innerEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IExpression expressionItem = item.As<IExpression>();
                if (((expressionItem != null) 
                            && this._parent.Inner.Remove(expressionItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Inner).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ExpressionBlock class
        /// </summary>
        public class ExpressionBlockReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ExpressionBlock _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ExpressionBlockReferencedElementsCollection(ExpressionBlock parent)
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
                    count = (count + this._parent.Inner.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Inner.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Inner.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IExpression innerCasted = item.As<IExpression>();
                if ((innerCasted != null))
                {
                    this._parent.Inner.Add(innerCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Inner.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Inner.Contains(item))
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
                IEnumerator<IModelElement> innerEnumerator = this._parent.Inner.GetEnumerator();
                try
                {
                    for (
                    ; innerEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = innerEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    innerEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IExpression expressionItem = item.As<IExpression>();
                if (((expressionItem != null) 
                            && this._parent.Inner.Remove(expressionItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Inner).GetEnumerator();
            }
        }
    }
}

