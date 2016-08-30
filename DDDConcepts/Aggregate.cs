using System;

namespace Amf.Framework.DDDConcepts
{
    public abstract class Aggregate : IEquatable<Aggregate>
    {
        public Guid Id { get { return _id; } }
        private readonly Guid _id;

        protected  Aggregate(Guid id)
        {
            _id = id;
        }

        public override bool Equals(object obj)
        {
            var entity = obj as Aggregate;
            if (entity != null)
            {
                return this.Equals(entity);
            }
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        public bool Equals(Aggregate other)
        {
            if (other == null)
            {
                return false;
            }
            return this.Id.Equals(other.Id);
        }
    }
}
