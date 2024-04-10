namespace de_lucrat_pentru_paw_3
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
            this.buttonAddTractor = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // buttonAddTractor
            // 
            this.buttonAddTractor.Location = new System.Drawing.Point(525, 607);
            this.buttonAddTractor.Name = "buttonAddTractor";
            this.buttonAddTractor.Size = new System.Drawing.Size(202, 90);
            this.buttonAddTractor.TabIndex = 0;
            this.buttonAddTractor.Text = "Add Tractor";
            this.buttonAddTractor.UseVisualStyleBackColor = true;
            this.buttonAddTractor.Click += new System.EventHandler(this.buttonAddTractor_Click);
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(217, 12);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(844, 533);
            this.treeView.TabIndex = 1;
            this.treeView.DoubleClick += new System.EventHandler(this.treeView_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 709);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.buttonAddTractor);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddTractor;
        private System.Windows.Forms.TreeView treeView;
    }
}

