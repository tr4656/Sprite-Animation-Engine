namespace GraphicsEngine
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
            this.components = new System.ComponentModel.Container();
            this.pboxPlayground = new System.Windows.Forms.PictureBox();
            this.btnLoadAnim = new System.Windows.Forms.Button();
            this.btnRemAnim = new System.Windows.Forms.Button();
            this.btnUseSet = new System.Windows.Forms.Button();
            this.txtboxFPS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbooxSpeed = new System.Windows.Forms.TextBox();
            this.txtboxAnimPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxFrameAnimNum = new System.Windows.Forms.TextBox();
            this.tmrRender = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pboxPlayground)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxPlayground
            // 
            this.pboxPlayground.Location = new System.Drawing.Point(12, 12);
            this.pboxPlayground.Name = "pboxPlayground";
            this.pboxPlayground.Size = new System.Drawing.Size(912, 282);
            this.pboxPlayground.TabIndex = 0;
            this.pboxPlayground.TabStop = false;
            this.pboxPlayground.Paint += new System.Windows.Forms.PaintEventHandler(this.pboxPlayground_Paint);
            // 
            // btnLoadAnim
            // 
            this.btnLoadAnim.Location = new System.Drawing.Point(13, 480);
            this.btnLoadAnim.Name = "btnLoadAnim";
            this.btnLoadAnim.Size = new System.Drawing.Size(75, 42);
            this.btnLoadAnim.TabIndex = 1;
            this.btnLoadAnim.Text = "Load Animation";
            this.btnLoadAnim.UseVisualStyleBackColor = true;
            this.btnLoadAnim.Click += new System.EventHandler(this.btnLoadAnim_Click);
            // 
            // btnRemAnim
            // 
            this.btnRemAnim.Location = new System.Drawing.Point(113, 480);
            this.btnRemAnim.Name = "btnRemAnim";
            this.btnRemAnim.Size = new System.Drawing.Size(75, 42);
            this.btnRemAnim.TabIndex = 2;
            this.btnRemAnim.Text = "Remove Animation";
            this.btnRemAnim.UseVisualStyleBackColor = true;
            this.btnRemAnim.Click += new System.EventHandler(this.btnRemAnim_Click);
            // 
            // btnUseSet
            // 
            this.btnUseSet.Location = new System.Drawing.Point(849, 480);
            this.btnUseSet.Name = "btnUseSet";
            this.btnUseSet.Size = new System.Drawing.Size(75, 42);
            this.btnUseSet.TabIndex = 3;
            this.btnUseSet.Text = "Use Settings";
            this.btnUseSet.UseVisualStyleBackColor = true;
            this.btnUseSet.Click += new System.EventHandler(this.btnUseSet_Click);
            // 
            // txtboxFPS
            // 
            this.txtboxFPS.Location = new System.Drawing.Point(715, 502);
            this.txtboxFPS.Name = "txtboxFPS";
            this.txtboxFPS.Size = new System.Drawing.Size(100, 20);
            this.txtboxFPS.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(660, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "FPS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(644, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Speed";
            // 
            // txtbooxSpeed
            // 
            this.txtbooxSpeed.Location = new System.Drawing.Point(715, 456);
            this.txtbooxSpeed.Name = "txtbooxSpeed";
            this.txtbooxSpeed.Size = new System.Drawing.Size(100, 20);
            this.txtbooxSpeed.TabIndex = 7;
            // 
            // txtboxAnimPath
            // 
            this.txtboxAnimPath.Location = new System.Drawing.Point(13, 454);
            this.txtboxAnimPath.Name = "txtboxAnimPath";
            this.txtboxAnimPath.Size = new System.Drawing.Size(100, 20);
            this.txtboxAnimPath.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Animation Path";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Frames Of Animation";
            // 
            // txtboxFrameAnimNum
            // 
            this.txtboxFrameAnimNum.Location = new System.Drawing.Point(12, 394);
            this.txtboxFrameAnimNum.Name = "txtboxFrameAnimNum";
            this.txtboxFrameAnimNum.Size = new System.Drawing.Size(100, 20);
            this.txtboxFrameAnimNum.TabIndex = 11;
            // 
            // tmrRender
            // 
            this.tmrRender.Interval = 1;
            this.tmrRender.Tick += new System.EventHandler(this.tmrRender_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 534);
            this.Controls.Add(this.txtboxFrameAnimNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxAnimPath);
            this.Controls.Add(this.txtbooxSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxFPS);
            this.Controls.Add(this.btnUseSet);
            this.Controls.Add(this.btnRemAnim);
            this.Controls.Add(this.btnLoadAnim);
            this.Controls.Add(this.pboxPlayground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pboxPlayground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxPlayground;
        private System.Windows.Forms.Button btnLoadAnim;
        private System.Windows.Forms.Button btnRemAnim;
        private System.Windows.Forms.Button btnUseSet;
        private System.Windows.Forms.TextBox txtboxFPS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbooxSpeed;
        private System.Windows.Forms.TextBox txtboxAnimPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxFrameAnimNum;
        private System.Windows.Forms.Timer tmrRender;
    }
}

