namespace Kalkulatorprosty;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        BACKPANEL = new System.Windows.Forms.Panel();
        PLUS = new System.Windows.Forms.Button();
        EQUAL = new System.Windows.Forms.Button();
        NUM0 = new System.Windows.Forms.Button();
        CHANGE = new System.Windows.Forms.Button();
        MINUS = new System.Windows.Forms.Button();
        NUM3 = new System.Windows.Forms.Button();
        NUM2 = new System.Windows.Forms.Button();
        NUM1 = new System.Windows.Forms.Button();
        MULTIPLY = new System.Windows.Forms.Button();
        NUM6 = new System.Windows.Forms.Button();
        NUM5 = new System.Windows.Forms.Button();
        NUM4 = new System.Windows.Forms.Button();
        DIVIDE = new System.Windows.Forms.Button();
        NUM9 = new System.Windows.Forms.Button();
        NUM8 = new System.Windows.Forms.Button();
        NUM7 = new System.Windows.Forms.Button();
        DOT = new System.Windows.Forms.Button();
        CLEARALL = new System.Windows.Forms.Button();
        CLEARROW = new System.Windows.Forms.Button();
        BCKSPC = new System.Windows.Forms.Button();
        numOut = new System.Windows.Forms.TextBox();
        BACKPANEL.SuspendLayout();
        SuspendLayout();
        // 
        // BACKPANEL
        // 
        BACKPANEL.BackColor = System.Drawing.SystemColors.ActiveBorder;
        BACKPANEL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        BACKPANEL.Controls.Add(PLUS);
        BACKPANEL.Controls.Add(EQUAL);
        BACKPANEL.Controls.Add(NUM0);
        BACKPANEL.Controls.Add(CHANGE);
        BACKPANEL.Controls.Add(MINUS);
        BACKPANEL.Controls.Add(NUM3);
        BACKPANEL.Controls.Add(NUM2);
        BACKPANEL.Controls.Add(NUM1);
        BACKPANEL.Controls.Add(MULTIPLY);
        BACKPANEL.Controls.Add(NUM6);
        BACKPANEL.Controls.Add(NUM5);
        BACKPANEL.Controls.Add(NUM4);
        BACKPANEL.Controls.Add(DIVIDE);
        BACKPANEL.Controls.Add(NUM9);
        BACKPANEL.Controls.Add(NUM8);
        BACKPANEL.Controls.Add(NUM7);
        BACKPANEL.Controls.Add(DOT);
        BACKPANEL.Controls.Add(CLEARALL);
        BACKPANEL.Controls.Add(CLEARROW);
        BACKPANEL.Controls.Add(BCKSPC);
        BACKPANEL.Controls.Add(numOut);
        BACKPANEL.Location = new System.Drawing.Point(10, 5);
        BACKPANEL.Name = "BACKPANEL";
        BACKPANEL.Size = new System.Drawing.Size(349, 488);
        BACKPANEL.TabIndex = 0;
        // 
        // PLUS
        // 
        PLUS.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        PLUS.Location = new System.Drawing.Point(269, 406);
        PLUS.Name = "PLUS";
        PLUS.Size = new System.Drawing.Size(66, 67);
        PLUS.TabIndex = 20;
        PLUS.Text = "+";
        PLUS.UseVisualStyleBackColor = true;
        PLUS.Click += PLUS_Click;
        // 
        // EQUAL
        // 
        EQUAL.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        EQUAL.Location = new System.Drawing.Point(182, 406);
        EQUAL.Name = "EQUAL";
        EQUAL.Size = new System.Drawing.Size(66, 67);
        EQUAL.TabIndex = 19;
        EQUAL.Text = "=";
        EQUAL.UseVisualStyleBackColor = true;
        EQUAL.Click += EQUAL_Click;
        // 
        // NUM0
        // 
        NUM0.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        NUM0.Location = new System.Drawing.Point(7, 406);
        NUM0.Name = "NUM0";
        NUM0.Size = new System.Drawing.Size(66, 67);
        NUM0.TabIndex = 18;
        NUM0.Text = "0";
        NUM0.UseVisualStyleBackColor = true;
        NUM0.Click += NUM0_Click;
        // 
        // CHANGE
        // 
        CHANGE.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        CHANGE.Location = new System.Drawing.Point(7, 86);
        CHANGE.Name = "CHANGE";
        CHANGE.Size = new System.Drawing.Size(66, 67);
        CHANGE.TabIndex = 17;
        CHANGE.Text = "+-";
        CHANGE.UseVisualStyleBackColor = true;
        CHANGE.Click += CHANGE_Click;
        // 
        // MINUS
        // 
        MINUS.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        MINUS.Location = new System.Drawing.Point(269, 323);
        MINUS.Name = "MINUS";
        MINUS.Size = new System.Drawing.Size(66, 67);
        MINUS.TabIndex = 16;
        MINUS.Text = "-";
        MINUS.UseVisualStyleBackColor = true;
        MINUS.Click += MINUS_Click;
        // 
        // NUM3
        // 
        NUM3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        NUM3.Location = new System.Drawing.Point(182, 323);
        NUM3.Name = "NUM3";
        NUM3.Size = new System.Drawing.Size(66, 67);
        NUM3.TabIndex = 15;
        NUM3.Text = "3";
        NUM3.UseVisualStyleBackColor = true;
        NUM3.Click += NUM3_Click;
        // 
        // NUM2
        // 
        NUM2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        NUM2.Location = new System.Drawing.Point(90, 323);
        NUM2.Name = "NUM2";
        NUM2.Size = new System.Drawing.Size(66, 67);
        NUM2.TabIndex = 14;
        NUM2.Text = "2";
        NUM2.UseVisualStyleBackColor = true;
        NUM2.Click += NUM2_Click;
        // 
        // NUM1
        // 
        NUM1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        NUM1.Location = new System.Drawing.Point(7, 323);
        NUM1.Name = "NUM1";
        NUM1.Size = new System.Drawing.Size(66, 67);
        NUM1.TabIndex = 13;
        NUM1.Text = "1";
        NUM1.UseVisualStyleBackColor = true;
        NUM1.Click += NUM1_Click;
        // 
        // MULTIPLY
        // 
        MULTIPLY.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        MULTIPLY.Location = new System.Drawing.Point(269, 250);
        MULTIPLY.Name = "MULTIPLY";
        MULTIPLY.Size = new System.Drawing.Size(66, 67);
        MULTIPLY.TabIndex = 12;
        MULTIPLY.Text = "*";
        MULTIPLY.UseVisualStyleBackColor = true;
        MULTIPLY.Click += MULTIPLY_Click;
        // 
        // NUM6
        // 
        NUM6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        NUM6.Location = new System.Drawing.Point(182, 250);
        NUM6.Name = "NUM6";
        NUM6.Size = new System.Drawing.Size(66, 67);
        NUM6.TabIndex = 11;
        NUM6.Text = "6";
        NUM6.UseVisualStyleBackColor = true;
        NUM6.Click += NUM6_Click;
        // 
        // NUM5
        // 
        NUM5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        NUM5.Location = new System.Drawing.Point(90, 250);
        NUM5.Name = "NUM5";
        NUM5.Size = new System.Drawing.Size(66, 67);
        NUM5.TabIndex = 10;
        NUM5.Text = "5";
        NUM5.UseVisualStyleBackColor = true;
        NUM5.Click += NUM5_Click;
        // 
        // NUM4
        // 
        NUM4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        NUM4.Location = new System.Drawing.Point(7, 250);
        NUM4.Name = "NUM4";
        NUM4.Size = new System.Drawing.Size(66, 67);
        NUM4.TabIndex = 9;
        NUM4.Text = "4";
        NUM4.UseVisualStyleBackColor = true;
        NUM4.Click += NUM4_Click;
        // 
        // DIVIDE
        // 
        DIVIDE.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        DIVIDE.Location = new System.Drawing.Point(269, 174);
        DIVIDE.Name = "DIVIDE";
        DIVIDE.Size = new System.Drawing.Size(66, 67);
        DIVIDE.TabIndex = 8;
        DIVIDE.Text = "/";
        DIVIDE.UseVisualStyleBackColor = true;
        DIVIDE.Click += DIVIDE_Click;
        // 
        // NUM9
        // 
        NUM9.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        NUM9.Location = new System.Drawing.Point(182, 174);
        NUM9.Name = "NUM9";
        NUM9.Size = new System.Drawing.Size(66, 67);
        NUM9.TabIndex = 7;
        NUM9.Text = "9";
        NUM9.UseVisualStyleBackColor = true;
        NUM9.Click += NUM9_Click;
        // 
        // NUM8
        // 
        NUM8.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        NUM8.Location = new System.Drawing.Point(90, 174);
        NUM8.Name = "NUM8";
        NUM8.Size = new System.Drawing.Size(66, 67);
        NUM8.TabIndex = 6;
        NUM8.Text = "8";
        NUM8.UseVisualStyleBackColor = true;
        NUM8.Click += NUM8_Click;
        // 
        // NUM7
        // 
        NUM7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        NUM7.Location = new System.Drawing.Point(7, 174);
        NUM7.Name = "NUM7";
        NUM7.Size = new System.Drawing.Size(66, 67);
        NUM7.TabIndex = 5;
        NUM7.Text = "7";
        NUM7.UseVisualStyleBackColor = true;
        NUM7.Click += NUM7_Click;
        // 
        // DOT
        // 
        DOT.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        DOT.Location = new System.Drawing.Point(90, 406);
        DOT.Name = "DOT";
        DOT.Size = new System.Drawing.Size(66, 67);
        DOT.TabIndex = 4;
        DOT.Text = ".";
        DOT.UseVisualStyleBackColor = true;
        DOT.Click += button4_Click;
        // 
        // CLEARALL
        // 
        CLEARALL.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        CLEARALL.Location = new System.Drawing.Point(182, 86);
        CLEARALL.Name = "CLEARALL";
        CLEARALL.Size = new System.Drawing.Size(66, 67);
        CLEARALL.TabIndex = 3;
        CLEARALL.Text = "C";
        CLEARALL.UseVisualStyleBackColor = true;
        CLEARALL.Click += CLEARALL_Click;
        // 
        // CLEARROW
        // 
        CLEARROW.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        CLEARROW.Location = new System.Drawing.Point(90, 86);
        CLEARROW.Name = "CLEARROW";
        CLEARROW.Size = new System.Drawing.Size(66, 67);
        CLEARROW.TabIndex = 2;
        CLEARROW.Text = "CE";
        CLEARROW.UseVisualStyleBackColor = true;
        CLEARROW.Click += CLEARROW_Click;
        // 
        // BCKSPC
        // 
        BCKSPC.Font = new System.Drawing.Font("Wingdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)2));
        BCKSPC.Location = new System.Drawing.Point(269, 86);
        BCKSPC.Name = "BCKSPC";
        BCKSPC.Size = new System.Drawing.Size(66, 67);
        BCKSPC.TabIndex = 1;
        BCKSPC.Text = "";
        BCKSPC.UseVisualStyleBackColor = true;
        BCKSPC.Click += BCKSPC_Click;
        // 
        // numOut
        // 
        numOut.BackColor = System.Drawing.Color.DeepPink;
        numOut.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        numOut.Location = new System.Drawing.Point(7, 7);
        numOut.Multiline = true;
        numOut.Name = "numOut";
        numOut.Size = new System.Drawing.Size(328, 65);
        numOut.TabIndex = 0;
        numOut.Text = "0";
        numOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.HotPink;
        ClientSize = new System.Drawing.Size(373, 501);
        Controls.Add(BACKPANEL);
        Location = new System.Drawing.Point(15, 15);
        Load += Form1_Load;
        BACKPANEL.ResumeLayout(false);
        BACKPANEL.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel BACKPANEL;

    private System.Windows.Forms.Button MULTIPLY;
    private System.Windows.Forms.Button NUM6;
    private System.Windows.Forms.Button NUM5;
    private System.Windows.Forms.Button NUM4;
    private System.Windows.Forms.Button MINUS;
    private System.Windows.Forms.Button NUM3;
    private System.Windows.Forms.Button NUM2;
    private System.Windows.Forms.Button NUM1;
    private System.Windows.Forms.Button PLUS;
    private System.Windows.Forms.Button EQUAL;
    private System.Windows.Forms.Button NUM0;
    private System.Windows.Forms.Button CHANGE;

    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button NUM7;
    private System.Windows.Forms.Button NUM8;
    private System.Windows.Forms.Button NUM9;
    private System.Windows.Forms.Button DIVIDE;

    private System.Windows.Forms.Button CLEARROW;
    private System.Windows.Forms.Button CLEARALL;

    private System.Windows.Forms.Button BCKSPC;

    private System.Windows.Forms.TextBox numOut;

    private System.Windows.Forms.Button DOT;

    #endregion
}