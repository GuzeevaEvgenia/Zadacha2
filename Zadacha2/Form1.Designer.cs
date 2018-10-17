namespace Zadacha2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_Type = new System.Windows.Forms.TextBox();
            this.TB_cableCores = new System.Windows.Forms.TextBox();
            this.TB_diameter = new System.Windows.Forms.TextBox();
            this.TB_Result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.But_Add = new System.Windows.Forms.Button();
            this.But_Show_1 = new System.Windows.Forms.Button();
            this.But_Show_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_Type
            // 
            this.TB_Type.Location = new System.Drawing.Point(230, 51);
            this.TB_Type.Multiline = true;
            this.TB_Type.Name = "TB_Type";
            this.TB_Type.Size = new System.Drawing.Size(125, 51);
            this.TB_Type.TabIndex = 0;
            // 
            // TB_cableCores
            // 
            this.TB_cableCores.Location = new System.Drawing.Point(230, 124);
            this.TB_cableCores.Multiline = true;
            this.TB_cableCores.Name = "TB_cableCores";
            this.TB_cableCores.Size = new System.Drawing.Size(125, 50);
            this.TB_cableCores.TabIndex = 1;
            // 
            // TB_diameter
            // 
            this.TB_diameter.Location = new System.Drawing.Point(230, 206);
            this.TB_diameter.Multiline = true;
            this.TB_diameter.Name = "TB_diameter";
            this.TB_diameter.Size = new System.Drawing.Size(125, 50);
            this.TB_diameter.TabIndex = 2;
            // 
            // TB_Result
            // 
            this.TB_Result.Location = new System.Drawing.Point(230, 290);
            this.TB_Result.Multiline = true;
            this.TB_Result.Name = "TB_Result";
            this.TB_Result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TB_Result.Size = new System.Drawing.Size(125, 59);
            this.TB_Result.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "CableCores:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Diameter:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Result:";
            // 
            // But_Add
            // 
            this.But_Add.Location = new System.Drawing.Point(455, 51);
            this.But_Add.Name = "But_Add";
            this.But_Add.Size = new System.Drawing.Size(154, 51);
            this.But_Add.TabIndex = 8;
            this.But_Add.Text = "Добавить кабель";
            this.But_Add.UseVisualStyleBackColor = true;
            // 
            // But_Show_1
            // 
            this.But_Show_1.Location = new System.Drawing.Point(455, 167);
            this.But_Show_1.Name = "But_Show_1";
            this.But_Show_1.Size = new System.Drawing.Size(154, 51);
            this.But_Show_1.TabIndex = 9;
            this.But_Show_1.Text = "Качество1";
            this.But_Show_1.UseVisualStyleBackColor = true;
            // 
            // But_Show_2
            // 
            this.But_Show_2.Location = new System.Drawing.Point(455, 277);
            this.But_Show_2.Name = "But_Show_2";
            this.But_Show_2.Size = new System.Drawing.Size(154, 51);
            this.But_Show_2.TabIndex = 10;
            this.But_Show_2.Text = "Качество2";
            this.But_Show_2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 598);
            this.Controls.Add(this.But_Show_2);
            this.Controls.Add(this.But_Show_1);
            this.Controls.Add(this.But_Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Result);
            this.Controls.Add(this.TB_diameter);
            this.Controls.Add(this.TB_cableCores);
            this.Controls.Add(this.TB_Type);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Type;
        private System.Windows.Forms.TextBox TB_cableCores;
        private System.Windows.Forms.TextBox TB_diameter;
        private System.Windows.Forms.TextBox TB_Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button But_Add;
        private System.Windows.Forms.Button But_Show_1;
        private System.Windows.Forms.Button But_Show_2;
    }
}

