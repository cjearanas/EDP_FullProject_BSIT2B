namespace LoginForm
{
    partial class frmHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBck = new System.Windows.Forms.Button();
            this.btnTimeClock = new System.Windows.Forms.Button();
            this.btnVendors = new System.Windows.Forms.Button();
            this.btnStoreStatus = new System.Windows.Forms.Button();
            this.btnPricebook = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome!";
            // 
            // btnBck
            // 
            this.btnBck.Image = global::LoginForm.Properties.Resources.image_removebg_preview__7_;
            this.btnBck.Location = new System.Drawing.Point(12, 526);
            this.btnBck.Name = "btnBck";
            this.btnBck.Size = new System.Drawing.Size(75, 75);
            this.btnBck.TabIndex = 7;
            this.btnBck.UseVisualStyleBackColor = true;
            this.btnBck.Click += new System.EventHandler(this.btnBck_Click);
            // 
            // btnTimeClock
            // 
            this.btnTimeClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeClock.Image = global::LoginForm.Properties.Resources.image_removebg_preview__6_;
            this.btnTimeClock.Location = new System.Drawing.Point(723, 315);
            this.btnTimeClock.Name = "btnTimeClock";
            this.btnTimeClock.Size = new System.Drawing.Size(325, 205);
            this.btnTimeClock.TabIndex = 6;
            this.btnTimeClock.Text = "Time Clock";
            this.btnTimeClock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTimeClock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTimeClock.UseVisualStyleBackColor = true;
            this.btnTimeClock.Click += new System.EventHandler(this.btnTimeClock_Click);
            // 
            // btnVendors
            // 
            this.btnVendors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendors.Image = global::LoginForm.Properties.Resources.image_removebg_preview__3_;
            this.btnVendors.Location = new System.Drawing.Point(12, 315);
            this.btnVendors.Name = "btnVendors";
            this.btnVendors.Size = new System.Drawing.Size(325, 205);
            this.btnVendors.TabIndex = 5;
            this.btnVendors.Text = "Vendors";
            this.btnVendors.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVendors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVendors.UseVisualStyleBackColor = true;
            this.btnVendors.Click += new System.EventHandler(this.btnVendors_Click);
            // 
            // btnStoreStatus
            // 
            this.btnStoreStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStoreStatus.Image = global::LoginForm.Properties.Resources.image_removebg_preview__1_;
            this.btnStoreStatus.Location = new System.Drawing.Point(372, 76);
            this.btnStoreStatus.Name = "btnStoreStatus";
            this.btnStoreStatus.Size = new System.Drawing.Size(325, 205);
            this.btnStoreStatus.TabIndex = 4;
            this.btnStoreStatus.Text = "StoreStatus";
            this.btnStoreStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStoreStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStoreStatus.UseVisualStyleBackColor = true;
            this.btnStoreStatus.Click += new System.EventHandler(this.btnStoreStatus_Click);
            // 
            // btnPricebook
            // 
            this.btnPricebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPricebook.Image = global::LoginForm.Properties.Resources.image_removebg_preview__2_;
            this.btnPricebook.Location = new System.Drawing.Point(723, 76);
            this.btnPricebook.Name = "btnPricebook";
            this.btnPricebook.Size = new System.Drawing.Size(325, 205);
            this.btnPricebook.TabIndex = 3;
            this.btnPricebook.Text = "Pricebook";
            this.btnPricebook.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPricebook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPricebook.UseVisualStyleBackColor = true;
            this.btnPricebook.Click += new System.EventHandler(this.btnPricebook_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Image = global::LoginForm.Properties.Resources.image_removebg_preview__5_;
            this.btnUsers.Location = new System.Drawing.Point(372, 315);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(325, 205);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Image = global::LoginForm.Properties.Resources.image_removebg_preview;
            this.btnRegister.Location = new System.Drawing.Point(12, 76);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(325, 205);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 546);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hi! Carl Aranas";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 604);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBck);
            this.Controls.Add(this.btnTimeClock);
            this.Controls.Add(this.btnVendors);
            this.Controls.Add(this.btnStoreStatus);
            this.Controls.Add(this.btnPricebook);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label1);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnPricebook;
        private System.Windows.Forms.Button btnStoreStatus;
        private System.Windows.Forms.Button btnVendors;
        private System.Windows.Forms.Button btnTimeClock;
        private System.Windows.Forms.Button btnBck;
        private System.Windows.Forms.Label label2;
    }
}