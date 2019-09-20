using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZQQ.Controls
{
    public partial class CloseBtn : UserControl
    {
        public CloseBtn()
        {
            InitializeComponent();
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = levelColor;
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = enterColor;
        }

        private Color enterColor =Color.Red;
        [Category("自定义")]
        [Description("悬停颜色")]
        [DefaultValue(typeof(Color), "Red")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color EnterColor
        {
            get { return enterColor; }
            set
            {
                enterColor = value;
            }
        }

        private Color levelColor =Color.White;
        [Category("自定义")]
        [Description("离开颜色")]
        [DefaultValue(typeof(Color), "White")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color LevelColor
        {
            get { return levelColor; }
            set
            {
                levelColor = value;
            }
        }

        [Category("自定义")]
        [Description("宽度")]
        [DefaultValue(typeof(int), "30")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int btnWidth
        {
            get { return this.Width; }
            set
            {
                this.Width = value;
                button1.Width = value;
            }
        }


        [Category("自定义")]
        [Description("高度")]
        [DefaultValue(typeof(int), "30")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int btnHeight
        {
            get { return this.Height; }
            set
            {
                this.Height = value;
                button1.Height = value;
            }
        }

        //定义委托
        public delegate void BtnClickHandle(object sender, EventArgs e);
        //定义事件
        [Category("自定义")]
        [Description("按钮单机事件")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public event BtnClickHandle BtnClicked;
        private void btn_Click(object sender, EventArgs e)
        {
            if (BtnClicked != null)
                BtnClicked(sender, new EventArgs());//把按钮自身作为参数传递
        }

        private void CloseBtn_Load(object sender, EventArgs e)
        {
            button1.Click += btn_Click;
        }
    }
}
