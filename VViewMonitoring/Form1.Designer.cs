namespace VViewMonitoring
{
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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            label1 = new Label();
            dgvIisSites = new DataGridView();
            label2 = new Label();
            dgvServices = new DataGridView();
            lblLastUpdated = new Label();
            refreshTimer = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            dataGridView1 = new DataGridView();
            lblLastUpdated2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvIisSites).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(60, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(244, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "VView System Monitoring";
            lblTitle.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(136, 45);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 1;
            label1.Text = "IIS Websites";
            label1.Click += label1_Click_1;
            // 
            // dgvIisSites
            // 
            dgvIisSites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIisSites.Location = new Point(12, 63);
            dgvIisSites.Name = "dgvIisSites";
            dgvIisSites.Size = new Size(368, 113);
            dgvIisSites.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(136, 199);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 3;
            label2.Text = "Windows Services";
            label2.Click += label2_Click;
            // 
            // dgvServices
            // 
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.Location = new Point(12, 217);
            dgvServices.Name = "dgvServices";
            dgvServices.Size = new Size(368, 113);
            dgvServices.TabIndex = 4;
            // 
            // lblLastUpdated
            // 
            lblLastUpdated.AutoSize = true;
            lblLastUpdated.Location = new Point(12, 343);
            lblLastUpdated.Name = "lblLastUpdated";
            lblLastUpdated.Size = new Size(79, 15);
            lblLastUpdated.TabIndex = 5;
            lblLastUpdated.Text = "Last Updated:";
            // 
            // refreshTimer
            // 
            refreshTimer.Interval = 5000;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(429, 9);
            label3.Name = "label3";
            label3.Size = new Size(333, 25);
            label3.TabIndex = 6;
            label3.Text = "VView Windows Service Monitoring";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(411, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(368, 113);
            dataGridView1.TabIndex = 7;
            // 
            // lblLastUpdated2
            // 
            lblLastUpdated2.AutoSize = true;
            lblLastUpdated2.Location = new Point(449, 343);
            lblLastUpdated2.Name = "lblLastUpdated2";
            lblLastUpdated2.Size = new Size(79, 15);
            lblLastUpdated2.TabIndex = 8;
            lblLastUpdated2.Text = "Last Updated:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLastUpdated2);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(lblLastUpdated);
            Controls.Add(dgvServices);
            Controls.Add(label2);
            Controls.Add(dgvIisSites);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvIisSites).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label1;
        private DataGridView dgvIisSites;
        private Label label2;
        private DataGridView dgvServices;
        private Label lblLastUpdated;
        private System.Windows.Forms.Timer refreshTimer;
        private Label label3;
        private DataGridView dataGridView1;
        private Label lblLastUpdated2;
    }
}
