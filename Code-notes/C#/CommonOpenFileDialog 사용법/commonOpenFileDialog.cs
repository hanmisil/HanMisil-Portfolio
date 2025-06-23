using System;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace CommonOpenFileDialogSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            ShowFolderOpenDialog();
        }

        private void ShowFolderOpenDialog()
        {

            //폴더 오픈창 생성 및 설정
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            // 기본 폴더 설정
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            // true면 폴더 선택 false면 파일 선택
            dialog.IsFolderPicker = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string fileFullName = dialog.FileName;
                textPath.Text = fileFullName;

            }
        }
    }
}
