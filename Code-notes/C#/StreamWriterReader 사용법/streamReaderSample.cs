using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace StreamReaderSample
{
    public partial class Form1 : Form
    {
        string path = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            path = ShowImgOpenDialog();
        }

        public string ShowImgOpenDialog()
        {
            string fileFullName = string.Empty;

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
                fileFullName = ofd.FileName;
                textbox.Text = fileFullName;
            }
            return fileFullName;
        }

        private void FileRead()
        {
            if (File.Exists(path))
            {
                using (var reader = new StreamReader(path))
                {
                    //EndOfStream 속성을 이용하여 파일의 마지막행까지 반복
                    while (!reader.EndOfStream)
                    {
                        //ReadLine 메서드로 한 줄씩 읽기
                        string line = reader.ReadLine();
                        textContent.AppendText(line);
                        textContent.AppendText("\r\n");
                    }
                }
            }
            else
            {
                textContent.Text = "The file does not exist.";
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            FileRead();
            ConsoleRead();
        }

        # 한 줄씩 읽는 방법
        public void ConsoleRead()
        {
            List<string> list = new List<string>();

            if (File.Exists(path))
            {
                using (var reader = new StreamReader(path))
                {
                    //EndOfStream 속성을 이용하여 파일의 마지막행까지 반복
                    while (!reader.EndOfStream)
                    {
                        //ReadLine 메서드로 한 줄씩 읽기
                        string line = reader.ReadLine();
                        list.Add(line);
                        Console.WriteLine(line);
                    }
                }
            }
            else
            {
                Console.WriteLine("The file does not exist.");
            }
        }

        # 텍스트 파일 전체 읽는 방법
        public void ConsoleAllRead()
        {
            if (File.Exists(path))
            {
                using (var reader = new StreamReader(path))
                {
                    string readData = File.ReadAllText(path);
                    Console.WriteLine(readData);
                }
            }
            else
            {
                Console.WriteLine("The file does not exist.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            path = @"C:\Users\user\Desktop\테스트 문서.txt";
            ConsoleRead();
            //ConsoleAllRead();
        }


        public void CSVRead()
        {
            List<string> list = new List<string>();

            if (File.Exists(path))
            {
                using (var reader = new StreamReader(path))
                {
                    //EndOfStream 속성을 이용하여 파일의 마지막행까지 반복
                    while (!reader.EndOfStream)
                    {
                        //ReadLine 메서드로 한 줄씩 읽기
                        string[] temp = reader.ReadLine().Split(';');
                        list.Add(temp[0]);
                        Console.WriteLine(temp);
                    }
                }
            }
            else
            {
                Console.WriteLine("The file does not exist.");
            }
        }
    }
}
