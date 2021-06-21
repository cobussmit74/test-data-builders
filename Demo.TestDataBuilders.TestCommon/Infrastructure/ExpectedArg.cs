using System;
using FluentAssertions;

namespace Demo.TestDataBuilders.TestCommon.Infrastructure
{
  public class ExpectedArg<T>
  {
    private readonly ExpectedType _type;
    private readonly T _value;

    private ExpectedArg(ExpectedType type, T value)
    {
      _type = type;
      _value = value;
    }

    private enum ExpectedType
    {
      Any = 0,
      EquivalentTo = 1,
      SameAs = 2,
    }

    public static ExpectedArg<T> Any()
    {
      return new (ExpectedType.Any, default);
    }
    public static ExpectedArg<T> EquivalentTo(T value)
    {
      return new(ExpectedType.EquivalentTo, value);
    }
    public static ExpectedArg<T> SameAs(T value)
    {
      return new(ExpectedType.SameAs, value);
    }

    public static implicit operator ExpectedArg<T>(T expected) => EquivalentTo(expected);

    public override string ToString()
    {
      return _value == null ? "[NULL]" : $"{_value}";
    }

    public void Match(T value)
    {
      switch (_type)
      {
        case ExpectedType.Any:
          break;
        case ExpectedType.EquivalentTo:
          _value.Should().BeEquivalentTo(value);
          break;
        case ExpectedType.SameAs:
          _value.Should().BeSameAs(value);
          break;
        default:
          throw new ArgumentOutOfRangeException();
      }
    }
  }
}