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

public static class ContextMenuService {
  public static DependencyProperty ContextMenuProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ContextMenuService_ContextMenuProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty HasDropShadowProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ContextMenuService_HasDropShadowProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty HorizontalOffsetProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ContextMenuService_HorizontalOffsetProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty IsEnabledProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ContextMenuService_IsEnabledProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty PlacementProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ContextMenuService_PlacementProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty PlacementRectangleProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ContextMenuService_PlacementRectangleProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty PlacementTargetProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ContextMenuService_PlacementTargetProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty ShowOnDisabledProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ContextMenuService_ShowOnDisabledProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty VerticalOffsetProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ContextMenuService_VerticalOffsetProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent ContextMenuClosingEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ContextMenuService_ContextMenuClosingEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent ContextMenuOpeningEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ContextMenuService_ContextMenuOpeningEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static ContextMenu GetContextMenu(DependencyObject obj) {
    if (obj == null) throw new ArgumentNullException("obj");
    {
      IntPtr cPtr = NoesisGUI_PINVOKE.ContextMenuService_GetContextMenu(DependencyObject.getCPtr(obj));
      return (ContextMenu)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static void SetContextMenu(DependencyObject obj, ContextMenu contextMenu) {
    if (obj == null) throw new ArgumentNullException("obj");
    {
      NoesisGUI_PINVOKE.ContextMenuService_SetContextMenu(DependencyObject.getCPtr(obj), ContextMenu.getCPtr(contextMenu));
    }
  }

  public static bool GetHasDropShadow(DependencyObject obj) {
    if (obj == null) throw new ArgumentNullException("obj");
    {
      bool ret = NoesisGUI_PINVOKE.ContextMenuService_GetHasDropShadow(DependencyObject.getCPtr(obj));
      return ret;
    }
  }

  public static void SetHasDropShadow(DependencyObject obj, bool hasDropShadow) {
    if (obj == null) throw new ArgumentNullException("obj");
    {
      NoesisGUI_PINVOKE.ContextMenuService_SetHasDropShadow(DependencyObject.getCPtr(obj), hasDropShadow);
    }
  }

  public static float GetHorizontalOffset(DependencyObject obj) {
    if (obj == null) throw new ArgumentNullException("obj");
    {
      float ret = NoesisGUI_PINVOKE.ContextMenuService_GetHorizontalOffset(DependencyObject.getCPtr(obj));
      return ret;
    }
  }

  public static void SetHorizontalOffset(DependencyObject obj, float offset) {
    if (obj == null) throw new ArgumentNullException("obj");
    {
      NoesisGUI_PINVOKE.ContextMenuService_SetHorizontalOffset(DependencyObject.getCPtr(obj), offset);
    }
  }

  public static bool GetIsEnabled(DependencyObject obj) {
    if (obj == null) throw new ArgumentNullException("obj");
    {
      bool ret = NoesisGUI_PINVOKE.ContextMenuService_GetIsEnabled(DependencyObject.getCPtr(obj));
      return ret;
    }
  }

  public static void SetIsEnabled(DependencyObject obj, bool isEnabled) {
    if (obj == null) throw new ArgumentNullException("obj");
    {
      NoesisGUI_PINVOKE.ContextMenuService_SetIsEnabled(DependencyObject.getCPtr(obj), isEnabled);
    }
  }

  public static PlacementMode GetPlacement(DependencyObject obj) {
    if (obj == null) throw new ArgumentNullException("obj");
    {
      PlacementMode ret = (PlacementMode)NoesisGUI_PINVOKE.ContextMenuService_GetPlacement(DependencyObject.getCPtr(obj));
      return ret;
    }
  }

  public static void SetPlacement(DependencyObject obj, PlacementMode mode) {
    if (obj == null) throw new ArgumentNullException("obj");
    {
      NoesisGUI_PINVOKE.ContextMenuService_SetPlacement(DependencyObject.getCPtr(obj), (int)mode);
    }
  }

  public static Rect GetPlacementRectangle(DependencyObject obj) {
    if (obj == null) throw new ArgumentNullException("obj");
    {
      IntPtr ret = NoesisGUI_PINVOKE.ContextMenuService_GetPlacementRectangle(DependencyObject.getCPtr(obj));
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<Rect>(ret);
      }
      else {
        return new Rect();
      }
    }
  }

  public static void SetPlacementRectangle(DependencyObject obj, Rect rect) {
    if (obj == null) throw new ArgumentNullException("obj");
    {
      NoesisGUI_PINVOKE.ContextMenuService_SetPlacementRectangle(DependencyObject.getCPtr(obj), ref rect);
    }
  }

  public static UIElement GetPlacementTarget(DependencyObject obj) {
    if (obj == null) throw new ArgumentNullException("obj");
    {
      IntPtr cPtr = NoesisGUI_PINVOKE.ContextMenuService_GetPlacementTarget(DependencyObject.getCPtr(obj));
      return (UIElement)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static void SetPlacementTarget(DependencyObject obj, UIElement target) {
    if (obj == null) throw new ArgumentNullException("obj");
    {
      NoesisGUI_PINVOKE.ContextMenuService_SetPlacementTarget(DependencyObject.getCPtr(obj), UIElement.getCPtr(target));
    }
  }

  public static bool GetShowOnDisabled(DependencyObject obj) {
    if (obj == null) throw new ArgumentNullException("obj");
    {
      bool ret = NoesisGUI_PINVOKE.ContextMenuService_GetShowOnDisabled(DependencyObject.getCPtr(obj));
      return ret;
    }
  }

  public static void SetShowOnDisabled(DependencyObject obj, bool showOnDisable) {
    if (obj == null) throw new ArgumentNullException("obj");
    {
      NoesisGUI_PINVOKE.ContextMenuService_SetShowOnDisabled(DependencyObject.getCPtr(obj), showOnDisable);
    }
  }

  public static float GetVerticalOffset(DependencyObject obj) {
    if (obj == null) throw new ArgumentNullException("obj");
    {
      float ret = NoesisGUI_PINVOKE.ContextMenuService_GetVerticalOffset(DependencyObject.getCPtr(obj));
      return ret;
    }
  }

  public static void SetVerticalOffset(DependencyObject obj, float offset) {
    if (obj == null) throw new ArgumentNullException("obj");
    {
      NoesisGUI_PINVOKE.ContextMenuService_SetVerticalOffset(DependencyObject.getCPtr(obj), offset);
    }
  }

}

}

