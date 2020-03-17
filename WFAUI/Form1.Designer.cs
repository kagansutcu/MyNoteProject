namespace WFAUI
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.rb_error = new System.Windows.Forms.RadioButton();
            this.rb_note = new System.Windows.Forms.RadioButton();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.lbl_subject = new System.Windows.Forms.Label();
            this.lbl_whyfor = new System.Windows.Forms.Label();
            this.lbl_howfix = new System.Windows.Forms.Label();
            this.txt_whyfor = new System.Windows.Forms.TextBox();
            this.txt_howfix = new System.Windows.Forms.TextBox();
            this.rb_low = new System.Windows.Forms.RadioButton();
            this.rb_medium = new System.Windows.Forms.RadioButton();
            this.rb_high = new System.Windows.Forms.RadioButton();
            this.gb_rb = new System.Windows.Forms.GroupBox();
            this.dgw = new System.Windows.Forms.DataGridView();
            this.gb_rb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(1025, 12);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(339, 43);
            this.txt_search.TabIndex = 1;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_search.Location = new System.Drawing.Point(1125, 61);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(156, 43);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(1009, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 518);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_save.Location = new System.Drawing.Point(1125, 484);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(156, 43);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // rb_error
            // 
            this.rb_error.AutoSize = true;
            this.rb_error.Location = new System.Drawing.Point(1122, 125);
            this.rb_error.Name = "rb_error";
            this.rb_error.Size = new System.Drawing.Size(61, 21);
            this.rb_error.TabIndex = 5;
            this.rb_error.TabStop = true;
            this.rb_error.Text = "Error";
            this.rb_error.UseVisualStyleBackColor = true;
            this.rb_error.CheckedChanged += new System.EventHandler(this.rb_error_CheckedChanged);
            // 
            // rb_note
            // 
            this.rb_note.AutoSize = true;
            this.rb_note.Location = new System.Drawing.Point(1222, 125);
            this.rb_note.Name = "rb_note";
            this.rb_note.Size = new System.Drawing.Size(59, 21);
            this.rb_note.TabIndex = 5;
            this.rb_note.TabStop = true;
            this.rb_note.Text = "Note";
            this.rb_note.UseVisualStyleBackColor = true;
            this.rb_note.CheckedChanged += new System.EventHandler(this.rb_note_CheckedChanged);
            // 
            // txt_subject
            // 
            this.txt_subject.Location = new System.Drawing.Point(1025, 234);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(338, 22);
            this.txt_subject.TabIndex = 6;
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_subject.Location = new System.Drawing.Point(1147, 211);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(72, 20);
            this.lbl_subject.TabIndex = 7;
            this.lbl_subject.Text = "Subject";
            // 
            // lbl_whyfor
            // 
            this.lbl_whyfor.AutoSize = true;
            this.lbl_whyfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_whyfor.Location = new System.Drawing.Point(1148, 276);
            this.lbl_whyfor.Name = "lbl_whyfor";
            this.lbl_whyfor.Size = new System.Drawing.Size(73, 20);
            this.lbl_whyfor.TabIndex = 7;
            this.lbl_whyfor.Text = "WhyFor";
            // 
            // lbl_howfix
            // 
            this.lbl_howfix.AutoSize = true;
            this.lbl_howfix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_howfix.Location = new System.Drawing.Point(1148, 378);
            this.lbl_howfix.Name = "lbl_howfix";
            this.lbl_howfix.Size = new System.Drawing.Size(71, 20);
            this.lbl_howfix.TabIndex = 7;
            this.lbl_howfix.Text = "HowFix";
            // 
            // txt_whyfor
            // 
            this.txt_whyfor.Location = new System.Drawing.Point(1025, 299);
            this.txt_whyfor.Multiline = true;
            this.txt_whyfor.Name = "txt_whyfor";
            this.txt_whyfor.Size = new System.Drawing.Size(338, 57);
            this.txt_whyfor.TabIndex = 6;
            // 
            // txt_howfix
            // 
            this.txt_howfix.Location = new System.Drawing.Point(1025, 400);
            this.txt_howfix.Multiline = true;
            this.txt_howfix.Name = "txt_howfix";
            this.txt_howfix.Size = new System.Drawing.Size(338, 67);
            this.txt_howfix.TabIndex = 6;
            // 
            // rb_low
            // 
            this.rb_low.AutoSize = true;
            this.rb_low.Location = new System.Drawing.Point(18, 21);
            this.rb_low.Name = "rb_low";
            this.rb_low.Size = new System.Drawing.Size(54, 21);
            this.rb_low.TabIndex = 8;
            this.rb_low.TabStop = true;
            this.rb_low.Text = "Low";
            this.rb_low.UseVisualStyleBackColor = true;
            // 
            // rb_medium
            // 
            this.rb_medium.AutoSize = true;
            this.rb_medium.Location = new System.Drawing.Point(78, 21);
            this.rb_medium.Name = "rb_medium";
            this.rb_medium.Size = new System.Drawing.Size(78, 21);
            this.rb_medium.TabIndex = 8;
            this.rb_medium.TabStop = true;
            this.rb_medium.Text = "Medium";
            this.rb_medium.UseVisualStyleBackColor = true;
            // 
            // rb_high
            // 
            this.rb_high.AutoSize = true;
            this.rb_high.Location = new System.Drawing.Point(162, 21);
            this.rb_high.Name = "rb_high";
            this.rb_high.Size = new System.Drawing.Size(58, 21);
            this.rb_high.TabIndex = 8;
            this.rb_high.TabStop = true;
            this.rb_high.Text = "High";
            this.rb_high.UseVisualStyleBackColor = true;
            // 
            // gb_rb
            // 
            this.gb_rb.Controls.Add(this.rb_low);
            this.gb_rb.Controls.Add(this.rb_high);
            this.gb_rb.Controls.Add(this.rb_medium);
            this.gb_rb.Location = new System.Drawing.Point(1073, 395);
            this.gb_rb.Name = "gb_rb";
            this.gb_rb.Size = new System.Drawing.Size(247, 72);
            this.gb_rb.TabIndex = 9;
            this.gb_rb.TabStop = false;
            // 
            // dgw
            // 
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Location = new System.Drawing.Point(13, 12);
            this.dgw.Name = "dgw";
            this.dgw.RowHeadersWidth = 51;
            this.dgw.RowTemplate.Height = 24;
            this.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw.Size = new System.Drawing.Size(990, 455);
            this.dgw.TabIndex = 10;
            this.dgw.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_CellClick);
            this.dgw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_CellContentClick);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 539);
            this.Controls.Add(this.dgw);
            this.Controls.Add(this.gb_rb);
            this.Controls.Add(this.lbl_howfix);
            this.Controls.Add(this.lbl_whyfor);
            this.Controls.Add(this.lbl_subject);
            this.Controls.Add(this.txt_howfix);
            this.Controls.Add(this.txt_whyfor);
            this.Controls.Add(this.txt_subject);
            this.Controls.Add(this.rb_note);
            this.Controls.Add(this.rb_error);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.form1_Load);
            this.Click += new System.EventHandler(this.form1_Click);
            this.gb_rb.ResumeLayout(false);
            this.gb_rb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.RadioButton rb_error;
        private System.Windows.Forms.RadioButton rb_note;
        private System.Windows.Forms.TextBox txt_subject;
        private System.Windows.Forms.Label lbl_subject;
        private System.Windows.Forms.Label lbl_whyfor;
        private System.Windows.Forms.Label lbl_howfix;
        private System.Windows.Forms.TextBox txt_whyfor;
        private System.Windows.Forms.TextBox txt_howfix;
        private System.Windows.Forms.RadioButton rb_low;
        private System.Windows.Forms.RadioButton rb_medium;
        private System.Windows.Forms.RadioButton rb_high;
        private System.Windows.Forms.GroupBox gb_rb;
        private System.Windows.Forms.DataGridView dgw;
    }
}

