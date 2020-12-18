namespace Hospital.Models
{
    public class IdentityRole<TKey>
    {
        public virtual TKey Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string NormalizedName { get; set; }
        public virtual string ConcurrencyStamp { get; set; }
    }
}