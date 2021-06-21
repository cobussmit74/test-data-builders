using Demo.TestDataBuilders.TestCommon.Builders;
using FluentAssertions;
using NUnit.Framework;

namespace Demo.TestDataBuilders.Test
{
  [TestFixture]
  public class TestAccountHolderDtoDataBuilder
  {
    [Test]
    public void DataBuilder_ShouldCreateRandomAccountHolder()
    {
      // Arrange
      // Act
      var first = AccountHolderDtoDataBuilder.Create().Build();
      var second = AccountHolderDtoDataBuilder.Create().Build();
      // Assert
      first.Should().NotBeEquivalentTo(second);
    }


    [Test]
    public void GivenColumnOverride_ShouldSetColumnToKnownValue()
    {
      // Arrange
      // Act
      var first = AccountHolderDtoDataBuilder.Create()
        .WithName("Bob Bobberson")
        .Build();
      var second = AccountHolderDtoDataBuilder.Create()
        .WithName("Bob Bobberson")
        .Build();
      // Assert
      first.Name.Should().Be(second.Name);
    }

    [Test]
    public void GivenBuildNumber_ShouldBuilderRandomArray()
    {
      // Arrange
      // Act
      var values = AccountHolderDtoDataBuilder.Create().Build(5);
      // Assert
      values.Should().OnlyHaveUniqueItems(d => d.Id);
    }

  }
}