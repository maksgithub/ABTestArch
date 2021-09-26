namespace Guard.Models
{
    public abstract class BaseModel
    {
        public virtual string Description => $"{GetType().ToString()} Description";
    }
}