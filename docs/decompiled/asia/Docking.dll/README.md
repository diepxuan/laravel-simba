# Báo cáo Phân tích DLL: Docking.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 2.0 |
| Output type | Class Library (DLL) |
| AllowUnsafeBlocks | True |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | Docking |
| Assembly Version | 1.1.3.0 |
| Assembly File Version | 1.1.3.0 |
| GUID | 9d690ef9-ce19-4c69-874c-e24d8eb36aff |
| ComVisible | false |
| CLSCompliant | true |

---

## Cấu trúc File

```
Docking.dll/
├── Docking.csproj                    # Project file
├── app.ico                           # Application icon
├── Properties/
│   └── AssemblyInfo.cs               # Assembly metadata
├── AsiaErp.Framework.Docking/
│   ├── DockPanel.cs                  # Main dock panel control
│   ├── DockContent.cs                # Dockable content base class
│   ├── DockContentHandler.cs         # Dock content handler
│   ├── DockContentCollection.cs      # Dock content collection
│   ├── DockPane.cs                   # Dock pane container
│   ├── DockPaneCollection.cs         # Dock pane collection
│   ├── DockPaneCaptionBase.cs        # Base caption for dock pane
│   ├── DockPaneStripBase.cs          # Base strip for dock pane
│   ├── DockWindow.cs                 # Dock window
│   ├── DockWindowCollection.cs       # Dock window collection
│   ├── FloatWindow.cs                # Floating window
│   ├── FloatWindowCollection.cs      # Floating window collection
│   ├── DockState.cs                  # Dock state enum
│   ├── DockAreas.cs                  # Dock areas enum
│   ├── DockAlignment.cs              # Dock alignment enum
│   ├── DocumentStyle.cs              # Document style enum
│   ├── VS2005AutoHideStrip.cs        # VS2005 auto-hide strip
│   ├── VS2005DockPaneCaption.cs      # VS2005 dock pane caption
│   ├── VS2005DockPaneStrip.cs        # VS2005 dock pane strip
│   ├── AutoHideStripBase.cs          # Base auto-hide strip
│   ├── AutoHideStripSkin.cs          # Auto-hide strip skin
│   ├── DockPanelSkin.cs              # Dock panel skin
│   ├── DockPanelGradient.cs          # Dock panel gradient
│   ├── DockPaneStripGradient.cs      # Dock pane strip gradient
│   ├── DockPaneStripSkin.cs          # Dock pane strip skin
│   ├── TabGradient.cs                # Tab gradient
│   ├── DockOutlineBase.cs            # Base dock outline
│   ├── DragForm.cs                   # Drag form
│   ├── DrawHelper.cs                 # Drawing helper
│   ├── NativeMethods.cs              # Native Win32 methods
│   ├── Win32Helper.cs                # Win32 helper
│   ├── NestedDockingStatus.cs        # Nested docking status
│   ├── NestedPaneCollection.cs       # Nested pane collection
│   ├── VisibleNestedPaneCollection.cs # Visible nested pane collection
│   ├── DockHelper.cs                 # Dock helper utilities
│   ├── MeasurePane.cs                # Measure pane
│   ├── Measures.cs                   # Measures
│   ├── SplitterBase.cs               # Base splitter
│   ├── InertButtonBase.cs            # Base inert button
│   ├── DummyControl.cs               # Dummy control
│   ├── ResourceHelper.cs             # Resource helper
│   ├── Resources.cs                  # Resources
│   ├── Strings.cs                    # Localized strings
│   ├── IDockContent.cs               # Dock content interface
│   ├── IContentFocusManager.cs       # Content focus manager interface
│   ├── IDockDragSource.cs            # Dock drag source interface
│   ├── ISplitterDragSource.cs        # Splitter drag source interface
│   ├── INestedPanesContainer.cs      # Nested panes container interface
│   ├── DeserializeDockContent.cs     # Deserialize dock content
│   ├── GetPersistStringCallback.cs   # Get persist string callback
│   ├── LocalizedDescriptionAttribute.cs # Localized description attribute
│   ├── LocalizedCategoryAttribute.cs # Localized category attribute
│   ├── AutoHideStripConverter.cs     # Auto-hide strip converter
│   ├── DockPanelGradientConverter.cs # Dock panel gradient converter
│   ├── DockPanelSkinConverter.cs     # Dock panel skin converter
│   ├── DockPaneTabGradientConverter.cs # Dock pane tab gradient converter
│   ├── AutoHideStripSkin.cs          # Auto-hide strip skin
│   ├── DockPaneStripToolWindowGradient.cs # Dock pane strip tool window gradient
│   ├── DocumentTabStripLocation.cs   # Document tab strip location
│   └── DockAreasEditor.cs            # Dock areas editor
└── AsiaErp.Framework.Docking.Win32/
    └── (Win32 interop)
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Xml | XML processing |
| System.Drawing | Graphics and drawing |
| System.Windows.Forms | Windows Forms controls |
| System.ComponentModel | Component model |
| System.ComponentModel.Design | Design-time support |
| System.Windows.Forms.Design | Forms designer support |

---

## Classes và Components

### Core Classes

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `DockPanel` | `Panel` | Main container control for docking system |
| `DockContent` | `Form`, `IDockContent` | Base class for dockable content |
| `DockContentHandler` | - | Handles dock content operations |
| `DockPane` | - | Container for docked content |
| `DockWindow` | - | Window that hosts dock panes |
| `FloatWindow` | `Form` | Floating window for docked content |

### Support Classes

| Class | Mục đích |
|-------|----------|
| `DockContentCollection` | Collection of dock contents |
| `DockPaneCollection` | Collection of dock panes |
| `DockWindowCollection` | Collection of dock windows |
| `FloatWindowCollection` | Collection of float windows |
| `NestedPaneCollection` | Collection of nested panes |
| `VisibleNestedPaneCollection` | Collection of visible nested panes |

### Skin and Appearance

| Class | Mục đích |
|-------|----------|
| `DockPanelSkin` | Skin for dock panel |
| `AutoHideStripSkin` | Skin for auto-hide strip |
| `DockPaneStripSkin` | Skin for dock pane strip |
| `DockPanelGradient` | Gradient for dock panel |
| `DockPaneStripGradient` | Gradient for dock pane strip |
| `TabGradient` | Gradient for tabs |
| `DockPaneStripToolWindowGradient` | Gradient for tool windows |

### VS2005 Style

| Class | Mục đích |
|-------|----------|
| `VS2005AutoHideStrip` | VS2005 style auto-hide strip |
| `VS2005DockPaneCaption` | VS2005 style dock pane caption |
| `VS2005DockPaneStrip` | VS2005 style dock pane strip |

---

## Enums

### DockState

| Giá trị | Ý nghĩa |
|---------|---------|
| `Unknown` | Trạng thái không xác định |
| `Float` | Nổi (floating) |
| `DockTopAutoHide` | Dock trên, tự động ẩn |
| `DockLeftAutoHide` | Dock trái, tự động ẩn |
| `DockBottomAutoHide` | Dock dưới, tự động ẩn |
| `DockRightAutoHide` | Dock phải, tự động ẩn |
| `Document` | Dạng document |
| `DockTop` | Dock trên |
| `DockLeft` | Dock trái |
| `DockBottom` | Dock dưới |
| `DockRight` | Dock phải |
| `Hidden` | Ẩn |

### DockAreas

| Giá trị | Ý nghĩa |
|---------|---------|
| `Float` | Có thể nổi |
| `DockLeft` | Có thể dock trái |
| `DockRight` | Có thể dock phải |
| `DockTop` | Có thể dock trên |
| `DockBottom` | Có thể dock dưới |
| `Document` | Có thể dạng document |

### DocumentStyle

| Giá trị | Ý nghĩa |
|---------|---------|
| `DockingMdi` | MDI docking |
| `DockingSdi` | SDI docking |
| `DockingWindow` | Window docking |
| `DockingMultipleDocument` | Multiple document docking |

---

## Interfaces

| Interface | Mục đích |
|-----------|----------|
| `IDockContent` | Interface for dockable content |
| `IContentFocusManager` | Interface for focus management |
| `IDockDragSource` | Interface for dock drag source |
| `ISplitterDragSource` | Interface for splitter drag source |
| `INestedPanesContainer` | Interface for nested panes container |

---

## Mục đích sử dụng

**Docking.dll là Docking Framework** cho ứng dụng Windows Forms trong hệ thống ERP của Asia Software.

### Chức năng chính

#### 1. Window Docking
- Hỗ trợ dock windows vào các vùng: trái, phải, trên, dưới, center (document)
- Hỗ trợ floating windows
- Auto-hide functionality

#### 2. Visual Studio 2005 Style
- Giao diện giống Visual Studio 2005
- Auto-hide strip
- Dock pane caption
- Dock pane strip với tabs

#### 3. Customization
- Skin system cho appearance
- Gradient support
- Tab customization
- Document style options

#### 4. Persistence
- Lưu và khôi phục layout
- Serialize/deserialize dock state
- GetPersistString callback

### Đặc điểm kỹ thuật

- Native Win32 interop cho hooks và window messages
- Focus management system
- Drag and drop support
- Splitter support
- Nested docking support

---

## Kết luận

Đây là một docking framework mạnh mẽ cho Windows Forms, cho phép tạo giao diện giống Visual Studio với khả năng dock/undock windows, floating windows, và auto-hide panels.

---

*Ngày phân tích: 2026-03-29*