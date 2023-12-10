namespace jvyx1q
{
    partial class LanguageModification
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
            textBoxFilm = new TextBox();
            textBoxLanguage = new TextBox();
            listBoxFilm = new ListBox();
            listBoxLanguage = new ListBox();
            buttonAdd = new Button();
            buttonRemove = new Button();
            ListBoxAddLanguage = new ListBox();
            SuspendLayout();
            // 
            // textBoxFilm
            // 
            textBoxFilm.Location = new Point(29, 26);
            textBoxFilm.Name = "textBoxFilm";
            textBoxFilm.Size = new Size(164, 27);
            textBoxFilm.TabIndex = 0;
            textBoxFilm.TextAlign = HorizontalAlignment.Right;
            textBoxFilm.TextChanged += textBoxFilm_TextChanged;
            // 
            // textBoxLanguage
            // 
            textBoxLanguage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxLanguage.Location = new Point(503, 35);
            textBoxLanguage.Name = "textBoxLanguage";
            textBoxLanguage.Size = new Size(164, 27);
            textBoxLanguage.TabIndex = 1;
            textBoxLanguage.TextChanged += textBoxLanguage_TextChanged;
            // 
            // listBoxFilm
            // 
            listBoxFilm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBoxFilm.FormattingEnabled = true;
            listBoxFilm.ItemHeight = 20;
            listBoxFilm.Location = new Point(30, 68);
            listBoxFilm.Name = "listBoxFilm";
            listBoxFilm.Size = new Size(163, 344);
            listBoxFilm.TabIndex = 2;
            listBoxFilm.SelectedIndexChanged += listBoxFilm_SelectedIndexChanged;
            // 
            // listBoxLanguage
            // 
            listBoxLanguage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            listBoxLanguage.FormattingEnabled = true;
            listBoxLanguage.ItemHeight = 20;
            listBoxLanguage.Location = new Point(504, 68);
            listBoxLanguage.Name = "listBoxLanguage";
            listBoxLanguage.Size = new Size(163, 344);
            listBoxLanguage.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonAdd.Location = new Point(391, 149);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 71);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonRemove.Location = new Point(391, 226);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(94, 71);
            buttonRemove.TabIndex = 7;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // ListBoxAddLanguage
            // 
            ListBoxAddLanguage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ListBoxAddLanguage.FormattingEnabled = true;
            ListBoxAddLanguage.ItemHeight = 20;
            ListBoxAddLanguage.Location = new Point(212, 68);
            ListBoxAddLanguage.Name = "ListBoxAddLanguage";
            ListBoxAddLanguage.Size = new Size(163, 344);
            ListBoxAddLanguage.TabIndex = 8;
            // 
            // LanguageModification
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 450);
            Controls.Add(ListBoxAddLanguage);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(listBoxLanguage);
            Controls.Add(listBoxFilm);
            Controls.Add(textBoxLanguage);
            Controls.Add(textBoxFilm);
            Name = "LanguageModification";
            Text = "LanguageModification";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFilm;
        private TextBox textBoxLanguage;
        private ListBox listBoxFilm;
        private ListBox listBoxLanguage;
        private Button buttonAdd;
        private Button buttonRemove;
        private ListBox ListBoxAddLanguage;
    }
}