namespace Adventure_Capitalist_Calculator
{
    partial class main
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
            this.suggestButton = new System.Windows.Forms.Button();
            this.LemonStandInput = new System.Windows.Forms.TextBox();
            this.NewspaperInput = new System.Windows.Forms.TextBox();
            this.CarwashInput = new System.Windows.Forms.TextBox();
            this.PizzaDeliveryInput = new System.Windows.Forms.TextBox();
            this.DonutShopInput = new System.Windows.Forms.TextBox();
            this.ShrimpBoatInput = new System.Windows.Forms.TextBox();
            this.HockeyTeamInput = new System.Windows.Forms.TextBox();
            this.MovieStudioInput = new System.Windows.Forms.TextBox();
            this.BankInput = new System.Windows.Forms.TextBox();
            this.OilRigInput = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // suggestButton
            // 
            this.suggestButton.Location = new System.Drawing.Point(139, 156);
            this.suggestButton.Name = "suggestButton";
            this.suggestButton.Size = new System.Drawing.Size(144, 31);
            this.suggestButton.TabIndex = 11;
            this.suggestButton.Text = "suggest next Steps";
            this.suggestButton.UseVisualStyleBackColor = true;
            this.suggestButton.Click += new System.EventHandler(this.suggestButton_Click);
            // 
            // LemonStandInput
            // 
            this.LemonStandInput.Location = new System.Drawing.Point(62, 22);
            this.LemonStandInput.Name = "LemonStandInput";
            this.LemonStandInput.Size = new System.Drawing.Size(100, 20);
            this.LemonStandInput.TabIndex = 1;
            // 
            // NewspaperInput
            // 
            this.NewspaperInput.Location = new System.Drawing.Point(62, 49);
            this.NewspaperInput.Name = "NewspaperInput";
            this.NewspaperInput.Size = new System.Drawing.Size(100, 20);
            this.NewspaperInput.TabIndex = 2;
            // 
            // CarwashInput
            // 
            this.CarwashInput.Location = new System.Drawing.Point(62, 76);
            this.CarwashInput.Name = "CarwashInput";
            this.CarwashInput.Size = new System.Drawing.Size(100, 20);
            this.CarwashInput.TabIndex = 3;
            // 
            // PizzaDeliveryInput
            // 
            this.PizzaDeliveryInput.Location = new System.Drawing.Point(62, 103);
            this.PizzaDeliveryInput.Name = "PizzaDeliveryInput";
            this.PizzaDeliveryInput.Size = new System.Drawing.Size(100, 20);
            this.PizzaDeliveryInput.TabIndex = 4;
            // 
            // DonutShopInput
            // 
            this.DonutShopInput.Location = new System.Drawing.Point(62, 130);
            this.DonutShopInput.Name = "DonutShopInput";
            this.DonutShopInput.Size = new System.Drawing.Size(100, 20);
            this.DonutShopInput.TabIndex = 5;
            // 
            // ShrimpBoatInput
            // 
            this.ShrimpBoatInput.Location = new System.Drawing.Point(258, 21);
            this.ShrimpBoatInput.Name = "ShrimpBoatInput";
            this.ShrimpBoatInput.Size = new System.Drawing.Size(100, 20);
            this.ShrimpBoatInput.TabIndex = 6;
            // 
            // HockeyTeamInput
            // 
            this.HockeyTeamInput.Location = new System.Drawing.Point(258, 48);
            this.HockeyTeamInput.Name = "HockeyTeamInput";
            this.HockeyTeamInput.Size = new System.Drawing.Size(100, 20);
            this.HockeyTeamInput.TabIndex = 7;
            // 
            // MovieStudioInput
            // 
            this.MovieStudioInput.Location = new System.Drawing.Point(258, 75);
            this.MovieStudioInput.Name = "MovieStudioInput";
            this.MovieStudioInput.Size = new System.Drawing.Size(100, 20);
            this.MovieStudioInput.TabIndex = 8;
            // 
            // BankInput
            // 
            this.BankInput.Location = new System.Drawing.Point(258, 102);
            this.BankInput.Name = "BankInput";
            this.BankInput.Size = new System.Drawing.Size(100, 20);
            this.BankInput.TabIndex = 9;
            // 
            // OilRigInput
            // 
            this.OilRigInput.Location = new System.Drawing.Point(258, 129);
            this.OilRigInput.Name = "OilRigInput";
            this.OilRigInput.Size = new System.Drawing.Size(100, 20);
            this.OilRigInput.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(12, 197);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(1036, 328);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 542);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.OilRigInput);
            this.Controls.Add(this.BankInput);
            this.Controls.Add(this.MovieStudioInput);
            this.Controls.Add(this.HockeyTeamInput);
            this.Controls.Add(this.ShrimpBoatInput);
            this.Controls.Add(this.DonutShopInput);
            this.Controls.Add(this.PizzaDeliveryInput);
            this.Controls.Add(this.CarwashInput);
            this.Controls.Add(this.NewspaperInput);
            this.Controls.Add(this.LemonStandInput);
            this.Controls.Add(this.suggestButton);
            this.Name = "main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button suggestButton;
        private System.Windows.Forms.TextBox LemonStandInput;
        private System.Windows.Forms.TextBox NewspaperInput;
        private System.Windows.Forms.TextBox CarwashInput;
        private System.Windows.Forms.TextBox PizzaDeliveryInput;
        private System.Windows.Forms.TextBox DonutShopInput;
        private System.Windows.Forms.TextBox ShrimpBoatInput;
        private System.Windows.Forms.TextBox HockeyTeamInput;
        private System.Windows.Forms.TextBox MovieStudioInput;
        private System.Windows.Forms.TextBox BankInput;
        private System.Windows.Forms.TextBox OilRigInput;
        private System.Windows.Forms.ListBox listBox1;
    }
}

