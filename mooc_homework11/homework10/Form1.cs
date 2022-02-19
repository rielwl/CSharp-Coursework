using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;
using System.Net;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Runtime.InteropServices; // for console

namespace homework10
{
    // 这个代码按照老师提供的代码来写
    // 我是为了理解自己敲了一遍，加上自己的注释
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            this.Text = "简单爬虫程序";
        }
        public string startUrl = "http://www.cnblogs.com/dstang2000/"; // default string
        public int MaxCount = 10; 
        private void Form1_Load_1(object sender, EventArgs e)
        {
            // This is to show the console
            // AllocConsole();

            

        }
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Check the number
            string StringMaxCount = txtMaxCount.Text;
            // if it is empty, don't change anything
            if (!String.IsNullOrEmpty(StringMaxCount))
            {

                int TempMaxCount = int.Parse(txtMaxCount.Text);
                // Can remove this, but I didn't want too big a number being inputted
                if (TempMaxCount > 25)
                {
                    MessageBox.Show("请输入小于等于25的数字");
                }
                else if (TempMaxCount <= 0)
                {
                    MessageBox.Show("请输入大于0的数字");
                }
                else
                {
                    MaxCount = TempMaxCount;
                }
                txtMaxCount.Text = "";

            }

            // Check the link
            string TempUrl = txtUrl.Text;

            // if the field is empty, take it as keeping it as the previous link
            if (!String.IsNullOrEmpty(TempUrl))
            {
                using (var client = new MyClient())
                {
                    client.HeadOnly = true;
                    try
                    {
                        string str = client.DownloadString(TempUrl);

                        // update the text
                        lblCrawlFrom.Text = TempUrl;
                        startUrl = TempUrl;
                    }
                    catch
                    {
                        MessageBox.Show("网页不存在！" + Environment.NewLine + "请输入正确的链接!");
                    }
                    finally
                    {
                        txtUrl.Text = "";
                    }

                }
            }
            

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            Crawler myCrawler = new Crawler(MaxCount);

            myCrawler.urls.Add(startUrl, false); //加入初始页面
            new Thread(new ThreadStart(myCrawler.Crawl)).Start(); //开始爬行
        }
       
        
    }
    // issue HEAD instead of GET
    // this allows testing of the URL without downloading hte content
    class MyClient : WebClient
    {
        public bool HeadOnly { get; set; }
        protected override WebRequest GetWebRequest(Uri address)
        {
            WebRequest req = base.GetWebRequest(address);
            if (HeadOnly && req.Method == "GET")
            {
                req.Method = "HEAD";
            }
            return req;
        }
    }

    public class Crawler
    {
        Form1 myForm = new Form1();
        public WebClient webClient = new WebClient();
        // storing the urls in a hashtable, with the keys being the urls
        // the value is a true or false, true if it has been downloaded, false if it hasn't
        public Hashtable urls = new Hashtable();
        public int count = 0;
        public int maxcount = 10;
        public Crawler(int x)
        {
            maxcount = x;
        }
        public void Crawl()
        {
            //Console.WriteLine("Start crawling...");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue; // it wil be true if it has been downloaded, false if it hasn't been downloaded
                    current = url; // update the url
                }
                if (current == null || count > maxcount) break; // no more urls/count more than 10?
                Console.WriteLine("Crawl " + current + " page!");
                string html = Download(current);  // download content;
                urls[current] = true; // downloaded content
                count++;
                Parse(html); //parse, add new link
            }
            Console.WriteLine("Finished crawling");
            MessageBox.Show("爬行结束!");
        }

        public string Download(string url)
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url); // make a request with the url found in the webcrawler
                req.Timeout = 30000;
                HttpWebResponse response = (HttpWebResponse)req.GetResponse();
                byte[] buffer = ReadInstreamIntoMemory(response.GetResponseStream());
                string fileName = count.ToString(); // the name of the file to save the content in 
                FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate); // if the file exists, open it, else create
                fs.Write(buffer, 0, buffer.Length); // write content to file
                fs.Close();
                string html = Encoding.UTF8.GetString(buffer);
                return html;
            }
            catch { }
            return "";
        }

        public void Parse(string html)
        {
            string strRef = @"(href|HREF|src|SRC)[ ]*=[ ]*[""'][^""'#>]+[""']"; // get the links on the page
            MatchCollection matches = new Regex(strRef).Matches(html); // find the matches
            foreach (Match match in matches) // run through each string that matches the strRef (are links)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\'', '#', ' ', '>'); // get rid of symbols to retrieve just the link
                if (strRef.Length == 0) continue; // if there is no link

                if (urls[strRef] == null) urls[strRef] = false; // if does not already exist in hash table, make an entry
                                                                // false is for not downloaded
            }
        }

        // to read the data to be downloaded and write into the buffer
        private static byte[] ReadInstreamIntoMemory(Stream stream)
        {
            int bufferSize = 16384;
            byte[] buffer = new byte[bufferSize];
            MemoryStream ms = new MemoryStream();
            while (true)
            {
                int numBytesRead = stream.Read(buffer, 0, bufferSize);
                if (numBytesRead <= 0) break;
                ms.Write(buffer, 0, numBytesRead);
            }
            return ms.ToArray();
        }

    }


    
}
