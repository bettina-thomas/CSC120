
namespace Week5
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
            this.startbt = new System.Windows.Forms.Button();
            this.truebt = new System.Windows.Forms.Button();
            this.falsebt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wha = new System.Windows.Forms.Button();
            this.logic = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startbt
            // 
            this.startbt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.startbt.Location = new System.Drawing.Point(320, 160);
            this.startbt.Name = "startbt";
            this.startbt.Size = new System.Drawing.Size(112, 34);
            this.startbt.TabIndex = 0;
            this.startbt.Text = "Start";
            this.startbt.UseVisualStyleBackColor = false;
            this.startbt.Click += new System.EventHandler(this.button1_Click);
            // 
            // truebt
            // 
            this.truebt.Location = new System.Drawing.Point(319, 213);
            this.truebt.Name = "truebt";
            this.truebt.Size = new System.Drawing.Size(55, 34);
            this.truebt.TabIndex = 1;
            this.truebt.Text = "true";
            this.truebt.UseVisualStyleBackColor = true;
            this.truebt.Click += new System.EventHandler(this.buttonclick_Click);
            // 
            // falsebt
            // 
            this.falsebt.Location = new System.Drawing.Point(420, 212);
            this.falsebt.Name = "falsebt";
            this.falsebt.Size = new System.Drawing.Size(67, 34);
            this.falsebt.TabIndex = 2;
            this.falsebt.Text = "false";
            this.falsebt.UseVisualStyleBackColor = true;
            this.falsebt.Click += new System.EventHandler(this.Btnclck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-652, -180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-662, -168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(368, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // wha
            // 
            this.wha.Location = new System.Drawing.Point(553, 160);
            this.wha.Name = "wha";
            this.wha.Size = new System.Drawing.Size(112, 34);
            this.wha.TabIndex = 6;
            this.wha.Text = "button1";
            this.wha.UseVisualStyleBackColor = true;
            this.wha.Click += new System.EventHandler(this.wha_Click);
            // 
            // logic
            // 
            this.logic.AutoSize = true;
            this.logic.Location = new System.Drawing.Point(293, 121);
            this.logic.Name = "logic";
            this.logic.Size = new System.Drawing.Size(206, 25);
            this.logic.TabIndex = 7;
            this.logic.Text = "Color + Number + Logic";
            this.logic.Click += new System.EventHandler(this.logic_Click);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.score.Location = new System.Drawing.Point(380, 300);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(56, 25);
            this.score.TabIndex = 8;
            this.score.Text = "Score";
            this.score.Click += new System.EventHandler(this.score_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.score);
            this.Controls.Add(this.logic);
            this.Controls.Add(this.wha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.falsebt);
            this.Controls.Add(this.truebt);
            this.Controls.Add(this.startbt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startbt;
        private System.Windows.Forms.Button truebt;
        private System.Windows.Forms.Button falsebt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button wha;
        private System.Windows.Forms.Label logic;
        private System.Windows.Forms.Label score;
    }
}

