namespace _24_Delegate_Event
{
    partial class DelegateForm
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
            this.greetButton = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnUpper = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnHandle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // greetButton
            // 
            this.greetButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.greetButton.Location = new System.Drawing.Point(143, 70);
            this.greetButton.Name = "greetButton";
            this.greetButton.Size = new System.Drawing.Size(110, 44);
            this.greetButton.TabIndex = 0;
            this.greetButton.Text = "Greet!";
            this.greetButton.UseVisualStyleBackColor = true;
            this.greetButton.Click += new System.EventHandler(this.greetButton_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(12, 12);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(110, 23);
            this.txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(12, 41);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(110, 23);
            this.txtNum2.TabIndex = 2;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calculateBtn.Location = new System.Drawing.Point(12, 70);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(110, 52);
            this.calculateBtn.TabIndex = 3;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(12, 128);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(110, 23);
            this.txtValue.TabIndex = 4;
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(12, 157);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(110, 23);
            this.btnReverse.TabIndex = 5;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnUpper
            // 
            this.btnUpper.Location = new System.Drawing.Point(12, 186);
            this.btnUpper.Name = "btnUpper";
            this.btnUpper.Size = new System.Drawing.Size(110, 23);
            this.btnUpper.TabIndex = 6;
            this.btnUpper.Text = "Upper Case";
            this.btnUpper.UseVisualStyleBackColor = true;
            this.btnUpper.Click += new System.EventHandler(this.btnUpper_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(12, 215);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(110, 23);
            this.btnEncrypt.TabIndex = 7;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnHandle
            // 
            this.btnHandle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHandle.Location = new System.Drawing.Point(143, 120);
            this.btnHandle.Name = "btnHandle";
            this.btnHandle.Size = new System.Drawing.Size(110, 44);
            this.btnHandle.TabIndex = 8;
            this.btnHandle.Text = "Handle";
            this.btnHandle.UseVisualStyleBackColor = true;
            this.btnHandle.Click += new System.EventHandler(this.btnHandle_Click);
            // 
            // DelegateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 257);
            this.Controls.Add(this.btnHandle);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnUpper);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.greetButton);
            this.Name = "DelegateForm";
            this.Text = "DelegateForm";
            this.Load += new System.EventHandler(this.DelegateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button greetButton;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Button calculateBtn;
        private TextBox txtValue;
        private Button btnReverse;
        private Button btnUpper;
        private Button btnEncrypt;
        private Button btnHandle;
    }
}