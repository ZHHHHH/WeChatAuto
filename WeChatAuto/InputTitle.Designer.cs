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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(109, 141);
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
            button2.Location = new Point(267, 141);
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
            textBox2.Location = new Point(222, 31);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 38);
            textBox2.TabIndex = 1;
            textBox2.Text = "0 0/30 9,11,12,13,14,19,20 * * ? ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 31);
            label2.Name = "label2";
            label2.Size = new Size(187, 31);
            label2.TabIndex = 2;
            label2.Text = "定时间隔(Cron):";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(170, 92);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(156, 24);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "cron表达式生成器";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // InputTitle
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 194);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InputTitle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "请输入定时任务标题";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        public TextBox textBox2;
        private Label label2;
        private LinkLabel linkLabel1;
    }
}