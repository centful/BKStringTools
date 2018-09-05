using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 批量操作工具
{
    public partial class BKYZtools : Form
    {
        public BKYZtools()
        {
            InitializeComponent();
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            txtContent2.Text = "";
            txtContent1.Text = txtContent1.Text.Trim().Replace(" ", "");
            string str = txtContent1.Text.Trim().Replace("\n", " ");
            string[] pp = str.Split(' ');
            string Xml = ""; 
            for (int i = 0; i < pp.Length; i++)
            {
                pp[i] = pp[i].Substring(0, 1).ToUpper() + pp[i].Substring(1);
                pp[i] = "public string " + pp[i] + " {get;set;} \n";
                Xml += pp[i];
            }
            Xml = Xml.Replace("\r", "");
            Xml = Xml.Replace("\t", "");
            txtContent2.Text = Xml;
        }

        private void btnReqXML_Click(object sender, EventArgs e)
        {
            txtContent2.Text = "";
            txtContent1.Text = txtContent1.Text.Trim().Replace(" ", "");
            string str = txtContent1.Text.Trim().Replace("\n", " ");
            string[] pp = str.Split(' ');
            string Xml = "var xmlDoc = new XmlDocument();\r\nXmlNode root = xmlDoc.CreateElement(\"req\"); \r\n";
            for (int i = 0; i < pp.Length; i++)
            {
                //pp[i] = pp[i].Substring(0, 1).ToUpper() + pp[i].Substring(1);
                pp[i] =string.Format("XmlNode {0}Node = xmlDoc.CreateElement(\"{1}\");\r\n{2}Node.InnerText = request.{3};\r\nroot.AppendChild({4}Node); \r\n\n", 
                    pp[i], pp[i], pp[i], pp[i], pp[i]);
                Xml += pp[i];
            }
            Xml += "xmlDoc.AppendChild(root);\r\nstring requestXml = xmlDoc.InnerXml; \r\n";
            Xml = Xml.Replace("\r", "");
            Xml = Xml.Replace("\t", "");
            txtContent2.Text = Xml;

        }

        private void btnResXML_Click(object sender, EventArgs e)
        {
            txtContent2.Text = "";
            string str = txtContent1.Text.Trim().Replace("\n", " ");
            string[] pp = str.Split(' ');
            string Xml="";
            for (int i = 0; i < pp.Length; i++)
            {
                pp[i] = pp[i].Substring(0, 1).ToUpper() + pp[i].Substring(1);
                pp[i] = "infoList."+pp[i]+ " = xNode.SelectSingleNode(\"" + pp[i] + "\")?.InnerText ?? \"\";\n";
                Xml += pp[i];
            }
            Xml = Xml.Replace("\r", "");
            Xml = Xml.Replace("\t", "");
            txtContent2.Text = Xml;
        }

        private void btnReqCs_Click(object sender, EventArgs e)
        {
            string path = @"C:\CsFile\Request4" + txtClass.Text.Trim() + @".cs";
            if (!Directory.Exists(@"C:\CsFile"))
            {
                Directory.CreateDirectory(@"C:\CsFile");
            }
            if(File.Exists(path))
            {
                File.Delete(path);
            }
            txtContent1.Text = txtContent1.Text.Trim().Replace(" ", "");
            string str = txtContent1.Text.Trim().Replace("\n", " ");
            string[] pp = str.Split(' ');
            string Xml = "";
            for (int i = 0; i < pp.Length; i++)
            {
                pp[i] = pp[i].Substring(0, 1).ToUpper() + pp[i].Substring(1);
                pp[i] = "\t\tpublic string " + pp[i] + " {get;set;} \n";
                Xml += pp[i];
            }
            Xml = Xml.Replace("\r", "");
            //Xml = Xml.Replace("\t", "");
            
            string Cs = "namespace In.Api.Dto.HisWs\n{\n\tpublic class Request4" + txtClass.Text.Trim() +"\n\t{\n"+ Xml + "\t}\n}";
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            //开始写入
            sw.Write(Cs);
            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            fs.Close();
            MessageBox.Show(@"生成成功!文件存放在C:\CsFile");
        }

        private void btnResCs_Click(object sender, EventArgs e)
        {
            string path = @"C:\CsFile\Response4" + txtClass.Text.Trim() + @".cs";
            if (!Directory.Exists(@"C:\CsFile"))
            {
                Directory.CreateDirectory(@"C:\CsFile");
            }
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            txtContent1.Text = txtContent1.Text.Trim().Replace(" ", "");
            string str = txtContent1.Text.Trim().Replace("\n", " ");
            string[] pp = str.Split(' ');
            string Xml = "";
            for (int i = 0; i < pp.Length; i++)
            {
                pp[i] = pp[i].Substring(0, 1).ToUpper() + pp[i].Substring(1);
                pp[i] = "\t\tpublic string " + pp[i] + " {get;set;} \n";
                Xml += pp[i];
            }
            Xml = Xml.Replace("\r", "");
            //Xml = Xml.Replace("\t", "");

            string Cs = "using System.Collections.Generic;\nnamespace In.Api.Dto.HisWs\n{\n\tpublic class Response4" + txtClass.Text.Trim() + 
                "\n\t{\n\t\tpublic string ResultCode {get;set;}\n\t\tpublic string ResultDesc {get;set;}\n\t\t public List<"+txtClass.Text.Trim()+"Info> info {get;set;}\n\n\t}\n\tpublic class "+txtClass.Text.Trim()+"Info\n\t{\n" + Xml + "\t}\n}";
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            //开始写入
            sw.Write(Cs);
            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            fs.Close();
            MessageBox.Show(@"生成成功!文件存放在C:\CsFile");
        }

        private void BKYZtools_Load(object sender, EventArgs e)
        {

        }

        private void btnJson_Click(object sender, EventArgs e)
        {
            txtContent2.Text = "";
            txtContent1.Text = txtContent1.Text.Trim().Replace(" ", "");
            string str = txtContent1.Text.Trim().Replace("\n", " ");
            string[] pp = str.Split(' ');
            string Xml = "{\n";
            for (int i = 0; i < pp.Length; i++)
            {
                pp[i] = pp[i].Substring(0, 1).ToUpper() + pp[i].Substring(1);
                pp[i] = "\"" + pp[i] + "\":\"\", \n";
                Xml += pp[i];
            }
            Xml = Xml.Replace("\r", "");
            Xml = Xml.Replace("\t", "");
            Xml = Xml.Substring(0, Xml.Length - 3);
            txtContent2.Text = Xml+"\n}";
        }
    }
}
