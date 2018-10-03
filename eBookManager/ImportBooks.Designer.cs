namespace eBookManager
{
    partial class ImportBooks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportBooks));
            this.tvImages = new System.Windows.Forms.ImageList(this.components);
            this.btnSelectSourceFolder = new System.Windows.Forms.Button();
            this.tvFoundBooks = new System.Windows.Forms.TreeView();
            this.dlVirtualStorageSpaces = new System.Windows.Forms.ComboBox();
            this.btnAddNewStorageSpace = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSaveNewStorageSpace = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tvImages
            // 
            this.tvImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tvImages.ImageStream")));
            this.tvImages.TransparentColor = System.Drawing.Color.Transparent;
            this.tvImages.Images.SetKeyName(0, "docx16.png");
            this.tvImages.Images.SetKeyName(1, "docxx16.png");
            this.tvImages.Images.SetKeyName(2, "epubx16.png");
            this.tvImages.Images.SetKeyName(3, "folder_exp_x16.png");
            this.tvImages.Images.SetKeyName(4, "folder-close-x16.png");
            this.tvImages.Images.SetKeyName(5, "pdfx16.png");
            // 
            // btnSelectSourceFolder
            // 
            this.btnSelectSourceFolder.AutoSize = true;
            this.btnSelectSourceFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectSourceFolder.Location = new System.Drawing.Point(29, 12);
            this.btnSelectSourceFolder.Name = "btnSelectSourceFolder";
            this.btnSelectSourceFolder.Size = new System.Drawing.Size(116, 23);
            this.btnSelectSourceFolder.TabIndex = 0;
            this.btnSelectSourceFolder.Text = "Select Source Folder";
            this.btnSelectSourceFolder.UseVisualStyleBackColor = true;
            // 
            // tvFoundBooks
            // 
            this.tvFoundBooks.Location = new System.Drawing.Point(29, 45);
            this.tvFoundBooks.Name = "tvFoundBooks";
            this.tvFoundBooks.Size = new System.Drawing.Size(361, 158);
            this.tvFoundBooks.TabIndex = 1;
            // 
            // dlVirtualStorageSpaces
            // 
            this.dlVirtualStorageSpaces.FormattingEnabled = true;
            this.dlVirtualStorageSpaces.Location = new System.Drawing.Point(29, 209);
            this.dlVirtualStorageSpaces.Name = "dlVirtualStorageSpaces";
            this.dlVirtualStorageSpaces.Size = new System.Drawing.Size(121, 21);
            this.dlVirtualStorageSpaces.TabIndex = 2;
            // 
            // btnAddNewStorageSpace
            // 
            this.btnAddNewStorageSpace.AutoSize = true;
            this.btnAddNewStorageSpace.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddNewStorageSpace.Location = new System.Drawing.Point(157, 209);
            this.btnAddNewStorageSpace.Name = "btnAddNewStorageSpace";
            this.btnAddNewStorageSpace.Size = new System.Drawing.Size(23, 23);
            this.btnAddNewStorageSpace.TabIndex = 3;
            this.btnAddNewStorageSpace.Text = "+";
            this.btnAddNewStorageSpace.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(185, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // btnSaveNewStorageSpace
            // 
            this.btnSaveNewStorageSpace.AutoSize = true;
            this.btnSaveNewStorageSpace.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveNewStorageSpace.Location = new System.Drawing.Point(292, 209);
            this.btnSaveNewStorageSpace.Name = "btnSaveNewStorageSpace";
            this.btnSaveNewStorageSpace.Size = new System.Drawing.Size(42, 23);
            this.btnSaveNewStorageSpace.TabIndex = 5;
            this.btnSaveNewStorageSpace.Text = "Save";
            this.btnSaveNewStorageSpace.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Location = new System.Drawing.Point(340, 209);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ImportBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveNewStorageSpace);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAddNewStorageSpace);
            this.Controls.Add(this.dlVirtualStorageSpaces);
            this.Controls.Add(this.tvFoundBooks);
            this.Controls.Add(this.btnSelectSourceFolder);
            this.Name = "ImportBooks";
            this.Text = "ImportBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList tvImages;
        private System.Windows.Forms.Button btnSelectSourceFolder;
        private System.Windows.Forms.TreeView tvFoundBooks;
        private System.Windows.Forms.ComboBox dlVirtualStorageSpaces;
        private System.Windows.Forms.Button btnAddNewStorageSpace;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSaveNewStorageSpace;
        private System.Windows.Forms.Button btnCancel;
    }
}