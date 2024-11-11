namespace Store_Codes
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
            this.search_button = new System.Windows.Forms.Button();
            this.search_bar = new System.Windows.Forms.TextBox();
            this.code_view = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // search_button
            // 
            this.search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.Location = new System.Drawing.Point(1375, 55);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(141, 53);
            this.search_button.TabIndex = 0;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // search_bar
            // 
            this.search_bar.AcceptsReturn = true;
            this.search_bar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_bar.Location = new System.Drawing.Point(43, 55);
            this.search_bar.Name = "search_bar";
            this.search_bar.Size = new System.Drawing.Size(1326, 38);
            this.search_bar.TabIndex = 1;
            this.search_bar.TextChanged += new System.EventHandler(this.search_bar_TextChanged);
            // 
            // code_view
            // 
            this.code_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code_view.Location = new System.Drawing.Point(45, 112);
            this.code_view.Multiline = true;
            this.code_view.Name = "code_view";
            this.code_view.ReadOnly = true;
            this.code_view.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.code_view.Size = new System.Drawing.Size(1459, 801);
            this.code_view.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 925);
            this.Controls.Add(this.code_view);
            this.Controls.Add(this.search_bar);
            this.Controls.Add(this.search_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox search_bar;
        private System.Windows.Forms.TextBox code_view;
    }
}

