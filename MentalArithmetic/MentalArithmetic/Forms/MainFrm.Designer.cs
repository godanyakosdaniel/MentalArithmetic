namespace MentalArithmetic
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.summationChBx = new System.Windows.Forms.CheckBox();
            this.sumFractionCmBx = new System.Windows.Forms.ComboBox();
            this.sumMinNmUD = new System.Windows.Forms.NumericUpDown();
            this.sumMaxNmUD = new System.Windows.Forms.NumericUpDown();
            this.SummationGrpBx = new System.Windows.Forms.GroupBox();
            this.SubtractionGrpBx = new System.Windows.Forms.GroupBox();
            this.subtracionChBx = new System.Windows.Forms.CheckBox();
            this.subFractionCmBx = new System.Windows.Forms.ComboBox();
            this.subMinNmUD = new System.Windows.Forms.NumericUpDown();
            this.subMaxNmUD = new System.Windows.Forms.NumericUpDown();
            this.multiplicationGrpBx = new System.Windows.Forms.GroupBox();
            this.multiplicationChBx = new System.Windows.Forms.CheckBox();
            this.multiFractionCmBx = new System.Windows.Forms.ComboBox();
            this.multiMinNmUD = new System.Windows.Forms.NumericUpDown();
            this.multiMaxNmUD = new System.Windows.Forms.NumericUpDown();
            this.rootGrpBx = new System.Windows.Forms.GroupBox();
            this.rootChBx = new System.Windows.Forms.CheckBox();
            this.rootFractionCmBx = new System.Windows.Forms.ComboBox();
            this.rootNmUD = new System.Windows.Forms.NumericUpDown();
            this.rootMinNmUD = new System.Windows.Forms.NumericUpDown();
            this.rootMaxNmUD = new System.Windows.Forms.NumericUpDown();
            this.exponentGrpBx = new System.Windows.Forms.GroupBox();
            this.exponentChBx = new System.Windows.Forms.CheckBox();
            this.exFractionCmBx = new System.Windows.Forms.ComboBox();
            this.exponentNmUD = new System.Windows.Forms.NumericUpDown();
            this.exMinNmUD = new System.Windows.Forms.NumericUpDown();
            this.exMaxNmUD = new System.Windows.Forms.NumericUpDown();
            this.divisionGrpBx = new System.Windows.Forms.GroupBox();
            this.divisionChBx = new System.Windows.Forms.CheckBox();
            this.divFractionCmBx = new System.Windows.Forms.ComboBox();
            this.divMinNmUD = new System.Windows.Forms.NumericUpDown();
            this.divMaxNmUD = new System.Windows.Forms.NumericUpDown();
            this.playBtn = new System.Windows.Forms.Button();
            this.statisticsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sumMinNmUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumMaxNmUD)).BeginInit();
            this.SummationGrpBx.SuspendLayout();
            this.SubtractionGrpBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subMinNmUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subMaxNmUD)).BeginInit();
            this.multiplicationGrpBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.multiMinNmUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiMaxNmUD)).BeginInit();
            this.rootGrpBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rootNmUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootMinNmUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootMaxNmUD)).BeginInit();
            this.exponentGrpBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exponentNmUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exMinNmUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exMaxNmUD)).BeginInit();
            this.divisionGrpBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.divMinNmUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divMaxNmUD)).BeginInit();
            this.SuspendLayout();
            // 
            // summationChBx
            // 
            resources.ApplyResources(this.summationChBx, "summationChBx");
            this.summationChBx.Name = "summationChBx";
            this.summationChBx.UseVisualStyleBackColor = true;
            // 
            // sumFractionCmBx
            // 
            this.sumFractionCmBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sumFractionCmBx.FormattingEnabled = true;
            this.sumFractionCmBx.Items.AddRange(new object[] {
            resources.GetString("sumFractionCmBx.Items"),
            resources.GetString("sumFractionCmBx.Items1"),
            resources.GetString("sumFractionCmBx.Items2")});
            resources.ApplyResources(this.sumFractionCmBx, "sumFractionCmBx");
            this.sumFractionCmBx.Name = "sumFractionCmBx";
            // 
            // sumMinNmUD
            // 
            resources.ApplyResources(this.sumMinNmUD, "sumMinNmUD");
            this.sumMinNmUD.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.sumMinNmUD.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.sumMinNmUD.Name = "sumMinNmUD";
            this.sumMinNmUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sumMaxNmUD
            // 
            resources.ApplyResources(this.sumMaxNmUD, "sumMaxNmUD");
            this.sumMaxNmUD.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.sumMaxNmUD.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.sumMaxNmUD.Name = "sumMaxNmUD";
            this.sumMaxNmUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // SummationGrpBx
            // 
            this.SummationGrpBx.Controls.Add(this.summationChBx);
            this.SummationGrpBx.Controls.Add(this.sumFractionCmBx);
            this.SummationGrpBx.Controls.Add(this.sumMinNmUD);
            this.SummationGrpBx.Controls.Add(this.sumMaxNmUD);
            resources.ApplyResources(this.SummationGrpBx, "SummationGrpBx");
            this.SummationGrpBx.Name = "SummationGrpBx";
            this.SummationGrpBx.TabStop = false;
            // 
            // SubtractionGrpBx
            // 
            this.SubtractionGrpBx.Controls.Add(this.subtracionChBx);
            this.SubtractionGrpBx.Controls.Add(this.subFractionCmBx);
            this.SubtractionGrpBx.Controls.Add(this.subMinNmUD);
            this.SubtractionGrpBx.Controls.Add(this.subMaxNmUD);
            resources.ApplyResources(this.SubtractionGrpBx, "SubtractionGrpBx");
            this.SubtractionGrpBx.Name = "SubtractionGrpBx";
            this.SubtractionGrpBx.TabStop = false;
            // 
            // subtracionChBx
            // 
            resources.ApplyResources(this.subtracionChBx, "subtracionChBx");
            this.subtracionChBx.Name = "subtracionChBx";
            this.subtracionChBx.UseVisualStyleBackColor = true;
            // 
            // subFractionCmBx
            // 
            this.subFractionCmBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subFractionCmBx.FormattingEnabled = true;
            this.subFractionCmBx.Items.AddRange(new object[] {
            resources.GetString("subFractionCmBx.Items"),
            resources.GetString("subFractionCmBx.Items1"),
            resources.GetString("subFractionCmBx.Items2")});
            resources.ApplyResources(this.subFractionCmBx, "subFractionCmBx");
            this.subFractionCmBx.Name = "subFractionCmBx";
            // 
            // subMinNmUD
            // 
            resources.ApplyResources(this.subMinNmUD, "subMinNmUD");
            this.subMinNmUD.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.subMinNmUD.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.subMinNmUD.Name = "subMinNmUD";
            this.subMinNmUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // subMaxNmUD
            // 
            resources.ApplyResources(this.subMaxNmUD, "subMaxNmUD");
            this.subMaxNmUD.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.subMaxNmUD.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.subMaxNmUD.Name = "subMaxNmUD";
            this.subMaxNmUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // multiplicationGrpBx
            // 
            this.multiplicationGrpBx.Controls.Add(this.multiplicationChBx);
            this.multiplicationGrpBx.Controls.Add(this.multiFractionCmBx);
            this.multiplicationGrpBx.Controls.Add(this.multiMinNmUD);
            this.multiplicationGrpBx.Controls.Add(this.multiMaxNmUD);
            resources.ApplyResources(this.multiplicationGrpBx, "multiplicationGrpBx");
            this.multiplicationGrpBx.Name = "multiplicationGrpBx";
            this.multiplicationGrpBx.TabStop = false;
            // 
            // multiplicationChBx
            // 
            resources.ApplyResources(this.multiplicationChBx, "multiplicationChBx");
            this.multiplicationChBx.Name = "multiplicationChBx";
            this.multiplicationChBx.UseVisualStyleBackColor = true;
            // 
            // multiFractionCmBx
            // 
            this.multiFractionCmBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.multiFractionCmBx.FormattingEnabled = true;
            this.multiFractionCmBx.Items.AddRange(new object[] {
            resources.GetString("multiFractionCmBx.Items"),
            resources.GetString("multiFractionCmBx.Items1"),
            resources.GetString("multiFractionCmBx.Items2")});
            resources.ApplyResources(this.multiFractionCmBx, "multiFractionCmBx");
            this.multiFractionCmBx.Name = "multiFractionCmBx";
            // 
            // multiMinNmUD
            // 
            resources.ApplyResources(this.multiMinNmUD, "multiMinNmUD");
            this.multiMinNmUD.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.multiMinNmUD.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.multiMinNmUD.Name = "multiMinNmUD";
            this.multiMinNmUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // multiMaxNmUD
            // 
            resources.ApplyResources(this.multiMaxNmUD, "multiMaxNmUD");
            this.multiMaxNmUD.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.multiMaxNmUD.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.multiMaxNmUD.Name = "multiMaxNmUD";
            this.multiMaxNmUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // rootGrpBx
            // 
            this.rootGrpBx.Controls.Add(this.rootChBx);
            this.rootGrpBx.Controls.Add(this.rootFractionCmBx);
            this.rootGrpBx.Controls.Add(this.rootNmUD);
            this.rootGrpBx.Controls.Add(this.rootMinNmUD);
            this.rootGrpBx.Controls.Add(this.rootMaxNmUD);
            resources.ApplyResources(this.rootGrpBx, "rootGrpBx");
            this.rootGrpBx.Name = "rootGrpBx";
            this.rootGrpBx.TabStop = false;
            // 
            // rootChBx
            // 
            resources.ApplyResources(this.rootChBx, "rootChBx");
            this.rootChBx.Name = "rootChBx";
            this.rootChBx.UseVisualStyleBackColor = true;
            // 
            // rootFractionCmBx
            // 
            this.rootFractionCmBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rootFractionCmBx.FormattingEnabled = true;
            this.rootFractionCmBx.Items.AddRange(new object[] {
            resources.GetString("rootFractionCmBx.Items"),
            resources.GetString("rootFractionCmBx.Items1"),
            resources.GetString("rootFractionCmBx.Items2")});
            resources.ApplyResources(this.rootFractionCmBx, "rootFractionCmBx");
            this.rootFractionCmBx.Name = "rootFractionCmBx";
            // 
            // rootNmUD
            // 
            resources.ApplyResources(this.rootNmUD, "rootNmUD");
            this.rootNmUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rootNmUD.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.rootNmUD.Name = "rootNmUD";
            this.rootNmUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // rootMinNmUD
            // 
            resources.ApplyResources(this.rootMinNmUD, "rootMinNmUD");
            this.rootMinNmUD.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.rootMinNmUD.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.rootMinNmUD.Name = "rootMinNmUD";
            this.rootMinNmUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rootMaxNmUD
            // 
            resources.ApplyResources(this.rootMaxNmUD, "rootMaxNmUD");
            this.rootMaxNmUD.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.rootMaxNmUD.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.rootMaxNmUD.Name = "rootMaxNmUD";
            this.rootMaxNmUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // exponentGrpBx
            // 
            this.exponentGrpBx.Controls.Add(this.exponentChBx);
            this.exponentGrpBx.Controls.Add(this.exFractionCmBx);
            this.exponentGrpBx.Controls.Add(this.exponentNmUD);
            this.exponentGrpBx.Controls.Add(this.exMinNmUD);
            this.exponentGrpBx.Controls.Add(this.exMaxNmUD);
            resources.ApplyResources(this.exponentGrpBx, "exponentGrpBx");
            this.exponentGrpBx.Name = "exponentGrpBx";
            this.exponentGrpBx.TabStop = false;
            // 
            // exponentChBx
            // 
            resources.ApplyResources(this.exponentChBx, "exponentChBx");
            this.exponentChBx.Name = "exponentChBx";
            this.exponentChBx.UseVisualStyleBackColor = true;
            // 
            // exFractionCmBx
            // 
            this.exFractionCmBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exFractionCmBx.FormattingEnabled = true;
            this.exFractionCmBx.Items.AddRange(new object[] {
            resources.GetString("exFractionCmBx.Items"),
            resources.GetString("exFractionCmBx.Items1"),
            resources.GetString("exFractionCmBx.Items2")});
            resources.ApplyResources(this.exFractionCmBx, "exFractionCmBx");
            this.exFractionCmBx.Name = "exFractionCmBx";
            // 
            // exponentNmUD
            // 
            resources.ApplyResources(this.exponentNmUD, "exponentNmUD");
            this.exponentNmUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.exponentNmUD.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.exponentNmUD.Name = "exponentNmUD";
            this.exponentNmUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // exMinNmUD
            // 
            resources.ApplyResources(this.exMinNmUD, "exMinNmUD");
            this.exMinNmUD.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.exMinNmUD.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.exMinNmUD.Name = "exMinNmUD";
            this.exMinNmUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // exMaxNmUD
            // 
            resources.ApplyResources(this.exMaxNmUD, "exMaxNmUD");
            this.exMaxNmUD.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.exMaxNmUD.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.exMaxNmUD.Name = "exMaxNmUD";
            this.exMaxNmUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // divisionGrpBx
            // 
            this.divisionGrpBx.Controls.Add(this.divisionChBx);
            this.divisionGrpBx.Controls.Add(this.divFractionCmBx);
            this.divisionGrpBx.Controls.Add(this.divMinNmUD);
            this.divisionGrpBx.Controls.Add(this.divMaxNmUD);
            resources.ApplyResources(this.divisionGrpBx, "divisionGrpBx");
            this.divisionGrpBx.Name = "divisionGrpBx";
            this.divisionGrpBx.TabStop = false;
            // 
            // divisionChBx
            // 
            resources.ApplyResources(this.divisionChBx, "divisionChBx");
            this.divisionChBx.Name = "divisionChBx";
            this.divisionChBx.UseVisualStyleBackColor = true;
            // 
            // divFractionCmBx
            // 
            this.divFractionCmBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.divFractionCmBx.FormattingEnabled = true;
            this.divFractionCmBx.Items.AddRange(new object[] {
            resources.GetString("divFractionCmBx.Items"),
            resources.GetString("divFractionCmBx.Items1"),
            resources.GetString("divFractionCmBx.Items2")});
            resources.ApplyResources(this.divFractionCmBx, "divFractionCmBx");
            this.divFractionCmBx.Name = "divFractionCmBx";
            // 
            // divMinNmUD
            // 
            resources.ApplyResources(this.divMinNmUD, "divMinNmUD");
            this.divMinNmUD.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.divMinNmUD.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.divMinNmUD.Name = "divMinNmUD";
            this.divMinNmUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // divMaxNmUD
            // 
            resources.ApplyResources(this.divMaxNmUD, "divMaxNmUD");
            this.divMaxNmUD.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.divMaxNmUD.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.divMaxNmUD.Name = "divMaxNmUD";
            this.divMaxNmUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // playBtn
            // 
            resources.ApplyResources(this.playBtn, "playBtn");
            this.playBtn.Name = "playBtn";
            this.playBtn.UseVisualStyleBackColor = true;
            // 
            // statisticsBtn
            // 
            resources.ApplyResources(this.statisticsBtn, "statisticsBtn");
            this.statisticsBtn.Name = "statisticsBtn";
            this.statisticsBtn.UseVisualStyleBackColor = true;
            // 
            // MainFrm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.statisticsBtn);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.rootGrpBx);
            this.Controls.Add(this.multiplicationGrpBx);
            this.Controls.Add(this.exponentGrpBx);
            this.Controls.Add(this.divisionGrpBx);
            this.Controls.Add(this.SubtractionGrpBx);
            this.Controls.Add(this.SummationGrpBx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            ((System.ComponentModel.ISupportInitialize)(this.sumMinNmUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumMaxNmUD)).EndInit();
            this.SummationGrpBx.ResumeLayout(false);
            this.SummationGrpBx.PerformLayout();
            this.SubtractionGrpBx.ResumeLayout(false);
            this.SubtractionGrpBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subMinNmUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subMaxNmUD)).EndInit();
            this.multiplicationGrpBx.ResumeLayout(false);
            this.multiplicationGrpBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.multiMinNmUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiMaxNmUD)).EndInit();
            this.rootGrpBx.ResumeLayout(false);
            this.rootGrpBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rootNmUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootMinNmUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootMaxNmUD)).EndInit();
            this.exponentGrpBx.ResumeLayout(false);
            this.exponentGrpBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exponentNmUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exMinNmUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exMaxNmUD)).EndInit();
            this.divisionGrpBx.ResumeLayout(false);
            this.divisionGrpBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.divMinNmUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divMaxNmUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox summationChBx;
        private System.Windows.Forms.ComboBox sumFractionCmBx;
        private System.Windows.Forms.NumericUpDown sumMinNmUD;
        private System.Windows.Forms.NumericUpDown sumMaxNmUD;
        private System.Windows.Forms.GroupBox SummationGrpBx;
        private System.Windows.Forms.GroupBox SubtractionGrpBx;
        private System.Windows.Forms.CheckBox subtracionChBx;
        private System.Windows.Forms.ComboBox subFractionCmBx;
        private System.Windows.Forms.NumericUpDown subMinNmUD;
        private System.Windows.Forms.NumericUpDown subMaxNmUD;
        private System.Windows.Forms.GroupBox multiplicationGrpBx;
        private System.Windows.Forms.CheckBox multiplicationChBx;
        private System.Windows.Forms.ComboBox multiFractionCmBx;
        private System.Windows.Forms.NumericUpDown multiMinNmUD;
        private System.Windows.Forms.NumericUpDown multiMaxNmUD;
        private System.Windows.Forms.GroupBox rootGrpBx;
        private System.Windows.Forms.CheckBox rootChBx;
        private System.Windows.Forms.ComboBox rootFractionCmBx;
        private System.Windows.Forms.NumericUpDown rootNmUD;
        private System.Windows.Forms.NumericUpDown rootMinNmUD;
        private System.Windows.Forms.NumericUpDown rootMaxNmUD;
        private System.Windows.Forms.GroupBox exponentGrpBx;
        private System.Windows.Forms.CheckBox exponentChBx;
        private System.Windows.Forms.ComboBox exFractionCmBx;
        private System.Windows.Forms.NumericUpDown exponentNmUD;
        private System.Windows.Forms.NumericUpDown exMinNmUD;
        private System.Windows.Forms.NumericUpDown exMaxNmUD;
        private System.Windows.Forms.GroupBox divisionGrpBx;
        private System.Windows.Forms.CheckBox divisionChBx;
        private System.Windows.Forms.ComboBox divFractionCmBx;
        private System.Windows.Forms.NumericUpDown divMinNmUD;
        private System.Windows.Forms.NumericUpDown divMaxNmUD;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button statisticsBtn;
    }
}

