using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace osgb2fbx
{
    public partial class 数据转换器 : Form
    {
        public static string m_inputpath = @"F:\QXM\DangPeng_OSGB\Data";
        public static string m_outptah = @"F:\data";

        public static int m_infiles = 0;
        bool m_converting = false;

        public 数据转换器()
        {
            InitializeComponent();
        }

        private void btn_datapath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                m_infiles = 0;
                m_inputpath = dialog.SelectedPath;
                txt_datapath.Text = m_inputpath;

                foreach (var dir in Directory.GetDirectories(m_inputpath))
                {
                    foreach (var file in Directory.GetFiles(dir))
                    {
                        m_infiles++;
                    }
                }
            }
        }

        private void btn_outpath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                m_outptah = dialog.SelectedPath;
                txt_outpath.Text = m_outptah;
            }
        }

        private void btn_exchange_Click(object sender, EventArgs e)
        {
            if (m_inputpath == "" || m_outptah == "")
            {
                return;
            }

            if (m_converting)
            {
                m_converting = false;
                btn_exchange.Text = "stoping";
            }
            else
            {
                if (m_infiles > 0)
                {
                    m_converting = true;
                    btn_exchange.Text = "stop";

                    pb_exc.Visible = true;
                    pb_exc.Value = 0;

                    Thread tth = new Thread(exchange);
                    tth.Start();
                }
            }
        }

        void exchange()
        {
            int tfiles = 0;

            string t_runPath = System.AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine(t_runPath);

            System.Diagnostics.Process exep = new System.Diagnostics.Process();
            exep.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

            exep.StartInfo.FileName = t_runPath + @".\osg3.6.5\bin\osgconv.exe";

            Console.WriteLine(exep.StartInfo.WorkingDirectory);

            foreach (var dir in Directory.GetDirectories(m_inputpath))
            {
                if (!m_converting)
                {
                    if (!this.pb_exc.InvokeRequired)
                    {
                        this.pb_exc.Visible = false;
                    }
                    else
                    {
                        Action<bool> actionDelegate = (x) => { this.pb_exc.Visible = x; };

                        this.pb_exc.BeginInvoke(actionDelegate, false);
                    }

                    if (!this.btn_exchange.InvokeRequired)
                    {
                        this.btn_exchange.Text = "convert";
                    }
                    else
                    {
                        Action<string> actionDelegate = (x) => { this.btn_exchange.Text = x; };

                        this.btn_exchange.BeginInvoke(actionDelegate, "convert");
                    }

                    if (!this.lbl_status.InvokeRequired)
                    {
                        this.lbl_status.Text = "user canceled.";
                    }
                    else
                    {
                        Action<string> actionDelegate = (x) => { this.lbl_status.Text = x; };

                        this.lbl_status.BeginInvoke(actionDelegate, "user canceled.");
                    }
                    return;
                }

                string tsubdir = Path.GetFileNameWithoutExtension(dir);

                // 设置工作目录为需要转换的tile所在目录传入的转换路径参数较小
                exep.StartInfo.WorkingDirectory = dir;

                Console.WriteLine(exep.StartInfo.WorkingDirectory);

                if (!Directory.Exists(m_outptah + @"\Data\" + tsubdir))
                {
                    Directory.CreateDirectory(m_outptah + @"\Data\" + tsubdir);
                }
#if false
                int t_idxL16 = 0;
                int t_idxL17 = 0;
                int t_idxL18 = 0;
                int t_idxL19 = 0;
                int t_idxL20 = 0;
                int t_idxL21 = 0;
                int t_idxL22 = 0;
                int t_idxL23 = 0;

                foreach (var file in Directory.GetFiles(dir))
                {
                    string filename = Path.GetFileNameWithoutExtension(file);
                    string outfile = "";
                    if (filename.IndexOf("L16") > 0)
                    {
                        outfile = tsubdir + "_L16_" + t_idxL16.ToString() + ".fbx";
                        exep.StartInfo.Arguments = "-o -90-1,0,0 " + file.ToString() + " " + m_outptah + @"\Data\" + tsubdir + @"\" + outfile;
                        t_idxL16++;
                    }
                    else if (filename.IndexOf("L17") > 0)
                    {
                        outfile = tsubdir + "_L17_" + t_idxL17.ToString() + ".fbx";
                        exep.StartInfo.Arguments = "-o -90-1,0,0 " + file.ToString() + " " + m_outptah + @"\Data\" + tsubdir + @"\" + outfile;
                        t_idxL17++;
                    }
                    else if (filename.IndexOf("L18") > 0)
                    {
                        outfile = tsubdir + "_L18_" + t_idxL18.ToString() + ".fbx";
                        exep.StartInfo.Arguments = "-o -90-1,0,0 " + file.ToString() + " " + m_outptah + @"\Data\" + tsubdir + @"\" + outfile;
                        t_idxL18++;
                    }
                    else if (filename.IndexOf("L19") > 0)
                    {
                        outfile = tsubdir + "_L19_" + t_idxL19.ToString() + ".fbx";
                        exep.StartInfo.Arguments = "-o -90-1,0,0 " + file.ToString() + " " + m_outptah + @"\Data\" + tsubdir + @"\" + outfile;
                        t_idxL19++;
                    }
                    else if (filename.IndexOf("L20") > 0)
                    {
                        outfile = tsubdir + "_L20_" + t_idxL20.ToString() + ".fbx";
                        exep.StartInfo.Arguments = "-o -90-1,0,0 " + file.ToString() + " " + m_outptah + @"\Data\" + tsubdir + @"\" + outfile;
                        t_idxL20++;
                    }
                    else if (filename.IndexOf("L21") > 0)
                    {
                        outfile = tsubdir + "_L21_" + t_idxL21.ToString() + ".fbx";
                        exep.StartInfo.Arguments = "-o -90-1,0,0 " + file.ToString() + " " + m_outptah + @"\Data\" + tsubdir + @"\" + outfile;
                        t_idxL21++;
                    }
                    else if (filename.IndexOf("L22") > 0)
                    {
                        outfile = tsubdir + "_L22_" + t_idxL22.ToString() + ".fbx";
                        exep.StartInfo.Arguments = "-o -90-1,0,0 " + file.ToString() + " " + m_outptah + @"\Data\" + tsubdir + @"\" + outfile;
                        t_idxL22++;
                    }
                    else if (filename.IndexOf("L23") > 0)
                    {
                        outfile = tsubdir + "_L23_" + t_idxL23.ToString() + ".fbx";
                        exep.StartInfo.Arguments = "-o -90-1,0,0 " + file.ToString() + " " + m_outptah + @"\Data\" + tsubdir + @"\" + outfile;
                        t_idxL23++;
                    }

                    if (!this.lbl_status.InvokeRequired)
                    {
                        this.lbl_status.Text = filename + ".osgb => " + outfile;
                    }
                    else
                    {
                        Action<string> actionDelegate = (x) => { this.lbl_status.Text = x; };

                        this.lbl_status.BeginInvoke(actionDelegate, filename + ".osgb => " + outfile);
                    }

                    exep.Start();
                    exep.WaitForExit();

                    tfiles++;

                    float tpb = (float)((float)tfiles / (float)m_infiles);
                    tpb *= 100;
                    int tipb = (int)tpb;

                    if (!this.pb_exc.InvokeRequired)
                    {
                        this.pb_exc.Value = (int)tpb;
                    }
                    else
                    {
                        Action<int> actionDelegate = (x) => { this.pb_exc.Value = x; };

                        this.pb_exc.BeginInvoke(actionDelegate, tipb);
                    }
                }
#else
                // L16 // L17 // L18 // L19 // L20 // L21 // L22 // L23  // L24
                for (int i = 0; i < 9; i++)
                {
                    string filesarray = "";
                    float tpb = 0;
                    int tipb = 0;

                    string t_level = "L" + (16 + i).ToString();

                    int t_idx = 0;

                    foreach (var file in Directory.GetFiles(dir))
                    {
                        string filename = Path.GetFileNameWithoutExtension(file);
                        Console.WriteLine(filename);
                        if (filename.IndexOf(t_level) > 0)
                        {
                            filesarray += @".\" + filename + ".osgb ";
                            tfiles++;

                            if (!this.lbl_status.InvokeRequired)
                            {
                                this.lbl_status.Text = filename + ".osgb";
                            }
                            else
                            {
                                Action<string> actionDelegate = (x) => { this.lbl_status.Text = x; };

                                this.lbl_status.BeginInvoke(actionDelegate, filename + ".osgb");
                            }
                        }

                        tpb = (float)((float)tfiles / (float)m_infiles);
                        tpb *= 100;
                        tipb = (int)tpb;
                    }

                    string targ = "-o -90-1,0,0 " + filesarray + " " + m_outptah + @"\Data\" + tsubdir + @"\" + tsubdir + "_" + t_level + "_" + t_idx.ToString() + ".fbx";
                    // 压缩纹理
                    // string targ = "-O --compressed -o -90-1,0,0 " + filesarray + " " + m_outptah + @"\Data\" + tsubdir + @"\" + tsubdir + "_" + t_level + "_" + t_idx.ToString() + ".fbx";
                    if (!this.lbl_status.InvokeRequired)
                    {
                        this.lbl_status.Text = "=> " + tsubdir + "_" + t_level + "_" + t_idx.ToString() + ".fbx";
                    }
                    else
                    {
                        Action<string> actionDelegate = (x) => { this.lbl_status.Text = x; };
                        this.lbl_status.BeginInvoke(actionDelegate, "=> " + tsubdir + "_" + t_level + "_" + t_idx.ToString() + ".fbx");
                    }
                    // Console.WriteLine(targ);
                    exep.StartInfo.Arguments = targ;
                    exep.Start();
                    exep.WaitForExit();
                    if (!this.pb_exc.InvokeRequired)
                    {
                        this.pb_exc.Value = (int)tpb;
                    }
                    else
                    {
                        Action<int> actionDelegate = (x) => { this.pb_exc.Value = x; };

                        this.pb_exc.BeginInvoke(actionDelegate, tipb);
                    }
                }
#endif
            }
            if (!this.pb_exc.InvokeRequired)
            {
                this.pb_exc.Visible = false;
            }
            else
            {
                Action<bool> actionDelegate = (x) => { this.pb_exc.Visible = x; };
                this.pb_exc.BeginInvoke(actionDelegate, false);
            }

            if (!this.lbl_status.InvokeRequired)
            {
                this.lbl_status.Text = "completed";
            }
            else
            {
                Action<string> actionDelegate = (x) => { this.lbl_status.Text = x; };

                this.lbl_status.BeginInvoke(actionDelegate, "completed");
            }

            if (!this.btn_exchange.InvokeRequired)
            {
                this.btn_exchange.Text = "convert";
            }
            else
            {
                Action<string> actionDelegate = (x) => { this.btn_exchange.Text = x; };

                this.btn_exchange.BeginInvoke(actionDelegate, "convert");
            }

            return;
        }

        private void 数据转换器_Load(object sender, EventArgs e)
        {
            pb_exc.Visible = false;
            pb_exc.Value = 0;
        }
    }
}
