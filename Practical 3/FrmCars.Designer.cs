namespace Practical_3
{
    partial class FrmCars
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
            this.grbD = new System.Windows.Forms.GroupBox();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.grbM = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblStudyDescription = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtCarDescription = new System.Windows.Forms.TextBox();
            this.lblTopicDescription = new System.Windows.Forms.Label();
            this.lblTopicId = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbManufacturer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grbD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.grbM.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbD
            // 
            this.grbD.Controls.Add(this.dgvCars);
            this.grbD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbD.Location = new System.Drawing.Point(15, 277);
            this.grbD.Name = "grbD";
            this.grbD.Size = new System.Drawing.Size(771, 157);
            this.grbD.TabIndex = 10;
            this.grbD.TabStop = false;
            this.grbD.Text = "Car Details";
            // 
            // dgvCars
            // 
            this.dgvCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Location = new System.Drawing.Point(13, 17);
            this.dgvCars.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.RowHeadersWidth = 51;
            this.dgvCars.RowTemplate.Height = 24;
            this.dgvCars.Size = new System.Drawing.Size(745, 135);
            this.dgvCars.TabIndex = 9;
            this.dgvCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCars_CellClick);
            // 
            // grbM
            // 
            this.grbM.Controls.Add(this.label2);
            this.grbM.Controls.Add(this.cmbManufacturer);
            this.grbM.Controls.Add(this.cmbModel);
            this.grbM.Controls.Add(this.label1);
            this.grbM.Controls.Add(this.txtPrice);
            this.grbM.Controls.Add(this.btnAdd);
            this.grbM.Controls.Add(this.lblStudyDescription);
            this.grbM.Controls.Add(this.btnUpdate);
            this.grbM.Controls.Add(this.btnBack);
            this.grbM.Controls.Add(this.btnList);
            this.grbM.Controls.Add(this.txtYear);
            this.grbM.Controls.Add(this.txtCarDescription);
            this.grbM.Controls.Add(this.lblTopicDescription);
            this.grbM.Controls.Add(this.lblTopicId);
            this.grbM.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbM.Location = new System.Drawing.Point(15, 16);
            this.grbM.Name = "grbM";
            this.grbM.Size = new System.Drawing.Size(771, 255);
            this.grbM.TabIndex = 9;
            this.grbM.TabStop = false;
            this.grbM.Text = "Manage Cars";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(324, 168);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(434, 29);
            this.txtPrice.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(324, 212);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 28);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblStudyDescription
            // 
            this.lblStudyDescription.AutoSize = true;
            this.lblStudyDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudyDescription.Location = new System.Drawing.Point(75, 100);
            this.lblStudyDescription.Name = "lblStudyDescription";
            this.lblStudyDescription.Size = new System.Drawing.Size(108, 19);
            this.lblStudyDescription.TabIndex = 101;
            this.lblStudyDescription.Text = "Car Description:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(434, 212);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 28);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(654, 212);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 28);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(544, 212);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(104, 28);
            this.btnList.TabIndex = 7;
            this.btnList.Text = "List All";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(324, 136);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(434, 29);
            this.txtYear.TabIndex = 3;
            // 
            // txtCarDescription
            // 
            this.txtCarDescription.Location = new System.Drawing.Point(324, 100);
            this.txtCarDescription.Name = "txtCarDescription";
            this.txtCarDescription.Size = new System.Drawing.Size(434, 29);
            this.txtCarDescription.TabIndex = 2;
            // 
            // lblTopicDescription
            // 
            this.lblTopicDescription.AutoSize = true;
            this.lblTopicDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopicDescription.Location = new System.Drawing.Point(73, 73);
            this.lblTopicDescription.Name = "lblTopicDescription";
            this.lblTopicDescription.Size = new System.Drawing.Size(52, 19);
            this.lblTopicDescription.TabIndex = 1;
            this.lblTopicDescription.Text = "Model:";
            // 
            // lblTopicId
            // 
            this.lblTopicId.AutoSize = true;
            this.lblTopicId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopicId.Location = new System.Drawing.Point(73, 38);
            this.lblTopicId.Name = "lblTopicId";
            this.lblTopicId.Size = new System.Drawing.Size(93, 19);
            this.lblTopicId.TabIndex = 0;
            this.lblTopicId.Text = "Manufacturer:";
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(324, 69);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(434, 29);
            this.cmbModel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 102;
            this.label1.Text = "Car Price:";
            // 
            // cmbManufacturer
            // 
            this.cmbManufacturer.FormattingEnabled = true;
            this.cmbManufacturer.Location = new System.Drawing.Point(324, 34);
            this.cmbManufacturer.Name = "cmbManufacturer";
            this.cmbManufacturer.Size = new System.Drawing.Size(434, 29);
            this.cmbManufacturer.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 105;
            this.label2.Text = "Car Release Year:";
            // 
            // FrmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbD);
            this.Controls.Add(this.grbM);
            this.Name = "FrmCars";
            this.Text = "FrmCars";
            this.Load += new System.EventHandler(this.FrmCars_Load);
            this.grbD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.grbM.ResumeLayout(false);
            this.grbM.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbD;
        private System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.GroupBox grbM;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblStudyDescription;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtCarDescription;
        private System.Windows.Forms.Label lblTopicDescription;
        private System.Windows.Forms.Label lblTopicId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbManufacturer;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label label1;
    }
}