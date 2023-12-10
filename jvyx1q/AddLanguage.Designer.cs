namespace jvyx1q
{
    partial class AddLanguage
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            languageBindingSource = new BindingSource(components);
            languageIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            language1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mlanguagesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)languageBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { languageIdDataGridViewTextBoxColumn, language1DataGridViewTextBoxColumn, mlanguagesDataGridViewTextBoxColumn });
            dataGridView1.DataSource = languageBindingSource;
            dataGridView1.Location = new Point(20, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(280, 378);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(346, 175);
            button1.Name = "button1";
            button1.Size = new Size(94, 89);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // languageBindingSource
            // 
            languageBindingSource.DataSource = typeof(Models.Language);
            // 
            // languageIdDataGridViewTextBoxColumn
            // 
            languageIdDataGridViewTextBoxColumn.DataPropertyName = "LanguageId";
            languageIdDataGridViewTextBoxColumn.HeaderText = "LanguageId";
            languageIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            languageIdDataGridViewTextBoxColumn.Name = "languageIdDataGridViewTextBoxColumn";
            languageIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // language1DataGridViewTextBoxColumn
            // 
            language1DataGridViewTextBoxColumn.DataPropertyName = "Language1";
            language1DataGridViewTextBoxColumn.HeaderText = "Language1";
            language1DataGridViewTextBoxColumn.MinimumWidth = 6;
            language1DataGridViewTextBoxColumn.Name = "language1DataGridViewTextBoxColumn";
            language1DataGridViewTextBoxColumn.Width = 125;
            // 
            // mlanguagesDataGridViewTextBoxColumn
            // 
            mlanguagesDataGridViewTextBoxColumn.DataPropertyName = "Mlanguages";
            mlanguagesDataGridViewTextBoxColumn.HeaderText = "Mlanguages";
            mlanguagesDataGridViewTextBoxColumn.MinimumWidth = 6;
            mlanguagesDataGridViewTextBoxColumn.Name = "mlanguagesDataGridViewTextBoxColumn";
            mlanguagesDataGridViewTextBoxColumn.Width = 125;
            // 
            // AddLanguage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "AddLanguage";
            Text = "AddLanguage";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)languageBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn languageIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn language1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mlanguagesDataGridViewTextBoxColumn;
        private BindingSource languageBindingSource;
    }
}