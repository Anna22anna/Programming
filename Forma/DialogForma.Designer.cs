namespace Forma
{
    partial class DialogForma
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
            this.Question = new System.Windows.Forms.Label();
            this.OkeyButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Question.Location = new System.Drawing.Point(283, 53);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(189, 25);
            this.Question.TabIndex = 0;
            this.Question.Text = "Вы любите кошек?";
            // 
            // OkeyButton
            // 
            this.OkeyButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.OkeyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkeyButton.Location = new System.Drawing.Point(145, 111);
            this.OkeyButton.Name = "OkeyButton";
            this.OkeyButton.Size = new System.Drawing.Size(101, 57);
            this.OkeyButton.TabIndex = 1;
            this.OkeyButton.Text = "Да";
            this.OkeyButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(473, 111);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(101, 57);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Нет";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // DialogForma
            // 
            this.AcceptButton = this.OkeyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkeyButton);
            this.Controls.Add(this.Question);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogForma";
            this.Text = "Вопрос";
            this.Load += new System.EventHandler(this.DialogForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Button OkeyButton;
        private System.Windows.Forms.Button CancelButton;
    }
}