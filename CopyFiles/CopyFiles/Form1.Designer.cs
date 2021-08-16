
namespace CopyFiles
{
    partial class Form1
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
            this.lbCopyFrom = new System.Windows.Forms.ListBox();
            this.lbCopyTo = new System.Windows.Forms.ListBox();
            this.btCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCopyFrom
            // 
            this.lbCopyFrom.FormattingEnabled = true;
            this.lbCopyFrom.Location = new System.Drawing.Point(45, 50);
            this.lbCopyFrom.Name = "lbCopyFrom";
            this.lbCopyFrom.Size = new System.Drawing.Size(300, 329);
            this.lbCopyFrom.TabIndex = 0;
            // 
            // lbCopyTo
            // 
            this.lbCopyTo.FormattingEnabled = true;
            this.lbCopyTo.Location = new System.Drawing.Point(374, 50);
            this.lbCopyTo.Name = "lbCopyTo";
            this.lbCopyTo.Size = new System.Drawing.Size(300, 329);
            this.lbCopyTo.TabIndex = 1;
            this.lbCopyTo.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // btCopy
            // 
            this.btCopy.Location = new System.Drawing.Point(432, 412);
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(121, 28);
            this.btCopy.TabIndex = 2;
            this.btCopy.Text = "Копировать";
            this.btCopy.UseVisualStyleBackColor = true;
            this.btCopy.Click += new System.EventHandler(this.btCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 482);
            this.Controls.Add(this.btCopy);
            this.Controls.Add(this.lbCopyTo);
            this.Controls.Add(this.lbCopyFrom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbCopyFrom;
        private System.Windows.Forms.ListBox lbCopyTo;
        private System.Windows.Forms.Button btCopy;
    }
}

