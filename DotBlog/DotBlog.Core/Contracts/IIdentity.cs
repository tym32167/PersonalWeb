namespace DotBlog.Core.Contracts
{
    public interface IIdentity<out TKey>
    {
        TKey Id { get; }
    }
}