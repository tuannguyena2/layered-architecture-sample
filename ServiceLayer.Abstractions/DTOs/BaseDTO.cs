namespace ServiceLayer.Abstractions.DTOs
{
    public abstract class BaseDTO
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
    }
}
