using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StreamWriterSample
{
    public partial class Form1 : Form
    {
        string path = string.Empty;
        List<string> list;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            path = @"C:\Users\user\Desktop\테스트 문서.txt";
            //CSVRead();
            MakeList();
        }


        public void CSVRead()
        {
            list = new List<string>();

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
                    }
                }

                Save(list);
            }
        }

        public void MakeList()
        {
            List<string> list = new List<string>();

            list.Add("c# 파일 저장 테스트 중입니다.");
            list.Add("Hello world!!");
            Save(list);
        }


        public void Save(List<string> list)
        {
            var csv = new StringBuilder();
            string savePath = @"C:\Users\user\Desktop\FileSave.csv";

            for (int i = 0; i < list.Count; i++)
            {
                csv.AppendLine(list[i].ToString());
            }
            
            File.WriteAllText(savePath, csv.ToString(), Encoding.UTF8);
        }

    }
}
