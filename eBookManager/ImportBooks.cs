using eBookManager.Engine;
using eBookManager.Helper;
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

namespace eBookManager
{
    public partial class ImportBooks : Form
    {
        private string _jsonPath;
        private List<StorageSpace> spaces;
        private HashSet<string> AllowedExtensions => new HashSet<string>(StringComparer.InvariantCultureIgnoreCase)
        {
            ".doc",".docx",".pdf",".epub"
        };
        private enum StorageSpaceSelection { New = 9999, NoSelection = -1 }
        private enum Extension { doc = 0, docx = 1, pdf = 2, epub = 3 }

        public ImportBooks()
        {
            InitializeComponent();
            _jsonPath = Path.Combine(Application.StartupPath, "bookData.txt");
            spaces = spaces.ReadFromDataStore(_jsonPath);
        }

        public void PopulateBookList(string paramDir, TreeNode paramNode)
        {
            DirectoryInfo dir = new DirectoryInfo(paramDir);
            foreach (DirectoryInfo dirInfo in dir.GetDirectories())
            {
                TreeNode node = new TreeNode(dirInfo.Name);
                node.ImageIndex = 4;
                node.SelectedImageIndex = 5;

                if (paramNode != null)
                {
                    paramNode.Nodes.Add(node);
                }
                else
                {
                    tvFoundBooks.Nodes.Add(node);
                }
                PopulateBookList(dirInfo.FullName, node);
            }

            foreach (FileInfo fileInfo in dir.GetFiles().Where(x=>
            AllowedExtensions.Contains(x.Extension)).ToList())
            {
                TreeNode node = new TreeNode(fileInfo.Name);
                node.Tag = fileInfo.FullName;
                int iconIndex = Enum.Parse(typeof(Extension),
                    fileInfo.Extension.TrimStart('.'), true).GetHashCode();
                node.ImageIndex = iconIndex;
                node.SelectedImageIndex = iconIndex;
                if (paramNode != null)
                {
                    paramNode.Nodes.Add(node);
                }
                else
                {
                    tvFoundBooks.Nodes.Add(node);
                }
            }
        }

        private void btnSelectSourceFolder_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = "Select the location of your eBooks and documents";

                DialogResult dialogResult = fbd.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    tvFoundBooks.Nodes.Clear();
                    tvFoundBooks.ImageList = tvImages;

                    string path = fbd.SelectedPath;
                    DirectoryInfo di = new DirectoryInfo(path);
                    TreeNode root = new TreeNode(di.Name);
                    root.ImageIndex = 4;
                    root.SelectedImageIndex = 5;
                    tvFoundBooks.Nodes.Add(root);
                    PopulateBookList(di.FullName, root);
                    tvFoundBooks.Sort();

                    root.Expand();

                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
