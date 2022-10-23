namespace Activity14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pizzaListBox = new System.Windows.Forms.ListBox();
            this.smallRadioBttn = new System.Windows.Forms.RadioButton();
            this.medRadioBttn = new System.Windows.Forms.RadioButton();
            this.largeRadioBttn = new System.Windows.Forms.RadioButton();
            this.xlargeRadioBttn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.ccCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.spriteCheckBox = new System.Windows.Forms.CheckBox();
            this.dietCCCheckBox = new System.Windows.Forms.CheckBox();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.exitBttn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pizza";
            // 
            // pizzaListBox
            // 
            this.pizzaListBox.FormattingEnabled = true;
            this.pizzaListBox.ItemHeight = 16;
            this.pizzaListBox.Items.AddRange(new object[] {
            "Cheese",
            "Pepperoni",
            "Meat Lovers",
            "Veggie"});
            this.pizzaListBox.Location = new System.Drawing.Point(157, 43);
            this.pizzaListBox.Name = "pizzaListBox";
            this.pizzaListBox.Size = new System.Drawing.Size(210, 84);
            this.pizzaListBox.TabIndex = 2;
            this.pizzaListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // smallRadioBttn
            // 
            this.smallRadioBttn.AutoSize = true;
            this.smallRadioBttn.Location = new System.Drawing.Point(195, 165);
            this.smallRadioBttn.Name = "smallRadioBttn";
            this.smallRadioBttn.Size = new System.Drawing.Size(62, 20);
            this.smallRadioBttn.TabIndex = 3;
            this.smallRadioBttn.TabStop = true;
            this.smallRadioBttn.Text = "Small";
            this.smallRadioBttn.UseVisualStyleBackColor = true;
            this.smallRadioBttn.CheckedChanged += new System.EventHandler(this.smallRadioBttn_CheckedChanged);
            // 
            // medRadioBttn
            // 
            this.medRadioBttn.AutoSize = true;
            this.medRadioBttn.Location = new System.Drawing.Point(195, 191);
            this.medRadioBttn.Name = "medRadioBttn";
            this.medRadioBttn.Size = new System.Drawing.Size(76, 20);
            this.medRadioBttn.TabIndex = 4;
            this.medRadioBttn.TabStop = true;
            this.medRadioBttn.Text = "Medium";
            this.medRadioBttn.UseVisualStyleBackColor = true;
            this.medRadioBttn.CheckedChanged += new System.EventHandler(this.medRadioBttn_CheckedChanged);
            // 
            // largeRadioBttn
            // 
            this.largeRadioBttn.AutoSize = true;
            this.largeRadioBttn.Location = new System.Drawing.Point(195, 215);
            this.largeRadioBttn.Name = "largeRadioBttn";
            this.largeRadioBttn.Size = new System.Drawing.Size(63, 20);
            this.largeRadioBttn.TabIndex = 5;
            this.largeRadioBttn.TabStop = true;
            this.largeRadioBttn.Text = "Large";
            this.largeRadioBttn.UseVisualStyleBackColor = true;
            this.largeRadioBttn.CheckedChanged += new System.EventHandler(this.largeRadioBttn_CheckedChanged);
            // 
            // xlargeRadioBttn
            // 
            this.xlargeRadioBttn.AutoSize = true;
            this.xlargeRadioBttn.Location = new System.Drawing.Point(195, 241);
            this.xlargeRadioBttn.Name = "xlargeRadioBttn";
            this.xlargeRadioBttn.Size = new System.Drawing.Size(96, 20);
            this.xlargeRadioBttn.TabIndex = 6;
            this.xlargeRadioBttn.TabStop = true;
            this.xlargeRadioBttn.Text = "Extra Large";
            this.xlargeRadioBttn.UseVisualStyleBackColor = true;
            this.xlargeRadioBttn.CheckedChanged += new System.EventHandler(this.xlargeRadioBttn_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pizza Sizes";
            // 
            // ccCheckBox
            // 
            this.ccCheckBox.AutoSize = true;
            this.ccCheckBox.Location = new System.Drawing.Point(195, 291);
            this.ccCheckBox.Name = "ccCheckBox";
            this.ccCheckBox.Size = new System.Drawing.Size(92, 20);
            this.ccCheckBox.TabIndex = 8;
            this.ccCheckBox.Text = "Coca Cola";
            this.ccCheckBox.UseVisualStyleBackColor = true;
            this.ccCheckBox.CheckedChanged += new System.EventHandler(this.ccCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Drinks";
            // 
            // spriteCheckBox
            // 
            this.spriteCheckBox.AutoSize = true;
            this.spriteCheckBox.Location = new System.Drawing.Point(196, 317);
            this.spriteCheckBox.Name = "spriteCheckBox";
            this.spriteCheckBox.Size = new System.Drawing.Size(64, 20);
            this.spriteCheckBox.TabIndex = 11;
            this.spriteCheckBox.Text = "Sprite";
            this.spriteCheckBox.UseVisualStyleBackColor = true;
            this.spriteCheckBox.CheckedChanged += new System.EventHandler(this.spriteCheckBox_CheckedChanged);
            // 
            // dietCCCheckBox
            // 
            this.dietCCCheckBox.AutoSize = true;
            this.dietCCCheckBox.Location = new System.Drawing.Point(195, 343);
            this.dietCCCheckBox.Name = "dietCCCheckBox";
            this.dietCCCheckBox.Size = new System.Drawing.Size(84, 20);
            this.dietCCCheckBox.TabIndex = 12;
            this.dietCCCheckBox.Text = "Diet Cola";
            this.dietCCCheckBox.UseVisualStyleBackColor = true;
            this.dietCCCheckBox.CheckedChanged += new System.EventHandler(this.dietCCCheckBox_CheckedChanged);
            // 
            // newOrderButton
            // 
            this.newOrderButton.Location = new System.Drawing.Point(361, 360);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(158, 23);
            this.newOrderButton.TabIndex = 13;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.addBttn_Click);
            // 
            // exitBttn
            // 
            this.exitBttn.Location = new System.Drawing.Point(604, 360);
            this.exitBttn.Name = "exitBttn";
            this.exitBttn.Size = new System.Drawing.Size(144, 23);
            this.exitBttn.TabIndex = 14;
            this.exitBttn.Text = "Exit";
            this.exitBttn.UseVisualStyleBackColor = true;
            this.exitBttn.Click += new System.EventHandler(this.exitBttn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(543, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 22);
            this.textBox1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Order Summary";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(543, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 22);
            this.textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(543, 123);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(128, 22);
            this.textBox3.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1113, 633);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.exitBttn);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.dietCCCheckBox);
            this.Controls.Add(this.spriteCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ccCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.xlargeRadioBttn);
            this.Controls.Add(this.largeRadioBttn);
            this.Controls.Add(this.medRadioBttn);
            this.Controls.Add(this.smallRadioBttn);
            this.Controls.Add(this.pizzaListBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pizza Pizza";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox pizzaListBox;
        private System.Windows.Forms.RadioButton smallRadioBttn;
        private System.Windows.Forms.RadioButton medRadioBttn;
        private System.Windows.Forms.RadioButton largeRadioBttn;
        private System.Windows.Forms.RadioButton xlargeRadioBttn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ccCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox spriteCheckBox;
        private System.Windows.Forms.CheckBox dietCCCheckBox;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Button exitBttn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

