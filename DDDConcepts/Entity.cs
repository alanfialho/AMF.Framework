using System;

namespace Amf.Framework.DDDConcepts
{
    public abstract class Entity<TId> : IEquatable<Entity<TId>>
    {
        protected Entity() { }

        protected Entity(TId id)
        {
            if (object.Equals(id, default(TId)))
            {
                throw new ArgumentException("O id não pode possuir o valor default", "id");
            }

            Id = id;
        }

        public virtual TId Id { get; private set; }

        public override bool Equals(object obj)
        {
            var entity = obj as Entity<TId>;
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

        #region IEquatable<Entity> Members

        public bool Equals(Entity<TId> other)
        {
            if (other == null)
            {
                return false;
            }
            return this.Id.Equals(other.Id);
        }

        #endregion
    }
}