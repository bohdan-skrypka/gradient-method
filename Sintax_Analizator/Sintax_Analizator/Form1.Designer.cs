namespace Sintax_Analizator
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
            this.txb_function = new System.Windows.Forms.TextBox();
            this.rtxb_grad = new System.Windows.Forms.RichTextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_calc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_start_point = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_repeat = new System.Windows.Forms.Button();
            this.rtxb_res = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txb_function
            // 
            this.txb_function.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_function.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_function.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txb_function.Location = new System.Drawing.Point(119, 58);
            this.txb_function.Name = "txb_function";
            this.txb_function.Size = new System.Drawing.Size(387, 29);
            this.txb_function.TabIndex = 1;
            this.txb_function.Text = "2*Math.Pow(x,2)-x*y-3*Math.Pow(z,3)";
            // 
            // rtxb_grad
            // 
            this.rtxb_grad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtxb_grad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtxb_grad.Location = new System.Drawing.Point(91, 168);
            this.rtxb_grad.Name = "rtxb_grad";
            this.rtxb_grad.Size = new System.Drawing.Size(234, 168);
            this.rtxb_grad.TabIndex = 2;
            this.rtxb_grad.Text = "4*x-1*y+0*z;\n-1*x+0*y+0*z;\n0*x+0*y+9*Math.Pow(z,2)";
            // 
            // btn_clear
            // 
            this.btn_clear.AllowDrop = true;
            this.btn_clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_clear.BackColor = System.Drawing.Color.Salmon;
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_clear.CausesValidation = false;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_clear.FlatAppearance.BorderSize = 10;
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_clear.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_clear.Location = new System.Drawing.Point(91, 357);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_clear.Size = new System.Drawing.Size(107, 54);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Visible = false;
            this.btn_clear.Click += new System.EventHandler(this.txb_clear_Click);
            // 
            // btn_calc
            // 
            this.btn_calc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_calc.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btn_calc.FlatAppearance.BorderSize = 3;
            this.btn_calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_calc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_calc.Location = new System.Drawing.Point(469, 357);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(174, 54);
            this.btn_calc.TabIndex = 4;
            this.btn_calc.Text = "Calculation";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gradient method";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(-9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "F(x,y,z)=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(-7, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "F\'(x) =";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(529, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "==> min";
            // 
            // txb_start_point
            // 
            this.txb_start_point.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_start_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txb_start_point.Location = new System.Drawing.Point(119, 114);
            this.txb_start_point.Name = "txb_start_point";
            this.txb_start_point.Size = new System.Drawing.Size(387, 29);
            this.txb_start_point.TabIndex = 10;
            this.txb_start_point.Text = "2, 5, 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(38, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 36);
            this.label5.TabIndex = 11;
            this.label5.Text = "A =";
            // 
            // btn_repeat
            // 
            this.btn_repeat.AllowDrop = true;
            this.btn_repeat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_repeat.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_repeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_repeat.CausesValidation = false;
            this.btn_repeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_repeat.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_repeat.FlatAppearance.BorderSize = 10;
            this.btn_repeat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_repeat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_repeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_repeat.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_repeat.Location = new System.Drawing.Point(246, 357);
            this.btn_repeat.Name = "btn_repeat";
            this.btn_repeat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_repeat.Size = new System.Drawing.Size(148, 54);
            this.btn_repeat.TabIndex = 12;
            this.btn_repeat.Text = "Repeat";
            this.btn_repeat.UseVisualStyleBackColor = false;
            this.btn_repeat.Visible = false;
            this.btn_repeat.Click += new System.EventHandler(this.btn_cont_Click);
            // 
            // rtxb_res
            // 
            this.rtxb_res.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtxb_res.Location = new System.Drawing.Point(404, 168);
            this.rtxb_res.Name = "rtxb_res";
            this.rtxb_res.Size = new System.Drawing.Size(239, 168);
            this.rtxb_res.TabIndex = 13;
            this.rtxb_res.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(333, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(655, 433);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtxb_res);
            this.Controls.Add(this.btn_repeat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_start_point);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.rtxb_grad);
            this.Controls.Add(this.txb_function);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_function;
        private System.Windows.Forms.RichTextBox rtxb_grad;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txb_start_point;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_repeat;
        private System.Windows.Forms.RichTextBox rtxb_res;
        private System.Windows.Forms.Label label6;
    }
}

