using System.Security.Cryptography;

namespace FootballManagement.WebApi.Models.Entities
{
    public class Entity<TId>
    {
        public TId Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;

        public Entity()
        {
            if (typeof(TId) == typeof(Guid))
            {
                Id = (TId)(object)Guid.NewGuid();
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var entity = (Entity<TId>)obj;
            return EqualityComparer<TId>.Default.Equals(Id, entity.Id);
        }

        public override int GetHashCode()
        {
            return EqualityComparer<TId>.Default.GetHashCode(Id);
        }

    }
}
