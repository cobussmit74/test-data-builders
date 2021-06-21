namespace Demo.TestDataBuilders.TestCommon.Infrastructure
{
  internal class CaptureInfo<T1> : CaptureInfoBase<T1, object, object, object, object, object, object, object>
  {
    public void Capture(T1 param1)
    {
      InternalCapture(param1);
    }
  }

  internal class CaptureInfo<T1, T2> : CaptureInfoBase<T1, T2, object, object, object, object, object, object>
  {
    public void Capture(T1 param1, T2 param2)
    {
      InternalCapture(param1, param2);
    }
  }

  internal class CaptureInfo<T1, T2, T3> : CaptureInfoBase<T1, T2, T3, object, object, object, object, object>
  {
    public void Capture(T1 param1, T2 param2, T3 param3)
    {
      InternalCapture(param1, param2, param3);
    }
  }

  internal class CaptureInfo<T1, T2, T3, T4> : CaptureInfoBase<T1, T2, T3, T4, object, object, object, object>
  {
    public void Capture(T1 param1, T2 param2, T3 param3, T4 param4)
    {
      InternalCapture(param1, param2, param3, param4);
    }
  }

  internal class CaptureInfo<T1, T2, T3, T4, T5> : CaptureInfoBase<T1, T2, T3, T4, T5, object, object, object>
  {
    public void Capture(T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
    {
      InternalCapture(param1, param2, param3, param4, param5);
    }
  }

  internal class CaptureInfo<T1, T2, T3, T4, T5, T6> : CaptureInfoBase<T1, T2, T3, T4, T5, T6, object, object>
  {
    public void Capture(T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
    {
      InternalCapture(param1, param2, param3, param4, param5, param6);
    }
  }

  internal class CaptureInfo<T1, T2, T3, T4, T5, T6, T7> : CaptureInfoBase<T1, T2, T3, T4, T5, T6, T7, object>
  {
    public void Capture(T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
    {
      InternalCapture(param1, param2, param3, param4, param5, param6, param7);
    }
  }
  internal class CaptureInfo<T1, T2, T3, T4, T5, T6, T7, T8> : CaptureInfoBase<T1, T2, T3, T4, T5, T6, T7, T8>
  {
    public void Capture(T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8)
    {
      InternalCapture(param1, param2, param3, param4, param5, param6, param7, param8);
    }
  }
}