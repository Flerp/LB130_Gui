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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_all_on = new System.Windows.Forms.Button();
            this.btn_all_off = new System.Windows.Forms.Button();
            this.grid_bulb = new System.Windows.Forms.DataGridView();
            this.clm_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_bulb)).BeginInit();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
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
            // grid_bulb
            // 
            this.grid_bulb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_bulb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_name,
            this.clm_IP});
            this.grid_bulb.Location = new System.Drawing.Point(12, 12);
            this.grid_bulb.Name = "grid_bulb";
            this.grid_bulb.RowTemplate.Height = 28;
            this.grid_bulb.Size = new System.Drawing.Size(529, 297);
            this.grid_bulb.TabIndex = 9;
            // 
            // clm_name
            // 
            this.clm_name.HeaderText = "Name";
            this.clm_name.Name = "clm_name";
            this.clm_name.Width = 240;
            // 
            // clm_IP
            // 
            this.clm_IP.HeaderText = "IP Address";
            this.clm_IP.Name = "clm_IP";
            this.clm_IP.Width = 240;
            // 
            // LB130_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 557);
            this.Controls.Add(this.grid_bulb);
            this.Controls.Add(this.btn_all_off);
            this.Controls.Add(this.btn_all_on);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_off);
            this.Controls.Add(this.btn_on);
            this.Name = "LB130_Form";
            this.Text = "LB130_Gui";
            ((System.ComponentModel.ISupportInitialize)(this.grid_bulb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_on;
        private System.Windows.Forms.Button btn_off;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_all_on;
        private System.Windows.Forms.Button btn_all_off;
        private System.Windows.Forms.DataGridView grid_bulb;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_IP;
    }
}

