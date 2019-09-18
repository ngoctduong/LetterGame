namespace InterfaceTestDictonary
{
    partial class TheHungman
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tuCanTim = new System.Windows.Forms.Label();
            this.rs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labTurn = new System.Windows.Forms.Label();
            this.labstatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Location = new System.Drawing.Point(694, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(239, 321);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 125;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Check";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Answer";
            // 
            // tuCanTim
            // 
            this.tuCanTim.AutoSize = true;
            this.tuCanTim.Location = new System.Drawing.Point(137, 71);
            this.tuCanTim.Name = "tuCanTim";
            this.tuCanTim.Size = new System.Drawing.Size(0, 16);
            this.tuCanTim.TabIndex = 4;
            this.tuCanTim.UseCompatibleTextRendering = true;
            // 
            // rs
            // 
            this.rs.Location = new System.Drawing.Point(57, 116);
            this.rs.Name = "rs";
            this.rs.Size = new System.Drawing.Size(44, 20);
            this.rs.TabIndex = 5;
            this.rs.TextChanged += new System.EventHandler(this.ketqua_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Turns";
            // 
            // labTurn
            // 
            this.labTurn.AutoSize = true;
            this.labTurn.Location = new System.Drawing.Point(518, 23);
            this.labTurn.Name = "labTurn";
            this.labTurn.Size = new System.Drawing.Size(30, 13);
            this.labTurn.TabIndex = 7;
            this.labTurn.Text = "0/11";
            // 
            // labstatus
            // 
            this.labstatus.AutoSize = true;
            this.labstatus.Location = new System.Drawing.Point(57, 153);
            this.labstatus.Name = "labstatus";
            this.labstatus.Size = new System.Drawing.Size(0, 13);
            this.labstatus.TabIndex = 8;
            // 
            // TheHungman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 345);
            this.Controls.Add(this.labstatus);
            this.Controls.Add(this.labTurn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rs);
            this.Controls.Add(this.tuCanTim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Name = "TheHungman";
            this.Text = "The hungman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tuCanTim;
        private System.Windows.Forms.TextBox rs;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labTurn;
        private System.Windows.Forms.Label labstatus;




    }
}

