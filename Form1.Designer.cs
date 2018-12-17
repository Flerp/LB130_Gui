namespace LB130_Gui
{
    partial class LB130_Form
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
            this.btn_on = new System.Windows.Forms.Button();
            this.btn_off = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_IP = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_all_on = new System.Windows.Forms.Button();
            this.btn_all_off = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_on
            // 
            this.btn_on.Location = new System.Drawing.Point(12, 380);
            this.btn_on.Name = "btn_on";
            this.btn_on.Size = new System.Drawing.Size(195, 165);
            this.btn_on.TabIndex = 0;
            this.btn_on.Text = "On";
            this.btn_on.UseVisualStyleBackColor = true;
            this.btn_on.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_off
            // 
            this.btn_off.Location = new System.Drawing.Point(346, 380);
            this.btn_off.Name = "btn_off";
            this.btn_off.Size = new System.Drawing.Size(195, 165);
            this.btn_off.TabIndex = 1;
            this.btn_off.Text = "Off";
            this.btn_off.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(215, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 26);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(57, 51);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(110, 20);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "Friendly Name";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_IP
            // 
            this.lbl_IP.AutoSize = true;
            this.lbl_IP.Location = new System.Drawing.Point(259, 51);
            this.lbl_IP.Name = "lbl_IP";
            this.lbl_IP.Size = new System.Drawing.Size(87, 20);
            this.lbl_IP.TabIndex = 5;
            this.lbl_IP.Text = "IP Address";
            this.lbl_IP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_all_on
            // 
            this.btn_all_on.Location = new System.Drawing.Point(213, 380);
            this.btn_all_on.Name = "btn_all_on";
            this.btn_all_on.Size = new System.Drawing.Size(125, 80);
            this.btn_all_on.TabIndex = 7;
            this.btn_all_on.Text = "All On";
            this.btn_all_on.UseVisualStyleBackColor = true;
            // 
            // btn_all_off
            // 
            this.btn_all_off.Location = new System.Drawing.Point(213, 466);
            this.btn_all_off.Name = "btn_all_off";
            this.btn_all_off.Size = new System.Drawing.Size(125, 80);
            this.btn_all_off.TabIndex = 8;
            this.btn_all_off.Text = "All Off";
            this.btn_all_off.UseVisualStyleBackColor = true;
            // 
            // LB130_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 557);
            this.Controls.Add(this.btn_all_off);
            this.Controls.Add(this.btn_all_on);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_IP);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_off);
            this.Controls.Add(this.btn_on);
            this.Name = "LB130_Form";
            this.Text = "LB130_Gui";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_on;
        private System.Windows.Forms.Button btn_off;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_IP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_all_on;
        private System.Windows.Forms.Button btn_all_off;
    }
}

