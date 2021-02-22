﻿using System.Numerics;

namespace TrippingCubes.Entities.Behaviors
{
    class AlignTargetBehavior<ParamT> : AlignBehavior<ParamT>
    {
        public Vector3 TargetPosition { get; set; }

        public AlignTargetBehavior(IEntity self) : base(self)
        {
        }

        protected override Vector3 CalculateAlignDirection()
        {
            return TargetPosition - Self.Body.Position;
        }
    }
}