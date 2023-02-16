namespace Calculator
{
    partial class MainForm
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MinBtn = new System.Windows.Forms.Button();
            this.MaxBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.HistoryPanel = new System.Windows.Forms.Panel();
            this.HistoryBtn = new System.Windows.Forms.Button();
            this.FormulaPanel = new System.Windows.Forms.Panel();
            this.ResultPanel = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.HistoryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Controls.Add(this.MinBtn);
            this.TopPanel.Controls.Add(this.MaxBtn);
            this.TopPanel.Controls.Add(this.CloseBtn);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(384, 32);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(38, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "LB计算器";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Calculator.Properties.Resources.CalculatorAppicon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MinBtn
            // 
            this.MinBtn.BackgroundImage = global::Calculator.Properties.Resources.Min;
            this.MinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MinBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.Location = new System.Drawing.Point(246, 0);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(46, 32);
            this.MinBtn.TabIndex = 2;
            this.MinBtn.UseVisualStyleBackColor = true;
            // 
            // MaxBtn
            // 
            this.MaxBtn.BackgroundImage = global::Calculator.Properties.Resources.Max;
            this.MaxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MaxBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxBtn.Location = new System.Drawing.Point(292, 0);
            this.MaxBtn.Name = "MaxBtn";
            this.MaxBtn.Size = new System.Drawing.Size(46, 32);
            this.MaxBtn.TabIndex = 1;
            this.MaxBtn.UseVisualStyleBackColor = true;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackgroundImage = global::Calculator.Properties.Resources.Close;
            this.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Location = new System.Drawing.Point(338, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(46, 32);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.UseVisualStyleBackColor = true;
            // 
            // HistoryPanel
            // 
            this.HistoryPanel.Controls.Add(this.HistoryBtn);
            this.HistoryPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HistoryPanel.Location = new System.Drawing.Point(0, 32);
            this.HistoryPanel.Name = "HistoryPanel";
            this.HistoryPanel.Size = new System.Drawing.Size(384, 32);
            this.HistoryPanel.TabIndex = 1;
            // 
            // HistoryBtn
            // 
            this.HistoryBtn.BackgroundImage = global::Calculator.Properties.Resources.History;
            this.HistoryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HistoryBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.HistoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HistoryBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.HistoryBtn.Location = new System.Drawing.Point(352, 0);
            this.HistoryBtn.Name = "HistoryBtn";
            this.HistoryBtn.Size = new System.Drawing.Size(32, 32);
            this.HistoryBtn.TabIndex = 0;
            this.HistoryBtn.UseVisualStyleBackColor = true;
            // 
            // FormulaPanel
            // 
            this.FormulaPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormulaPanel.Location = new System.Drawing.Point(0, 64);
            this.FormulaPanel.Name = "FormulaPanel";
            this.FormulaPanel.Size = new System.Drawing.Size(384, 64);
            this.FormulaPanel.TabIndex = 2;
            // 
            // ResultPanel
            // 
            this.ResultPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ResultPanel.Location = new System.Drawing.Point(0, 128);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.Size = new System.Drawing.Size(384, 64);
            this.ResultPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 640);
            this.Controls.Add(this.ResultPanel);
            this.Controls.Add(this.FormulaPanel);
            this.Controls.Add(this.HistoryPanel);
            this.Controls.Add(this.TopPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.HistoryPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel TopPanel;
        private Label label1;
        private PictureBox pictureBox1;
        private Button MinBtn;
        private Button MaxBtn;
        private Button CloseBtn;
        private Panel HistoryPanel;
        private Button HistoryBtn;
        private Panel FormulaPanel;
        private Panel ResultPanel;
    }
}