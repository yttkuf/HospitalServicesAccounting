namespace HospitalSystem
{
    partial class AdminForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.специалистыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pricesBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.соединениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выполнитьКомандуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.личныйКабинетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.специалистыToolStripMenuItem,
            this.pricesBtn,
            this.соединениеToolStripMenuItem,
            this.выполнитьКомандуToolStripMenuItem,
            this.личныйКабинетToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // специалистыToolStripMenuItem
            // 
            this.специалистыToolStripMenuItem.Name = "специалистыToolStripMenuItem";
            this.специалистыToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.специалистыToolStripMenuItem.Text = "Специалисты";
            // 
            // pricesBtn
            // 
            this.pricesBtn.Name = "pricesBtn";
            this.pricesBtn.Size = new System.Drawing.Size(50, 22);
            this.pricesBtn.Text = "Цены";
            // 
            // соединениеToolStripMenuItem
            // 
            this.соединениеToolStripMenuItem.Name = "соединениеToolStripMenuItem";
            this.соединениеToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.соединениеToolStripMenuItem.Text = "Соединение";
            // 
            // выполнитьКомандуToolStripMenuItem
            // 
            this.выполнитьКомандуToolStripMenuItem.Name = "выполнитьКомандуToolStripMenuItem";
            this.выполнитьКомандуToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.выполнитьКомандуToolStripMenuItem.Text = "Выполнить команду";
            // 
            // личныйКабинетToolStripMenuItem
            // 
            this.личныйКабинетToolStripMenuItem.Name = "личныйКабинетToolStripMenuItem";
            this.личныйКабинетToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.личныйКабинетToolStripMenuItem.Text = "Личный кабинет";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "AdminForm";
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem специалистыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pricesBtn;
        private System.Windows.Forms.ToolStripMenuItem соединениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выполнитьКомандуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem личныйКабинетToolStripMenuItem;
    }
}