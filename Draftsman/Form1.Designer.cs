namespace Draftsman
{
    partial class Board
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
            btnRectangle = new Button();
            btnTriangle = new Button();
            btnCircle = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // btnRectangle
            // 
            btnRectangle.Cursor = Cursors.Hand;
            btnRectangle.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRectangle.Location = new Point(12, 12);
            btnRectangle.Name = "btnRectangle";
            btnRectangle.Size = new Size(168, 67);
            btnRectangle.TabIndex = 0;
            btnRectangle.Text = "Rectangle";
            btnRectangle.UseVisualStyleBackColor = true;
            btnRectangle.Click += btnRectangle_Click;
            // 
            // btnTriangle
            // 
            btnTriangle.Cursor = Cursors.Hand;
            btnTriangle.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTriangle.Location = new Point(12, 85);
            btnTriangle.Name = "btnTriangle";
            btnTriangle.Size = new Size(168, 67);
            btnTriangle.TabIndex = 1;
            btnTriangle.Text = "Triangle";
            btnTriangle.UseVisualStyleBackColor = true;
            // 
            // btnCircle
            // 
            btnCircle.Cursor = Cursors.Hand;
            btnCircle.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCircle.Location = new Point(12, 158);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(168, 67);
            btnCircle.TabIndex = 2;
            btnCircle.Text = "Circle";
            btnCircle.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Cursor = Cursors.Hand;
            btnReset.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Location = new Point(92, 231);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(88, 28);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // Board
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(btnCircle);
            Controls.Add(btnTriangle);
            Controls.Add(btnRectangle);
            Name = "Board";
            Text = "Board";
            Load += Board_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnRectangle;
        private Button btnTriangle;
        private Button btnCircle;
        private Button btnReset;
    }
}
