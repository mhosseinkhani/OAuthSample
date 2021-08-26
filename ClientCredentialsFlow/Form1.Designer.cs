
namespace ClientCredentialsFlow
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetHomework = new System.Windows.Forms.Button();
            this.dataGridListHomework = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListHomework)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetHomework
            // 
            this.btnGetHomework.Location = new System.Drawing.Point(631, 12);
            this.btnGetHomework.Name = "btnGetHomework";
            this.btnGetHomework.Size = new System.Drawing.Size(157, 39);
            this.btnGetHomework.TabIndex = 0;
            this.btnGetHomework.Text = "Get Homework";
            this.btnGetHomework.UseVisualStyleBackColor = false;
            this.btnGetHomework.Click += new System.EventHandler(this.btnGetHomework_Click);
            // 
            // dataGridListHomework
            // 
            this.dataGridListHomework.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListHomework.Location = new System.Drawing.Point(12, 66);
            this.dataGridListHomework.Name = "dataGridListHomework";
            this.dataGridListHomework.RowTemplate.Height = 25;
            this.dataGridListHomework.Size = new System.Drawing.Size(776, 269);
            this.dataGridListHomework.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridListHomework);
            this.Controls.Add(this.btnGetHomework);
            this.Name = "Form1";
            this.Text = "My Homework";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListHomework)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetHomework;
        private System.Windows.Forms.DataGridView dataGridListHomework;
    }
}

