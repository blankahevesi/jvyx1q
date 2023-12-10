namespace jvyx1q
{
    partial class NewLanguage
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
            label1 = new Label();
            label2 = new Label();
            textBoxID = new TextBox();
            textBoxLanguage = new TextBox();
            button1 = new Button();
            button2 = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Language:";
            // 
            // textBoxID
            // 
            textBoxID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxID.Location = new Point(105, 36);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(303, 27);
            textBoxID.TabIndex = 2;
            textBoxID.Validating += textBoxID_Validating;
            textBoxID.Validated += textBoxID_Validated;
            // 
            // textBoxLanguage
            // 
            textBoxLanguage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxLanguage.Location = new Point(105, 86);
            textBoxLanguage.Name = "textBoxLanguage";
            textBoxLanguage.Size = new Size(303, 27);
            textBoxLanguage.TabIndex = 3;
            textBoxLanguage.Validating += textBoxLanguage_Validating;
            textBoxLanguage.Validated += textBoxLanguage_Validated;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(188, 173);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.CausesValidation = false;
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(314, 173);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // NewLanguage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 241);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxLanguage);
            Controls.Add(textBoxID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NewLanguage";
            Text = "NewLanguage";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        public TextBox textBoxID;
        public TextBox textBoxLanguage;
        private Button button1;
        private Button button2;
        private ErrorProvider errorProvider1;
    }
}