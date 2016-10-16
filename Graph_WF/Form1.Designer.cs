namespace Graph_WF
{
    partial class Form1
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
            this.visualization = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vertexes = new System.Windows.Forms.TextBox();
            this.dane = new System.Windows.Forms.Label();
            this.drw = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.visualization)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // visualization
            // 
            this.visualization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.visualization.Location = new System.Drawing.Point(0, 81);
            this.visualization.Name = "visualization";
            this.visualization.Size = new System.Drawing.Size(400, 581);
            this.visualization.TabIndex = 0;
            this.visualization.TabStop = false;
            this.visualization.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(984, 662);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.drw);
            this.panel1.Controls.Add(this.vertexes);
            this.panel1.Controls.Add(this.dane);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 72);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.visualization_Paint);
            // 
            // vertexes
            // 
            this.vertexes.Location = new System.Drawing.Point(110, 27);
            this.vertexes.Name = "vertexes";
            this.vertexes.Size = new System.Drawing.Size(287, 20);
            this.vertexes.TabIndex = 2;
            this.vertexes.TextChanged += new System.EventHandler(this.vertexes_TextChanged);
            // 
            // dane
            // 
            this.dane.AutoSize = true;
            this.dane.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.dane.Location = new System.Drawing.Point(33, 27);
            this.dane.Name = "dane";
            this.dane.Size = new System.Drawing.Size(58, 22);
            this.dane.TabIndex = 1;
            this.dane.Text = "Dane:";
            // 
            // drw
            // 
            this.drw.Location = new System.Drawing.Point(440, 27);
            this.drw.Name = "drw";
            this.drw.Size = new System.Drawing.Size(75, 23);
            this.drw.TabIndex = 3;
            this.drw.Text = "Rysuj";
            this.drw.UseVisualStyleBackColor = true;
            this.drw.Click += new System.EventHandler(this.drw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.visualization);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visualization)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox visualization;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dane;
        private System.Windows.Forms.TextBox vertexes;
        private System.Windows.Forms.Button drw;
    }
}

