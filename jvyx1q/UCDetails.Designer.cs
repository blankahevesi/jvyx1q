namespace jvyx1q
{
    partial class UCDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxLanguage = new TextBox();
            listBoxLanguage = new ListBox();
            listBoxFilms = new ListBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxLanguage
            // 
            textBoxLanguage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxLanguage.Location = new Point(18, 31);
            textBoxLanguage.Name = "textBoxLanguage";
            textBoxLanguage.Size = new Size(169, 27);
            textBoxLanguage.TabIndex = 0;
            textBoxLanguage.TextChanged += textBoxLanguage_TextChanged;
            // 
            // listBoxLanguage
            // 
            listBoxLanguage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBoxLanguage.FormattingEnabled = true;
            listBoxLanguage.ItemHeight = 20;
            listBoxLanguage.Location = new Point(23, 79);
            listBoxLanguage.Name = "listBoxLanguage";
            listBoxLanguage.Size = new Size(164, 324);
            listBoxLanguage.TabIndex = 1;
            listBoxLanguage.SelectedIndexChanged += listBoxLanguage_SelectedIndexChanged;
            // 
            // listBoxFilms
            // 
            listBoxFilms.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBoxFilms.FormattingEnabled = true;
            listBoxFilms.ItemHeight = 20;
            listBoxFilms.Location = new Point(217, 79);
            listBoxFilms.Name = "listBoxFilms";
            listBoxFilms.Size = new Size(164, 324);
            listBoxFilms.TabIndex = 2;
            listBoxFilms.SelectedIndexChanged += listBoxFilms_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(408, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(424, 324);
            dataGridView1.TabIndex = 3;
            // 
            // UCDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(listBoxFilms);
            Controls.Add(listBoxLanguage);
            Controls.Add(textBoxLanguage);
            Name = "UCDetails";
            Size = new Size(873, 453);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLanguage;
        private ListBox listBoxLanguage;
        private ListBox listBoxFilms;
        private DataGridView dataGridView1;
    }
}
