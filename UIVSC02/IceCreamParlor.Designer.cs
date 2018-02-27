namespace UIVSC02
{
    partial class IceCreamParlor
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
            this.btnOrder = new System.Windows.Forms.Button();
            this.gboFlavor = new System.Windows.Forms.GroupBox();
            this.optStrawberry = new System.Windows.Forms.RadioButton();
            this.optChocolate = new System.Windows.Forms.RadioButton();
            this.gboTopping = new System.Windows.Forms.GroupBox();
            this.gboSize = new System.Windows.Forms.GroupBox();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.lboTopping = new System.Windows.Forms.ListBox();
            this.gboFlavor.SuspendLayout();
            this.gboTopping.SuspendLayout();
            this.gboSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(153, 361);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(107, 34);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Get Orders";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // gboFlavor
            // 
            this.gboFlavor.Controls.Add(this.optStrawberry);
            this.gboFlavor.Controls.Add(this.optChocolate);
            this.gboFlavor.Location = new System.Drawing.Point(102, 119);
            this.gboFlavor.Name = "gboFlavor";
            this.gboFlavor.Size = new System.Drawing.Size(222, 115);
            this.gboFlavor.TabIndex = 5;
            this.gboFlavor.TabStop = false;
            this.gboFlavor.Text = "Flavor";
            // 
            // optStrawberry
            // 
            this.optStrawberry.AutoSize = true;
            this.optStrawberry.Location = new System.Drawing.Point(27, 66);
            this.optStrawberry.Name = "optStrawberry";
            this.optStrawberry.Size = new System.Drawing.Size(75, 17);
            this.optStrawberry.TabIndex = 1;
            this.optStrawberry.Text = "Strawberry";
            this.optStrawberry.UseVisualStyleBackColor = true;
            // 
            // optChocolate
            // 
            this.optChocolate.AutoSize = true;
            this.optChocolate.Checked = true;
            this.optChocolate.Location = new System.Drawing.Point(27, 33);
            this.optChocolate.Name = "optChocolate";
            this.optChocolate.Size = new System.Drawing.Size(73, 17);
            this.optChocolate.TabIndex = 0;
            this.optChocolate.TabStop = true;
            this.optChocolate.Text = "Chocolate";
            this.optChocolate.UseVisualStyleBackColor = true;
            // 
            // gboTopping
            // 
            this.gboTopping.Controls.Add(this.lboTopping);
            this.gboTopping.Location = new System.Drawing.Point(102, 255);
            this.gboTopping.Name = "gboTopping";
            this.gboTopping.Size = new System.Drawing.Size(222, 91);
            this.gboTopping.TabIndex = 6;
            this.gboTopping.TabStop = false;
            this.gboTopping.Text = "Topping";
            // 
            // gboSize
            // 
            this.gboSize.Controls.Add(this.cboSize);
            this.gboSize.Location = new System.Drawing.Point(102, 29);
            this.gboSize.Name = "gboSize";
            this.gboSize.Size = new System.Drawing.Size(222, 76);
            this.gboSize.TabIndex = 4;
            this.gboSize.TabStop = false;
            this.gboSize.Text = "Size";
            // 
            // cboSize
            // 
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Big"});
            this.cboSize.Location = new System.Drawing.Point(27, 33);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(114, 21);
            this.cboSize.TabIndex = 0;
            this.cboSize.Text = "Small";
            // 
            // lboTopping
            // 
            this.lboTopping.FormattingEnabled = true;
            this.lboTopping.Items.AddRange(new object[] {
            "Nuts",
            "Raisins",
            "Chocolate Chips"});
            this.lboTopping.Location = new System.Drawing.Point(27, 33);
            this.lboTopping.Name = "lboTopping";
            this.lboTopping.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lboTopping.Size = new System.Drawing.Size(120, 43);
            this.lboTopping.TabIndex = 0;
            // 
            // IceCreamParlor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 406);
            this.Controls.Add(this.gboTopping);
            this.Controls.Add(this.gboFlavor);
            this.Controls.Add(this.gboSize);
            this.Controls.Add(this.btnOrder);
            this.Name = "IceCreamParlor";
            this.Text = "IceCreamParlor";
            this.gboFlavor.ResumeLayout(false);
            this.gboFlavor.PerformLayout();
            this.gboTopping.ResumeLayout(false);
            this.gboSize.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.GroupBox gboFlavor;
        private System.Windows.Forms.RadioButton optStrawberry;
        private System.Windows.Forms.RadioButton optChocolate;
        private System.Windows.Forms.GroupBox gboTopping;
        private System.Windows.Forms.GroupBox gboSize;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.ListBox lboTopping;
    }
}