namespace CSharpMongoDBTest
{
    partial class FormMain
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
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnInsertOne = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnListDB = new System.Windows.Forms.Button();
            this.btnQueryAll = new System.Windows.Forms.Button();
            this.btnSkipLimit = new System.Windows.Forms.Button();
            this.btnProjections = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsertMany = new System.Windows.Forms.Button();
            this.btnDropDB = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(38, 160);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(141, 54);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnInsertOne
            // 
            this.btnInsertOne.Location = new System.Drawing.Point(38, 242);
            this.btnInsertOne.Name = "btnInsertOne";
            this.btnInsertOne.Size = new System.Drawing.Size(141, 54);
            this.btnInsertOne.TabIndex = 1;
            this.btnInsertOne.Text = "Insert One";
            this.btnInsertOne.UseVisualStyleBackColor = true;
            this.btnInsertOne.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(38, 77);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(141, 54);
            this.btnStatus.TabIndex = 2;
            this.btnStatus.Text = "Status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnListDB
            // 
            this.btnListDB.Location = new System.Drawing.Point(271, 77);
            this.btnListDB.Name = "btnListDB";
            this.btnListDB.Size = new System.Drawing.Size(141, 54);
            this.btnListDB.TabIndex = 3;
            this.btnListDB.Text = "List DB";
            this.btnListDB.UseVisualStyleBackColor = true;
            this.btnListDB.Click += new System.EventHandler(this.btnListDB_Click);
            // 
            // btnQueryAll
            // 
            this.btnQueryAll.Location = new System.Drawing.Point(271, 160);
            this.btnQueryAll.Name = "btnQueryAll";
            this.btnQueryAll.Size = new System.Drawing.Size(141, 54);
            this.btnQueryAll.TabIndex = 4;
            this.btnQueryAll.Text = "Query All";
            this.btnQueryAll.UseVisualStyleBackColor = true;
            this.btnQueryAll.Click += new System.EventHandler(this.btnQueryAll_Click);
            // 
            // btnSkipLimit
            // 
            this.btnSkipLimit.Location = new System.Drawing.Point(271, 327);
            this.btnSkipLimit.Name = "btnSkipLimit";
            this.btnSkipLimit.Size = new System.Drawing.Size(141, 54);
            this.btnSkipLimit.TabIndex = 5;
            this.btnSkipLimit.Text = "Skip and Limit";
            this.btnSkipLimit.UseVisualStyleBackColor = true;
            this.btnSkipLimit.Click += new System.EventHandler(this.btnSkipLimit_Click);
            // 
            // btnProjections
            // 
            this.btnProjections.Location = new System.Drawing.Point(38, 327);
            this.btnProjections.Name = "btnProjections";
            this.btnProjections.Size = new System.Drawing.Size(141, 54);
            this.btnProjections.TabIndex = 6;
            this.btnProjections.Text = "Projections";
            this.btnProjections.UseVisualStyleBackColor = true;
            this.btnProjections.Click += new System.EventHandler(this.btnProjections_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(38, 407);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 54);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(38, 479);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(141, 54);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsertMany
            // 
            this.btnInsertMany.Location = new System.Drawing.Point(271, 242);
            this.btnInsertMany.Name = "btnInsertMany";
            this.btnInsertMany.Size = new System.Drawing.Size(141, 54);
            this.btnInsertMany.TabIndex = 9;
            this.btnInsertMany.Text = "Insert Many";
            this.btnInsertMany.UseVisualStyleBackColor = true;
            this.btnInsertMany.Click += new System.EventHandler(this.btnInsertMany_Click);
            // 
            // btnDropDB
            // 
            this.btnDropDB.Location = new System.Drawing.Point(271, 407);
            this.btnDropDB.Name = "btnDropDB";
            this.btnDropDB.Size = new System.Drawing.Size(141, 54);
            this.btnDropDB.TabIndex = 10;
            this.btnDropDB.Text = "Drop DB";
            this.btnDropDB.UseVisualStyleBackColor = true;
            this.btnDropDB.Click += new System.EventHandler(this.btnDropDB_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(129, 26);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(283, 25);
            this.txtIP.TabIndex = 11;
            this.txtIP.Text = "10.2.21.39";
            this.txtIP.TextChanged += new System.EventHandler(this.txtIP_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "IP Addess:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnDropDB);
            this.Controls.Add(this.btnInsertMany);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnProjections);
            this.Controls.Add(this.btnSkipLimit);
            this.Controls.Add(this.btnQueryAll);
            this.Controls.Add(this.btnListDB);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.btnInsertOne);
            this.Controls.Add(this.btnQuery);
            this.Name = "FormMain";
            this.Text = "CSharpMongoDB Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnInsertOne;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnListDB;
        private System.Windows.Forms.Button btnQueryAll;
        private System.Windows.Forms.Button btnSkipLimit;
        private System.Windows.Forms.Button btnProjections;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsertMany;
        private System.Windows.Forms.Button btnDropDB;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
    }
}

