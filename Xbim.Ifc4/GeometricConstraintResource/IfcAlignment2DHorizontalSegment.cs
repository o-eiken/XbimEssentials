// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometricConstraintResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcAlignment2DHorizontalSegment
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcAlignment2DHorizontalSegment : IIfcAlignment2DSegment
	{
		IIfcCurveSegment2D @CurveGeometry { get;  set; }
		IEnumerable<IIfcAlignment2DHorizontal> @ToHorizontal {  get; }
	
	}
}

namespace Xbim.Ifc4.GeometricConstraintResource
{
	[ExpressType("IfcAlignment2DHorizontalSegment", 1333)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAlignment2DHorizontalSegment : IfcAlignment2DSegment, IInstantiableEntity, IIfcAlignment2DHorizontalSegment, IContainsEntityReferences, IEquatable<@IfcAlignment2DHorizontalSegment>
	{
		#region IIfcAlignment2DHorizontalSegment explicit implementation
		IIfcCurveSegment2D IIfcAlignment2DHorizontalSegment.CurveGeometry { 
 
 
			get { return @CurveGeometry; } 
			set { CurveGeometry = value as IfcCurveSegment2D;}
		}	
		 
		IEnumerable<IIfcAlignment2DHorizontal> IIfcAlignment2DHorizontalSegment.ToHorizontal {  get { return @ToHorizontal; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAlignment2DHorizontalSegment(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcCurveSegment2D _curveGeometry;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 4)]
		public IfcCurveSegment2D @CurveGeometry 
		{ 
			get 
			{
				if(_activated) return _curveGeometry;
				Activate();
				return _curveGeometry;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _curveGeometry = v, _curveGeometry, value,  "CurveGeometry", 4);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("Segments")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, 1, 5)]
		public IEnumerable<IfcAlignment2DHorizontal> @ToHorizontal 
		{ 
			get 
			{
				return Model.Instances.Where<IfcAlignment2DHorizontal>(e => e.Segments != null &&  e.Segments.Contains(this), "Segments", this);
			} 
		}
		#endregion

		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_curveGeometry = (IfcCurveSegment2D)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcAlignment2DHorizontalSegment other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@CurveGeometry != null)
					yield return @CurveGeometry;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}