using Dapper;
using Domain.Repositories;
using Domain.Repositories.BookRepositories;
using Domain.Repositories.CustomerRepositories;
using Domain.Repositories.OrderRepositories;
using InfraStucture.Persistance.Dapper;
using InfraStucture.Repositories.ReadRepository;
using InfraStucture.Repositories.WriteRepository;
using System.Data;

public class DapperUnitOfWork : IDapperUnitOfWork
{
    private readonly DapperContext DapperContext;
    public DapperUnitOfWork(DapperContext dapperContext)
    {
        DapperContext = dapperContext;
    }

    public void BeginTransaction()
    {
        DapperContext.transaction = DapperContext.connection.BeginTransaction();
    }

    public void Commit()
    {
        DapperContext.transaction.Commit();
    }

    public void Rollback()
    {
        DapperContext.transaction.Rollback();
    }
}