///////////////////////////////////////////////////////////////////////////
// Change History
// Date ------- Developer ---- Description
// 2022-01-28 - Charles Costarella - All code has been created by Charles Costarella. Subsequent changes list my name: Jared Howard
// to show the timeline of changes while creating the calculator per my professor's instruction.
// 2022-01-28 - Jared Howard - Project created, buttons built and named
// 2022-01-29 - Jared Howard - Functionality added to buttons 0 - 9
// 2022-01-30 - Jared Howard - Functionality added to remaining buttons.
// 2022-01-30 - Jared Howard - COMPLETED and built
//
namespace MathCalc
{
    ///////////////////////////////////////////////////////////////////////////
    // TINFO 200 B, Winter 2022
    // UWTacoma SET, Jared Howard
    // 2022-01-30 - L4calc - This application creates a functional calculator that allows the user to perform basic operations
    //
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

        private void InitializeComponent()
        {
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addBtn = new System.Windows.Forms.Button();
            this.equalsBtn = new System.Windows.Forms.Button();
            this.decimalPtBtn = new System.Windows.Forms.Button();
            this.num0Btn = new System.Windows.Forms.Button();
            this.posNegBtn = new System.Windows.Forms.Button();
            this.num3Btn = new System.Windows.Forms.Button();
            this.num2Btn = new System.Windows.Forms.Button();
            this.num1Btn = new System.Windows.Forms.Button();
            this.subtractBtn = new System.Windows.Forms.Button();
            this.num6Btn = new System.Windows.Forms.Button();
            this.num5Btn = new System.Windows.Forms.Button();
            this.num4Btn = new System.Windows.Forms.Button();
            this.multiplyBtn = new System.Windows.Forms.Button();
            this.num9Btn = new System.Windows.Forms.Button();
            this.num8Btn = new System.Windows.Forms.Button();
            this.num7Btn = new System.Windows.Forms.Button();
            this.divideBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.clearEntryBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(0, 0);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 4;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(0, 0);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.addBtn, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.equalsBtn, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.decimalPtBtn, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.num0Btn, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.posNegBtn, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.num3Btn, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.num2Btn, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.num1Btn, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.subtractBtn, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.num6Btn, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.num5Btn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.num4Btn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.multiplyBtn, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.num9Btn, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.num8Btn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.num7Btn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.divideBtn, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.backBtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.clearBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.display, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.clearEntryBtn, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(578, 644);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // addBtn
            // 
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(435, 412);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(140, 109);
            this.addBtn.TabIndex = 16;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.mathOpBtn_Click);
            // 
            // equalsBtn
            // 
            this.equalsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equalsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsBtn.Location = new System.Drawing.Point(435, 527);
            this.equalsBtn.Name = "equalsBtn";
            this.equalsBtn.Size = new System.Drawing.Size(140, 114);
            this.equalsBtn.TabIndex = 20;
            this.equalsBtn.Text = "=";
            this.equalsBtn.UseVisualStyleBackColor = true;
            this.equalsBtn.Click += new System.EventHandler(this.equalsBtn_Click);
            // 
            // decimalPtBtn
            // 
            this.decimalPtBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decimalPtBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalPtBtn.Location = new System.Drawing.Point(291, 527);
            this.decimalPtBtn.Name = "decimalPtBtn";
            this.decimalPtBtn.Size = new System.Drawing.Size(138, 114);
            this.decimalPtBtn.TabIndex = 19;
            this.decimalPtBtn.Text = ".";
            this.decimalPtBtn.UseVisualStyleBackColor = true;
            this.decimalPtBtn.Click += new System.EventHandler(this.decimalPtBtn_Click);
            // 
            // num0Btn
            // 
            this.num0Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num0Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0Btn.Location = new System.Drawing.Point(147, 527);
            this.num0Btn.Name = "num0Btn";
            this.num0Btn.Size = new System.Drawing.Size(138, 114);
            this.num0Btn.TabIndex = 18;
            this.num0Btn.Text = "0";
            this.num0Btn.UseVisualStyleBackColor = true;
            this.num0Btn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // posNegBtn
            // 
            this.posNegBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.posNegBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posNegBtn.Location = new System.Drawing.Point(3, 527);
            this.posNegBtn.Name = "posNegBtn";
            this.posNegBtn.Size = new System.Drawing.Size(138, 114);
            this.posNegBtn.TabIndex = 17;
            this.posNegBtn.Text = "+/-";
            this.posNegBtn.UseVisualStyleBackColor = true;
            this.posNegBtn.Click += new System.EventHandler(this.posNegBtn_Click);
            // 
            // num3Btn
            // 
            this.num3Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num3Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3Btn.Location = new System.Drawing.Point(291, 412);
            this.num3Btn.Name = "num3Btn";
            this.num3Btn.Size = new System.Drawing.Size(138, 109);
            this.num3Btn.TabIndex = 15;
            this.num3Btn.Text = "3";
            this.num3Btn.UseVisualStyleBackColor = true;
            this.num3Btn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // num2Btn
            // 
            this.num2Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2Btn.Location = new System.Drawing.Point(147, 412);
            this.num2Btn.Name = "num2Btn";
            this.num2Btn.Size = new System.Drawing.Size(138, 109);
            this.num2Btn.TabIndex = 14;
            this.num2Btn.Text = "2";
            this.num2Btn.UseVisualStyleBackColor = true;
            this.num2Btn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // num1Btn
            // 
            this.num1Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1Btn.Location = new System.Drawing.Point(3, 412);
            this.num1Btn.Name = "num1Btn";
            this.num1Btn.Size = new System.Drawing.Size(138, 109);
            this.num1Btn.TabIndex = 13;
            this.num1Btn.Text = "1";
            this.num1Btn.UseVisualStyleBackColor = true;
            this.num1Btn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // subtractBtn
            // 
            this.subtractBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subtractBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractBtn.Location = new System.Drawing.Point(435, 297);
            this.subtractBtn.Name = "subtractBtn";
            this.subtractBtn.Size = new System.Drawing.Size(140, 109);
            this.subtractBtn.TabIndex = 12;
            this.subtractBtn.Text = "-";
            this.subtractBtn.UseVisualStyleBackColor = true;
            this.subtractBtn.Click += new System.EventHandler(this.mathOpBtn_Click);
            // 
            // num6Btn
            // 
            this.num6Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num6Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6Btn.Location = new System.Drawing.Point(291, 297);
            this.num6Btn.Name = "num6Btn";
            this.num6Btn.Size = new System.Drawing.Size(138, 109);
            this.num6Btn.TabIndex = 11;
            this.num6Btn.Text = "6";
            this.num6Btn.UseVisualStyleBackColor = true;
            this.num6Btn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // num5Btn
            // 
            this.num5Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num5Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5Btn.Location = new System.Drawing.Point(147, 297);
            this.num5Btn.Name = "num5Btn";
            this.num5Btn.Size = new System.Drawing.Size(138, 109);
            this.num5Btn.TabIndex = 10;
            this.num5Btn.Text = "5";
            this.num5Btn.UseVisualStyleBackColor = true;
            this.num5Btn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // num4Btn
            // 
            this.num4Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num4Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4Btn.Location = new System.Drawing.Point(3, 297);
            this.num4Btn.Name = "num4Btn";
            this.num4Btn.Size = new System.Drawing.Size(138, 109);
            this.num4Btn.TabIndex = 9;
            this.num4Btn.Text = "4";
            this.num4Btn.UseVisualStyleBackColor = true;
            this.num4Btn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // multiplyBtn
            // 
            this.multiplyBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiplyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyBtn.Location = new System.Drawing.Point(435, 182);
            this.multiplyBtn.Name = "multiplyBtn";
            this.multiplyBtn.Size = new System.Drawing.Size(140, 109);
            this.multiplyBtn.TabIndex = 8;
            this.multiplyBtn.Text = "x";
            this.multiplyBtn.UseVisualStyleBackColor = true;
            this.multiplyBtn.Click += new System.EventHandler(this.mathOpBtn_Click);
            // 
            // num9Btn
            // 
            this.num9Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num9Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9Btn.Location = new System.Drawing.Point(291, 182);
            this.num9Btn.Name = "num9Btn";
            this.num9Btn.Size = new System.Drawing.Size(138, 109);
            this.num9Btn.TabIndex = 7;
            this.num9Btn.Text = "9";
            this.num9Btn.UseVisualStyleBackColor = true;
            this.num9Btn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // num8Btn
            // 
            this.num8Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num8Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8Btn.Location = new System.Drawing.Point(147, 182);
            this.num8Btn.Name = "num8Btn";
            this.num8Btn.Size = new System.Drawing.Size(138, 109);
            this.num8Btn.TabIndex = 6;
            this.num8Btn.Text = "8";
            this.num8Btn.UseVisualStyleBackColor = true;
            this.num8Btn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // num7Btn
            // 
            this.num7Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num7Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7Btn.Location = new System.Drawing.Point(3, 182);
            this.num7Btn.Name = "num7Btn";
            this.num7Btn.Size = new System.Drawing.Size(138, 109);
            this.num7Btn.TabIndex = 5;
            this.num7Btn.Text = "7";
            this.num7Btn.UseVisualStyleBackColor = true;
            this.num7Btn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // divideBtn
            // 
            this.divideBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divideBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideBtn.Location = new System.Drawing.Point(435, 67);
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.Size = new System.Drawing.Size(140, 109);
            this.divideBtn.TabIndex = 4;
            this.divideBtn.Text = "/";
            this.divideBtn.UseVisualStyleBackColor = true;
            this.divideBtn.Click += new System.EventHandler(this.mathOpBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(291, 67);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(138, 109);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "<<";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(147, 67);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(138, 109);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "C";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // display
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.display, 4);
            this.display.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(3, 8);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(572, 53);
            this.display.TabIndex = 0;
            this.display.Text = "0";
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // clearEntryBtn
            // 
            this.clearEntryBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearEntryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearEntryBtn.Location = new System.Drawing.Point(3, 67);
            this.clearEntryBtn.Name = "clearEntryBtn";
            this.clearEntryBtn.Size = new System.Drawing.Size(138, 109);
            this.clearEntryBtn.TabIndex = 1;
            this.clearEntryBtn.Text = "CE";
            this.clearEntryBtn.UseVisualStyleBackColor = true;
            this.clearEntryBtn.Click += new System.EventHandler(this.clearEntryBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 644);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "TInfo-200Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button clearEntryBtn;
        private System.Windows.Forms.Button equalsBtn;
        private System.Windows.Forms.Button decimalPtBtn;
        private System.Windows.Forms.Button num0Btn;
        private System.Windows.Forms.Button posNegBtn;
        private System.Windows.Forms.Button num3Btn;
        private System.Windows.Forms.Button num2Btn;
        private System.Windows.Forms.Button num1Btn;
        private System.Windows.Forms.Button subtractBtn;
        private System.Windows.Forms.Button num6Btn;
        private System.Windows.Forms.Button num5Btn;
        private System.Windows.Forms.Button num4Btn;
        private System.Windows.Forms.Button multiplyBtn;
        private System.Windows.Forms.Button num9Btn;
        private System.Windows.Forms.Button num8Btn;
        private System.Windows.Forms.Button num7Btn;
        private System.Windows.Forms.Button divideBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button addBtn;
    }
}

