using System.Drawing;

namespace AsiaErp.Framework.Docking;

public interface INestedPanesContainer
{
	DockState DockState { get; }

	Rectangle DisplayingRectangle { get; }

	NestedPaneCollection NestedPanes { get; }

	VisibleNestedPaneCollection VisibleNestedPanes { get; }

	bool IsFloat { get; }
}
