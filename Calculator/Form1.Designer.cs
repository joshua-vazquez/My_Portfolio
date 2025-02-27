using System;
using System.Windows.Forms;

namespace Calculator
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
            lblHeader = new Label();
            btnPercentage = new Button();
            btnClear = new Button();
            btnBackspace = new Button();
            btnReciprocal = new Button();
            btnPower = new Button();
            btnSqRoot = new Button();
            btnDivide = new Button();
            btnSeven = new Button();
            btnEight = new Button();
            btnNine = new Button();
            btnMultiply = new Button();
            btnFour = new Button();
            btnFive = new Button();
            btnSix = new Button();
            btnSubtract = new Button();
            btnOne = new Button();
            btnTwo = new Button();
            btnThree = new Button();
            btnAdd = new Button();
            btnNegate = new Button();
            btnZero = new Button();
            btnDecimal = new Button();
            btnEquals = new Button();
            historyList = new ListView();
            txtCurrentExp = new TextBox();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Microsoft YaHei UI", 10F);
            lblHeader.Location = new Point(420, 10);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(59, 20);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "History:";
            // 
            // btnPercentage
            // 
            btnPercentage.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPercentage.Location = new Point(16, 254);
            btnPercentage.Name = "btnPercentage";
            btnPercentage.Size = new Size(90, 50);
            btnPercentage.TabIndex = 1;
            btnPercentage.Text = "%";
            btnPercentage.UseVisualStyleBackColor = true;
            btnPercentage.Click += btnPercentage_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(216, 254);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 50);
            btnClear.TabIndex = 3;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBackspace
            // 
            btnBackspace.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBackspace.Location = new Point(316, 254);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(90, 50);
            btnBackspace.TabIndex = 4;
            btnBackspace.Text = "⌫";
            btnBackspace.UseVisualStyleBackColor = true;
            btnBackspace.Click += btnBackspace_Click;
            // 
            // btnReciprocal
            // 
            btnReciprocal.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReciprocal.Location = new Point(16, 314);
            btnReciprocal.Name = "btnReciprocal";
            btnReciprocal.Size = new Size(90, 50);
            btnReciprocal.TabIndex = 5;
            btnReciprocal.Text = "1/x";
            btnReciprocal.UseVisualStyleBackColor = true;
            btnReciprocal.Click += btnReciprocal_Click;
            // 
            // btnPower
            // 
            btnPower.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPower.Location = new Point(116, 314);
            btnPower.Name = "btnPower";
            btnPower.Size = new Size(90, 50);
            btnPower.TabIndex = 6;
            btnPower.Text = "x²";
            btnPower.UseVisualStyleBackColor = true;
            btnPower.Click += btnPower_Click;
            // 
            // btnSqRoot
            // 
            btnSqRoot.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSqRoot.Location = new Point(216, 314);
            btnSqRoot.Name = "btnSqRoot";
            btnSqRoot.Size = new Size(90, 50);
            btnSqRoot.TabIndex = 7;
            btnSqRoot.Text = "√";
            btnSqRoot.UseVisualStyleBackColor = true;
            btnSqRoot.Click += btnSqRoot_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivide.Location = new Point(316, 314);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(90, 50);
            btnDivide.TabIndex = 8;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnSeven
            // 
            btnSeven.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeven.Location = new Point(16, 374);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(90, 50);
            btnSeven.TabIndex = 9;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnSeven_Click;
            // 
            // btnEight
            // 
            btnEight.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEight.Location = new Point(116, 374);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(90, 50);
            btnEight.TabIndex = 10;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += btnEight_Click;
            // 
            // btnNine
            // 
            btnNine.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNine.Location = new Point(216, 374);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(90, 50);
            btnNine.TabIndex = 11;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += btnNine_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiply.Location = new Point(316, 374);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(90, 50);
            btnMultiply.TabIndex = 12;
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnFour
            // 
            btnFour.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFour.Location = new Point(16, 434);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(90, 50);
            btnFour.TabIndex = 13;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += btnFour_Click;
            // 
            // btnFive
            // 
            btnFive.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFive.Location = new Point(116, 434);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(90, 50);
            btnFive.TabIndex = 14;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += btnFive_Click;
            // 
            // btnSix
            // 
            btnSix.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSix.Location = new Point(216, 434);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(90, 50);
            btnSix.TabIndex = 15;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += btnSix_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubtract.Location = new Point(316, 434);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(90, 50);
            btnSubtract.TabIndex = 16;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnOne
            // 
            btnOne.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOne.Location = new Point(16, 494);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(90, 50);
            btnOne.TabIndex = 17;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += btnOne_Click;
            // 
            // btnTwo
            // 
            btnTwo.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTwo.Location = new Point(116, 494);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(90, 50);
            btnTwo.TabIndex = 18;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnThree
            // 
            btnThree.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThree.Location = new Point(216, 494);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(90, 50);
            btnThree.TabIndex = 19;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += btnThree_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(316, 494);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 50);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnNegate
            // 
            btnNegate.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNegate.Location = new Point(16, 554);
            btnNegate.Name = "btnNegate";
            btnNegate.Size = new Size(90, 50);
            btnNegate.TabIndex = 21;
            btnNegate.Text = "+/-";
            btnNegate.UseVisualStyleBackColor = true;
            btnNegate.Click += btnNegate_Click;
            // 
            // btnZero
            // 
            btnZero.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnZero.Location = new Point(116, 554);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(90, 50);
            btnZero.TabIndex = 22;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDecimal.Location = new Point(216, 554);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(90, 50);
            btnDecimal.TabIndex = 23;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEquals.Location = new Point(316, 554);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(90, 50);
            btnEquals.TabIndex = 24;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // historyList
            // 
            historyList.Alignment = ListViewAlignment.SnapToGrid;
            historyList.AutoArrange = false;
            historyList.BackColor = Color.LightGray;
            historyList.Font = new Font("Consolas", 11F);
            historyList.GridLines = true;
            historyList.Location = new Point(420, 33);
            historyList.Name = "historyList";
            historyList.Size = new Size(169, 571);
            historyList.TabIndex = 26;
            historyList.UseCompatibleStateImageBehavior = false;
            historyList.View = View.List;
            // 
            // txtCurrentExp
            // 
            txtCurrentExp.Font = new Font("Consolas", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCurrentExp.Location = new Point(16, 49);
            txtCurrentExp.Name = "txtCurrentExp";
            txtCurrentExp.Size = new Size(260, 39);
            txtCurrentExp.TabIndex = 27;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Consolas", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResult.Location = new Point(16, 131);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(260, 39);
            txtResult.TabIndex = 28;
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(601, 622);
            Controls.Add(txtResult);
            Controls.Add(txtCurrentExp);
            Controls.Add(historyList);
            Controls.Add(btnEquals);
            Controls.Add(btnDecimal);
            Controls.Add(btnZero);
            Controls.Add(btnNegate);
            Controls.Add(btnAdd);
            Controls.Add(btnThree);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            Controls.Add(btnSubtract);
            Controls.Add(btnSix);
            Controls.Add(btnFive);
            Controls.Add(btnFour);
            Controls.Add(btnMultiply);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnSeven);
            Controls.Add(btnDivide);
            Controls.Add(btnSqRoot);
            Controls.Add(btnPower);
            Controls.Add(btnReciprocal);
            Controls.Add(btnBackspace);
            Controls.Add(btnClear);
            Controls.Add(btnPercentage);
            Controls.Add(lblHeader);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Button btnPercentage;
        private Button btnClear;
        private Button btnBackspace;
        private Button btnReciprocal;
        private Button btnPower;
        private Button btnSqRoot;
        private Button btnDivide;
        private Button btnSeven;
        private Button btnEight;
        private Button btnNine;
        private Button btnMultiply;
        private Button btnFour;
        private Button btnFive;
        private Button btnSix;
        private Button btnSubtract;
        private Button btnOne;
        private Button btnTwo;
        private Button btnThree;
        private Button btnAdd;
        private Button btnNegate;
        private Button btnZero;
        private Button btnDecimal;
        private Button btnEquals;
        private ListView historyList;
        private TextBox txtCurrentExp;
        private TextBox txtResult;
    }
}
