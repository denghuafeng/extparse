using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace web
{
    public partial class CodeTool : Form
    {
        public CodeTool()
        {
            InitializeComponent();
        }

        private void BT_FilePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.ShowDialog(this);
            TB_FilePath.Text = fb.SelectedPath;
            TB_FileExts.Focus();
        }

        private void BT_TrimCode_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TB_FilePath.Text))
            {
                MessageBox.Show(this, "请选择进行代码清理的目录！", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!Directory.Exists(TB_FilePath.Text))
            {
                MessageBox.Show(this, "您选择的目录不存在！", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (String.IsNullOrEmpty(TB_FileExts.Text))
            {
                MessageBox.Show(this, "请输入您要进行处理的文件后缀信息！", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult dr = MessageBox.Show(this, "确定要执行代码清理操作吗，此操作不可恢复？", "友情提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr != DialogResult.Yes)
            {
                return;
            }

            BT_TrimCode.Enabled = false;

            List<String> list = new List<string>();
            list.Add(TB_FilePath.Text);
            foreach (string s in TB_FileExts.Text.Split('\n'))
            {
                list.Add(s.Trim());
            }

            new Thread(TrimCode).Start(list);
        }

        private void TrimCode(object obj)
        {
            if (obj == null || !(obj is List<string>))
            {
                return;
            }
            List<string> list = (List<string>)obj;
            String path = list[0];

            if (!Directory.Exists(path))
            {
                return;
            }

            for (int i = 1; i < list.Count; i += 1)
            {
                foreach (string f in Directory.GetFiles(path, "*" + list[i]))
                {
                    TrimFile(f);
                }
            }

            foreach (string d in Directory.GetDirectories(path))
            {
                list[0] = d;
                TrimCode(list);
            }
        }

        private void TrimFile(string file)
        {
            LB_FileInfo.BeginInvoke(new EventHandler(ViewInfo), "正在处理：" + Path.GetFileName(file));

            StringBuilder sb = new StringBuilder();
            StreamReader sr = File.OpenText(file);
            string line = sr.ReadLine();
            while (line != null)
            {
                sb.Append(line.Trim());
                line = sr.ReadLine();
            }
            sr.Close();
            File.WriteAllText(file, sb.ToString(), Encoding.UTF8);
        }

        private void ViewInfo(object o, EventArgs e)
        {
            LB_FileInfo.Text = o + "";
        }
    }
}