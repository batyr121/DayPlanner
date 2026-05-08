namespace DayPlanner
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ListBox listBoxTasks;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBoxTask = new System.Windows.Forms.TextBox();
            buttonAdd = new System.Windows.Forms.Button();
            buttonDelete = new System.Windows.Forms.Button();
            listBoxTasks = new System.Windows.Forms.ListBox();

            SuspendLayout();

            // textBoxTask
            textBoxTask.Location = new System.Drawing.Point(20, 20);
            textBoxTask.Size = new System.Drawing.Size(200, 23);

            // buttonAdd
            buttonAdd.Location = new System.Drawing.Point(230, 20);
            buttonAdd.Size = new System.Drawing.Size(90, 23);
            buttonAdd.Text = "Добавить";
            buttonAdd.Click += buttonAdd_Click;

            // buttonDelete
            buttonDelete.Location = new System.Drawing.Point(330, 20);
            buttonDelete.Size = new System.Drawing.Size(90, 23);
            buttonDelete.Text = "Удалить";
            buttonDelete.Click += buttonDelete_Click;

            // listBoxTasks
            listBoxTasks.Location = new System.Drawing.Point(20, 60);
            listBoxTasks.Size = new System.Drawing.Size(400, 300);

            // Form1
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(450, 400);

            Controls.Add(textBoxTask);
            Controls.Add(buttonAdd);
            Controls.Add(buttonDelete);
            Controls.Add(listBoxTasks);

            Name = "Form1";
            Text = "Day Planner";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}