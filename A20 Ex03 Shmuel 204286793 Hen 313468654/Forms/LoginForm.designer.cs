namespace A20_Ex03_Shmuel_204286793_Hen_313468654
{
    public partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.FBLoginButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Explantion = new System.Windows.Forms.Label();
            this.TryItNowLabel = new System.Windows.Forms.Label();
            this.DownArrowLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FBLoginButton
            // 
            this.FBLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.FBLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FBLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FBLoginButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FBLoginButton.ForeColor = System.Drawing.Color.White;
            this.FBLoginButton.Location = new System.Drawing.Point(348, 485);
            this.FBLoginButton.Name = "FBLoginButton";
            this.FBLoginButton.Size = new System.Drawing.Size(181, 52);
            this.FBLoginButton.TabIndex = 0;
            this.FBLoginButton.Text = "Log In";
            this.FBLoginButton.UseVisualStyleBackColor = false;
            this.FBLoginButton.Click += new System.EventHandler(this.FBLoginButton_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 32.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.Title.Location = new System.Drawing.Point(175, 50);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(531, 59);
            this.Title.TabIndex = 1;
            this.Title.Text = "FaceBook Expansion App";
            // 
            // Explantion
            // 
            this.Explantion.BackColor = System.Drawing.Color.Transparent;
            this.Explantion.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Explantion.ForeColor = System.Drawing.Color.White;
            this.Explantion.Location = new System.Drawing.Point(235, 143);
            this.Explantion.Name = "Explantion";
            this.Explantion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Explantion.Size = new System.Drawing.Size(408, 233);
            this.Explantion.TabIndex = 2;
            this.Explantion.Text = "Find out who you can date on your friends list and what your most popular topics " +
    "on your Facebook ";
            this.Explantion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TryItNowLabel
            // 
            this.TryItNowLabel.BackColor = System.Drawing.Color.Transparent;
            this.TryItNowLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TryItNowLabel.ForeColor = System.Drawing.Color.White;
            this.TryItNowLabel.Location = new System.Drawing.Point(251, 376);
            this.TryItNowLabel.Name = "TryItNowLabel";
            this.TryItNowLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TryItNowLabel.Size = new System.Drawing.Size(374, 46);
            this.TryItNowLabel.TabIndex = 3;
            this.TryItNowLabel.Text = "Try It Now";
            this.TryItNowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DownArrowLabel
            // 
            this.DownArrowLabel.AutoSize = true;
            this.DownArrowLabel.BackColor = System.Drawing.Color.Transparent;
            this.DownArrowLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownArrowLabel.ForeColor = System.Drawing.Color.White;
            this.DownArrowLabel.Location = new System.Drawing.Point(414, 413);
            this.DownArrowLabel.Name = "DownArrowLabel";
            this.DownArrowLabel.Size = new System.Drawing.Size(55, 65);
            this.DownArrowLabel.TabIndex = 4;
            this.DownArrowLabel.Text = "⬇";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 571);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "©Muli Orgatz Hen Someh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::A20_Ex03_Shmuel_204286793_Hen_313468654.Properties.Resources.LoginBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(885, 582);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DownArrowLabel);
            this.Controls.Add(this.TryItNowLabel);
            this.Controls.Add(this.Explantion);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.FBLoginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login To FaceBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FBLoginButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Explantion;
        private System.Windows.Forms.Label TryItNowLabel;
        private System.Windows.Forms.Label DownArrowLabel;
        private System.Windows.Forms.Label label1;
    }
}