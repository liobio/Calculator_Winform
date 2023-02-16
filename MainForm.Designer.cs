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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.KeyPanel = new System.Windows.Forms.Panel();
            this.ResultPanel = new System.Windows.Forms.Panel();
            this.FormulaPanel = new System.Windows.Forms.Panel();
            this.HistoryPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.HistoryBtn = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MinBtn = new System.Windows.Forms.Button();
            this.MaxBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.HistoryPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.KeyPanel);
            this.MainPanel.Controls.Add(this.ResultPanel);
            this.MainPanel.Controls.Add(this.FormulaPanel);
            this.MainPanel.Controls.Add(this.HistoryPanel);
            this.MainPanel.Controls.Add(this.TopPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(1);
            this.MainPanel.Size = new System.Drawing.Size(384, 640);
            this.MainPanel.TabIndex = 4;
            this.MainPanel.MouseLeave += new System.EventHandler(this.Main_Leave);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // KeyPanel
            // 
            this.KeyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeyPanel.Location = new System.Drawing.Point(1, 193);
            this.KeyPanel.Name = "KeyPanel";
            this.KeyPanel.Size = new System.Drawing.Size(382, 446);
            this.KeyPanel.TabIndex = 8;
            // 
            // ResultPanel
            // 
            this.ResultPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ResultPanel.Location = new System.Drawing.Point(1, 129);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.Size = new System.Drawing.Size(382, 64);
            this.ResultPanel.TabIndex = 7;
            // 
            // FormulaPanel
            // 
            this.FormulaPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormulaPanel.Location = new System.Drawing.Point(1, 65);
            this.FormulaPanel.Name = "FormulaPanel";
            this.FormulaPanel.Size = new System.Drawing.Size(382, 64);
            this.FormulaPanel.TabIndex = 6;
            // 
            // HistoryPanel
            // 
            this.HistoryPanel.Controls.Add(this.button1);
            this.HistoryPanel.Controls.Add(this.HistoryBtn);
            this.HistoryPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HistoryPanel.Location = new System.Drawing.Point(1, 33);
            this.HistoryPanel.Name = "HistoryPanel";
            this.HistoryPanel.Size = new System.Drawing.Size(382, 32);
            this.HistoryPanel.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Calculator.Properties.Resources.History;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(318, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.TestEventClick);
            // 
            // HistoryBtn
            // 
            this.HistoryBtn.BackgroundImage = global::Calculator.Properties.Resources.History;
            this.HistoryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HistoryBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.HistoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HistoryBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.HistoryBtn.Location = new System.Drawing.Point(350, 0);
            this.HistoryBtn.Name = "HistoryBtn";
            this.HistoryBtn.Size = new System.Drawing.Size(32, 32);
            this.HistoryBtn.TabIndex = 0;
            this.HistoryBtn.UseVisualStyleBackColor = true;
            this.HistoryBtn.Click += new System.EventHandler(this.HistoyrBtnClick);
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
            this.TopPanel.Location = new System.Drawing.Point(1, 1);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(382, 32);
            this.TopPanel.TabIndex = 4;
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
            this.MinBtn.Location = new System.Drawing.Point(244, 0);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(46, 32);
            this.MinBtn.TabIndex = 2;
            this.MinBtn.UseVisualStyleBackColor = true;
            this.MinBtn.Click += new System.EventHandler(this.Min_Click);
            // 
            // MaxBtn
            // 
            this.MaxBtn.BackgroundImage = global::Calculator.Properties.Resources.Max;
            this.MaxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MaxBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxBtn.Location = new System.Drawing.Point(290, 0);
            this.MaxBtn.Name = "MaxBtn";
            this.MaxBtn.Size = new System.Drawing.Size(46, 32);
            this.MaxBtn.TabIndex = 1;
            this.MaxBtn.UseVisualStyleBackColor = true;
            this.MaxBtn.Click += new System.EventHandler(this.Max_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackgroundImage = global::Calculator.Properties.Resources.Close;
            this.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Location = new System.Drawing.Point(336, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(46, 32);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.Close_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 640);
            this.Controls.Add(this.MainPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(384, 640);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.MainPanel.ResumeLayout(false);
            this.HistoryPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel MainPanel;
        private Panel ResultPanel;
        private Panel FormulaPanel;
        private Panel HistoryPanel;
        private Button HistoryBtn;
        private Panel TopPanel;
        private Label label1;
        private PictureBox pictureBox1;
        private Button MinBtn;
        private Button MaxBtn;
        private Button CloseBtn;
        private Panel KeyPanel;
        private Button button1;
    }
}