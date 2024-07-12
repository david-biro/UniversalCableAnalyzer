using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public class DropdownCheckedListBox : ComboBox
{
    private CheckedListBox checkedListBox;

    public DropdownCheckedListBox(Control parentControl)
    {
        // Initialize the CheckedListBox
        checkedListBox = new CheckedListBox();
        checkedListBox.CheckOnClick = true;

        // Add event handlers
        checkedListBox.ItemCheck += checkedListBox_ItemCheck;
        checkedListBox.Leave += checkedListBox_Leave;

        // Set the size and position of the CheckedListBox
        checkedListBox.Size = new Size(Width, 150);
        checkedListBox.Location = new Point(Left, Top + Height);

        // Add the CheckedListBox to the parent control
        parentControl.Controls.Add(checkedListBox);

        // Hide the CheckedListBox by default
        checkedListBox.Hide();
    }

    protected override void OnDropDown(EventArgs e)
    {
        // Toggle the visibility of the CheckedListBox
        checkedListBox.Visible = !checkedListBox.Visible;
        if (checkedListBox.Visible)
            checkedListBox.Focus();
    }

    protected override void OnResize(EventArgs e)
    {
        // Update the size and position of the CheckedListBox when the control is resized
        checkedListBox.Size = new Size(Width, 150);
        checkedListBox.Location = new Point(Left, Top + Height);

        base.OnResize(e);
    }

    private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
    {
        // Update the checked items in the ComboBox when an item in the CheckedListBox is checked or unchecked
        var checkedItems = new List<string>();

        for (int i = 0; i < checkedListBox.Items.Count; i++)
        {
            if (checkedListBox.GetItemChecked(i))
                checkedItems.Add(checkedListBox.Items[i].ToString());
        }

        Text = string.Join(", ", checkedItems);
    }

    private void checkedListBox_Leave(object sender, EventArgs e)
    {
        // Hide the CheckedListBox when it loses focus
        checkedListBox.Hide();
    }
}