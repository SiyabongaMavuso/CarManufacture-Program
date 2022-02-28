namespace Practical_3
{
    partial class FrmManufacture
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
            this.dgvManufacture = new System.Windows.Forms.DataGridView();
            this.grbM = new System.Windows.Forms.GroupBox();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblStudyDescription = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.txtManufacturerLocation = new System.Windows.Forms.TextBox();
            this.txtManufacturerDescription = new System.Windows.Forms.TextBox();
            this.lblTopicDescription = new System.Windows.Forms.Label();
            this.lblTopicId = new System.Windows.Forms.Label();
            this.grbD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManufacture)).BeginInit();
            this.grbM.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbD
            // 
            this.grbD.Controls.Add(this.dgvManufacture);
            this.grbD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbD.Location = new System.Drawing.Point(15, 216);
            this.grbD.Name = "grbD";
            this.grbD.Size = new System.Drawing.Size(771, 218);
            this.grbD.TabIndex = 8;
            this.grbD.TabStop = false;
            this.grbD.Text = "Display Manufacturers";
            // 
            // dgvManufacture
            // 
            this.dgvManufacture.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvManufacture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManufacture.Location = new System.Drawing.Point(13, 17);
            this.dgvManufacture.Margin = new System.Windows.Forms.Padding(2);
            this.dgvManufacture.Name = "dgvManufacture";
            this.dgvManufacture.RowHeadersWidth = 51;
            this.dgvManufacture.RowTemplate.Height = 24;
            this.dgvManufacture.Size = new System.Drawing.Size(745, 185);
            this.dgvManufacture.TabIndex = 7;
            this.dgvManufacture.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvManufacture_CellClick);
            // 
            // grbM
            // 
            this.grbM.Controls.Add(this.txtContactPerson);
            this.grbM.Controls.Add(this.btnAdd);
            this.grbM.Controls.Add(this.lblStudyDescription);
            this.grbM.Controls.Add(this.btnUpdate);
            this.grbM.Controls.Add(this.btnBack);
            this.grbM.Controls.Add(this.btnList);
            this.grbM.Controls.Add(this.txtManufacturerLocation);
            this.grbM.Controls.Add(this.txtManufacturerDescription);
            this.grbM.Controls.Add(this.lblTopicDescription);
            this.grbM.Controls.Add(this.lblTopicId);
            this.grbM.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbM.Location = new System.Drawing.Point(15, 16);
            this.grbM.Name = "grbM";
            this.grbM.Size = new System.Drawing.Size(771, 194);
            this.grbM.TabIndex = 7;
            this.grbM.TabStop = false;
            this.grbM.Text = "Manufacturer Details";
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.Location = new System.Drawing.Point(322, 95);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(434, 29);
            this.txtContactPerson.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(322, 133);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 28);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblStudyDescription
            // 
            this.lblStudyDescription.AutoSize = true;
            this.lblStudyDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudyDescription.Location = new System.Drawing.Point(73, 99);
            this.lblStudyDescription.Name = "lblStudyDescription";
            this.lblStudyDescription.Size = new System.Drawing.Size(106, 19);
            this.lblStudyDescription.TabIndex = 101;
            this.lblStudyDescription.Text = "Contact Person:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(432, 133);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 28);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(652, 133);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 28);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(542, 133);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(104, 28);
            this.btnList.TabIndex = 5;
            this.btnList.Text = "List All";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // txtManufacturerLocation
            // 
            this.txtManufacturerLocation.Location = new System.Drawing.Point(322, 63);
            this.txtManufacturerLocation.Name = "txtManufacturerLocation";
            this.txtManufacturerLocation.Size = new System.Drawing.Size(434, 29);
            this.txtManufacturerLocation.TabIndex = 1;
            // 
            // txtManufacturerDescription
            // 
            this.txtManufacturerDescription.Location = new System.Drawing.Point(322, 27);
            this.txtManufacturerDescription.Name = "txtManufacturerDescription";
            this.txtManufacturerDescription.Size = new System.Drawing.Size(434, 29);
            this.txtManufacturerDescription.TabIndex = 0;
            // 
            // lblTopicDescription
            // 
            this.lblTopicDescription.AutoSize = true;
            this.lblTopicDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopicDescription.Location = new System.Drawing.Point(73, 63);
            this.lblTopicDescription.Name = "lblTopicDescription";
            this.lblTopicDescription.Size = new System.Drawing.Size(150, 19);
            this.lblTopicDescription.TabIndex = 1;
            this.lblTopicDescription.Text = "Manufacturer Location:";
            // 
            // lblTopicId
            // 
            this.lblTopicId.AutoSize = true;
            this.lblTopicId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopicId.Location = new System.Drawing.Point(73, 38);
            this.lblTopicId.Name = "lblTopicId";
            this.lblTopicId.Size = new System.Drawing.Size(166, 19);
            this.lblTopicId.TabIndex = 0;
            this.lblTopicId.Text = "Manufacturer Description:";
            // 
            // FrmManufacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbD);
            this.Controls.Add(this.grbM);
            this.Name = "FrmManufacture";
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.grbD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManufacture)).EndInit();
            this.grbM.ResumeLayout(false);
            this.grbM.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbD;
        private System.Windows.Forms.GroupBox grbM;
        private System.Windows.Forms.TextBox txtContactPerson;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblStudyDescription;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtManufacturerLocation;
        private System.Windows.Forms.TextBox txtManufacturerDescription;
        private System.Windows.Forms.Label lblTopicDescription;
        private System.Windows.Forms.Label lblTopicId;
        private System.Windows.Forms.DataGridView dgvManufacture;
    }
}