namespace Controlls
{
    partial class ControllsForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.firstRichBox = new System.Windows.Forms.RichTextBox();
            this.BoldCheckBox = new System.Windows.Forms.CheckBox();
            this.ItelicCheckBox = new System.Windows.Forms.CheckBox();
            this.UnderlineCheckBox = new System.Windows.Forms.CheckBox();
            this.Size12radio = new System.Windows.Forms.RadioButton();
            this.Size14radio = new System.Windows.Forms.RadioButton();
            this.Size16radio = new System.Windows.Forms.RadioButton();
            this.CaptionListBox = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(20, 20);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(360, 60);
            this.Title.TabIndex = 0;
            this.Title.Text = "Заголовок";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите текст:";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputTextBox.Location = new System.Drawing.Point(30, 125);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(300, 60);
            this.inputTextBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(30, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Нажми меня!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // firstRichBox
            // 
            this.firstRichBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstRichBox.Location = new System.Drawing.Point(429, 20);
            this.firstRichBox.Name = "firstRichBox";
            this.firstRichBox.Size = new System.Drawing.Size(359, 405);
            this.firstRichBox.TabIndex = 4;
            this.firstRichBox.Text = "";
            // 
            // BoldCheckBox
            // 
            this.BoldCheckBox.AutoSize = true;
            this.BoldCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BoldCheckBox.Location = new System.Drawing.Point(30, 286);
            this.BoldCheckBox.Name = "BoldCheckBox";
            this.BoldCheckBox.Size = new System.Drawing.Size(146, 24);
            this.BoldCheckBox.TabIndex = 5;
            this.BoldCheckBox.Text = "Полужирный";
            this.BoldCheckBox.UseVisualStyleBackColor = true;
            this.BoldCheckBox.CheckedChanged += new System.EventHandler(this.ChangeFontStyle);
            // 
            // ItelicCheckBox
            // 
            this.ItelicCheckBox.AutoSize = true;
            this.ItelicCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItelicCheckBox.Location = new System.Drawing.Point(30, 313);
            this.ItelicCheckBox.Name = "ItelicCheckBox";
            this.ItelicCheckBox.Size = new System.Drawing.Size(89, 24);
            this.ItelicCheckBox.TabIndex = 6;
            this.ItelicCheckBox.Text = "Курсив";
            this.ItelicCheckBox.UseVisualStyleBackColor = true;
            this.ItelicCheckBox.CheckedChanged += new System.EventHandler(this.ChangeFontStyle);
            // 
            // UnderlineCheckBox
            // 
            this.UnderlineCheckBox.AutoSize = true;
            this.UnderlineCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnderlineCheckBox.Location = new System.Drawing.Point(30, 340);
            this.UnderlineCheckBox.Name = "UnderlineCheckBox";
            this.UnderlineCheckBox.Size = new System.Drawing.Size(165, 24);
            this.UnderlineCheckBox.TabIndex = 7;
            this.UnderlineCheckBox.Text = "Подчёркивание";
            this.UnderlineCheckBox.UseVisualStyleBackColor = true;
            this.UnderlineCheckBox.CheckedChanged += new System.EventHandler(this.ChangeFontStyle);
            // 
            // Size12radio
            // 
            this.Size12radio.AutoSize = true;
            this.Size12radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Size12radio.Location = new System.Drawing.Point(242, 288);
            this.Size12radio.Name = "Size12radio";
            this.Size12radio.Size = new System.Drawing.Size(73, 24);
            this.Size12radio.TabIndex = 8;
            this.Size12radio.Text = "12 пт";
            this.Size12radio.UseVisualStyleBackColor = true;
            this.Size12radio.CheckedChanged += new System.EventHandler(this.ChangeFontSize);
            // 
            // Size14radio
            // 
            this.Size14radio.AutoSize = true;
            this.Size14radio.Checked = true;
            this.Size14radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Size14radio.Location = new System.Drawing.Point(242, 317);
            this.Size14radio.Name = "Size14radio";
            this.Size14radio.Size = new System.Drawing.Size(73, 24);
            this.Size14radio.TabIndex = 9;
            this.Size14radio.TabStop = true;
            this.Size14radio.Text = "14 пт";
            this.Size14radio.UseVisualStyleBackColor = true;
            this.Size14radio.CheckedChanged += new System.EventHandler(this.ChangeFontSize);
            // 
            // Size16radio
            // 
            this.Size16radio.AutoSize = true;
            this.Size16radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Size16radio.Location = new System.Drawing.Point(242, 344);
            this.Size16radio.Name = "Size16radio";
            this.Size16radio.Size = new System.Drawing.Size(73, 24);
            this.Size16radio.TabIndex = 10;
            this.Size16radio.Text = "16 пт";
            this.Size16radio.UseVisualStyleBackColor = true;
            this.Size16radio.CheckedChanged += new System.EventHandler(this.ChangeFontSize);
            // 
            // CaptionListBox
            // 
            this.CaptionListBox.FormattingEnabled = true;
            this.CaptionListBox.ItemHeight = 16;
            this.CaptionListBox.Location = new System.Drawing.Point(25, 396);
            this.CaptionListBox.Name = "CaptionListBox";
            this.CaptionListBox.Size = new System.Drawing.Size(305, 132);
            this.CaptionListBox.TabIndex = 11;
            this.CaptionListBox.SelectedIndexChanged += new System.EventHandler(this.CaptionListBox_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(269, 212);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 28);
            this.comboBox1.TabIndex = 12;
            // 
            // ControllsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CaptionListBox);
            this.Controls.Add(this.Size16radio);
            this.Controls.Add(this.Size14radio);
            this.Controls.Add(this.Size12radio);
            this.Controls.Add(this.UnderlineCheckBox);
            this.Controls.Add(this.ItelicCheckBox);
            this.Controls.Add(this.BoldCheckBox);
            this.Controls.Add(this.firstRichBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Name = "ControllsForm";
            this.Text = "Элементы управления";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox firstRichBox;
        private System.Windows.Forms.CheckBox BoldCheckBox;
        private System.Windows.Forms.CheckBox ItelicCheckBox;
        private System.Windows.Forms.CheckBox UnderlineCheckBox;
        private System.Windows.Forms.RadioButton Size12radio;
        private System.Windows.Forms.RadioButton Size14radio;
        private System.Windows.Forms.RadioButton Size16radio;
        private System.Windows.Forms.ListBox CaptionListBox;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

