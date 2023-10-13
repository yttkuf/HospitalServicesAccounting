namespace HospitalSystem
{
    partial class CommandPromtForm
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
            this.commandTextBox = new System.Windows.Forms.TextBox();
            this.RunCommandButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // commandTextBox
            // 
            this.commandTextBox.Location = new System.Drawing.Point(12, 12);
            this.commandTextBox.Multiline = true;
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.Size = new System.Drawing.Size(594, 150);
            this.commandTextBox.TabIndex = 0;
            // 
            // RunCommandButton
            // 
            this.RunCommandButton.BackColor = System.Drawing.Color.Azure;
            this.RunCommandButton.Location = new System.Drawing.Point(473, 181);
            this.RunCommandButton.Name = "RunCommandButton";
            this.RunCommandButton.Size = new System.Drawing.Size(133, 36);
            this.RunCommandButton.TabIndex = 6;
            this.RunCommandButton.Text = "Выполнить";
            this.RunCommandButton.UseVisualStyleBackColor = false;
            // 
            // CommandPromtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 229);
            this.Controls.Add(this.RunCommandButton);
            this.Controls.Add(this.commandTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CommandPromtForm";
            this.Text = "Выполнить DML/DDL команду";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox commandTextBox;
        private System.Windows.Forms.Button RunCommandButton;
    }
}