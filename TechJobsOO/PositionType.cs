using System;
namespace TechJobsOO
{
    public class PositionType : JobField
    {
        public PositionType()
        {
        }
        public PositionType(string value) : this()
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is PositionType positionType &&
                   Id == positionType.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }

        // TODO: Add custom Equals(), GetHashCode(), and ToString() methods.
    }
}
