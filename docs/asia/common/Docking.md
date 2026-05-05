# Docking.dll - Docking Framework

## Tong quan

| Thuoc tinh | Gia tri |
|------------|---------|
| **Module** | Common |
| **Loai** | UI Framework (Class Library) |
| **Chuc nang** | Cung cap kha nang docking, floating, auto-hide cho Windows Forms - giao dien kieu Visual Studio 2005 |
| **Assembly** | Docking v1.1.3.0 |
| **Framework** | .NET Framework 2.0 |
| **Namespace** | AsiaErp.Framework.Docking, AsiaErp.Framework.Docking.Win32 |
| **AllowUnsafeBlocks** | True |
| **GUID** | 9d690ef9-ce19-4c69-874c-e24d8eb36aff |

## Dependencies

| Assembly | Muc dich |
|----------|----------|
| System.Windows.Forms | Windows Forms controls |
| System.Drawing | Drawing, gradients, rendering |
| System.ComponentModel | Component model, type converters |
| System.Xml | XML persistence (save/restore layout) |
| System.IO | Stream operations |
| Win32 (native) | Hooks, window messages |

## Core Classes

### DockPanel

| Thuoc tinh | Chi tiet |
|------------|----------|
| **Ke thua** | Panel |
| **Muc dich** | Container chinh cho docking system - quan ly tat ca dock windows, panes, content, float windows |
| **Properties** | DocumentStyle, ActiveContent, ActivePane, ActiveDocument, ActiveDocumentPane, DockWindows, FloatWindows, Contents, Panes, Skin, AllowEndUserDocking, ShowDocumentIcon |
| **Events** | ActiveContentChanged, ContentAdded, ContentRemoved |
| **Methods** | SaveAsXml(), LoadFromXml(), IsFocusTrackingSuspended |
| **Inner class** | FocusManagerImpl (quan ly focus tracking qua Win32 hooks) |

### DockContent

| Thuoc tinh | Chi tiet |
|------------|----------|
| **Ke thua** | Form, implements IDockContent |
| **Muc dich** | Base class cho form co the dock - moi form muon dock deu ke thua class nay |
| **Properties** | DockHandler, AllowEndUserDocking, DockAreas, AutoHidePortion, TabText, CloseButton, CloseButtonVisible, HideOnClose, ShowHint, IsHidden, DockState, Pane, DockPanel, FloatWindow |
| **Events** | DockStateChanged |

### DockPane

| Thuoc tinh | Chi tiet |
|------------|----------|
| **Ke thua** | UserControl, IDockDragSource |
| **Muc dich** | Container cho cac dock content - quan ly tabs, splitter, nested docking |
| **Inner class** | SplitterControl (ke thua Control, ISplitterDragSource) |
| **Properties** | DockPanel, DockWindow, DockState, DisplayingContents, NestedDockingStatus, Splitter, CaptionControl, StripControl |

### DockWindow

| Thuoc tinh | Chi tiet |
|------------|----------|
| **Muc dich** | Container cho dock panes o 4 vi tri: Top, Left, Right, Bottom |

### FloatWindow

| Thuoc tinh | Chi tiet |
|------------|----------|
| **Ke thua** | Form |
| **Muc dich** | Cua so floating cho dock content |

## Enums

### DockState
Unknown, Float, DockTopAutoHide, DockLeftAutoHide, DockBottomAutoHide, DockRightAutoHide, Document, DockTop, DockLeft, DockBottom, DockRight, Hidden

### DockAreas (Flags)
Float, DockLeft, DockRight, DockTop, DockBottom, Document

### DocumentStyle
DockingMdi, DockingSdi, DockingWindow, DockingMultipleDocument

### DockAlignment
Left, Right, Top, Bottom

## Interfaces

| Interface | Muc dich |
|-----------|----------|
| IDockContent | Interface cho dockable content (DockHandler, OnActivated, OnDeactivate) |
| IContentFocusManager | Quan ly focus tracking |
| IDockDragSource | Drag source cho docking operations |
| ISplitterDragSource | Drag source cho splitter |
| INestedPanesContainer | Container cho nested panes |
| IDragSource | Base drag source interface |

## Skin & Appearance

| Class | Muc dich |
|-------|----------|
| DockPanelSkin | Skin chinh cho DockPanel |
| DockPanelGradient | Gradient cho panel |
| DockPaneStripSkin | Skin cho tab strip |
| DockPaneStripGradient | Gradient cho strip |
| TabGradient | Gradient cho tab |
| AutoHideStripSkin | Skin cho auto-hide strip |
| DockPaneStripToolWindowGradient | Gradient cho tool window |

## VS2005 Style Classes

| Class | Muc dich |
|-------|----------|
| VS2005AutoHideStrip | Auto-hide strip style VS2005 |
| VS2005DockPaneCaption | Caption style VS2005 |
| VS2005DockPaneStrip | Tab strip style VS2005 |

## Utility Classes

| Class | Muc dich |
|-------|----------|
| DockHelper | Helper functions cho docking logic |
| DrawHelper | Ve gradient, background |
| NativeMethods | Win32 API calls (hooks, window positioning) |
| Win32Helper | Win32 utilities |
| DragForm | Form hien thi khi keo tha |
| DockOutlineBase | Base class cho dock outline |
| SplitterBase | Base class cho splitter |
| InertButtonBase | Base class cho button |
| DummyControl | Dummy control cho focus management |
| MeasurePane | Tinh toan kich thuoc pane |
| NestedDockingStatus | Trang thai nested docking |
| NestedPaneCollection | Collection nested panes |
| VisibleNestedPaneCollection | Collection visible nested panes |
| DockContentCollection | Collection dock contents |
| DockPaneCollection | Collection dock panes |
| DockWindowCollection | Collection dock windows |
| FloatWindowCollection | Collection float windows |
| DockContentHandler | Xu ly docking cho DockContent |
| AutoHideStripBase | Base class auto-hide strip |
| DockPaneCaptionBase | Base class pane caption |
| DockPaneStripBase | Base class pane strip |
| DeserializeDockContent | Delegate deserialize content |
| GetPersistStringCallback | Callback lay persist string |
| DockAreasEditor | UI TypeEditor cho DockAreas |
| ResourceHelper | Helper tai resources |
| Strings | Localized strings |
| Resources | Resource manager |

## Type Converters

| Class | Muc dich |
|-------|----------|
| AutoHideStripConverter | TypeConverter |
| DockPanelGradientConverter | TypeConverter |
| DockPanelSkinConverter | TypeConverter |
| DockPaneStripGradientConverter | TypeConverter |
| DockPaneTabGradientConverter | TypeConverter |
| DockPaneStripConverter | TypeConverter |

## Persistence (XML)

- DockPanel.SaveAsXml() / LoadFromXml() - Luu/restore layout
- Su dung GetPersistStringCallback de map content types
- Format XML: DockPanel > Contents > Content (AutoHidePortion, IsHidden, DockState, FloatWindow, DockWindow, Pane)

## Ket luan

Docking.dll la **UI Framework** nen tang cho toan bo ung dung Asia ERP. Cung cap kha nang docking/floating/auto-hide cho Windows Forms, tuong tu Visual Studio 2005. Moi form trong he thong muon co kha nang docking deu ke thua `DockContent`. DockPanel la container chinh dat tren main form.
