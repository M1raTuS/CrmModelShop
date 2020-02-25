namespace CrmUi
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сущностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerAddToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sellerAddToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сущностиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(967, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сущностиToolStripMenuItem
            // 
            this.сущностиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductToolStripMenuItem,
            this.SellerToolStripMenuItem,
            this.CustomerToolStripMenuItem,
            this.CheckToolStripMenuItem});
            this.сущностиToolStripMenuItem.Name = "сущностиToolStripMenuItem";
            this.сущностиToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.сущностиToolStripMenuItem.Text = "Сущности";
            // 
            // ProductToolStripMenuItem
            // 
            this.ProductToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productAddToolStripMenuItem});
            this.ProductToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem";
            this.ProductToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ProductToolStripMenuItem.Text = "Товар";
            this.ProductToolStripMenuItem.Click += new System.EventHandler(this.ProductToolStripMenuItem_Click);
            // 
            // SellerToolStripMenuItem
            // 
            this.SellerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sellerAddToolStripMenuItem2});
            this.SellerToolStripMenuItem.Name = "SellerToolStripMenuItem";
            this.SellerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SellerToolStripMenuItem.Text = "Продавец";
            this.SellerToolStripMenuItem.Click += new System.EventHandler(this.SellerToolStripMenuItem_Click);
            // 
            // CustomerToolStripMenuItem
            // 
            this.CustomerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerAddToolStripMenuItem1});
            this.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem";
            this.CustomerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CustomerToolStripMenuItem.Text = "Покупатель";
            this.CustomerToolStripMenuItem.Click += new System.EventHandler(this.CustomerToolStripMenuItem_Click);
            // 
            // CheckToolStripMenuItem
            // 
            this.CheckToolStripMenuItem.Name = "CheckToolStripMenuItem";
            this.CheckToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CheckToolStripMenuItem.Text = "Чек";
            this.CheckToolStripMenuItem.Click += new System.EventHandler(this.CheckToolStripMenuItem_Click);
            // 
            // productAddToolStripMenuItem
            // 
            this.productAddToolStripMenuItem.Name = "productAddToolStripMenuItem";
            this.productAddToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productAddToolStripMenuItem.Text = "Добавить";
            // 
            // customerAddToolStripMenuItem1
            // 
            this.customerAddToolStripMenuItem1.Name = "customerAddToolStripMenuItem1";
            this.customerAddToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.customerAddToolStripMenuItem1.Text = "Добавить";
            this.customerAddToolStripMenuItem1.Click += new System.EventHandler(this.СustomerAddToolStripMenuItem1_Click);
            // 
            // sellerAddToolStripMenuItem2
            // 
            this.sellerAddToolStripMenuItem2.Name = "sellerAddToolStripMenuItem2";
            this.sellerAddToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.sellerAddToolStripMenuItem2.Text = "Добавить";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 536);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сущностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellerAddToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem customerAddToolStripMenuItem1;
    }
}

