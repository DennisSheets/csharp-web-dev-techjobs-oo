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
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        // TODO: Add custom Equals(), GetHashCode(), and ToString() methods.
    }
}
