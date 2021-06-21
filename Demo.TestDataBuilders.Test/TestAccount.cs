using System;
using System.Threading;
using System.Threading.Tasks;
using Demo.TestDataBuilders.Core.Account;
using Demo.TestDataBuilders.TestCommon.Builders;
using Demo.TestDataBuilders.TestCommon.Infrastructure;
using Demo.TestDataBuilders.TestCommon.Randoms;
using FluentAssertions;
using NUnit.Framework;

namespace Demo.TestDataBuilders.Test
{
  [TestFixture]
  public class TestAccount
  {
    [TestFixture]
    public class MonthEndBilling
    {
      [Test]
      public async Task GivenNewBalanceIs123_ShouldMarkForFraud()
      {
        // Arrange
        var dto = AccountDtoDataBuilder.Create().Build();
        
        var balanceFetcher = FakeFetchAccountBalanceDataBuilder.Create()
          .WithBalance(dto.Id, 123.45m)
          .Build();
        
        var fraudMarker = FakeMarkAccountForFraudCheckDataBuilder.Create()
          .WithExecuteCapturing(out var capture)
          .Build();

        var sut = CreateSut(dto, balanceFetcher, fraudMarker);
        // Act
        await sut.MonthEndBilling();

        // Assert
        capture.ShouldHaveBeenCalledWith(dto.Id, ExpectedArg<CancellationToken>.Any());
      }

      private static Account CreateSut(
        AccountDto dto = null,
        IFetchAccountBalance fetchAccountBalance = null,
        IMarkAccountForFraudCheck markAccountForFraudCheck = null)
      {
        dto ??= AccountDtoDataBuilder.Create().Build();
        fetchAccountBalance ??= FakeFetchAccountBalanceDataBuilder.Create().Build();
        markAccountForFraudCheck ??= FakeMarkAccountForFraudCheckDataBuilder.Create().Build();

        return new Account(dto, fetchAccountBalance, markAccountForFraudCheck);
      }
    }
  }
}