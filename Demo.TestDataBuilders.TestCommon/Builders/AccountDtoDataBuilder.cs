using System;
using Bogus;
using Demo.TestDataBuilders.Core.Account;
using Demo.TestDataBuilders.TestCommon.Randoms;

namespace Demo.TestDataBuilders.TestCommon.Builders
{
  public class AccountDtoDataBuilder
  {
    private readonly Faker<AccountDto> _faker;

    private AccountDtoDataBuilder()
    {
      _faker = new Faker<AccountDto>()
        .StrictMode(true)
        .RuleFor(dto => dto.Id, _ => RandomDemo.Account.Id)
        .RuleFor(dto => dto.AccountHolderId, _ => RandomDemo.Account.AccountHolderId)
        .RuleFor(dto => dto.Balance, _ => RandomDemo.Account.Balance)
        ;
    }

    public static AccountDtoDataBuilder Create()
    {
      return new AccountDtoDataBuilder();
    }

    public AccountDto Build()
    {
      return _faker.Generate();
    }
    public AccountDto[] Build(int count)
    {
      return _faker.Generate(count).ToArray();
    }

    public AccountDtoDataBuilder WithId(Guid value)
    {
      _faker.RuleFor(dto => dto.Id, _ => value);
      return this;
    }

    public AccountDtoDataBuilder WithAccountHolderId(Guid value)
    {
      _faker.RuleFor(dto => dto.AccountHolderId, _ => value);
      return this;
    }

    public AccountDtoDataBuilder WithBalance(decimal value)
    {
      _faker.RuleFor(dto => dto.Balance, _ => value);
      return this;
    }
  }
}