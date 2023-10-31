namespace WeChatAuto
{
    partial class InputTitle
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
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            textBox1 = new TextBox();
            label1 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(173, 226);
            button1.Name = "button1";
            button1.Size = new Size(127, 41);
            button1.TabIndex = 1;
            button1.Text = "确定";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(395, 226);
            button2.Name = "button2";
            button2.Size = new Size(127, 41);
            button2.TabIndex = 1;
            button2.Text = "取消";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(222, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(409, 38);
            textBox2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 100);
            label2.Name = "label2";
            label2.Size = new Size(187, 31);
            label2.TabIndex = 2;
            label2.Text = "定时间隔(Cron):";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(475, 169);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(156, 24);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "cron表达式生成器";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(222, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(409, 38);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(42, 41);
            label1.Name = "label1";
            label1.Size = new Size(164, 31);
            label1.TabIndex = 2;
            label1.Text = "定时任务标题:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(222, 162);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(232, 35);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "定时任务立刻启动";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // InputTitle
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 296);
            Controls.Add(checkBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InputTitle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "输入定时任务信息";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        public TextBox textBox2;
        private Label label2;
        private LinkLabel linkLabel1;
        public TextBox textBox1;
        private Label label1;
        public CheckBox checkBox1;
    }
}