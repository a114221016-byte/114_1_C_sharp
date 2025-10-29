namespace LOginDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 修正：直接使用 txtAccount 和 txtPassword 控制項的 Text 屬性
            string account = txtAccount.Text;
            string password = txtPassword.Text;

            //    if (account == "admin" && password == "1234")
            //    {
            //        lblResult.Text = "登入成功";
            //    }
            //    else
            //    {
            //        lblResult.Text = "登入失敗";
            //    }
            //}
            if (account.Length == 0 || password.Length == 0)
            {
                lblResult.Text = "請輸入帳號或密碼";
            }
            else
            {
                if (String.Compare(account, "admin") == 0 && String.Compare(password, "1234") == 0)
                {
                    lblResult.Text = "登入成功";
                }
                else
                {
                    lblResult.Text = "登入失敗";
                }
            }
        }