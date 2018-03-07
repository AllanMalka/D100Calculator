namespace Warhammer40KRoller
{
    partial class WarhammerRoller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarhammerRoller));
            this.lblRolled = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtDifficulty = new System.Windows.Forms.TextBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.txtIRLRoll = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRolled
            // 
            this.lblRolled.AutoSize = true;
            this.lblRolled.BackColor = System.Drawing.SystemColors.Control;
            this.lblRolled.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolled.Location = new System.Drawing.Point(9, 160);
            this.lblRolled.Name = "lblRolled";
            this.lblRolled.Size = new System.Drawing.Size(131, 18);
            this.lblRolled.TabIndex = 0;
            this.lblRolled.Text = "D100 rolled result: ";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(9, 196);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(89, 18);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Label Empty";
            // 
            // txtDifficulty
            // 
            this.txtDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDifficulty.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDifficulty.Location = new System.Drawing.Point(12, 42);
            this.txtDifficulty.Name = "txtDifficulty";
            this.txtDifficulty.Size = new System.Drawing.Size(100, 24);
            this.txtDifficulty.TabIndex = 2;
            this.txtDifficulty.Text = "Difficulty";
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(22, 72);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(77, 26);
            this.btnRoll.TabIndex = 3;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // txtIRLRoll
            // 
            this.txtIRLRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIRLRoll.ForeColor = System.Drawing.Color.DarkGray;
            this.txtIRLRoll.Location = new System.Drawing.Point(12, 12);
            this.txtIRLRoll.Name = "txtIRLRoll";
            this.txtIRLRoll.Size = new System.Drawing.Size(100, 24);
            this.txtIRLRoll.TabIndex = 4;
            this.txtIRLRoll.Text = "In real life roll";
            // 
            // WarhammerRoller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(222, 223);
            this.Controls.Add(this.txtIRLRoll);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.txtDifficulty);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblRolled);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(238, 261);
            this.MinimumSize = new System.Drawing.Size(238, 261);
            this.Name = "WarhammerRoller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skull Probe";
            this.Load += new System.EventHandler(this.WarhammerRoller_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRolled;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtDifficulty;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.TextBox txtIRLRoll;
    }
}

