namespace de_lucrat_pentru_paw_3
{
    partial class AddEditForm
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
            this.components = new System.ComponentModel.Container();
            this.labelId = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.numericUpDownId = new System.Windows.Forms.NumericUpDown();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.checkBoxIsElectric = new System.Windows.Forms.CheckBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(265, 127);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(32, 25);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "ID";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(254, 240);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(69, 25);
            this.labelBrand.TabIndex = 1;
            this.labelBrand.Text = "Brand";
            // 
            // numericUpDownId
            // 
            this.numericUpDownId.Location = new System.Drawing.Point(378, 121);
            this.numericUpDownId.Name = "numericUpDownId";
            this.numericUpDownId.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownId.TabIndex = 2;
            this.numericUpDownId.Validating += new System.ComponentModel.CancelEventHandler(this.numericUpDownId_Validating);
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(378, 234);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(100, 31);
            this.textBoxBrand.TabIndex = 3;
            this.textBoxBrand.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxBrand_Validating);
            // 
            // checkBoxIsElectric
            // 
            this.checkBoxIsElectric.AutoSize = true;
            this.checkBoxIsElectric.Location = new System.Drawing.Point(320, 341);
            this.checkBoxIsElectric.Name = "checkBoxIsElectric";
            this.checkBoxIsElectric.Size = new System.Drawing.Size(115, 29);
            this.checkBoxIsElectric.TabIndex = 4;
            this.checkBoxIsElectric.Text = "Electric";
            this.checkBoxIsElectric.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(168, 499);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(129, 48);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(439, 499);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(129, 48);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 632);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.checkBoxIsElectric);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.numericUpDownId);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.labelId);
            this.Name = "AddEditForm";
            this.Text = "AddEditForm";
            this.Load += new System.EventHandler(this.AddEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.NumericUpDown numericUpDownId;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.CheckBox checkBoxIsElectric;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}