namespace WinFormsApp1
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
            label1 = new Label();
            fntxtbox = new TextBox();
            gntxtbox = new TextBox();
            label2 = new Label();
            lntxtbox = new TextBox();
            label3 = new Label();
            ctytxtbox = new TextBox();
            label4 = new Label();
            isatxtbox = new TextBox();
            label5 = new Label();
            addbtn = new Button();
            updatebtn = new Button();
            delbtn = new Button();
            selbtn = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            eidtxtbox = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 51);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 0;
            label1.Text = "FirstName";
            // 
            // fntxtbox
            // 
            fntxtbox.Location = new Point(130, 48);
            fntxtbox.Name = "fntxtbox";
            fntxtbox.Size = new Size(150, 31);
            fntxtbox.TabIndex = 1;
            // 
            // gntxtbox
            // 
            gntxtbox.Location = new Point(371, 54);
            gntxtbox.Name = "gntxtbox";
            gntxtbox.Size = new Size(150, 31);
            gntxtbox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 54);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 2;
            label2.Text = "Gender";
            // 
            // lntxtbox
            // 
            lntxtbox.Location = new Point(130, 92);
            lntxtbox.Name = "lntxtbox";
            lntxtbox.Size = new Size(150, 31);
            lntxtbox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 95);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 4;
            label3.Text = "LastName";
            // 
            // ctytxtbox
            // 
            ctytxtbox.Location = new Point(371, 95);
            ctytxtbox.Name = "ctytxtbox";
            ctytxtbox.Size = new Size(150, 31);
            ctytxtbox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(296, 98);
            label4.Name = "label4";
            label4.Size = new Size(42, 25);
            label4.TabIndex = 6;
            label4.Text = "City";
            // 
            // isatxtbox
            // 
            isatxtbox.Location = new Point(130, 130);
            isatxtbox.Name = "isatxtbox";
            isatxtbox.Size = new Size(150, 31);
            isatxtbox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 130);
            label5.Name = "label5";
            label5.Size = new Size(73, 25);
            label5.TabIndex = 8;
            label5.Text = "IsActive";
            // 
            // addbtn
            // 
            addbtn.Location = new Point(567, 48);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(112, 34);
            addbtn.TabIndex = 10;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += addbtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.Location = new Point(567, 89);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(112, 34);
            updatebtn.TabIndex = 11;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = true;
            updatebtn.Click += updatebtn_Click;
            // 
            // delbtn
            // 
            delbtn.Location = new Point(685, 49);
            delbtn.Name = "delbtn";
            delbtn.Size = new Size(112, 34);
            delbtn.TabIndex = 12;
            delbtn.Text = "Delete";
            delbtn.UseVisualStyleBackColor = true;
            delbtn.Click += delbtn_Click;
            // 
            // selbtn
            // 
            selbtn.Location = new Point(685, 92);
            selbtn.Name = "selbtn";
            selbtn.Size = new Size(112, 34);
            selbtn.TabIndex = 13;
            selbtn.Text = "Select";
            selbtn.UseVisualStyleBackColor = true;
            selbtn.Click += selbtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(53, 213);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(709, 225);
            dataGridView1.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(375, 136);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 16;
            // 
            // eidtxtbox
            // 
            eidtxtbox.AutoSize = true;
            eidtxtbox.Location = new Point(296, 136);
            eidtxtbox.Name = "eidtxtbox";
            eidtxtbox.Size = new Size(66, 25);
            eidtxtbox.TabIndex = 15;
            eidtxtbox.Text = "EmpID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(eidtxtbox);
            Controls.Add(dataGridView1);
            Controls.Add(selbtn);
            Controls.Add(delbtn);
            Controls.Add(updatebtn);
            Controls.Add(addbtn);
            Controls.Add(isatxtbox);
            Controls.Add(label5);
            Controls.Add(ctytxtbox);
            Controls.Add(label4);
            Controls.Add(lntxtbox);
            Controls.Add(label3);
            Controls.Add(gntxtbox);
            Controls.Add(label2);
            Controls.Add(fntxtbox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox fntxtbox;
        private TextBox gntxtbox;
        private Label label2;
        private TextBox lntxtbox;
        private Label label3;
        private TextBox ctytxtbox;
        private Label label4;
        private TextBox isatxtbox;
        private Label label5;
        private Button addbtn;
        private Button updatebtn;
        private Button delbtn;
        private Button selbtn;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label eidtxtbox;
    }
}
