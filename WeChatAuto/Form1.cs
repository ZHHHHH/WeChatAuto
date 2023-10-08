using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Runtime.InteropServices;
using FlaUI.UIA3;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Definitions;
using System;
using System.Collections.Specialized;

namespace WeChatAuto
{
    public partial class Form1 : Form
    {
        private List<dynamic> list = new List<dynamic>();
        private Dictionary<string, string> Content = new Dictionary<string, string>();
        /// <summary>
        /// 滚动条模拟
        /// </summary>
        /// <param name="nInputs"></param>
        /// <param name="pInputs"></param>
        /// <param name="cbSize"></param>
        /// <returns></returns>
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);
        //根据名称获取窗体句柄
        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        private extern static IntPtr FindWindow(string lpClassName, string lpWindowName);
        //根据句柄获取进程ID
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int GetWindowThreadProcessId(IntPtr hwnd, out int ID);

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        //设置光标的位置
        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        static extern bool SetCursorPos(int X, int Y);

        //返回指定窗口的边框矩形的大小
        [DllImport("user32.dll", EntryPoint = "GetWindowRect")]
        private static extern int GetWindowRect(IntPtr hwnd, out Rect lpRect);

        //设置窗口的尺寸、位置和Z序
        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndlnsertAfter, int X, int Y, int cx, int cy, uint Flags);

        //控制鼠标执行点击，滚轮
        [DllImport("user32", EntryPoint = "mouse_event")]
        private static extern int mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        //显示窗口
        [DllImport("User32.dll", EntryPoint = "ShowWindow")]
        private static extern bool ShowWindow(IntPtr hWnd, int type);

        ////将窗口设置为最上层窗口
        [DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        ////控制窗口或控件的输入焦点,从而控制用户的输入
        [DllImport("user32.dll", EntryPoint = "SetFocus")]
        public static extern IntPtr SetFocus(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern bool PostMessage(int hhwnd, uint msg, IntPtr wparam, IntPtr lparam);

        [DllImport("user32.dll")]
        public static extern IntPtr LoadKeyboardLayout(string pwszKLID, uint Flags);

        public static uint WM_INPUTLANGUANGEREQUEST = 0X0050;
        public static int HWND_BROADCAST = 0xffff;
        public static string en_US = "00000409"; //英文
        public static string cn_ZH = "00000804";
        public static uint KLF_ACTIVATE = 1;

        public struct Rect { public int Left; public int Top; public int Right; public int Bottom; }
        public Form1()
        {
            InitializeComponent();
            GetWxHandle();
            GetFriendTokenSource = new CancellationTokenSource();
            GetFriendCancellationToken = GetFriendTokenSource.Token;
            ChatListTokenSource = new CancellationTokenSource();
            ChatListCancellationToken = ChatListTokenSource.Token;
            FriendTokenSource = new CancellationTokenSource();
            FriendCancellationToken = FriendTokenSource.Token;
        }
        private CancellationToken FriendCancellationToken { get; set; }
        private CancellationTokenSource FriendTokenSource { get; set; }
        private CancellationToken ChatListCancellationToken { get; set; }
        private CancellationTokenSource ChatListTokenSource { get; set; }
        private CancellationToken GetFriendCancellationToken { get; set; }
        private CancellationTokenSource GetFriendTokenSource { get; set; }
        private int ProcessId { get; set; }
        private FlaUI.Core.AutomationElements.Window wxWindow { get; set; }
        private bool IsInit { get; set; } = false;
        void GetWxHandle()
        {
            var process = Process.GetProcessesByName("Wechat").FirstOrDefault();
            if (process != null)
            {
                ProcessId = process.Id;
            }

        }
        void InitWechat()
        {
            IsInit = true;
            //根据微信进程ID绑定FLAUI
            var application = FlaUI.Core.Application.Attach(ProcessId);
            var automation = new UIA3Automation();

            //获取微信window自动化操作对象
            wxWindow = application.GetMainWindow(automation);
            //唤起微信

        }
        #region Scroll Event
        void Scroll(int scroll)
        {


            INPUT[] inputs = new INPUT[1];

            // 设置鼠标滚动事件
            inputs[0].type = InputType.INPUT_MOUSE;
            inputs[0].mi.dwFlags = MouseEventFlags.MOUSEEVENTF_WHEEL;
            inputs[0].mi.mouseData = (uint)scroll;

            // 发送输入事件
            SendInput(1, inputs, Marshal.SizeOf(typeof(INPUT)));

        }
        public struct INPUT
        {
            public InputType type;
            public MouseInput mi;
        }

        // 输入类型
        public enum InputType : uint
        {
            INPUT_MOUSE = 0x0000,
            INPUT_KEYBOARD = 0x0001,
            INPUT_HARDWARE = 0x0002
        }

        // 鼠标输入结构体
        public struct MouseInput
        {
            public int dx;
            public int dy;
            public uint mouseData;
            public MouseEventFlags dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        // 鼠标事件标志位
        [Flags]
        public enum MouseEventFlags : uint
        {
            MOUSEEVENTF_MOVE = 0x0001,
            MOUSEEVENTF_LEFTDOWN = 0x0002,
            MOUSEEVENTF_LEFTUP = 0x0004,
            MOUSEEVENTF_RIGHTDOWN = 0x0008,
            MOUSEEVENTF_RIGHTUP = 0x0010,
            MOUSEEVENTF_MIDDLEDOWN = 0x0020,
            MOUSEEVENTF_MIDDLEUP = 0x0040,
            MOUSEEVENTF_XDOWN = 0x0080,
            MOUSEEVENTF_XUP = 0x0100,
            MOUSEEVENTF_WHEEL = 0x0800,
            MOUSEEVENTF_HWHEEL = 0x1000,
            MOUSEEVENTF_MOVE_NOCOALESCE = 0x2000,
            MOUSEEVENTF_VIRTUALDESK = 0x4000,
            MOUSEEVENTF_ABSOLUTE = 0x8000
        }
        const int MOUSEEVENTF_WHEEL = 0x800;
        #endregion

        public enum MessageType
        {
            TEXT = 0,
            IMAGE = 1,
            FILE = 2,
            ALL = 3
        }
        private void button1_Click(object sender, EventArgs e)
        {
            showwxWindows();
            if (!IsInit)
            {
                InitWechat();
            }
            if (wxWindow != null)
            {
                if (wxWindow.AsWindow().Patterns.Window.PatternOrDefault != null)
                {
                    //将微信窗体设置为默认焦点状态
                    wxWindow.AsWindow().Patterns.Window.Pattern.SetWindowVisualState(FlaUI.Core.Definitions.WindowVisualState.Normal);
                }
            }

            this.button1.Enabled = false;
            this.button2.Enabled = true;
            this.Text = "微信自动化（" + wxWindow.FindAllDescendants().Where(s => s.ControlType == ControlType.Button).FirstOrDefault().Name + "）";


            wxWindow.FindAllDescendants().Where(s => s.Name == "通讯录")?.FirstOrDefault()?.Click(false);
            wxWindow.FindAllDescendants().Where(s => s.Name == "新的朋友")?.FirstOrDefault()?.Click(false);
            string LastName = string.Empty;
            var list = new List<AutomationElement>();
            var sync = SynchronizationContext.Current;

            Task.Run(() =>
            {
                while (true)
                {
                    if (GetFriendCancellationToken.IsCancellationRequested)
                    {
                        break;
                    }
                    var all = wxWindow.FindAllDescendants();
                    var allItem = all?.Where(s => s.Parent != null && s.Parent.Name == "联系人").ToList();
                    foreach (var item in allItem)
                    {
                        if (item.Name != null && item.ControlType == ControlType.ListItem && !string.IsNullOrWhiteSpace(item.Name) && !listBox1.Items.Contains(item.Name.ToString()))
                        {
                            sync.Post(s =>
                            {
                                listBox1.Items.Add(s);
                            }, item.Name.ToString());
                        }
                    }
                    Scroll(-700);
                }
            }, GetFriendCancellationToken);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetFriendTokenSource.Cancel();
            this.button1.Enabled = true;
            this.button2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showwxWindows();
            if (!IsInit)
            {
                InitWechat();
            }
            if (wxWindow != null)
            {
                if (wxWindow.AsWindow().Patterns.Window.PatternOrDefault != null)
                {
                    //将微信窗体设置为默认焦点状态
                    wxWindow.AsWindow().Patterns.Window.Pattern.SetWindowVisualState(FlaUI.Core.Definitions.WindowVisualState.Normal);
                }
            }
            this.button4.Enabled = false;
            this.button5.Enabled = true;
            wxWindow.FindAllDescendants().Where(s => s.Name == "聊天").FirstOrDefault().Click(false);
            //wxWindow.FindAllDescendants().Where(s => s.Name == "妈妈").FirstOrDefault().Click(false);
            var sync = SynchronizationContext.Current;
            Task.Run(async () =>
            {
                object obj;
                while (true)
                {
                    var all = wxWindow.FindAllDescendants();
                    try
                    {
                        if (ChatListCancellationToken.IsCancellationRequested)
                        {
                            break;
                        }
                        var allItem = all.Where(s => s.ControlType == ControlType.ListItem && !string.IsNullOrEmpty(s.Name) && s.Parent.Name == "会话" && s.Name != "折叠的群聊");

                        foreach (var item in allItem)
                        {
                            var allText = item.FindAllByXPath("//*/Text");
                            if (allText != null && allText.Length >= 3)
                            {
                                var name = allText[0].Name;
                                var time = allText[1].Name;
                                var content = allText[2].Name;
                                if (Content.ContainsKey(name))
                                {
                                    var val = Content[name];
                                    if (val != content)
                                    {
                                        Content.Remove(name);
                                        Content.Add(name, content);
                                    }
                                }
                                else
                                {
                                    Content.Add(name, content);
                                }
                                sync.Post(s =>
                                {
                                    dataGridView1.Rows.Add(item.Name, content, time);
                                }, null);
                            }
                        }

                        Scroll(-700);
                        await Task.Delay(100);
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
            }, ChatListCancellationToken);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChatListTokenSource.Cancel();
            this.button4.Enabled = true;
            this.button5.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            showwxWindows();
            if (!IsInit)
            {
                InitWechat();
            }
            if (wxWindow != null)
            {
                if (wxWindow.AsWindow().Patterns.Window.PatternOrDefault != null)
                {
                    //将微信窗体设置为默认焦点状态
                    wxWindow.AsWindow().Patterns.Window.Pattern.SetWindowVisualState(FlaUI.Core.Definitions.WindowVisualState.Normal);
                }
            }
            this.button7.Enabled = false;
            this.button6.Enabled = true;
            wxWindow.FindAllDescendants().Where(s => s.Name == "朋友圈")?.FirstOrDefault()?.Click(false);
            var handls = FindWindow(null, "朋友圈");
            if (handls != IntPtr.Zero)
            {
                GetWindowThreadProcessId(handls, out int FridId);
                var applicationFrid = FlaUI.Core.Application.Attach(FridId);
                var automationFrid = new UIA3Automation();

                //获取微信window自动化操作对象
                var Friend = applicationFrid.GetMainWindow(automationFrid);
                Friend.FindAllDescendants()?.FirstOrDefault(s => s.ControlType == ControlType.List)?.Click(false);

                var sync = SynchronizationContext.Current;
                Task.Run(async () =>
                {
                    while (true)
                    {
                        try
                        {
                            if (FriendCancellationToken.IsCancellationRequested)
                            {
                                break;
                            }
                            var allInfo = Friend.FindAllDescendants();
                            var itema = allInfo.Where(s => s.ControlType == ControlType.ListItem && s.Parent.Name == "朋友圈" && s.Parent.ControlType == ControlType.List);
                            if (itema != null)
                            {
                                foreach (var item in itema)
                                {
                                    var ass = item.FindAllDescendants().FirstOrDefault(s => s.ControlType == ControlType.Text);
                                    //ass.FocusNative();
                                    //ass.Focus();
                                    var index = item.Name.IndexOf(':');
                                    var name = item.Name.Substring(0, index);
                                    var content = item.Name.Substring(index + 1);
                                    var split = content.Split("\n");
                                    if (split.Length > 3)
                                    {
                                        var time = split[split.Length - 2];
                                        var mediaType = split[split.Length - 3];
                                        var FriendContent = split[0..(split.Length - 3)];
                                        var con = string.Join(",", FriendContent);
                                        if (list.Any(s => s.Content == con))
                                        {
                                            continue;
                                        }
                                        sync.Post(s =>
                                        {
                                            dataGridView2.Rows.Add(name, s, mediaType, time);
                                            dynamic entity = new
                                            {
                                                Name = name,
                                                Content = s,
                                                MediaType = mediaType,
                                                Time = time
                                            };
                                            list.Add(entity);
                                        }, con);
                                    }
                                }
                                Scroll(-500);
                                await Task.Delay(100);

                            }

                        }
                        catch (Exception ex)
                        {
                            continue;
                        }

                    }
                });
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FriendTokenSource.Cancel();
            this.button7.Enabled = true;
            this.button6.Enabled = false;
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            PostMessage(HWND_BROADCAST, WM_INPUTLANGUANGEREQUEST, IntPtr.Zero, LoadKeyboardLayout(en_US, KLF_ACTIVATE));
            var sendMsg = richTextBox1.Text.Trim();
            var itemName = listBox1.SelectedItem?.ToString();
            if (!IsInit)
            {
                InitWechat();
            }
            if (wxWindow != null)
            {
                if (wxWindow.AsWindow().Patterns.Window.PatternOrDefault != null)
                {
                    //将微信窗体设置为默认焦点状态
                    wxWindow.AsWindow().Patterns.Window.Pattern.SetWindowVisualState(FlaUI.Core.Definitions.WindowVisualState.Normal);
                }
            }
            var search = wxWindow.FindAllDescendants().FirstOrDefault(s => s.Name == "搜索");
            var text = wxWindow.FindAllDescendants().FirstOrDefault(s => s.Name == "搜索").Parent;
            foreach (var item1 in listBox1.SelectedItems)
            {
                itemName = item1.ToString();
                search.FocusNative();
                search.Focus();
                search.Click();
                await Task.Delay(500);

                if (text != null)
                {
                    //await Task.Delay(500);
                    var txt = text.FindAllChildren().FirstOrDefault(s => s.ControlType == ControlType.Text).AsTextBox();
                    txt.Text = itemName;
                    await Task.Delay(500);
                    var item = wxWindow.FindAllDescendants().Where(s => s.Name == itemName && s.ControlType == ControlType.ListItem).ToList();
                    wxWindow.FocusNative();
                    if (item != null && item.Count > 0 && !string.IsNullOrWhiteSpace(sendMsg))
                    {
                        if (item.Count <= 1)
                        {
                            item.FirstOrDefault().Click();
                        }
                        else
                        {
                            item.FirstOrDefault(s => s.Parent != null && s.Parent.Name.Contains("@str:IDS_FAV_SEARCH_RESULT")).Click();
                        }

                        var msgBox = wxWindow.FindFirstDescendant(x => x.ByControlType(FlaUI.Core.Definitions.ControlType.Text)).AsTextBox();
                        msgBox.Text = sendMsg;
                        var button = wxWindow.FindAllDescendants().Where(s => s.Name == "发送(S)").FirstOrDefault();
                        button?.Click();
                    }
                }
            }


        }
        /// <summary>
        /// 自动添加好友，场景是我手动选中一个群聊记录，然后获取最后一个记录，然后如果没有添加好友，然后就模拟添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button8_Click(object sender, EventArgs e)
        {
            if (!IsInit)
            {
                InitWechat();
            }
            if (wxWindow != null)
            {
                if (wxWindow.AsWindow().Patterns.Window.PatternOrDefault != null)
                {
                    //将微信窗体设置为默认焦点状态
                    wxWindow.AsWindow().Patterns.Window.Pattern.SetWindowVisualState(FlaUI.Core.Definitions.WindowVisualState.Normal);
                }
            }
            var all = wxWindow.FindAllByXPath(@"//*/List[@Name='消息']").FirstOrDefault().AsListBox();
            if (all != null && all.Items?.Length > 0)
            {
                var last = all.Items.Last();
                var y = last.FindAllDescendants().Where(s => s.ControlType == ControlType.Button);
                if (y != null && y.Any())
                {
                    y.First().Click(true);
                    wxWindow.FindAllDescendants().Where(s => s.Name == "添加到通讯录").FirstOrDefault().Click();
                    await Task.Delay(500);
                    wxWindow.FindAllDescendants().Where(s => s.Name == "确定").FirstOrDefault().Click();
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择图片";
            ofd.Multiselect = true;
            ofd.RestoreDirectory = true;
            ofd.Filter = "PNG文件|*.png|JPG文件|*.jpg|GIF文件|*.gif|所有文件|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (var item in ofd.FileNames)
                {
                    this.listBox2.Items.Add(item);
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择文件";
            ofd.Multiselect = true;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (var item in ofd.FileNames)
                {
                    this.listBox3.Items.Add(item);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            for (int i = listBox2.Items.Count - 1; i > -1; i--)
            {
                if (listBox2.GetSelected(i))
                {
                    listBox2.Items.RemoveAt(i);
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            for (int i = listBox3.Items.Count - 1; i > -1; i--)
            {
                if (listBox3.GetSelected(i))
                {
                    listBox3.Items.RemoveAt(i);
                }
            }
        }

        public void SendMsg(MessageType messageType)
        {
            try
            {
                if (this.listBox1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("请选择要发送的人或群");
                    return;
                }
                foreach (var receiver in this.listBox1.SelectedItems)
                {
                    IntPtr maindHwnd = FindWindow("WeChatMainWndForPC", null);
                    if (maindHwnd != IntPtr.Zero)
                    {
                        ShowWindow(maindHwnd, 9);
                        SetForegroundWindow(maindHwnd);
                        SetFocus(maindHwnd);

                        Rect lpRect;
                        GetWindowRect(maindHwnd, out lpRect);
                        int top_ = lpRect.Top + 50;
                        int left_ = lpRect.Left + 160;
                        SetCursorPos(left_, top_);

                        mouse_event(0x0002, left_, top_, 0, 0);
                        mouse_event(0x0004, left_, top_, 0, 0);
                        System.Threading.Thread.Sleep(1000);

                        // 清除搜索框===================================================
                        //System.Windows.Forms.SendKeys.SendWait("^a");
                        //System.Threading.Thread.Sleep(1000);
                        //System.Windows.Forms.SendKeys.SendWait("^x");
                        //System.Threading.Thread.Sleep(1000);

                        //SetForegroundWindow(maindHwnd);
                        //SetFocus(maindHwnd);
                        //SetCursorPos(left_, top_);
                        //mouse_event(0x0002, left_, top_, 0, 0);
                        //mouse_event(0x0004, left_, top_, 0, 0);
                        //System.Threading.Thread.Sleep(1000);

                        //搜索群===================================================
                        System.Windows.Forms.SendKeys.SendWait(receiver.ToString());
                        System.Threading.Thread.Sleep(1000);
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}");

                        Clipboard.Clear();

                        ShowWindow(maindHwnd, 9);
                        SetForegroundWindow(maindHwnd);
                        SetFocus(maindHwnd);
                        int top2_ = lpRect.Bottom - 108;
                        int left2_ = lpRect.Left + 600;
                        SetCursorPos(left2_, top2_);

                        mouse_event(0x0002, left2_, top2_, 0, 0);
                        mouse_event(0x0004, left2_, top2_, 0, 0);
                        System.Threading.Thread.Sleep(1000);


                        if (messageType == MessageType.TEXT || messageType == MessageType.ALL)
                        {
                            //发文字===================================================
                            if (!string.IsNullOrWhiteSpace(this.richTextBox1.Text))
                            {
                                Clipboard.SetText(this.richTextBox1.Text);
                                System.Threading.Thread.Sleep(1000);
                                System.Windows.Forms.SendKeys.SendWait("^v");  //发送Ctrl+v 
                                System.Threading.Thread.Sleep(1000);
                                SendMessage(maindHwnd, 0x0100, 13, 0);  //回车
                                System.Threading.Thread.Sleep(1000);
                                Clipboard.Clear();
                            }

                            //===================================================
                        }


                        if (messageType == MessageType.IMAGE || messageType == MessageType.ALL)
                        {
                            //发图片===================================================
                            foreach (var item in this.listBox2.Items)
                            {
                                var image = Image.FromFile(item.ToString());
                                Clipboard.SetImage(image);
                                System.Threading.Thread.Sleep(1000);
                                System.Windows.Forms.SendKeys.SendWait("^v");
                                System.Threading.Thread.Sleep(1000);
                                SendMessage(maindHwnd, 0x0100, 13, 0);
                                System.Threading.Thread.Sleep(1000);
                                Clipboard.Clear();
                            }

                            //===================================================
                        }

                        if (messageType == MessageType.FILE || messageType == MessageType.ALL)
                        {
                            //发文件===================================================
                            StringCollection stringCollection = new StringCollection();
                            foreach (var item in this.listBox3.Items)
                            {
                                stringCollection.Add(item.ToString());
                            }
                            if (stringCollection.Count > 0)
                            {
                                Clipboard.SetFileDropList(stringCollection);
                                System.Threading.Thread.Sleep(1000);
                                System.Windows.Forms.SendKeys.SendWait("^v");
                                System.Threading.Thread.Sleep(1000);
                                SendMessage(maindHwnd, 0x0100, 13, 0);
                                System.Threading.Thread.Sleep(1000);
                                Clipboard.Clear();
                            }

                            //===================================================
                        }
                    }
                    else
                    {
                        MessageBox.Show("错误，没有找到微信！");
                    }
                }
                MessageBox.Show("发送完成", "完成", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
                //MessageBox.Show("发送完成！",options: MessageBoxOptions.ServiceNotification);

            }
            catch (Exception ex)
            {

            }
        }

        public void SendMsg1(MessageType messageType)
        {

            try
            {
                if (this.listBox1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("请选择要发送的人或群");
                    return;
                }
                PostMessage(HWND_BROADCAST, WM_INPUTLANGUANGEREQUEST, IntPtr.Zero, LoadKeyboardLayout(en_US, KLF_ACTIVATE));
                foreach (var receiver in this.listBox1.SelectedItems)
                {
                    IntPtr maindHwnd = FindWindow("WeChatMainWndForPC", null);
                    if (maindHwnd != IntPtr.Zero)
                    {
                        ShowWindow(maindHwnd, 9);
                        SetForegroundWindow(maindHwnd);
                        SetFocus(maindHwnd);


                        if (!IsInit)
                        {
                            InitWechat();
                        }
                        if (wxWindow != null)
                        {
                            if (wxWindow.AsWindow().Patterns.Window.PatternOrDefault != null)
                            {
                                //将微信窗体设置为默认焦点状态
                                wxWindow.AsWindow().Patterns.Window.Pattern.SetWindowVisualState(FlaUI.Core.Definitions.WindowVisualState.Normal);
                            }
                        }

                        //搜索群===================================================
                        wxWindow.FindAllDescendants().Where(s => s.Name == "通讯录")?.FirstOrDefault()?.Click();
                        wxWindow.FindAllDescendants().Where(s => s.Name == "聊天")?.FirstOrDefault()?.Click();
                        var search = wxWindow.FindAllDescendants().FirstOrDefault(s => s.Name == "搜索");
                        search.FocusNative();
                        search.Focus();
                        search.Click();
                        System.Threading.Thread.Sleep(1000);
                        System.Windows.Forms.SendKeys.SendWait(receiver.ToString());
                        System.Threading.Thread.Sleep(1000);


                        var listitem = wxWindow.FindAllDescendants().Where(s => s.ControlType == ControlType.List && s.Name.Contains("@str:IDS_FAV_SEARCH_RESULT")).
                            FirstOrDefault()?.FindAllDescendants().Where(s => s.ControlType == ControlType.ListItem).FirstOrDefault();
                        if (listitem == null || listitem.Name != receiver.ToString())
                        {
                            continue;
                        }
                        System.Threading.Thread.Sleep(1000);
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                        Clipboard.Clear();
                       
                        var button = wxWindow.FindAllDescendants().Where(s => s.Name == "发送(S)").FirstOrDefault();
                        if (button == null)
                        {
                            continue;
                        }

                        wxWindow.FindFirstDescendant(x => x.ByControlType(FlaUI.Core.Definitions.ControlType.Text)).Click();

                        if (messageType == MessageType.TEXT || messageType == MessageType.ALL)
                        {
                            if (!string.IsNullOrWhiteSpace(this.richTextBox1.Text))
                            {
                                Clipboard.SetText(this.richTextBox1.Text);
                                System.Threading.Thread.Sleep(1000);
                                System.Windows.Forms.SendKeys.SendWait("^v");  //发送Ctrl+v 
                                System.Threading.Thread.Sleep(1000);
                                SendMessage(maindHwnd, 0x0100, 13, 0);  //回车
                                System.Threading.Thread.Sleep(1000);
                                Clipboard.Clear();
                            }

                            //===================================================
                        }


                        if (messageType == MessageType.IMAGE || messageType == MessageType.ALL)
                        {
                            //发图片===================================================
                            foreach (var item in this.listBox2.Items)
                            {
                                var image = Image.FromFile(item.ToString());
                                Clipboard.SetImage(image);
                                System.Threading.Thread.Sleep(1000);
                                System.Windows.Forms.SendKeys.SendWait("^v");
                                System.Threading.Thread.Sleep(1000);
                                SendMessage(maindHwnd, 0x0100, 13, 0);
                                System.Threading.Thread.Sleep(1000);
                                Clipboard.Clear();
                            }

                            //===================================================
                        }

                        if (messageType == MessageType.FILE || messageType == MessageType.ALL)
                        {
                            //发文件===================================================
                            StringCollection stringCollection = new StringCollection();
                            foreach (var item in this.listBox3.Items)
                            {
                                stringCollection.Add(item.ToString());
                            }
                            if (stringCollection.Count > 0)
                            {
                                Clipboard.SetFileDropList(stringCollection);
                                System.Threading.Thread.Sleep(1000);
                                System.Windows.Forms.SendKeys.SendWait("^v");
                                System.Threading.Thread.Sleep(1000);
                                SendMessage(maindHwnd, 0x0100, 13, 0);
                                System.Threading.Thread.Sleep(1000);
                                Clipboard.Clear();
                            }

                            //===================================================
                        }
                    }
                    else
                    {
                        MessageBox.Show("错误，没有找到微信！");
                    }
                }
                PostMessage(HWND_BROADCAST, WM_INPUTLANGUANGEREQUEST, IntPtr.Zero, LoadKeyboardLayout(cn_ZH, KLF_ACTIVATE));
                MessageBox.Show("发送完成", "完成", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
                //MessageBox.Show("发送完成！",options: MessageBoxOptions.ServiceNotification);

            }
            catch (Exception ex)
            {

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SendMsg1(MessageType.TEXT);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            SendMsg1(MessageType.IMAGE);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SendMsg1(MessageType.FILE);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SendMsg1(MessageType.ALL);
        }

        private void showwxWindows()
        {
            IntPtr maindHwnd = FindWindow("WeChatMainWndForPC", null);
            if (maindHwnd != IntPtr.Zero)
            {
                ShowWindow(maindHwnd, 9);
                SetForegroundWindow(maindHwnd);
                SetFocus(maindHwnd);
            }
        }
    }
}