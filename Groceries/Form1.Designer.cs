namespace Groceries
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblMotto = new System.Windows.Forms.Label();
            this.lblFruit = new System.Windows.Forms.Label();
            this.lblVegetables = new System.Windows.Forms.Label();
            this.lblShoppingCart = new System.Windows.Forms.Label();
            this.lstFruit = new System.Windows.Forms.ListBox();
            this.lstVegetables = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(292, 26);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(230, 29);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Publix";
            // 
            // lblMotto
            // 
            this.lblMotto.AutoSize = true;
            this.lblMotto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotto.Location = new System.Drawing.Point(287, 73);
            this.lblMotto.Name = "lblMotto";
            this.lblMotto.Size = new System.Drawing.Size(235, 20);
            this.lblMotto.TabIndex = 1;
            this.lblMotto.Text = "Where Shopping is a Pleasure";
            // 
            // lblFruit
            // 
            this.lblFruit.AutoSize = true;
            this.lblFruit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFruit.Location = new System.Drawing.Point(28, 137);
            this.lblFruit.Name = "lblFruit";
            this.lblFruit.Size = new System.Drawing.Size(43, 20);
            this.lblFruit.TabIndex = 2;
            this.lblFruit.Text = "Fruit";
            // 
            // lblVegetables
            // 
            this.lblVegetables.AutoSize = true;
            this.lblVegetables.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVegetables.Location = new System.Drawing.Point(28, 332);
            this.lblVegetables.Name = "lblVegetables";
            this.lblVegetables.Size = new System.Drawing.Size(92, 20);
            this.lblVegetables.TabIndex = 3;
            this.lblVegetables.Text = "Vegetables";
            // 
            // lblShoppingCart
            // 
            this.lblShoppingCart.AutoSize = true;
            this.lblShoppingCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShoppingCart.Location = new System.Drawing.Point(431, 137);
            this.lblShoppingCart.Name = "lblShoppingCart";
            this.lblShoppingCart.Size = new System.Drawing.Size(115, 20);
            this.lblShoppingCart.TabIndex = 4;
            this.lblShoppingCart.Text = "Shopping Cart";
            // 
            // lstFruit
            // 
            this.lstFruit.FormattingEnabled = true;
            this.lstFruit.ItemHeight = 16;
            this.lstFruit.Location = new System.Drawing.Point(31, 170);
            this.lstFruit.Name = "lstFruit";
            this.lstFruit.Size = new System.Drawing.Size(360, 132);
            this.lstFruit.TabIndex = 5;
            // 
            // lstVegetables
            // 
            this.lstVegetables.FormattingEnabled = true;
            this.lstVegetables.ItemHeight = 16;
            this.lstVegetables.Location = new System.Drawing.Point(31, 362);
            this.lstVegetables.Name = "lstVegetables";
            this.lstVegetables.Size = new System.Drawing.Size(360, 132);
            this.lstVegetables.TabIndex = 6;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(435, 170);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(326, 324);
            this.listBox3.TabIndex = 7;
            // 
            // btnPurchase
            // 
            this.btnPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.Location = new System.Drawing.Point(31, 735);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(148, 45);
            this.btnPurchase.TabIndex = 8;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(317, 735);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(148, 45);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(613, 735);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 45);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Location = new System.Drawing.Point(28, 537);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(733, 142);
            this.lblMessage.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 806);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.lstVegetables);
            this.Controls.Add(this.lstFruit);
            this.Controls.Add(this.lblShoppingCart);
            this.Controls.Add(this.lblVegetables);
            this.Controls.Add(this.lblFruit);
            this.Controls.Add(this.lblMotto);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Form1";
            this.Text = "Groceries";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblMotto;
        private System.Windows.Forms.Label lblFruit;
        private System.Windows.Forms.Label lblVegetables;
        private System.Windows.Forms.Label lblShoppingCart;
        private System.Windows.Forms.ListBox lstFruit;
        private System.Windows.Forms.ListBox lstVegetables;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMessage;
    }
}

