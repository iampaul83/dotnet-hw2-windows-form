namespace Homework2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ansLabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tooltipLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ansLabel2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.diceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "1 + 2 + ... +";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(45, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.onTextBox1Changed);
            // 
            // ansLabel1
            // 
            this.ansLabel1.AutoSize = true;
            this.ansLabel1.Location = new System.Drawing.Point(130, 71);
            this.ansLabel1.Name = "ansLabel1";
            this.ansLabel1.Size = new System.Drawing.Size(11, 12);
            this.ansLabel1.TabIndex = 3;
            this.ansLabel1.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "1. 計算1加到n的值";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "2. 判斷是否為質數";
            // 
            // tooltipLabel
            // 
            this.tooltipLabel.AutoSize = true;
            this.tooltipLabel.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tooltipLabel.Location = new System.Drawing.Point(202, 141);
            this.tooltipLabel.Name = "tooltipLabel";
            this.tooltipLabel.Size = new System.Drawing.Size(11, 12);
            this.tooltipLabel.TabIndex = 6;
            this.tooltipLabel.Text = "?";
            this.toolTip1.SetToolTip(this.tooltipLabel, "在大於1的自然數中，除了1和本身外，無法被其他自然數整除的數");
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 191);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(66, 22);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "1";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.onTextBox2Changed);
            // 
            // ansLabel2
            // 
            this.ansLabel2.AutoSize = true;
            this.ansLabel2.Location = new System.Drawing.Point(91, 194);
            this.ansLabel2.Name = "ansLabel2";
            this.ansLabel2.Size = new System.Drawing.Size(66, 12);
            this.ansLabel2.TabIndex = 8;
            this.ansLabel2.Text = "-> 不是質數";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "3. 骰子";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(16, 304);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // diceButton
            // 
            this.diceButton.Location = new System.Drawing.Point(113, 253);
            this.diceButton.Name = "diceButton";
            this.diceButton.Size = new System.Drawing.Size(100, 23);
            this.diceButton.TabIndex = 11;
            this.diceButton.Text = "按住以骰骰子";
            this.diceButton.UseVisualStyleBackColor = true;
            this.diceButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onStartRandomDice);
            this.diceButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onStopRandomDice);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 467);
            this.Controls.Add(this.diceButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ansLabel2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tooltipLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ansLabel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ansLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tooltipLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label ansLabel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button diceButton;
    }
}

