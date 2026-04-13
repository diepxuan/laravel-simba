using System.Drawing;

namespace AsiaErp.Framework.Docking;

internal interface ISplitterDragSource : IDragSource
{
	bool IsVertical { get; }

	Rectangle DragLimitBounds { get; }

	void BeginDrag(Rectangle rectSplitter);

	void EndDrag();

	void MoveSplitter(int offset);
}
