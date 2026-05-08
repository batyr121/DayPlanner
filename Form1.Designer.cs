namespace DayPlanner;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
                this.textBoxTask = new System.Windows.Forms.TextBox();
        this.buttonAdd = new System.Windows.Forms.Button();
        this.buttonDelete = new System.Windows.Forms.Button();
        this.listBoxTasks = new System.Windows.Forms.ListBox();

        this.SuspendLayout();

// textBox
        this.textBoxTask.Location = new System.Drawing.Point(20, 20);
        this.textBoxTask.Size = new System.Drawing.Size(200, 23);

// add button
        this.buttonAdd.Text = "Добавить";
        this.buttonAdd.Location = new System.Drawing.Point(230, 20);
        this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);

// delete button
        this.buttonDelete.Text = "Удалить";
        this.buttonDelete.Location = new System.Drawing.Point(330, 20);
        this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);

// listbox
        this.listBoxTasks.Location = new System.Drawing.Point(20, 60);
        this.listBoxTasks.Size = new System.Drawing.Size(390, 300);

// form
        this.ClientSize = new System.Drawing.Size(450, 400);

        this.Controls.Add(this.textBoxTask);
        this.Controls.Add(this.buttonAdd);
        this.Controls.Add(this.buttonDelete);
        this.Controls.Add(this.listBoxTasks);

        this.ResumeLayout(false);
    }

    #endregion
}
