namespace BlackJack_Assistant
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtAmountBet = new TextBox();
            label2 = new Label();
            txtSideBet = new TextBox();
            txtNumHands = new TextBox();
            label3 = new Label();
            txtPlayerSum = new TextBox();
            label4 = new Label();
            txtDealerCard = new TextBox();
            label5 = new Label();
            txtLastCard = new TextBox();
            label6 = new Label();
            chkCanSplit = new CheckBox();
            chkCanDouble = new CheckBox();
            button1 = new Button();
            lblDecision = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 24);
            label1.Name = "label1";
            label1.Size = new Size(95, 21);
            label1.TabIndex = 0;
            label1.Text = "Amount Bet:";
            // 
            // txtAmountBet
            // 
            txtAmountBet.Location = new Point(130, 24);
            txtAmountBet.Name = "txtAmountBet";
            txtAmountBet.Size = new Size(100, 23);
            txtAmountBet.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 61);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 2;
            label2.Text = "Side Bet:";
            // 
            // txtSideBet
            // 
            txtSideBet.Location = new Point(104, 58);
            txtSideBet.Name = "txtSideBet";
            txtSideBet.Size = new Size(100, 23);
            txtSideBet.TabIndex = 3;
            // 
            // txtNumHands
            // 
            txtNumHands.Location = new Point(172, 95);
            txtNumHands.Name = "txtNumHands";
            txtNumHands.Size = new Size(100, 23);
            txtNumHands.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 95);
            label3.Name = "label3";
            label3.Size = new Size(137, 21);
            label3.TabIndex = 4;
            label3.Text = "Number of Hands:";
            // 
            // txtPlayerSum
            // 
            txtPlayerSum.Location = new Point(178, 134);
            txtPlayerSum.Name = "txtPlayerSum";
            txtPlayerSum.Size = new Size(100, 23);
            txtPlayerSum.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 134);
            label4.Name = "label4";
            label4.Size = new Size(143, 21);
            label4.TabIndex = 6;
            label4.Text = "Sum of Your Cards:";
            // 
            // txtDealerCard
            // 
            txtDealerCard.Location = new Point(201, 171);
            txtDealerCard.Name = "txtDealerCard";
            txtDealerCard.Size = new Size(100, 23);
            txtDealerCard.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(29, 173);
            label5.Name = "label5";
            label5.Size = new Size(166, 21);
            label5.TabIndex = 8;
            label5.Text = "Dealer's Face-Up Card:";
            // 
            // txtLastCard
            // 
            txtLastCard.Location = new Point(153, 211);
            txtLastCard.Name = "txtLastCard";
            txtLastCard.Size = new Size(100, 23);
            txtLastCard.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(29, 211);
            label6.Name = "label6";
            label6.Size = new Size(118, 21);
            label6.TabIndex = 10;
            label6.Text = "Last Card Dealt:";
            // 
            // chkCanSplit
            // 
            chkCanSplit.AutoSize = true;
            chkCanSplit.Location = new Point(89, 252);
            chkCanSplit.Name = "chkCanSplit";
            chkCanSplit.Size = new Size(73, 19);
            chkCanSplit.TabIndex = 12;
            chkCanSplit.Text = "Can Split";
            chkCanSplit.UseVisualStyleBackColor = true;
            // 
            // chkCanDouble
            // 
            chkCanDouble.AutoSize = true;
            chkCanDouble.Location = new Point(180, 252);
            chkCanDouble.Name = "chkCanDouble";
            chkCanDouble.Size = new Size(88, 19);
            chkCanDouble.TabIndex = 13;
            chkCanDouble.Text = "Can Double";
            chkCanDouble.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(116, 291);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 14;
            button1.Text = "Analyze";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblDecision
            // 
            lblDecision.AutoSize = true;
            lblDecision.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDecision.Location = new Point(68, 331);
            lblDecision.Name = "lblDecision";
            lblDecision.Size = new Size(94, 21);
            lblDecision.TabIndex = 15;
            lblDecision.Text = "AI Suggests:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(484, 361);
            Controls.Add(lblDecision);
            Controls.Add(button1);
            Controls.Add(chkCanDouble);
            Controls.Add(chkCanSplit);
            Controls.Add(txtLastCard);
            Controls.Add(label6);
            Controls.Add(txtDealerCard);
            Controls.Add(label5);
            Controls.Add(txtPlayerSum);
            Controls.Add(label4);
            Controls.Add(txtNumHands);
            Controls.Add(label3);
            Controls.Add(txtSideBet);
            Controls.Add(label2);
            Controls.Add(txtAmountBet);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Blackjack Assistant";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAmountBet;
        private Label label2;
        private TextBox txtSideBet;
        private TextBox txtNumHands;
        private Label label3;
        private TextBox txtPlayerSum;
        private Label label4;
        private TextBox txtDealerCard;
        private Label label5;
        private TextBox txtLastCard;
        private Label label6;
        private CheckBox chkCanSplit;
        private CheckBox chkCanDouble;
        private Button button1;
        private Label lblDecision;
    }
}
