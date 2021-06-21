using System;
using System.Threading;
using Demo.TestDataBuilders.Core.Account;
using Demo.TestDataBuilders.TestCommon.Infrastructure;
using NSubstitute;

namespace Demo.TestDataBuilders.TestCommon.Builders
{
  public class FakeMarkAccountForFraudCheckDataBuilder
  {
    private readonly IMarkAccountForFraudCheck _fake;

    private FakeMarkAccountForFraudCheckDataBuilder()
    {
      _fake = Substitute.For<IMarkAccountForFraudCheck>();

    }

    public static FakeMarkAccountForFraudCheckDataBuilder Create()
    {
      return new FakeMarkAccountForFraudCheckDataBuilder();
    }

    public IMarkAccountForFraudCheck Build()
    {
      return _fake;
    }

    public FakeMarkAccountForFraudCheckDataBuilder WithExecuteCapturing(out ICaptureInfo<Guid, CancellationToken> capture)
    {
      var instance = new CaptureInfo<Guid, CancellationToken>();
      capture = instance;
      _fake.When(f => f.Execute(Arg.Any<Guid>(), Arg.Any<CancellationToken>())).Do(info =>
      {
        instance.Capture(info.Arg<Guid>(), info.Arg<CancellationToken>());
      });
      return this;
    }
  }
}