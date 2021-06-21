using System;
using Bogus;

namespace Demo.TestDataBuilders.TestCommon.Randoms
{
  public class RandomAccount
  {
    private readonly Faker _faker;
    public RandomAccount()
    {
      _faker = new Faker();
    }

    public Guid Id => _faker.Random.Guid();
    public Guid AccountHolderId => RandomDemo.AccountHolder.Id;
    public decimal Balance => _faker.Finance.Amount(-10000, 10000);
  }
}