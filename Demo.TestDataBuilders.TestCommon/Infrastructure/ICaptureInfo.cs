namespace Demo.TestDataBuilders.TestCommon.Infrastructure
{
  public interface ICaptureInfo<T1>
  {
    void ShouldHaveBeenCalledWith(ExpectedArg<T1> expectedParam1);
  }

  public interface ICaptureInfo<T1, T2>
  {
    void ShouldHaveBeenCalledWith(
      ExpectedArg<T1> expectedParam1,
      ExpectedArg<T2> expectedParam2);
  }

  public interface ICaptureInfo<T1, T2, T3>
  {
    void ShouldHaveBeenCalledWith(
      ExpectedArg<T1> expectedParam1,
      ExpectedArg<T2> expectedParam2,
      ExpectedArg<T3> expectedParam3);
  }

  public interface ICaptureInfo<T1, T2, T3, T4>
  {
    void ShouldHaveBeenCalledWith(
      ExpectedArg<T1> expectedParam1,
      ExpectedArg<T2> expectedParam2,
      ExpectedArg<T3> expectedParam3,
      ExpectedArg<T4> expectedParam4);
  }

  public interface ICaptureInfo<T1, T2, T3, T4, T5>
  {
    void ShouldHaveBeenCalledWith(
      ExpectedArg<T1> expectedParam1,
      ExpectedArg<T2> expectedParam2,
      ExpectedArg<T3> expectedParam3,
      ExpectedArg<T4> expectedParam4,
      ExpectedArg<T5> expectedParam5);
  }

  public interface ICaptureInfo<T1, T2, T3, T4, T5, T6>
  {
    void ShouldHaveBeenCalledWith(
      ExpectedArg<T1> expectedParam1,
      ExpectedArg<T2> expectedParam2,
      ExpectedArg<T3> expectedParam3,
      ExpectedArg<T4> expectedParam4,
      ExpectedArg<T5> expectedParam5,
      ExpectedArg<T6> expectedParam6);
  }

  public interface ICaptureInfo<T1, T2, T3, T4, T5, T6, T7>
  {
    void ShouldHaveBeenCalledWith(
      ExpectedArg<T1> expectedParam1,
      ExpectedArg<T2> expectedParam2,
      ExpectedArg<T3> expectedParam3,
      ExpectedArg<T4> expectedParam4,
      ExpectedArg<T5> expectedParam5,
      ExpectedArg<T6> expectedParam6,
      ExpectedArg<T7> expectedParam7);
  }

  public interface ICaptureInfo<T1, T2, T3, T4, T5, T6, T7, T8>
  {
    void ShouldHaveBeenCalledWith(
      ExpectedArg<T1> expectedParam1,
      ExpectedArg<T2> expectedParam2,
      ExpectedArg<T3> expectedParam3,
      ExpectedArg<T4> expectedParam4,
      ExpectedArg<T5> expectedParam5,
      ExpectedArg<T6> expectedParam6,
      ExpectedArg<T7> expectedParam7,
      ExpectedArg<T8> expectedParam8);
  }
}