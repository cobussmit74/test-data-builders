using System;
using Bogus;
using Demo.TestDataBuilders.Core.AccountHolder;
using Demo.TestDataBuilders.TestCommon.Randoms;

namespace Demo.TestDataBuilders.TestCommon.Builders
{
  public class AccountHolderDtoDataBuilder
  {
    private readonly Faker<AccountHolderDto> _faker;

    private AccountHolderDtoDataBuilder()
    {
      _faker = new Faker<AccountHolderDto>()
        .StrictMode(true)
        .RuleFor(dto => dto.Id, _ => RandomDemo.AccountHolder.Id)
        .RuleFor(dto => dto.Name, _ => RandomDemo.AccountHolder.Name)
        .RuleFor(dto => dto.PhoneNumber, _ => RandomDemo.AccountHolder.PhoneNumber)
        .RuleFor(dto => dto.Email, _ => RandomDemo.AccountHolder.Email)
        ;
    }

    public static AccountHolderDtoDataBuilder Create()
    {
      return new AccountHolderDtoDataBuilder();
    }

    public AccountHolderDto Build()
    {
      return _faker.Generate();
    }
    public AccountHolderDto[] Build(int count)
    {
      return _faker.Generate(count).ToArray();
    }

    public AccountHolderDtoDataBuilder WithId(Guid value)
    {
      _faker.RuleFor(dto => dto.Id, _ => value);
      return this;
    }

    public AccountHolderDtoDataBuilder WithName(string value)
    {
      _faker.RuleFor(dto => dto.Name, _ => value);
      return this;
    }

    public AccountHolderDtoDataBuilder WithPhoneNumber(string value)
    {
      _faker.RuleFor(dto => dto.PhoneNumber, _ => value);
      return this;
    }

    public AccountHolderDtoDataBuilder WithEmail(string value)
    {
      _faker.RuleFor(dto => dto.Email, _ => value);
      return this;
    }
  }
}