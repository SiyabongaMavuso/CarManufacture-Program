namespace Practical_3
{
    partial class FrmModel
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
            this.dgvModel = new System.Windows.Forms.DataGridView();
            this.lblTopicId = new System.Windows.Forms.Label();
            this.lblTopicDescription = new System.Windows.Forms.Label();
            this.txtModelDescription = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grbM = new System.Windows.Forms.GroupBox();
            this.cmbManufacturer = new System.Windows.Forms.ComboBox();
            this.grbD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModel)).BeginInit();
            this.grbM.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbD
            // 
            this.grbD.Controls.Add(this.dgvModel);
            this.grbD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbD.Location = new System.Drawing.Point(15, 176);
            this.grbD.Name = "grbD";
            this.grbD.Size = new System.Drawing.Size(771, 258);
            this.grbD.TabIndex = 10;
            this.grbD.TabStop = false;
            this.grbD.Text = "All Model Details";
            // 
            // dgvModel
            // 
            this.dgvModel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModel.Location = new System.Drawing.Point(13, 17);
            this.dgvModel.Margin = new System.Windows.Forms.Padding(2);
            this.dgvModel.Name = "dgvModel";
            this.dgvModel.RowHeadersWidth = 51;
            this.dgvModel.RowTemplate.Height = 24;
            this.dgvModel.Size = new System.Drawing.Size(745, 229);
            this.dgvModel.TabIndex = 6;
            this.dgvModel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvModel_CellClick);
            // 
            // lblTopicId
            // 
            this.lblTopicId.AutoSize = true;
            this.lblTopicId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopicId.Location = new System.Drawing.Point(73, 38);
            this.lblTopicId.Name = "lblTopicId";
            this.lblTopicId.Size = new System.Drawing.Size(125, 19);
            this.lblTopicId.TabIndex = 0;
            this.lblTopicId.Text = "Model Description:";
            // 
            // lblTopicDescription
            // 
            this.lblTopicDescription.AutoSize = true;
            this.lblTopicDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopicDescription.Location = new System.Drawing.Point(73, 63);
            this.lblTopicDescription.Name = "lblTopicDescription";
            this.lblTopicDescription.Size = new System.Drawing.Size(93, 19);
            this.lblTopicDescription.TabIndex = 1;
            this.lblTopicDescription.Text = "Manufacturer:";
            // 
            // txtModelDescription
            // 
            this.txtModelDescription.Location = new System.Drawing.Point(322, 27);
            this.txtModelDescription.Name = "txtModelDescription";
            this.txtModelDescription.Size = new System.Drawing.Size(434, 29);
            this.txtModelDescription.TabIndex = 0;
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(542, 106);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(104, 28);
            this.btnList.TabIndex = 4;
            this.btnList.Text = "List All";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(652, 106);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 28);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(432, 106);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 28);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(322, 106);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 28);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // grbM
            // 
            this.grbM.Controls.Add(this.cmbManufacturer);
            this.grbM.Controls.Add(this.btnAdd);
            this.grbM.Controls.Add(this.btnUpdate);
            this.grbM.Controls.Add(this.btnBack);
            this.grbM.Controls.Add(this.btnList);
            this.grbM.Controls.Add(this.txtModelDescription);
            this.grbM.Controls.Add(this.lblTopicDescription);
            this.grbM.Controls.Add(this.lblTopicId);
            this.grbM.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbM.Location = new System.Drawing.Point(15, 16);
            this.grbM.Name = "grbM";
            this.grbM.Size = new System.Drawing.Size(771, 154);
            this.grbM.TabIndex = 9;
            this.grbM.TabStop = false;
            this.grbM.Text = "Manage Models";
            // 
            // cmbManufacturer
            // 
            this.cmbManufacturer.FormattingEnabled = true;
            this.cmbManufacturer.Location = new System.Drawing.Point(322, 59);
            this.cmbManufacturer.Name = "cmbManufacturer";
            this.cmbManufacturer.Size = new System.Drawing.Size(434, 29);
            this.cmbManufacturer.TabIndex = 1;
            // 
            // FrmModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbD);
            this.Controls.Add(this.grbM);
            this.Name = "FrmModel";
            this.Text = "FrmModel";
            this.Load += new System.EventHandler(this.FrmModel_Load);
            this.grbD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModel)).EndInit();
            this.grbM.ResumeLayout(false);
            this.grbM.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbD;
        private System.Windows.Forms.DataGridView dgvModel;
        private System.Windows.Forms.Label lblTopicId;
        private System.Windows.Forms.Label lblTopicDescription;
        private System.Windows.Forms.TextBox txtModelDescription;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grbM;
        private System.Windows.Forms.ComboBox cmbManufacturer;
    }
}