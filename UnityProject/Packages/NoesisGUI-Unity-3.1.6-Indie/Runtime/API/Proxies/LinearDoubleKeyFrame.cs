//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


using System;
using System.Runtime.InteropServices;

namespace Noesis
{

public class LinearDoubleKeyFrame : DoubleKeyFrame {
  internal new static LinearDoubleKeyFrame CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new LinearDoubleKeyFrame(cPtr, cMemoryOwn);
  }

  internal LinearDoubleKeyFrame(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(LinearDoubleKeyFrame obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public LinearDoubleKeyFrame() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_LinearDoubleKeyFrame();
  }

}

}

