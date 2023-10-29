using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		#region Constructor
		/// <summary>
		/// Constructor
		/// </summary>
		public Form1()
		{
			InitializeComponent();
		}
		#endregion /Constructor

		#region Properties
		/// <summary>
		/// Firstname Property
		/// </summary>
		private string _firstname;
		public string Firstname
		{
			get { return firstNameTextBox.Text; }
			set { _firstname = value; }
		}

		/// <summary>
		/// Lastname Property
		/// </summary>
		private string _lastname;
		public string Lastname
		{
			get { return lastNameTextBox.Text; }
			set { _lastname = value; }
		}
		#endregion /Properties

		#region Methods
		/// <summary>
		/// SaveButton Method
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SaveButton_Click(object sender, EventArgs e)
		{
			if (Firstname != "" && Lastname != "")
			{
				int counter = dataGridView1.CurrentRow.Index + 1;

				dataGridView1.Rows.Add(counter, firstNameTextBox.Text, lastNameTextBox.Text);

				firstNameTextBox.Text = string.Empty;
				lastNameTextBox.Text = string.Empty;

				firstNameTextBox.Focus();
			}
			else
			{
				string errorMessage = null;

				if (Firstname == "")
				{
					firstNameTextBox.Focus();
					errorMessage += "First Name is Required!";
				}

				if (Lastname == "")
				{
					if (Firstname == "")
					{
						firstNameTextBox.Focus();
					}

					else
					{
						lastNameTextBox.Focus();
					}

					errorMessage += System.Environment.NewLine + "Last Name is Required!";
				}

				System.Windows.Forms.MessageBox.Show
					(text: errorMessage, buttons: MessageBoxButtons.OK,
						icon: MessageBoxIcon.Warning, caption: "Warning");
			}
		}

		/// <summary>
		/// DeleteButton Method
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DeleteButton_Click(object sender, EventArgs e)
		{
			if (dataGridView1.Rows.Count <= 1)
			{
				System.Windows.Forms.MessageBox.Show(text: "There is no Rows in your list to delete!",
					caption: "Error", icon: MessageBoxIcon.Error, buttons: MessageBoxButtons.OK);
				return;
			}

			else
			{
				if (dataGridView1.CurrentRow.Index < dataGridView1.Rows.Count - 1)
				{
					var message =
						System.Windows.Forms.MessageBox
							.Show(icon: MessageBoxIcon.Question, text: "are you sure?", caption: "Delete",
								buttons: MessageBoxButtons.YesNo, defaultButton: MessageBoxDefaultButton.Button2);

					if (message == DialogResult.Yes)
					{
						int counter = dataGridView1.CurrentRow.Index;

						for (int i = 0; i <= counter; i++)
						{
							int index = dataGridView1.Rows[i].Index;
							index--;

							while (dataGridView1.SelectedRows.Count >= 1)
							{
								dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
								//dataGridView1.Sort(dataGridViewColumn: , direction: System.ComponentModel.ListSortDirection.Ascending);
							}
						}
					}
					else
					{
						return;
					}
				}

				else
				{
					System.Windows.Forms.MessageBox
						.Show(text: "you must select a row",
							icon: MessageBoxIcon.Error, buttons: MessageBoxButtons.OK, caption: "Error");
				}
			}
		}
		#endregion /Methods
	}
}