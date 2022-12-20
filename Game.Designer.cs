namespace GameOfLife
{
    partial class PlayingGrid
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
            this.btnDefaultLayout = new System.Windows.Forms.Button();
            this.btnCollideLayout = new System.Windows.Forms.Button();
            this.btnRotorLayout = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblStepTitle = new System.Windows.Forms.Label();
            this.lblSteps = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDefaultLayout
            // 
            this.btnDefaultLayout.Location = new System.Drawing.Point(676, 10);
            this.btnDefaultLayout.Margin = new System.Windows.Forms.Padding(2);
            this.btnDefaultLayout.Name = "btnDefaultLayout";
            this.btnDefaultLayout.Size = new System.Drawing.Size(67, 41);
            this.btnDefaultLayout.TabIndex = 0;
            this.btnDefaultLayout.Text = "Default";
            this.btnDefaultLayout.UseVisualStyleBackColor = true;
            this.btnDefaultLayout.Click += new System.EventHandler(this.btnDefaultLayout_Click);
            // 
            // btnCollideLayout
            // 
            this.btnCollideLayout.Location = new System.Drawing.Point(676, 101);
            this.btnCollideLayout.Margin = new System.Windows.Forms.Padding(2);
            this.btnCollideLayout.Name = "btnCollideLayout";
            this.btnCollideLayout.Size = new System.Drawing.Size(67, 41);
            this.btnCollideLayout.TabIndex = 1;
            this.btnCollideLayout.Text = "Collide";
            this.btnCollideLayout.UseVisualStyleBackColor = true;
            this.btnCollideLayout.Click += new System.EventHandler(this.btnCollideLayout_Click);
            // 
            // btnRotorLayout
            // 
            this.btnRotorLayout.Location = new System.Drawing.Point(676, 55);
            this.btnRotorLayout.Margin = new System.Windows.Forms.Padding(2);
            this.btnRotorLayout.Name = "btnRotorLayout";
            this.btnRotorLayout.Size = new System.Drawing.Size(67, 41);
            this.btnRotorLayout.TabIndex = 2;
            this.btnRotorLayout.Text = "Rotor";
            this.btnRotorLayout.UseVisualStyleBackColor = true;
            this.btnRotorLayout.Click += new System.EventHandler(this.btnRotorLayout_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(674, 377);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(67, 41);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(674, 332);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(67, 41);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Step";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(674, 423);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(67, 41);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblStepTitle
            // 
            this.lblStepTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStepTitle.Location = new System.Drawing.Point(674, 473);
            this.lblStepTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStepTitle.Name = "lblStepTitle";
            this.lblStepTitle.Size = new System.Drawing.Size(67, 17);
            this.lblStepTitle.TabIndex = 7;
            this.lblStepTitle.Text = "Current Step:";
            this.lblStepTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStepTitle.UseMnemonic = false;
            // 
            // lblSteps
            // 
            this.lblSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteps.Location = new System.Drawing.Point(674, 490);
            this.lblSteps.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(67, 68);
            this.lblSteps.TabIndex = 9;
            this.lblSteps.Text = "0";
            this.lblSteps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSteps.UseMnemonic = false;
            // 
            // PlayingGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 571);
            this.Controls.Add(this.lblSteps);
            this.Controls.Add(this.lblStepTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnRotorLayout);
            this.Controls.Add(this.btnCollideLayout);
            this.Controls.Add(this.btnDefaultLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PlayingGrid";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game of Life";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDefaultLayout;
        private System.Windows.Forms.Button btnCollideLayout;
        private System.Windows.Forms.Button btnRotorLayout;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblStepTitle;
        private System.Windows.Forms.Label lblSteps;
    }
}

