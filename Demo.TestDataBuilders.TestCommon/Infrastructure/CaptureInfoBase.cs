using System.Collections.Generic;
using System.Linq;
using FluentAssertions.Execution;

namespace Demo.TestDataBuilders.TestCommon.Infrastructure
{
  internal class CaptureInfoBase<T1, T2, T3, T4, T5, T6, T7, T8> :
    ICaptureInfo<T1>,
    ICaptureInfo<T1, T2>,
    ICaptureInfo<T1, T2, T3>,
    ICaptureInfo<T1, T2, T3, T4>,
    ICaptureInfo<T1, T2, T3, T4, T5>,
    ICaptureInfo<T1, T2, T3, T4, T5, T6>,
    ICaptureInfo<T1, T2, T3, T4, T5, T6, T7>,
    ICaptureInfo<T1, T2, T3, T4, T5, T6, T7, T8>
  {
    private class CapturedItem
    {
      public T1 Param1 { get; set; }
      public T2 Param2 { get; set; }
      public T3 Param3 { get; set; }
      public T4 Param4 { get; set; }
      public T5 Param5 { get; set; }
      public T6 Param6 { get; set; }
      public T7 Param7 { get; set; }
      public T8 Param8 { get; set; }
    }

    private readonly List<CapturedItem> _capturedItems = new();

    protected void InternalCapture(
      T1 param1,
      T2 param2 = default,
      T3 param3 = default,
      T4 param4 = default,
      T5 param5 = default,
      T6 param6 = default,
      T7 param7 = default,
      T8 param8 = default)
    {
      _capturedItems.Add(new()
      {
        Param1 = param1,
        Param2 = param2,
        Param3 = param3,
        Param4 = param4,
        Param5 = param5,
        Param6 = param6,
        Param7 = param7,
        Param8 = param8
      });
    }

    private bool WasCalledWith(
      ExpectedArg<T1> expectedParam1,
      ExpectedArg<T2> expectedParam2 = null,
      ExpectedArg<T3> expectedParam3 = null,
      ExpectedArg<T4> expectedParam4 = null,
      ExpectedArg<T5> expectedParam5 = null,
      ExpectedArg<T6> expectedParam6 = null,
      ExpectedArg<T7> expectedParam7 = null,
      ExpectedArg<T8> expectedParam8 = null)
    {
      return _capturedItems.Any(c =>
      {
        try
        {
          expectedParam1.Match(c.Param1);
          expectedParam2?.Match(c.Param2);
          expectedParam3?.Match(c.Param3);
          expectedParam4?.Match(c.Param4);
          expectedParam5?.Match(c.Param5);
          expectedParam6?.Match(c.Param6);
          expectedParam7?.Match(c.Param7);
          expectedParam8?.Match(c.Param8);
          return true;
        }
        catch
        {
          return false;
        }
      });
    }

    void ICaptureInfo<T1>.ShouldHaveBeenCalledWith(ExpectedArg<T1> expectedParam1)
    {
      if (!WasCalledWith(expectedParam1))
      {
        throw new AssertionFailedException(
          $"Expected method to be called with [{expectedParam1}], but found no matching calls");
      }
    }

    void ICaptureInfo<T1, T2>.ShouldHaveBeenCalledWith(ExpectedArg<T1> expectedParam1, ExpectedArg<T2> expectedParam2)
    {
      if (!WasCalledWith(expectedParam1, expectedParam2))
      {
        throw new AssertionFailedException(
          $"Expected method to be called with [{expectedParam1}, {expectedParam2}], but found no matching calls");
      }
    }

    void ICaptureInfo<T1, T2, T3>.ShouldHaveBeenCalledWith(
      ExpectedArg<T1> expectedParam1,
      ExpectedArg<T2> expectedParam2,
      ExpectedArg<T3> expectedParam3)
    {
      if (!WasCalledWith(
        expectedParam1,
        expectedParam2,
        expectedParam3))
      {
        throw new AssertionFailedException(
          $"Expected method to be called with [" +
          $"{expectedParam1}, " +
          $"{expectedParam2}, " +
          $"{expectedParam3}], but found no matching calls");
      }
    }

    void ICaptureInfo<T1, T2, T3, T4>.ShouldHaveBeenCalledWith(
      ExpectedArg<T1> expectedParam1,
      ExpectedArg<T2> expectedParam2,
      ExpectedArg<T3> expectedParam3,
      ExpectedArg<T4> expectedParam4)
    {
      if (!WasCalledWith(
        expectedParam1,
        expectedParam2,
        expectedParam3,
        expectedParam4))
      {
        throw new AssertionFailedException(
          $"Expected method to be called with [" +
          $"{expectedParam1}, " +
          $"{expectedParam2}, " +
          $"{expectedParam3}, " +
          $"{expectedParam4}], but found no matching calls");
      }
    }

    void ICaptureInfo<T1, T2, T3, T4, T5>.ShouldHaveBeenCalledWith(
      ExpectedArg<T1> expectedParam1,
      ExpectedArg<T2> expectedParam2,
      ExpectedArg<T3> expectedParam3,
      ExpectedArg<T4> expectedParam4,
      ExpectedArg<T5> expectedParam5)
    {
      if (!WasCalledWith(
        expectedParam1,
        expectedParam2,
        expectedParam3,
        expectedParam4,
        expectedParam5))
      {
        throw new AssertionFailedException(
          $"Expected method to be called with [" +
          $"{expectedParam1}, " +
          $"{expectedParam2}, " +
          $"{expectedParam3}, " +
          $"{expectedParam4}, " +
          $"{expectedParam5}], but found no matching calls");
      }
    }
    void ICaptureInfo<T1, T2, T3, T4, T5, T6>.ShouldHaveBeenCalledWith(
      ExpectedArg<T1> expectedParam1,
      ExpectedArg<T2> expectedParam2,
      ExpectedArg<T3> expectedParam3,
      ExpectedArg<T4> expectedParam4,
      ExpectedArg<T5> expectedParam5,
      ExpectedArg<T6> expectedParam6)
    {
      if (!WasCalledWith(
        expectedParam1,
        expectedParam2,
        expectedParam3,
        expectedParam4,
        expectedParam5,
        expectedParam6))
      {
        throw new AssertionFailedException(
          $"Expected method to be called with [" +
          $"{expectedParam1}, " +
          $"{expectedParam2}, " +
          $"{expectedParam3}, " +
          $"{expectedParam4}, " +
          $"{expectedParam5}, " +
          $"{expectedParam6}], but found no matching calls");
      }
    }

    void ICaptureInfo<T1, T2, T3, T4, T5, T6, T7>.ShouldHaveBeenCalledWith(
      ExpectedArg<T1> expectedParam1,
      ExpectedArg<T2> expectedParam2,
      ExpectedArg<T3> expectedParam3,
      ExpectedArg<T4> expectedParam4,
      ExpectedArg<T5> expectedParam5,
      ExpectedArg<T6> expectedParam6,
      ExpectedArg<T7> expectedParam7)
    {
      if (!WasCalledWith(
        expectedParam1,
        expectedParam2,
        expectedParam3,
        expectedParam4,
        expectedParam5,
        expectedParam6,
        expectedParam7))
      {
        throw new AssertionFailedException(
          $"Expected method to be called with [" +
          $"{expectedParam1}, " +
          $"{expectedParam2}, " +
          $"{expectedParam3}, " +
          $"{expectedParam4}, " +
          $"{expectedParam5}, " +
          $"{expectedParam6}, " +
          $"{expectedParam7}], but found no matching calls");
      }
    }

    void ICaptureInfo<T1, T2, T3, T4, T5, T6, T7, T8>.ShouldHaveBeenCalledWith(
      ExpectedArg<T1> expectedParam1,
      ExpectedArg<T2> expectedParam2,
      ExpectedArg<T3> expectedParam3,
      ExpectedArg<T4> expectedParam4,
      ExpectedArg<T5> expectedParam5,
      ExpectedArg<T6> expectedParam6,
      ExpectedArg<T7> expectedParam7,
      ExpectedArg<T8> expectedParam8)
    {
      if (!WasCalledWith(
        expectedParam1,
        expectedParam2,
        expectedParam3,
        expectedParam4,
        expectedParam5,
        expectedParam6,
        expectedParam7,
        expectedParam8))
      {
        throw new AssertionFailedException(
          $"Expected method to be called with [" +
          $"{expectedParam1}, " +
          $"{expectedParam2}, " +
          $"{expectedParam3}, " +
          $"{expectedParam4}, " +
          $"{expectedParam5}, " +
          $"{expectedParam6}, " +
          $"{expectedParam7}, " +
          $"{expectedParam8}], but found no matching calls");
      }
    }
  }
}