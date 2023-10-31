namespace WeChatAuto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle37 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle38 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle39 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle40 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle41 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle42 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle43 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle44 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle45 = new DataGridViewCellStyle();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            Friend = new DataGridViewTextBoxColumn();
            LastRecord = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            button6 = new Button();
            button7 = new Button();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            MediaType = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel5 = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button10 = new Button();
            button16 = new Button();
            groupBox2 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            button15 = new Button();
            button17 = new Button();
            button18 = new Button();
            checkedListBox2 = new CheckedListBox();
            groupBox4 = new GroupBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            button14 = new Button();
            button12 = new Button();
            button9 = new Button();
            checkedListBox3 = new CheckedListBox();
            tabPage4 = new TabPage();
            groupBox3 = new GroupBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            flowLayoutPanel4 = new FlowLayoutPanel();
            button8 = new Button();
            button11 = new Button();
            button13 = new Button();
            tabPage2 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            tabPage3 = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            checkedListBox1 = new CheckedListBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            title = new DataGridViewTextBoxColumn();
            time1 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            groupBox4.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            tabPage4.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tabPage3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(5, 4);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(172, 49);
            button1.TabIndex = 0;
            button1.Text = "获取好友列表";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(187, 4);
            button2.Margin = new Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new Size(125, 49);
            button2.TabIndex = 1;
            button2.Text = "停止获取";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(494, 4);
            button3.Margin = new Padding(5, 4, 5, 4);
            button3.Name = "button3";
            button3.Size = new Size(124, 52);
            button3.TabIndex = 4;
            button3.Text = "发送文本";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(5, 4);
            button4.Margin = new Padding(5, 4, 5, 4);
            button4.Name = "button4";
            button4.Size = new Size(195, 45);
            button4.TabIndex = 5;
            button4.Text = "获取聊天列表";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Enabled = false;
            button5.Location = new Point(210, 4);
            button5.Margin = new Padding(5, 4, 5, 4);
            button5.Name = "button5";
            button5.Size = new Size(156, 45);
            button5.TabIndex = 6;
            button5.Text = "停止获取";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle37.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle37;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle38.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle38.BackColor = SystemColors.Control;
            dataGridViewCellStyle38.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle38.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle38.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle38;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Friend, LastRecord, Time });
            tableLayoutPanel2.SetColumnSpan(dataGridView1, 2);
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(5, 57);
            dataGridView1.Margin = new Padding(5, 4, 5, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle39.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle39.BackColor = SystemColors.Control;
            dataGridViewCellStyle39.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle39.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle39.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle39.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle40.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle40;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1709, 1231);
            dataGridView1.TabIndex = 7;
            // 
            // Friend
            // 
            Friend.HeaderText = "好友";
            Friend.MinimumWidth = 8;
            Friend.Name = "Friend";
            Friend.ReadOnly = true;
            // 
            // LastRecord
            // 
            LastRecord.HeaderText = "最后一条记录";
            LastRecord.MinimumWidth = 8;
            LastRecord.Name = "LastRecord";
            LastRecord.ReadOnly = true;
            // 
            // Time
            // 
            Time.HeaderText = "时间";
            Time.MinimumWidth = 8;
            Time.Name = "Time";
            Time.ReadOnly = true;
            // 
            // button6
            // 
            button6.Enabled = false;
            button6.Location = new Point(170, 4);
            button6.Margin = new Padding(5, 4, 5, 4);
            button6.Name = "button6";
            button6.Size = new Size(155, 53);
            button6.TabIndex = 9;
            button6.Text = "停止获取";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(5, 4);
            button7.Margin = new Padding(5, 4, 5, 4);
            button7.Name = "button7";
            button7.Size = new Size(155, 53);
            button7.TabIndex = 8;
            button7.Text = "刷朋友圈";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle41.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle41;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle42.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle42.BackColor = SystemColors.Control;
            dataGridViewCellStyle42.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle42.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle42.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle42.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle42;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, MediaType, dataGridViewTextBoxColumn3 });
            tableLayoutPanel3.SetColumnSpan(dataGridView2, 2);
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(5, 65);
            dataGridView2.Margin = new Padding(5, 4, 5, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridViewCellStyle43.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle43.BackColor = SystemColors.Control;
            dataGridViewCellStyle43.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle43.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle43.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle43.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle43.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle43;
            dataGridView2.RowHeadersWidth = 62;
            dataGridViewCellStyle44.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle44;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(1709, 1223);
            dataGridView2.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "好友";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "朋友圈";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // MediaType
            // 
            MediaType.HeaderText = "媒体类型";
            MediaType.MinimumWidth = 8;
            MediaType.Name = "MediaType";
            MediaType.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "时间";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1733, 1342);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel5);
            tabPage1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 40);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1725, 1298);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "群发消息";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(flowLayoutPanel2, 0, 2);
            tableLayoutPanel5.Controls.Add(groupBox2, 0, 0);
            tableLayoutPanel5.Controls.Add(groupBox4, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 55.2631569F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 44.7368431F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(1719, 1292);
            tableLayoutPanel5.TabIndex = 6;
            // 
            // flowLayoutPanel2
            // 
            tableLayoutPanel5.SetColumnSpan(flowLayoutPanel2, 3);
            flowLayoutPanel2.Controls.Add(button10);
            flowLayoutPanel2.Controls.Add(button16);
            flowLayoutPanel2.Dock = DockStyle.Bottom;
            flowLayoutPanel2.Location = new Point(3, 1220);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1713, 69);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // button10
            // 
            button10.Location = new Point(5, 4);
            button10.Margin = new Padding(5, 4, 5, 4);
            button10.Name = "button10";
            button10.Size = new Size(136, 53);
            button10.TabIndex = 4;
            button10.Text = "全部发送";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button16
            // 
            button16.Location = new Point(149, 3);
            button16.Name = "button16";
            button16.Size = new Size(218, 54);
            button16.TabIndex = 5;
            button16.Text = "添加定时发送消息";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel4);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1713, 666);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "文本消息";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(flowLayoutPanel3, 0, 0);
            tableLayoutPanel4.Controls.Add(checkedListBox2, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 34);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1707, 629);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(button15);
            flowLayoutPanel3.Controls.Add(button17);
            flowLayoutPanel3.Controls.Add(button18);
            flowLayoutPanel3.Controls.Add(button3);
            flowLayoutPanel3.Dock = DockStyle.Top;
            flowLayoutPanel3.Location = new Point(3, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(1701, 62);
            flowLayoutPanel3.TabIndex = 1;
            // 
            // button15
            // 
            button15.Location = new Point(3, 3);
            button15.Name = "button15";
            button15.Size = new Size(126, 53);
            button15.TabIndex = 5;
            button15.Text = "添加文本";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button17
            // 
            button17.Location = new Point(137, 4);
            button17.Margin = new Padding(5, 4, 5, 4);
            button17.Name = "button17";
            button17.Size = new Size(174, 52);
            button17.TabIndex = 4;
            button17.Text = "删除选中文本";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // button18
            // 
            button18.Location = new Point(319, 3);
            button18.Name = "button18";
            button18.Size = new Size(167, 53);
            button18.TabIndex = 5;
            button18.Text = "编辑选中文本";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // checkedListBox2
            // 
            checkedListBox2.Dock = DockStyle.Fill;
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.HorizontalScrollbar = true;
            checkedListBox2.Location = new Point(3, 71);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(1701, 555);
            checkedListBox2.TabIndex = 2;
            checkedListBox2.ThreeDCheckBoxes = true;
            checkedListBox2.UseCompatibleTextRendering = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tableLayoutPanel7);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(3, 675);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1713, 538);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "文件消息";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(flowLayoutPanel5, 0, 0);
            tableLayoutPanel7.Controls.Add(checkedListBox3, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 34);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle());
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(1707, 501);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(button14);
            flowLayoutPanel5.Controls.Add(button12);
            flowLayoutPanel5.Controls.Add(button9);
            flowLayoutPanel5.Dock = DockStyle.Top;
            flowLayoutPanel5.Location = new Point(3, 3);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(1701, 60);
            flowLayoutPanel5.TabIndex = 1;
            // 
            // button14
            // 
            button14.Location = new Point(3, 3);
            button14.Name = "button14";
            button14.Size = new Size(180, 54);
            button14.TabIndex = 6;
            button14.Text = "添加文件";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button12
            // 
            button12.Location = new Point(191, 4);
            button12.Margin = new Padding(5, 4, 5, 4);
            button12.Name = "button12";
            button12.Size = new Size(230, 53);
            button12.TabIndex = 4;
            button12.Text = "删除选中文件";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button9
            // 
            button9.Location = new Point(431, 4);
            button9.Margin = new Padding(5, 4, 5, 4);
            button9.Name = "button9";
            button9.Size = new Size(184, 53);
            button9.TabIndex = 4;
            button9.Text = "发送文件";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // checkedListBox3
            // 
            checkedListBox3.Dock = DockStyle.Fill;
            checkedListBox3.FormattingEnabled = true;
            checkedListBox3.HorizontalScrollbar = true;
            checkedListBox3.Location = new Point(3, 69);
            checkedListBox3.Name = "checkedListBox3";
            checkedListBox3.Size = new Size(1701, 429);
            checkedListBox3.TabIndex = 2;
            checkedListBox3.ThreeDCheckBoxes = true;
            checkedListBox3.UseCompatibleTextRendering = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(groupBox3);
            tabPage4.Location = new Point(4, 40);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1725, 1298);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "定时任务";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel6);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1719, 1292);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "定时任务列表";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(listView1, 0, 1);
            tableLayoutPanel6.Controls.Add(flowLayoutPanel4, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 34);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(1713, 1255);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Dock = DockStyle.Fill;
            listView1.FullRowSelect = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Location = new Point(3, 71);
            listView1.Name = "listView1";
            listView1.Size = new Size(1707, 1181);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.Resize += listView1_Resize;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "任务标题";
            columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "定时间隔表达式";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "任务状态";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 200;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(button8);
            flowLayoutPanel4.Controls.Add(button11);
            flowLayoutPanel4.Controls.Add(button13);
            flowLayoutPanel4.Dock = DockStyle.Top;
            flowLayoutPanel4.Location = new Point(3, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(1707, 62);
            flowLayoutPanel4.TabIndex = 1;
            // 
            // button8
            // 
            button8.Location = new Point(3, 3);
            button8.Name = "button8";
            button8.Size = new Size(188, 54);
            button8.TabIndex = 0;
            button8.Text = "启动选中任务";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click_1;
            // 
            // button11
            // 
            button11.Location = new Point(197, 3);
            button11.Name = "button11";
            button11.Size = new Size(188, 54);
            button11.TabIndex = 0;
            button11.Text = "停止选中任务";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button13
            // 
            button13.Location = new Point(391, 3);
            button13.Name = "button13";
            button13.Size = new Size(188, 54);
            button13.TabIndex = 0;
            button13.Text = "删除选中任务";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel2);
            tabPage2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 40);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1725, 1298);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "聊天列表";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(button4, 0, 0);
            tableLayoutPanel2.Controls.Add(button5, 1, 0);
            tableLayoutPanel2.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1719, 1292);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tableLayoutPanel3);
            tabPage3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage3.Location = new Point(4, 40);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1725, 1298);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "朋友圈";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(dataGridView2, 0, 1);
            tableLayoutPanel3.Controls.Add(button7, 0, 0);
            tableLayoutPanel3.Controls.Add(button6, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1719, 1292);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControl1);
            splitContainer1.Size = new Size(2289, 1342);
            splitContainer1.SplitterDistance = 552;
            splitContainer1.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(552, 1342);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkedListBox1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(3, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(546, 1270);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "好友列表";
            // 
            // checkedListBox1
            // 
            checkedListBox1.Dock = DockStyle.Fill;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.HorizontalScrollbar = true;
            checkedListBox1.Location = new Point(3, 34);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(540, 1233);
            checkedListBox1.TabIndex = 0;
            checkedListBox1.ThreeDCheckBoxes = true;
            checkedListBox1.UseCompatibleTextRendering = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(546, 60);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // title
            // 
            title.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle45.Alignment = DataGridViewContentAlignment.MiddleCenter;
            title.DefaultCellStyle = dataGridViewCellStyle45;
            title.HeaderText = "标题";
            title.MinimumWidth = 8;
            title.Name = "title";
            title.ReadOnly = true;
            title.Width = 150;
            // 
            // time1
            // 
            time1.HeaderText = "间隔时间";
            time1.MinimumWidth = 8;
            time1.Name = "time1";
            time1.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2289, 1342);
            Controls.Add(splitContainer1);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "微信自动化";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel5.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Friend;
        private DataGridViewTextBoxColumn LastRecord;
        private DataGridViewTextBoxColumn Time;
        private Button button6;
        private Button button7;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn MediaType;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TabPage tabPage3;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button12;
        private Button button10;
        private Button button9;
        private Button button14;
        private TableLayoutPanel tableLayoutPanel5;
        private Button button15;
        private Button button16;
        private Button button17;
        private TableLayoutPanel tableLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel7;
        private FlowLayoutPanel flowLayoutPanel5;
        private Button button18;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn time1;
        private CheckedListBox checkedListBox1;
        private CheckedListBox checkedListBox2;
        private CheckedListBox checkedListBox3;
        private TabPage tabPage4;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel6;
        private ListView listView1;
        private FlowLayoutPanel flowLayoutPanel4;
        private Button button8;
        private Button button11;
        private Button button13;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}