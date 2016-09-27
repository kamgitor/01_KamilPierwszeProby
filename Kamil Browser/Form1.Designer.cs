namespace Kamil_Browser
{
    partial class Form1
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
            this.baton = new System.Windows.Forms.Button();
            this.klikacz = new System.Windows.Forms.CheckBox();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.nawigacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.domToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wróćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naprzódToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // baton
            // 
            this.baton.Location = new System.Drawing.Point(187, 45);
            this.baton.Name = "baton";
            this.baton.Size = new System.Drawing.Size(75, 23);
            this.baton.TabIndex = 0;
            this.baton.Text = "Baton";
            this.baton.UseVisualStyleBackColor = true;
            this.baton.Click += new System.EventHandler(this.baton_Click);
            // 
            // klikacz
            // 
            this.klikacz.AutoSize = true;
            this.klikacz.Location = new System.Drawing.Point(187, 105);
            this.klikacz.Name = "klikacz";
            this.klikacz.Size = new System.Drawing.Size(60, 17);
            this.klikacz.TabIndex = 1;
            this.klikacz.Text = "Klikacz";
            this.klikacz.UseVisualStyleBackColor = true;
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nawigacjaToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(655, 24);
            this.menuStrip3.TabIndex = 4;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // nawigacjaToolStripMenuItem
            // 
            this.nawigacjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.domToolStripMenuItem,
            this.wróćToolStripMenuItem,
            this.naprzódToolStripMenuItem});
            this.nawigacjaToolStripMenuItem.Name = "nawigacjaToolStripMenuItem";
            this.nawigacjaToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.nawigacjaToolStripMenuItem.Text = "Nawigacja";
            // 
            // domToolStripMenuItem
            // 
            this.domToolStripMenuItem.Name = "domToolStripMenuItem";
            this.domToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.domToolStripMenuItem.Text = "Dom";
            // 
            // wróćToolStripMenuItem
            // 
            this.wróćToolStripMenuItem.Name = "wróćToolStripMenuItem";
            this.wróćToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.wróćToolStripMenuItem.Text = "Wróć";
            // 
            // naprzódToolStripMenuItem
            // 
            this.naprzódToolStripMenuItem.Name = "naprzódToolStripMenuItem";
            this.naprzódToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.naprzódToolStripMenuItem.Text = "Naprzód";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(347, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 534);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.klikacz);
            this.Controls.Add(this.baton);
            this.Controls.Add(this.menuStrip3);
            this.Name = "Form1";
            this.Text = "Kamil Browser";
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button baton;
        private System.Windows.Forms.CheckBox klikacz;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem nawigacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem domToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wróćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naprzódToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

