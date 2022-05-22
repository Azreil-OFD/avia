using System.Windows.Forms;

namespace Avia
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BTN_download = new System.Windows.Forms.Button();
            this.BTN_add = new System.Windows.Forms.Button();
            this.BTN_update = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Кодклиента = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Фамилия = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Имя = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Отчество = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ДатаРождение = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ДанныеПаспорта = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Адрес = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Телефон = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BTN_download);
            this.flowLayoutPanel1.Controls.Add(this.BTN_add);
            this.flowLayoutPanel1.Controls.Add(this.BTN_update);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 420);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 30);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // BTN_download
            // 
            this.BTN_download.Location = new System.Drawing.Point(3, 3);
            this.BTN_download.Name = "BTN_download";
            this.BTN_download.Size = new System.Drawing.Size(75, 23);
            this.BTN_download.TabIndex = 0;
            this.BTN_download.Text = "Загрузить";
            this.BTN_download.UseVisualStyleBackColor = true;
            this.BTN_download.Click += new System.EventHandler(this.button_download_Click);
            // 
            // BTN_add
            // 
            this.BTN_add.Location = new System.Drawing.Point(84, 3);
            this.BTN_add.Name = "BTN_add";
            this.BTN_add.Size = new System.Drawing.Size(75, 23);
            this.BTN_add.TabIndex = 1;
            this.BTN_add.TabStop = false;
            this.BTN_add.Text = "Добавить";
            this.BTN_add.UseVisualStyleBackColor = true;
            this.BTN_add.Click += new System.EventHandler(this.BTN_add_Click);
            // 
            // BTN_update
            // 
            this.BTN_update.Location = new System.Drawing.Point(165, 3);
            this.BTN_update.Name = "BTN_update";
            this.BTN_update.Size = new System.Drawing.Size(75, 23);
            this.BTN_update.TabIndex = 2;
            this.BTN_update.Text = "изменить";
            this.BTN_update.UseVisualStyleBackColor = true;
            this.BTN_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(246, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Кодклиента,
            this.Фамилия,
            this.Имя,
            this.Отчество,
            this.ДатаРождение,
            this.ДанныеПаспорта,
            this.Адрес,
            this.Телефон});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 420);
            this.dataGridView1.TabIndex = 0;
            // 
            // Кодклиента
            // 
            this.Кодклиента.HeaderText = "Кодклиента";
            this.Кодклиента.Name = "Кодклиента";
            this.Кодклиента.ReadOnly = true;
            // 
            // Фамилия
            // 
            this.Фамилия.HeaderText = "Фамилия";
            this.Фамилия.Name = "Фамилия";
            this.Фамилия.ReadOnly = true;
            // 
            // Имя
            // 
            this.Имя.HeaderText = "Имя";
            this.Имя.Name = "Имя";
            this.Имя.ReadOnly = true;
            // 
            // Отчество
            // 
            this.Отчество.HeaderText = "Отчествоs";
            this.Отчество.Name = "Отчество";
            this.Отчество.ReadOnly = true;
            // 
            // ДатаРождение
            // 
            this.ДатаРождение.HeaderText = "ДатаРождение";
            this.ДатаРождение.Name = "ДатаРождение";
            this.ДатаРождение.ReadOnly = true;
            // 
            // ДанныеПаспорта
            // 
            this.ДанныеПаспорта.HeaderText = "ДанныеПаспорта";
            this.ДанныеПаспорта.Name = "ДанныеПаспорта";
            this.ДанныеПаспорта.ReadOnly = true;
            // 
            // Адрес
            // 
            this.Адрес.HeaderText = "Адрес";
            this.Адрес.Name = "Адрес";
            this.Адрес.ReadOnly = true;
            // 
            // Телефон
            // 
            this.Телефон.HeaderText = "Телефон";
            this.Телефон.Name = "Телефон";
            this.Телефон.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BTN_download;
        private System.Windows.Forms.Button BTN_add;
        private System.Windows.Forms.Button BTN_update;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Кодклиента;
        private DataGridViewTextBoxColumn Фамилия;
        private DataGridViewTextBoxColumn Имя;
        private DataGridViewTextBoxColumn Отчество;
        private DataGridViewTextBoxColumn ДатаРождение;
        private DataGridViewTextBoxColumn ДанныеПаспорта;
        private DataGridViewTextBoxColumn Адрес;
        private DataGridViewTextBoxColumn Телефон;
    }
}

