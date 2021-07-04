using FontAwesome.Sharp;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmAdmin : Form
    {
        private IconButton currentBtn; //nut ien tai
        private Panel leftBorderBtn; //panel thanh chay
        private Form currentChildForm; //form con hien tai
        public frmAdmin(string name, string pass)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 40);
            panelMenu.Controls.Add(leftBorderBtn);
            //form
            /*this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            */
            //open form
            startForm(Color.FromArgb(0, 124, 195));
            //login
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Text = name;
            lblLogin.ForeColor = Color.White;
        }

        private void startForm(Color color)
        {
            btnDashBoard.BackColor = Color.White;
            btnDashBoard.ForeColor = color;
            btnDashBoard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashBoard.IconColor = color;
            btnDashBoard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashBoard.ImageAlign = ContentAlignment.MiddleLeft;
            //leftborderbtn
            leftBorderBtn.BackColor = color;
            leftBorderBtn.Location = new Point(0, btnDashBoard.Location.Y);
            leftBorderBtn.BringToFront();
            //dat icon va label change
            iconChange.IconChar = btnDashBoard.IconChar;
            lblChange.Text = btnDashBoard.Text;
            //current child form
            currentChildForm = new frmDashBoard();
            currentChildForm.TopLevel = false;
            currentChildForm.FormBorderStyle = FormBorderStyle.None;
            currentChildForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(currentChildForm);
            panelContent.Tag = currentChildForm;
            currentChildForm.BringToFront();
            currentChildForm.Show();
        }
        private void ActivateButton(object senderBtn,Color color)
        {
            //neu nut duoc chon
            if(senderBtn != null)
            {
                DisableButon();
                //ep kieu cho senderBtn
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.White;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                //leftborderbtn
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.BringToFront();
                //dat icon va label change
                iconChange.IconChar = currentBtn.IconChar;
                lblChange.Text = currentBtn.Text;
            }

            
        }
        private void DisableButon()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.White;
                currentBtn.ForeColor = Color.DimGray;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.DimGray;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btnDashBoard_MouseHover(object sender, System.EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 124, 195));
        }

        private void btnQLHocSinh_MouseHover(object sender, System.EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 124, 195));
        }

        private void btnQLLopHoc_MouseHover(object sender, System.EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 124, 195));
        }

        private void btnGVCN_Click(object sender, System.EventArgs e)
        {

        }

        private void btnGVCN_MouseHover(object sender, System.EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 124, 195));
        }

        private void btnDiemSo_MouseHover(object sender, System.EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 124, 195));
        }

        private void btnThongKe_MouseHover(object sender, System.EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 124, 195));
        }

        private void btnThonTin_MouseHover(object sender, System.EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 124, 195));
        }

        private void btnHocPhi_Click(object sender, System.EventArgs e)
        {

        }

        private void btnHocPhi_MouseHover(object sender, System.EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 124, 195));
        }

        private void btnLogo_Click(object sender, System.EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            DisableButon();
            leftBorderBtn.Visible = false;
            iconChange.IconChar = IconChar.Home;
            lblChange.Text = "Home";
        }
        private void OpenChildForm(Form childForm)
        {
            if(lblChange != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //label change
            lblChange.Text = childForm.Text;
        }

        private void btnQLHocSinh_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new frmQLHocSinh());
        }

        private void btnDashBoard_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new frmDashBoard());
        }
    }
}
