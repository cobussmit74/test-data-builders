using System;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.TestDataBuilders.Core.Account
{
  public interface IMarkAccountForFraudCheck
  {
    Task Execute(Guid accountId, CancellationToken token = default);
  }
}