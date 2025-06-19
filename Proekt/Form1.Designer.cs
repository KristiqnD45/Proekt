namespace Proekt
{
    partial class Form1
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lstboxSouvenirs = new System.Windows.Forms.ListBox();
            this.souvenirContextDataSet = new Proekt.SouvenirContextDataSet();
            this.souvenirTypesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.souvenirsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.souvenirsTableAdapter = new Proekt.SouvenirContextDataSetTableAdapters.SouvenirsTableAdapter();
            this.souvenirTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.souvenirTypesTableAdapter = new Proekt.SouvenirContextDataSetTableAdapters.SouvenirTypesTableAdapter();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.souvenirContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.souvenirTypesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.souvenirsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.souvenirTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(33, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(246, 52);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 16);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(33, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(26, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(467, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Id";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(300, 49);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(95, 103);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(100, 21);
            this.cmbType.TabIndex = 7;
            // 
            // txtDescription
            // 
            this.txtDescription.AllowDrop = true;
            this.txtDescription.Location = new System.Drawing.Point(111, 187);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(276, 92);
            this.txtDescription.TabIndex = 8;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(508, 49);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(50, 355);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdd.Size = new System.Drawing.Size(129, 60);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(346, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 60);
            this.button3.TabIndex = 12;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lstboxSouvenirs
            // 
            this.lstboxSouvenirs.FormattingEnabled = true;
            this.lstboxSouvenirs.Items.AddRange(new object[] {
            "",
            ""});
            this.lstboxSouvenirs.Location = new System.Drawing.Point(491, 128);
            this.lstboxSouvenirs.Name = "lstboxSouvenirs";
            this.lstboxSouvenirs.Size = new System.Drawing.Size(229, 173);
            this.lstboxSouvenirs.TabIndex = 13;
            // 
            // souvenirContextDataSet
            // 
            this.souvenirContextDataSet.DataSetName = "SouvenirContextDataSet";
            this.souvenirContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // souvenirTypesBindingSource1
            // 
            this.souvenirTypesBindingSource1.DataMember = "SouvenirTypes";
            this.souvenirTypesBindingSource1.DataSource = this.souvenirContextDataSet;
            // 
            // souvenirsBindingSource
            // 
            this.souvenirsBindingSource.DataMember = "Souvenirs";
            this.souvenirsBindingSource.DataSource = this.souvenirContextDataSet;
            // 
            // souvenirsTableAdapter
            // 
            this.souvenirsTableAdapter.ClearBeforeFill = true;
            // 
            // souvenirTypesBindingSource
            // 
            this.souvenirTypesBindingSource.DataMember = "SouvenirTypes";
            this.souvenirTypesBindingSource.DataSource = this.souvenirContextDataSet;
            // 
            // souvenirTypesTableAdapter
            // 
            this.souvenirTypesTableAdapter.ClearBeforeFill = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.Location = new System.Drawing.Point(208, 355);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 60);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lstboxSouvenirs);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.souvenirContextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.souvenirTypesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.souvenirsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.souvenirTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnAdd;
   
        private System.Windows.Forms.Button button3;
        private SouvenirContextDataSet souvenirContextDataSet;
        private System.Windows.Forms.BindingSource souvenirsBindingSource;
        private SouvenirContextDataSetTableAdapters.SouvenirsTableAdapter souvenirsTableAdapter;
        private System.Windows.Forms.BindingSource souvenirTypesBindingSource;
        private SouvenirContextDataSetTableAdapters.SouvenirTypesTableAdapter souvenirTypesTableAdapter;
        private System.Windows.Forms.BindingSource souvenirTypesBindingSource1;
        private System.Windows.Forms.ListBox lstboxSouvenirs;
        private System.Windows.Forms.Button btnUpdate;
    }
}

