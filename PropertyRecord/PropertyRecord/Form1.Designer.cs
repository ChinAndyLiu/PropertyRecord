namespace PropertyRecord
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.datelabel = new System.Windows.Forms.Label();
            this.propertylabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.submitButton = new System.Windows.Forms.Button();
            this.amounttextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelabel.Location = new System.Drawing.Point(105, 121);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(126, 46);
            this.datelabel.TabIndex = 0;
            this.datelabel.Text = "label1";
            // 
            // propertylabel
            // 
            this.propertylabel.AutoSize = true;
            this.propertylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertylabel.Location = new System.Drawing.Point(105, 234);
            this.propertylabel.Name = "propertylabel";
            this.propertylabel.Size = new System.Drawing.Size(126, 46);
            this.propertylabel.TabIndex = 1;
            this.propertylabel.Text = "label2";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(321, 141);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(268, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(222, 343);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(182, 71);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // amounttextBox
            // 
            this.amounttextBox.Location = new System.Drawing.Point(321, 253);
            this.amounttextBox.Name = "amounttextBox";
            this.amounttextBox.Size = new System.Drawing.Size(268, 26);
            this.amounttextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 463);
            this.Controls.Add(this.amounttextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.propertylabel);
            this.Controls.Add(this.datelabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Label propertylabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox amounttextBox;
    }
}

