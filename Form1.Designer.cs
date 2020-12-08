namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.outbut = new System.Windows.Forms.Button();
            this.fan = new System.Windows.Forms.Button();
            this.power = new System.Windows.Forms.Button();
            this.coke = new System.Windows.Forms.Button();
            this.cider = new System.Windows.Forms.Button();
            this.po = new System.Windows.Forms.Button();
            this.insert1000 = new System.Windows.Forms.Button();
            this.insert5000 = new System.Windows.Forms.Button();
            this.insert10000 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // outbut
            // 
            this.outbut.Location = new System.Drawing.Point(297, 281);
            this.outbut.Name = "outbut";
            this.outbut.Size = new System.Drawing.Size(80, 20);
            this.outbut.TabIndex = 0;
            this.outbut.Text = "꺼내기";
            this.outbut.UseVisualStyleBackColor = true;
            this.outbut.Click += new System.EventHandler(this.outbut_Click);
            // 
            // fan
            // 
            this.fan.Font = new System.Drawing.Font("휴먼매직체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.fan.Location = new System.Drawing.Point(125, 150);
            this.fan.Name = "fan";
            this.fan.Size = new System.Drawing.Size(80, 50);
            this.fan.TabIndex = 2;
            this.fan.Text = "환타\r\n1500원";
            this.fan.UseVisualStyleBackColor = true;
            this.fan.Click += new System.EventHandler(this.fan_Click);
            // 
            // power
            // 
            this.power.Font = new System.Drawing.Font("휴먼매직체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.power.Location = new System.Drawing.Point(211, 150);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(80, 50);
            this.power.TabIndex = 3;
            this.power.Text = "파워에이드\r\n1700원";
            this.power.UseVisualStyleBackColor = true;
            this.power.Click += new System.EventHandler(this.power_Click);
            // 
            // coke
            // 
            this.coke.Font = new System.Drawing.Font("휴먼매직체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.coke.Location = new System.Drawing.Point(297, 150);
            this.coke.Name = "coke";
            this.coke.Size = new System.Drawing.Size(80, 50);
            this.coke.TabIndex = 3;
            this.coke.Text = "콜라\r\n900원";
            this.coke.UseVisualStyleBackColor = true;
            this.coke.Click += new System.EventHandler(this.coke_Click);
            // 
            // cider
            // 
            this.cider.Font = new System.Drawing.Font("휴먼매직체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cider.Location = new System.Drawing.Point(383, 150);
            this.cider.Name = "cider";
            this.cider.Size = new System.Drawing.Size(80, 50);
            this.cider.TabIndex = 3;
            this.cider.Text = "사이다\r\n1200원";
            this.cider.UseVisualStyleBackColor = true;
            this.cider.Click += new System.EventHandler(this.cider_Click);
            // 
            // po
            // 
            this.po.Font = new System.Drawing.Font("휴먼매직체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.po.Location = new System.Drawing.Point(39, 150);
            this.po.Name = "po";
            this.po.Size = new System.Drawing.Size(80, 50);
            this.po.TabIndex = 2;
            this.po.Text = "포카리\r\n1000원";
            this.po.UseVisualStyleBackColor = true;
            this.po.Click += new System.EventHandler(this.po_Click);
            // 
            // insert1000
            // 
            this.insert1000.Location = new System.Drawing.Point(530, 195);
            this.insert1000.Name = "insert1000";
            this.insert1000.Size = new System.Drawing.Size(80, 50);
            this.insert1000.TabIndex = 6;
            this.insert1000.Text = "1000원";
            this.insert1000.UseVisualStyleBackColor = true;
            this.insert1000.Click += new System.EventHandler(this.insert1000_Click);
            // 
            // insert5000
            // 
            this.insert5000.Location = new System.Drawing.Point(530, 251);
            this.insert5000.Name = "insert5000";
            this.insert5000.Size = new System.Drawing.Size(80, 50);
            this.insert5000.TabIndex = 6;
            this.insert5000.Text = "5000원";
            this.insert5000.UseVisualStyleBackColor = true;
            this.insert5000.Click += new System.EventHandler(this.insert5000_Click);
            // 
            // insert10000
            // 
            this.insert10000.Location = new System.Drawing.Point(530, 307);
            this.insert10000.Name = "insert10000";
            this.insert10000.Size = new System.Drawing.Size(80, 50);
            this.insert10000.TabIndex = 6;
            this.insert10000.Text = "10000원";
            this.insert10000.UseVisualStyleBackColor = true;
            this.insert10000.Click += new System.EventHandler(this.insert10000_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(517, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "현재 잔액";
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.money.ForeColor = System.Drawing.SystemColors.ControlText;
            this.money.Location = new System.Drawing.Point(527, 54);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(87, 13);
            this.money.TabIndex = 7;
            this.money.Text = "__________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("휴먼둥근헤드라인", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(526, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "돈 넣기";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("휴먼둥근헤드라인", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(32, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "배출구";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.사이다;
            this.pictureBox6.Location = new System.Drawing.Point(383, 17);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(80, 127);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.콜라;
            this.pictureBox5.Location = new System.Drawing.Point(297, 17);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(80, 127);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.파워에이드;
            this.pictureBox4.Location = new System.Drawing.Point(211, 17);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 127);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.환타;
            this.pictureBox3.Location = new System.Drawing.Point(125, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 127);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.포카리;
            this.pictureBox2.Location = new System.Drawing.Point(39, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 127);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(125, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 385);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.money);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insert10000);
            this.Controls.Add(this.insert5000);
            this.Controls.Add(this.insert1000);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cider);
            this.Controls.Add(this.coke);
            this.Controls.Add(this.power);
            this.Controls.Add(this.po);
            this.Controls.Add(this.fan);
            this.Controls.Add(this.outbut);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button outbut;
        private System.Windows.Forms.Button fan;
        private System.Windows.Forms.Button power;
        private System.Windows.Forms.Button coke;
        private System.Windows.Forms.Button cider;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button po;
        private System.Windows.Forms.Button insert1000;
        private System.Windows.Forms.Button insert5000;
        private System.Windows.Forms.Button insert10000;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label money;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label2;
    }
}

