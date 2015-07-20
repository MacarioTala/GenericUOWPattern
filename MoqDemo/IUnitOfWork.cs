using NHibernate;

namespace MoqDemo
{
    public interface IUnitOfWork
    {
        ISession Session { get; }
        void BeginTransaction();
        void Commit();
    }
}