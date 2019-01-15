namespace CS_MSG {
    partial class FrmStart {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelCopyRight = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.workerSSO = new System.ComponentModel.BackgroundWorker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCopyRight
            // 
            this.labelCopyRight.AutoSize = true;
            this.labelCopyRight.Location = new System.Drawing.Point(444, 369);
            this.labelCopyRight.Name = "labelCopyRight";
            this.labelCopyRight.Size = new System.Drawing.Size(65, 12);
            this.labelCopyRight.TabIndex = 0;
            this.labelCopyRight.Text = "copy right";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 339);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(696, 15);
            this.progressBar1.TabIndex = 1;
            // 
            // workerSSO
            // 
            this.workerSSO.WorkerReportsProgress = true;
            this.workerSSO.WorkerSupportsCancellation = true;
            this.workerSSO.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerSSO_DoWork);
            this.workerSSO.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workerSSO_ProgressChanged);
            this.workerSSO.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::CS_MSG.Properties.Resources.img_close;
            this.btnCancel.Location = new System.Drawing.Point(694, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(24, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = " ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CS_MSG.Properties.Resources.timg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(720, 401);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelCopyRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.Shown += new System.EventHandler(this.FrmStart_Shown);
            this.DoubleClick += new System.EventHandler(this.FrmStart_DoubleClick);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmStart_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCopyRight;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker workerSSO;
        private System.Windows.Forms.Button btnCancel;
    }
}

