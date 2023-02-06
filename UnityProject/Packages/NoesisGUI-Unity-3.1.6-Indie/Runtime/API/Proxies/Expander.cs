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

public class Expander : HeaderedContentControl {
  internal new static Expander CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new Expander(cPtr, cMemoryOwn);
  }

  internal Expander(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(Expander obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  #region Events
  public event RoutedEventHandler Collapsed {
    add {
      AddHandler(NoesisGUI_PINVOKE.Expander_CollapsedEvent_get(), value);
    }
    remove {
      RemoveHandler(NoesisGUI_PINVOKE.Expander_CollapsedEvent_get(), value);
    }
  }

  public event RoutedEventHandler Expanded {
    add {
      AddHandler(NoesisGUI_PINVOKE.Expander_ExpandedEvent_get(), value);
    }
    remove {
      RemoveHandler(NoesisGUI_PINVOKE.Expander_ExpandedEvent_get(), value);
    }
  }

  #endregion

  public Expander() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if (type == typeof(Expander)) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_Expander();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  public static DependencyProperty ExpandDirectionProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Expander_ExpandDirectionProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty IsExpandedProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Expander_IsExpandedProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent CollapsedEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Expander_CollapsedEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent ExpandedEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Expander_ExpandedEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public ExpandDirection ExpandDirection {
    set {
      NoesisGUI_PINVOKE.Expander_ExpandDirection_set(swigCPtr, (int)value);
    } 
    get {
      ExpandDirection ret = (ExpandDirection)NoesisGUI_PINVOKE.Expander_ExpandDirection_get(swigCPtr);
      return ret;
    } 
  }

  public bool IsExpanded {
    set {
      NoesisGUI_PINVOKE.Expander_IsExpanded_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.Expander_IsExpanded_get(swigCPtr);
      return ret;
    } 
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_Expander(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

