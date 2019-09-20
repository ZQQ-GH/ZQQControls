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
    [ToolboxItem(true)]
    public partial class LoginPanel : UserControl
    {
        public LoginPanel()
        {
            InitializeComponent();
        }

        private void LoginPanel_Load(object sender, EventArgs e)
        {
            button1.Click += btn_Click;
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

        [Browsable(false)]
        public string UserNumber
        {
            get { return TB_Number.Text; }
            set
            {
                TB_Number.Text= value;

            }
        }
        [Browsable(false)]
        public string UserPassword
        {
            get { return TB_Password.Text; }
            set
            {
                TB_Password.Text = value;
            }
        }


        [Category("自定义")]
        [Description("标签字体")]
        [DefaultValue(typeof(Font), "微软雅黑, 12pt")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Font LabelFont
        {
            get { return label1.Font; }
            set
            {
                label1.Font = value;
                label2.Font = value;
            }
        }

        [Category("自定义")]
        [Description("输入框字体")]
        [DefaultValue(typeof(Font), "微软雅黑, 12pt")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Font TextFont
        {
            get { return label1.Font; }
            set
            {
                TB_Number.Font = value;
                TB_Password.Font = value;
            }
        }

        [Category("自定义")]
        [Description("按钮字体")]
        [DefaultValue(typeof(Font), "微软雅黑, 18pt")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Font ButtonFont
        {
            get { return button1.Font; }
            set
            {
                button1.Font = value;
            }
        }

        [Category("自定义")]
        [Description("输入框背景色")]
        [DefaultValue(typeof(Color), "White")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color TextBackColor
        {
            get { return TB_Number.BackColor; }
            set
            {
                TB_Number.BackColor = value;
                TB_Password.BackColor = value;
            }
        }

        [Category("自定义")]
        [Description("输入框前景色")]
        [DefaultValue(typeof(Color), "16, 165, 132")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color TextForeColor
        {
            get { return TB_Number.ForeColor; }
            set
            {
                TB_Number.ForeColor = value;
                TB_Password.ForeColor = value;
            }
        }

        [Category("自定义")]
        [Description("按钮文字")]
        [DefaultValue(typeof(string), "立即登录")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string ButtonText
        {
            get { return button1.Text; }
            set
            {
                button1.Text = value;
            }
        }

        [Category("自定义")]
        [Description("按钮前景色")]
        [DefaultValue(typeof(Color), "16, 165, 132")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color ButtonForeColor
        {
            get { return button1.ForeColor; }
            set
            {
                button1.ForeColor = value;
            }
        }

        [Category("自定义")]
        [Description("图片")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image Image
        {
            get { return pictureBox1.Image; }
            set
            {
                pictureBox1.Image = value;
            }
        }




    }
}
