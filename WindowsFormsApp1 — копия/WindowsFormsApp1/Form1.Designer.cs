namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Screws = new System.Windows.Forms.TextBox();
            this.LargeDoor = new System.Windows.Forms.TextBox();
            this.TableDoor = new System.Windows.Forms.TextBox();
            this.Shelf = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(588, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Внести изменения в таблицу";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(634, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(309, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Рассчитать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Screws
            // 
            this.Screws.Location = new System.Drawing.Point(634, 33);
            this.Screws.Name = "Screws";
            this.Screws.Size = new System.Drawing.Size(309, 20);
            this.Screws.TabIndex = 3;
            // 
            // LargeDoor
            // 
            this.LargeDoor.Location = new System.Drawing.Point(634, 77);
            this.LargeDoor.Name = "LargeDoor";
            this.LargeDoor.Size = new System.Drawing.Size(309, 20);
            this.LargeDoor.TabIndex = 4;
            // 
            // TableDoor
            // 
            this.TableDoor.Location = new System.Drawing.Point(634, 121);
            this.TableDoor.Name = "TableDoor";
            this.TableDoor.Size = new System.Drawing.Size(309, 20);
            this.TableDoor.TabIndex = 5;
            // 
            // Shelf
            // 
            this.Shelf.Location = new System.Drawing.Point(634, 165);
            this.Shelf.Name = "Shelf";
            this.Shelf.Size = new System.Drawing.Size(309, 20);
            this.Shelf.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(634, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(314, 27);
            this.button3.TabIndex = 7;
            this.button3.Text = "Не ограниченное количесвто ресурсов";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(588, 382);
            this.dataGridView1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(631, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Количество полок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(631, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Количество дверей тумбочки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(631, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Количество больших дверей";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(631, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Количество саморезов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Shelf);
            this.Controls.Add(this.TableDoor);
            this.Controls.Add(this.LargeDoor);
            this.Controls.Add(this.Screws);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Screws;
        private System.Windows.Forms.TextBox LargeDoor;
        private System.Windows.Forms.TextBox TableDoor;
        private System.Windows.Forms.TextBox Shelf;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

