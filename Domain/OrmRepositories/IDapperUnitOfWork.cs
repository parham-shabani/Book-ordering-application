using Domain.Repositories;
using Domain.Repositories.BookRepositories;
using Domain.Repositories.CustomerRepositories;
using Domain.Repositories.OrderRepositories;
using InfraStucture.Repositories.ReadRepository;

public interface IDapperUnitOfWork
{
    void BeginTransaction();
    void Rollback();
    void Commit();
}