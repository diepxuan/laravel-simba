using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace AsiaErp.Framework.Docking;

internal class DockAreasEditor : UITypeEditor
{
	private class DockAreasEditorControl : UserControl
	{
		private CheckBox checkBoxFloat;

		private CheckBox checkBoxDockLeft;

		private CheckBox checkBoxDockRight;

		private CheckBox checkBoxDockTop;

		private CheckBox checkBoxDockBottom;

		private CheckBox checkBoxDockFill;

		private DockAreas m_oldDockAreas;

		public DockAreas DockAreas
		{
			get
			{
				DockAreas dockAreas = (DockAreas)0;
				if (checkBoxFloat.Checked)
				{
					dockAreas |= DockAreas.Float;
				}
				if (checkBoxDockLeft.Checked)
				{
					dockAreas |= DockAreas.DockLeft;
				}
				if (checkBoxDockRight.Checked)
				{
					dockAreas |= DockAreas.DockRight;
				}
				if (checkBoxDockTop.Checked)
				{
					dockAreas |= DockAreas.DockTop;
				}
				if (checkBoxDockBottom.Checked)
				{
					dockAreas |= DockAreas.DockBottom;
				}
				if (checkBoxDockFill.Checked)
				{
					dockAreas |= DockAreas.Document;
				}
				if (dockAreas == (DockAreas)0)
				{
					return m_oldDockAreas;
				}
				return dockAreas;
			}
		}

		public DockAreasEditorControl()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Expected O, but got Unknown
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			checkBoxFloat = new CheckBox();
			checkBoxDockLeft = new CheckBox();
			checkBoxDockRight = new CheckBox();
			checkBoxDockTop = new CheckBox();
			checkBoxDockBottom = new CheckBox();
			checkBoxDockFill = new CheckBox();
			((Control)this).SuspendLayout();
			checkBoxFloat.Appearance = (Appearance)1;
			((Control)checkBoxFloat).Dock = (DockStyle)1;
			((Control)checkBoxFloat).Height = 24;
			((Control)checkBoxFloat).Text = Strings.DockAreaEditor_FloatCheckBoxText;
			((ButtonBase)checkBoxFloat).TextAlign = (ContentAlignment)32;
			((ButtonBase)checkBoxFloat).FlatStyle = (FlatStyle)3;
			checkBoxDockLeft.Appearance = (Appearance)1;
			((Control)checkBoxDockLeft).Dock = (DockStyle)3;
			((Control)checkBoxDockLeft).Width = 24;
			((ButtonBase)checkBoxDockLeft).FlatStyle = (FlatStyle)3;
			checkBoxDockRight.Appearance = (Appearance)1;
			((Control)checkBoxDockRight).Dock = (DockStyle)4;
			((Control)checkBoxDockRight).Width = 24;
			((ButtonBase)checkBoxDockRight).FlatStyle = (FlatStyle)3;
			checkBoxDockTop.Appearance = (Appearance)1;
			((Control)checkBoxDockTop).Dock = (DockStyle)1;
			((Control)checkBoxDockTop).Height = 24;
			((ButtonBase)checkBoxDockTop).FlatStyle = (FlatStyle)3;
			checkBoxDockBottom.Appearance = (Appearance)1;
			((Control)checkBoxDockBottom).Dock = (DockStyle)2;
			((Control)checkBoxDockBottom).Height = 24;
			((ButtonBase)checkBoxDockBottom).FlatStyle = (FlatStyle)3;
			checkBoxDockFill.Appearance = (Appearance)1;
			((Control)checkBoxDockFill).Dock = (DockStyle)5;
			((ButtonBase)checkBoxDockFill).FlatStyle = (FlatStyle)3;
			((Control)this).Controls.AddRange((Control[])(object)new Control[6]
			{
				(Control)checkBoxDockFill,
				(Control)checkBoxDockBottom,
				(Control)checkBoxDockTop,
				(Control)checkBoxDockRight,
				(Control)checkBoxDockLeft,
				(Control)checkBoxFloat
			});
			((Control)this).Size = new Size(160, 144);
			((Control)this).BackColor = SystemColors.Control;
			((Control)this).ResumeLayout();
		}

		public void SetStates(DockAreas dockAreas)
		{
			m_oldDockAreas = dockAreas;
			if ((dockAreas & DockAreas.DockLeft) != 0)
			{
				checkBoxDockLeft.Checked = true;
			}
			if ((dockAreas & DockAreas.DockRight) != 0)
			{
				checkBoxDockRight.Checked = true;
			}
			if ((dockAreas & DockAreas.DockTop) != 0)
			{
				checkBoxDockTop.Checked = true;
			}
			if ((dockAreas & DockAreas.DockTop) != 0)
			{
				checkBoxDockTop.Checked = true;
			}
			if ((dockAreas & DockAreas.DockBottom) != 0)
			{
				checkBoxDockBottom.Checked = true;
			}
			if ((dockAreas & DockAreas.Document) != 0)
			{
				checkBoxDockFill.Checked = true;
			}
			if ((dockAreas & DockAreas.Float) != 0)
			{
				checkBoxFloat.Checked = true;
			}
		}
	}

	private DockAreasEditorControl m_ui;

	public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
	{
		return (UITypeEditorEditStyle)3;
	}

	public override object EditValue(ITypeDescriptorContext context, IServiceProvider sp, object value)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		if (m_ui == null)
		{
			m_ui = new DockAreasEditorControl();
		}
		m_ui.SetStates((DockAreas)value);
		IWindowsFormsEditorService val = (IWindowsFormsEditorService)sp.GetService(typeof(IWindowsFormsEditorService));
		val.DropDownControl((Control)(object)m_ui);
		return m_ui.DockAreas;
	}
}
