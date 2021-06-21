using System.Threading.Tasks;
using Demo.TestDataBuilders.TestCommon.Builders;
using Demo.TestDataBuilders.TestCommon.Randoms;
using FluentAssertions;
using NUnit.Framework;

namespace Demo.TestDataBuilders.Test
{
  [TestFixture]
  public class TestFakeFetchAccountBalanceDataBuilder
  {
    [Test] 
    public async Task GivenNoSetup_ShouldReturnRandomBalance()
    {
      var balanceFetcher = FakeFetchAccountBalanceDataBuilder.Create().Build();

      var first = await balanceFetcher.GetLatestBalance(RandomDemo.Account.Id);
      var second = await balanceFetcher.GetLatestBalance(RandomDemo.Account.Id);

      first.Should().NotBe(second);
    }

    [Test] 
    public async Task GivenExplicitBalance_ShouldAlwaysReturnThatValue()
    {
      var accountId = RandomDemo.Account.Id;
      var expected = RandomDemo.Account.Balance;

      var balanceFetcher = FakeFetchAccountBalanceDataBuilder.Create()
        .WithBalance(accountId, expected)
        .Build();

      var first = await balanceFetcher.GetLatestBalance(accountId);
      var second = await balanceFetcher.GetLatestBalance(accountId);

      first.Should().Be(second);
    }
  }
}