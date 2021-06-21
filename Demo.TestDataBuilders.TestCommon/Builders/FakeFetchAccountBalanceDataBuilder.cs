using System;
using System.Collections.Generic;
using System.Threading;
using Demo.TestDataBuilders.Core.Account;
using Demo.TestDataBuilders.TestCommon.Randoms;
using NSubstitute;

namespace Demo.TestDataBuilders.TestCommon.Builders
{
  public class FakeFetchAccountBalanceDataBuilder
  {
    private readonly IFetchAccountBalance _fake;
    private readonly Dictionary<Guid, decimal> _balances = new();

    private FakeFetchAccountBalanceDataBuilder()
    {
      _fake = Substitute.For<IFetchAccountBalance>();

      _fake.GetLatestBalance(Arg.Any<Guid>(), Arg.Any<CancellationToken>()).Returns(info =>
      {
        var accountId = info.Arg<Guid>();
        return _balances.TryGetValue(accountId, out var balance)
          ? balance
          : RandomDemo.Account.Balance;
      });
    }

    public static FakeFetchAccountBalanceDataBuilder Create()
    {
      return new FakeFetchAccountBalanceDataBuilder();
    }

    public IFetchAccountBalance Build()
    {
      return _fake;
    }

    public FakeFetchAccountBalanceDataBuilder WithBalance(Guid accountId, decimal balance)
    {
      _balances.Add(accountId, balance);
      return this;
    }
  }
}