namespace de_lucrat_pentru_paw_4
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddWaiter = new System.Windows.Forms.Button();
            this.listViewWaiters = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonAddWaiter
            // 
            this.buttonAddWaiter.Location = new System.Drawing.Point(315, 342);
            this.buttonAddWaiter.Name = "buttonAddWaiter";
            this.buttonAddWaiter.Size = new System.Drawing.Size(163, 96);
            this.buttonAddWaiter.TabIndex = 0;
            this.buttonAddWaiter.Text = "Add Waiter";
            this.buttonAddWaiter.UseVisualStyleBackColor = true;
            this.buttonAddWaiter.Click += new System.EventHandler(this.buttonAddWaiter_Click);
            // 
            // listViewWaiters
            // 
            this.listViewWaiters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderName,
            this.columnHeaderBirthDate});
            this.listViewWaiters.FullRowSelect = true;
            this.listViewWaiters.GridLines = true;
            this.listViewWaiters.HideSelection = false;
            this.listViewWaiters.Location = new System.Drawing.Point(75, 12);
            this.listViewWaiters.Name = "listViewWaiters";
            this.listViewWaiters.Size = new System.Drawing.Size(656, 302);
            this.listViewWaiters.TabIndex = 1;
            this.listViewWaiters.UseCompatibleStateImageBehavior = false;
            this.listViewWaiters.View = System.Windows.Forms.View.Details;
            this.listViewWaiters.DoubleClick += new System.EventHandler(this.listViewWaiters_DoubleClick);
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "ID";
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            // 
            // columnHeaderBirthDate
            // 
            this.columnHeaderBirthDate.Text = "Birth Date";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewWaiters);
            this.Controls.Add(this.buttonAddWaiter);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddWaiter;
        private System.Windows.Forms.ListView listViewWaiters;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderBirthDate;
    }
}

