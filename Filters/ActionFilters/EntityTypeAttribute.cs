using System;

namespace ApiNet8.Filters.ActionFilters
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class EntityTypeAttribute : Attribute
    {
        public Type EntityType { get; }

        public EntityTypeAttribute(Type entityType)
        {
            EntityType = entityType;
        }
    }
}
