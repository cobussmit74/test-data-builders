using System;
using Bogus;
using Bogus.Extensions;

namespace Demo.TestDataBuilders.TestCommon.Randoms
{
  public class RandomAccountHolder
  {
    private readonly Faker _faker;
    public RandomAccountHolder()
    {
      _faker = new Faker();
    }

    public Guid Id => _faker.Random.Guid();
    public string Name => _faker.Name.FullName();
    public string PhoneNumber => _faker.Phone.PhoneNumber().OrNull(_faker, 0.2f);
    public string Email => _faker.Internet.Email().OrNull(_faker, 0.2f);
  }
}