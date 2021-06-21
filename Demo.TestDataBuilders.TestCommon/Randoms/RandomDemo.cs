using Bogus;

namespace Demo.TestDataBuilders.TestCommon.Randoms
{
  public class RandomDemo
  {
    private static readonly Faker _faker = new();

    public static RandomAccountHolder AccountHolder { get; } = new RandomAccountHolder();
    public static RandomAccount Account { get; } = new RandomAccount();
  }
}