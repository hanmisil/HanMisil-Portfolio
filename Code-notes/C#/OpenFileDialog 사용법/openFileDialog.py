using System;
using System.Windows.Forms;

namespace openFIle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            ShowImgOpenDialog();
        }

        public void ShowImgOpenDialog()
        {
            //파일오픈창 생성 및 설정
            OpenFileDialog ofd = new OpenFileDialog();
            // 다이얼로그 Title
            ofd.Title = "파일 선택";
            // 필터 설정
            ofd.Filter = "txt files (*.txt) | *.txt; | All files (*.*) | *.*";
            // 기본 폴더 설정
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //파일 오픈창 로드
            DialogResult dr = ofd.ShowDialog();

            //OK버튼 클릭시
            if (dr == DialogResult.OK)
            {
                // 선택한 파일 전체 경로
                string fileFullName = ofd.FileName;
                textbox.Text = fileFullName;
            }
        }
    }
}
