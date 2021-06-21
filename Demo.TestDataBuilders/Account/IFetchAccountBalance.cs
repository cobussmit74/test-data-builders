using System;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.TestDataBuilders.Core.Account
{
  public interface IFetchAccountBalance
  {
    Task<decimal> GetLatestBalance(Guid accountId, CancellationToken token = default);
  }
}