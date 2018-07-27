namespace Записная_книжка
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AddNote = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Previous = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.DellAll = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.D18 = new System.Windows.Forms.Button();
            this.C18 = new System.Windows.Forms.Button();
            this.D17 = new System.Windows.Forms.Button();
            this.C17 = new System.Windows.Forms.Button();
            this.D16 = new System.Windows.Forms.Button();
            this.C16 = new System.Windows.Forms.Button();
            this.D15 = new System.Windows.Forms.Button();
            this.C15 = new System.Windows.Forms.Button();
            this.D14 = new System.Windows.Forms.Button();
            this.C14 = new System.Windows.Forms.Button();
            this.D13 = new System.Windows.Forms.Button();
            this.C13 = new System.Windows.Forms.Button();
            this.D12 = new System.Windows.Forms.Button();
            this.C12 = new System.Windows.Forms.Button();
            this.D11 = new System.Windows.Forms.Button();
            this.C11 = new System.Windows.Forms.Button();
            this.D10 = new System.Windows.Forms.Button();
            this.C10 = new System.Windows.Forms.Button();
            this.D9 = new System.Windows.Forms.Button();
            this.C9 = new System.Windows.Forms.Button();
            this.D8 = new System.Windows.Forms.Button();
            this.C8 = new System.Windows.Forms.Button();
            this.D7 = new System.Windows.Forms.Button();
            this.C7 = new System.Windows.Forms.Button();
            this.D6 = new System.Windows.Forms.Button();
            this.C6 = new System.Windows.Forms.Button();
            this.D5 = new System.Windows.Forms.Button();
            this.C5 = new System.Windows.Forms.Button();
            this.D4 = new System.Windows.Forms.Button();
            this.C4 = new System.Windows.Forms.Button();
            this.D3 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.D2 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.D1 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NoteB = new System.Windows.Forms.PictureBox();
            this.Background = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NoteB)).BeginInit();
            this.NoteB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            this.SuspendLayout();
            // 
            // AddNote
            // 
            this.AddNote.Image = global::Записная_книжка.Properties.Resources.add1;
            this.AddNote.Location = new System.Drawing.Point(15, 12);
            this.AddNote.Name = "AddNote";
            this.AddNote.Size = new System.Drawing.Size(48, 48);
            this.AddNote.TabIndex = 1;
            this.toolTip1.SetToolTip(this.AddNote, "Добавить запись");
            this.AddNote.UseVisualStyleBackColor = true;
            this.AddNote.Click += new System.EventHandler(this.AddNote_Click);
            // 
            // Next
            // 
            this.Next.Enabled = false;
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Next.Image = global::Записная_книжка.Properties.Resources.ArrowLeft1;
            this.Next.Location = new System.Drawing.Point(255, 12);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(48, 48);
            this.Next.TabIndex = 4;
            this.toolTip1.SetToolTip(this.Next, "Следующая страница");
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Previous
            // 
            this.Previous.Enabled = false;
            this.Previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Previous.Image = global::Записная_книжка.Properties.Resources.ArrowRight1;
            this.Previous.Location = new System.Drawing.Point(202, 12);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(48, 48);
            this.Previous.TabIndex = 5;
            this.toolTip1.SetToolTip(this.Previous, "Предыдущая страница");
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // DellAll
            // 
            this.DellAll.Image = global::Записная_книжка.Properties.Resources.корзина1;
            this.DellAll.Location = new System.Drawing.Point(123, 12);
            this.DellAll.Name = "DellAll";
            this.DellAll.Size = new System.Drawing.Size(48, 48);
            this.DellAll.TabIndex = 7;
            this.toolTip1.SetToolTip(this.DellAll, "Удалить все записи");
            this.DellAll.UseVisualStyleBackColor = true;
            this.DellAll.Click += new System.EventHandler(this.DellAll_Click);
            // 
            // Search
            // 
            this.Search.BackgroundImage = global::Записная_книжка.Properties.Resources.loupe;
            this.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Search.Location = new System.Drawing.Point(69, 12);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(48, 48);
            this.Search.TabIndex = 2;
            this.toolTip1.SetToolTip(this.Search, "Поиск по всем записям");
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // D18
            // 
            this.D18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.D18.FlatAppearance.BorderSize = 0;
            this.D18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.D18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D18.Image = global::Записная_книжка.Properties.Resources.ластик1;
            this.D18.Location = new System.Drawing.Point(610, 522);
            this.D18.Name = "D18";
            this.D18.Size = new System.Drawing.Size(26, 26);
            this.D18.TabIndex = 53;
            this.D18.TabStop = false;
            this.toolTip1.SetToolTip(this.D18, "Удалить запись");
            this.D18.UseVisualStyleBackColor = true;
            this.D18.Visible = false;
            this.D18.Click += new System.EventHandler(this.Dell_Click);
            // 
            // C18
            // 
            this.C18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C18.FlatAppearance.BorderSize = 0;
            this.C18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.C18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C18.Image = global::Записная_книжка.Properties.Resources.карандаш1;
            this.C18.Location = new System.Drawing.Point(578, 522);
            this.C18.Name = "C18";
            this.C18.Size = new System.Drawing.Size(26, 26);
            this.C18.TabIndex = 52;
            this.C18.TabStop = false;
            this.toolTip1.SetToolTip(this.C18, "Изменить запись");
            this.C18.UseVisualStyleBackColor = true;
            this.C18.Visible = false;
            this.C18.Click += new System.EventHandler(this.Change_Click);
            // 
            // D17
            // 
            this.D17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.D17.FlatAppearance.BorderSize = 0;
            this.D17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.D17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D17.Image = global::Записная_книжка.Properties.Resources.ластик1;
            this.D17.Location = new System.Drawing.Point(610, 466);
            this.D17.Name = "D17";
            this.D17.Size = new System.Drawing.Size(26, 26);
            this.D17.TabIndex = 51;
            this.D17.TabStop = false;
            this.toolTip1.SetToolTip(this.D17, "Удалить запись");
            this.D17.UseVisualStyleBackColor = true;
            this.D17.Visible = false;
            this.D17.Click += new System.EventHandler(this.Dell_Click);
            // 
            // C17
            // 
            this.C17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C17.FlatAppearance.BorderSize = 0;
            this.C17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.C17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C17.Image = global::Записная_книжка.Properties.Resources.карандаш1;
            this.C17.Location = new System.Drawing.Point(578, 466);
            this.C17.Name = "C17";
            this.C17.Size = new System.Drawing.Size(26, 26);
            this.C17.TabIndex = 50;
            this.C17.TabStop = false;
            this.toolTip1.SetToolTip(this.C17, "Изменить запись");
            this.C17.UseVisualStyleBackColor = true;
            this.C17.Visible = false;
            this.C17.Click += new System.EventHandler(this.Change_Click);
            // 
            // D16
            // 
            this.D16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.D16.FlatAppearance.BorderSize = 0;
            this.D16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.D16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D16.Image = global::Записная_книжка.Properties.Resources.ластик1;
            this.D16.Location = new System.Drawing.Point(610, 410);
            this.D16.Name = "D16";
            this.D16.Size = new System.Drawing.Size(26, 26);
            this.D16.TabIndex = 49;
            this.D16.TabStop = false;
            this.toolTip1.SetToolTip(this.D16, "Удалить запись");
            this.D16.UseVisualStyleBackColor = true;
            this.D16.Visible = false;
            this.D16.Click += new System.EventHandler(this.Dell_Click);
            // 
            // C16
            // 
            this.C16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C16.FlatAppearance.BorderSize = 0;
            this.C16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.C16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C16.Image = global::Записная_книжка.Properties.Resources.карандаш1;
            this.C16.Location = new System.Drawing.Point(578, 410);
            this.C16.Name = "C16";
            this.C16.Size = new System.Drawing.Size(26, 26);
            this.C16.TabIndex = 48;
            this.C16.TabStop = false;
            this.toolTip1.SetToolTip(this.C16, "Изменить запись");
            this.C16.UseVisualStyleBackColor = true;
            this.C16.Visible = false;
            this.C16.Click += new System.EventHandler(this.Change_Click);
            // 
            // D15
            // 
            this.D15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.D15.FlatAppearance.BorderSize = 0;
            this.D15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.D15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D15.Image = global::Записная_книжка.Properties.Resources.ластик1;
            this.D15.Location = new System.Drawing.Point(610, 354);
            this.D15.Name = "D15";
            this.D15.Size = new System.Drawing.Size(26, 26);
            this.D15.TabIndex = 47;
            this.D15.TabStop = false;
            this.toolTip1.SetToolTip(this.D15, "Удалить запись");
            this.D15.UseVisualStyleBackColor = true;
            this.D15.Visible = false;
            this.D15.Click += new System.EventHandler(this.Dell_Click);
            // 
            // C15
            // 
            this.C15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C15.FlatAppearance.BorderSize = 0;
            this.C15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.C15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C15.Image = global::Записная_книжка.Properties.Resources.карандаш1;
            this.C15.Location = new System.Drawing.Point(578, 354);
            this.C15.Name = "C15";
            this.C15.Size = new System.Drawing.Size(26, 26);
            this.C15.TabIndex = 46;
            this.C15.TabStop = false;
            this.toolTip1.SetToolTip(this.C15, "Изменить запись");
            this.C15.UseVisualStyleBackColor = true;
            this.C15.Visible = false;
            this.C15.Click += new System.EventHandler(this.Change_Click);
            // 
            // D14
            // 
            this.D14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.D14.FlatAppearance.BorderSize = 0;
            this.D14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.D14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D14.Image = global::Записная_книжка.Properties.Resources.ластик1;
            this.D14.Location = new System.Drawing.Point(610, 298);
            this.D14.Name = "D14";
            this.D14.Size = new System.Drawing.Size(26, 26);
            this.D14.TabIndex = 45;
            this.D14.TabStop = false;
            this.toolTip1.SetToolTip(this.D14, "Удалить запись");
            this.D14.UseVisualStyleBackColor = true;
            this.D14.Visible = false;
            this.D14.Click += new System.EventHandler(this.Dell_Click);
            // 
            // C14
            // 
            this.C14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C14.FlatAppearance.BorderSize = 0;
            this.C14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.C14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C14.Image = global::Записная_книжка.Properties.Resources.карандаш1;
            this.C14.Location = new System.Drawing.Point(578, 298);
            this.C14.Name = "C14";
            this.C14.Size = new System.Drawing.Size(26, 26);
            this.C14.TabIndex = 44;
            this.C14.TabStop = false;
            this.toolTip1.SetToolTip(this.C14, "Изменить запись");
            this.C14.UseVisualStyleBackColor = true;
            this.C14.Visible = false;
            this.C14.Click += new System.EventHandler(this.Change_Click);
            // 
            // D13
            // 
            this.D13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.D13.FlatAppearance.BorderSize = 0;
            this.D13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.D13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D13.Image = global::Записная_книжка.Properties.Resources.ластик1;
            this.D13.Location = new System.Drawing.Point(610, 242);
            this.D13.Name = "D13";
            this.D13.Size = new System.Drawing.Size(26, 26);
            this.D13.TabIndex = 43;
            this.D13.TabStop = false;
            this.toolTip1.SetToolTip(this.D13, "Удалить запись");
            this.D13.UseVisualStyleBackColor = true;
            this.D13.Visible = false;
            this.D13.Click += new System.EventHandler(this.Dell_Click);
            // 
            // C13
            // 
            this.C13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C13.FlatAppearance.BorderSize = 0;
            this.C13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.C13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C13.Image = global::Записная_книжка.Properties.Resources.карандаш1;
            this.C13.Location = new System.Drawing.Point(578, 242);
            this.C13.Name = "C13";
            this.C13.Size = new System.Drawing.Size(26, 26);
            this.C13.TabIndex = 42;
            this.C13.TabStop = false;
            this.toolTip1.SetToolTip(this.C13, "Изменить запись");
            this.C13.UseVisualStyleBackColor = true;
            this.C13.Visible = false;
            this.C13.Click += new System.EventHandler(this.Change_Click);
            // 
            // D12
            // 
            this.D12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.D12.FlatAppearance.BorderSize = 0;
            this.D12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.D12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D12.Image = global::Записная_книжка.Properties.Resources.ластик1;
            this.D12.Location = new System.Drawing.Point(610, 186);
            this.D12.Name = "D12";
            this.D12.Size = new System.Drawing.Size(26, 26);
            this.D12.TabIndex = 41;
            this.D12.TabStop = false;
            this.toolTip1.SetToolTip(this.D12, "Удалить запись");
            this.D12.UseVisualStyleBackColor = true;
            this.D12.Visible = false;
            this.D12.Click += new System.EventHandler(this.Dell_Click);
            // 
            // C12
            // 
            this.C12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C12.FlatAppearance.BorderSize = 0;
            this.C12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.C12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C12.Image = global::Записная_книжка.Properties.Resources.карандаш1;
            this.C12.Location = new System.Drawing.Point(578, 186);
            this.C12.Name = "C12";
            this.C12.Size = new System.Drawing.Size(26, 26);
            this.C12.TabIndex = 40;
            this.C12.TabStop = false;
            this.toolTip1.SetToolTip(this.C12, "Изменить запись");
            this.C12.UseVisualStyleBackColor = true;
            this.C12.Visible = false;
            this.C12.Click += new System.EventHandler(this.Change_Click);
            // 
            // D11
            // 
            this.D11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.D11.FlatAppearance.BorderSize = 0;
            this.D11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.D11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D11.Image = global::Записная_книжка.Properties.Resources.ластик1;
            this.D11.Location = new System.Drawing.Point(610, 130);
            this.D11.Name = "D11";
            this.D11.Size = new System.Drawing.Size(26, 26);
            this.D11.TabIndex = 39;
            this.D11.TabStop = false;
            this.toolTip1.SetToolTip(this.D11, "Удалить запись");
            this.D11.UseVisualStyleBackColor = true;
            this.D11.Visible = false;
            this.D11.Click += new System.EventHandler(this.Dell_Click);
            // 
            // C11
            // 
            this.C11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C11.FlatAppearance.BorderSize = 0;
            this.C11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.C11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C11.Image = global::Записная_книжка.Properties.Resources.карандаш1;
            this.C11.Location = new System.Drawing.Point(578, 130);
            this.C11.Name = "C11";
            this.C11.Size = new System.Drawing.Size(26, 26);
            this.C11.TabIndex = 38;
            this.C11.TabStop = false;
            this.toolTip1.SetToolTip(this.C11, "Изменить запись");
            this.C11.UseVisualStyleBackColor = true;
            this.C11.Visible = false;
            this.C11.Click += new System.EventHandler(this.Change_Click);
            // 
            // D10
            // 
            this.D10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.D10.FlatAppearance.BorderSize = 0;
            this.D10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.D10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D10.Image = global::Записная_книжка.Properties.Resources.ластик1;
            this.D10.Location = new System.Drawing.Point(610, 74);
            this.D10.Name = "D10";
            this.D10.Size = new System.Drawing.Size(26, 26);
            this.D10.TabIndex = 37;
            this.D10.TabStop = false;
            this.toolTip1.SetToolTip(this.D10, "Удалить запись");
            this.D10.UseVisualStyleBackColor = true;
            this.D10.Visible = false;
            this.D10.Click += new System.EventHandler(this.Dell_Click);
            // 
            // C10
            // 
            this.C10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C10.FlatAppearance.BorderSize = 0;
            this.C10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.C10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C10.Image = global::Записная_книжка.Properties.Resources.карандаш1;
            this.C10.Location = new System.Drawing.Point(578, 74);
            this.C10.Name = "C10";
            this.C10.Size = new System.Drawing.Size(26, 26);
            this.C10.TabIndex = 36;
            this.C10.TabStop = false;
            this.toolTip1.SetToolTip(this.C10, "Изменить запись");
            this.C10.UseVisualStyleBackColor = true;
            this.C10.Visible = false;
            this.C10.Click += new System.EventHandler(this.Change_Click);
            // 
            // D9
            // 
            this.D9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.D9.FlatAppearance.BorderSize = 0;
            this.D9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.D9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D9.Image = global::Записная_книжка.Properties.Resources.ластик1;
            this.D9.Location = new System.Drawing.Point(91, 557);
            this.D9.Name = "D9";
            this.D9.Size = new System.Drawing.Size(26, 26);
            this.D9.TabIndex = 35;
            this.D9.TabStop = false;
            this.toolTip1.SetToolTip(this.D9, "Удалить запись");
            this.D9.UseVisualStyleBackColor = true;
            this.D9.Visible = false;
            this.D9.Click += new System.EventHandler(this.Dell_Click);
            // 
            // C9
            // 
            this.C9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C9.FlatAppearance.BorderSize = 0;
            this.C9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.C9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C9.Image = global::Записная_книжка.Properties.Resources.карандаш1;
            this.C9.Location = new System.Drawing.Point(59, 557);
            this.C9.Name = "C9";
            this.C9.Size = new System.Drawing.Size(26, 26);
            this.C9.TabIndex = 34;
            this.C9.TabStop = false;
            this.toolTip1.SetToolTip(this.C9, "Изменить запись");
            this.C9.UseVisualStyleBackColor = true;
            this.C9.Visible = false;
            this.C9.Click += new System.EventHandler(this.Change_Click);
            // 
            // D8
            // 
            this.D8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.D8.FlatAppearance.BorderSize = 0;
            this.D8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.D8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D8.Image = global::Записная_книжка.Properties.Resources.ластик1;
            this.D8.Location = new System.Drawing.Point(91, 501);
            this.D8.Name = "D8";
            this.D8.Size = new System.Drawing.Size(26, 26);
            this.D8.TabIndex = 33;
            this.D8.TabStop = false;
            this.toolTip1.SetToolTip(this.D8, "Удалить запись");
            this.D8.UseVisualStyleBackColor = true;
            this.D8.Visible = false;
            this.D8.Click += new System.EventHandler(this.Dell_Click);
            // 
            // C8
            // 
            this.C8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C8.FlatAppearance.BorderSize = 0;
            this.C8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.C8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C8.Image = global::Записная_книжка.Properties.Resources.карандаш1;
            this.C8.Location = new System.Drawing.Point(59, 501);
            this.C8.Name = "C8";
            this.C8.Size = new System.Drawing.Size(26, 26);
            this.C8.TabIndex = 32;
            this.C8.TabStop = false;
            this.toolTip1.SetToolTip(this.C8, "Изменить запись");
            this.C8.UseVisualStyleBackColor = true;
            this.C8.Visible = false;
            this.C8.Click += new System.EventHandler(this.Change_Click);
            // 
            // D7
            // 
            this.D7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.D7.FlatAppearance.BorderSize = 0;
            this.D7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.D7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D7.Image = global::Записная_книжка.Properties.Resources.ластик1;
            this.D7.Location = new System.Drawing.Point(91, 445);
            this.D7.Name = "D7";
            this.D7.Size = new System.Drawing.Size(26, 26);
            this.D7.TabIndex = 31;
            this.D7.TabStop = false;
            this.toolTip1.SetToolTip(this.D7, "Удалить запись");
            this.D7.UseVisualStyleBackColor = true;
            this.D7.Visible = false;
            this.D7.Click += new System.EventHandler(this.Dell_Click);
            // 
            // C7
            // 
            this.C7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C7.FlatAppearance.BorderSize = 0;
            this.C7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.C7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C7.Image = global::Записная_книжка.Properties.Resources.карандаш1;
            this.C7.Location = new System.Drawing.Point(59, 445);
            this.C7.Name = "C7";
            this.C7.Size = new System.Drawing.Size(26, 26);
            this.C7.TabIndex = 30;
            this.C7.TabStop = false;
            this.toolTip1.SetToolTip(this.C7, "Изменить запись");
            this.C7.UseVisualStyleBackColor = true;
            this.C7.Visible = false;
            this.C7.Click += new System.EventHandler(this.Change_Click);
            // 
            // D6
            // 
            this.D6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.D6.FlatAppearance.BorderSize = 0;
            this.D6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.D6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D6.Image = global::Записная_книжка.Properties.Resources.ластик1;
            this.D6.Location = new System.Drawing.Point(91, 389);
            this.D6.Name = "D6";
            this.D6.Size = new System.Drawing.Size(26, 26);
            this.D6.TabIndex = 29;
            this.D6.TabStop = false;
            this.toolTip1.SetToolTip(this.D6, "Удалить запись");
            this.D6.UseVisualStyleBackColor = true;
            this.D6.Visible = false;
            this.D6.Click += new System.EventHandler(this.Dell_Click);
            // 
            // C6
            // 
            this.C6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C6.FlatAppearance.BorderSize = 0;
            this.C6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.C6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C6.Image = global::Записная_книжка.Properties.Resources.карандаш1;
            this.C6.Location = new System.Drawing.Point(59, 389);
            this.C6.Name = "C6";
            this.C6.Size = new System.Drawing.Size(26, 26);
            this.C6.TabIndex = 28;
            this.C6.TabStop = false;
            this.toolTip1.SetToolTip(this.C6, "Изменить запись");
            this.C6.UseVisualStyleBackColor = true;
            this.C6.Visible = false;
            this.C6.Click += new System.EventHandler(this.Change_Click);
            // 
            // D5
            // 
            this.D5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.D5.FlatAppearance.BorderSize = 0;
            this.D5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.D5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D5.Image = global::Записная_книжка.Properties.Resources.ластик1;
            this.D5.Location = new System.Drawing.Point(91, 333);
            this.D5.Name = "D5";
            this.D5.Size = new System.Drawing.Size(26, 26);
            this.D5.TabIndex = 27;
            this.D5.TabStop = false;
            this.toolTip1.SetToolTip(this.D5, "Удалить запись");
            this.D5.UseVisualStyleBackColor = true;
            this.D5.Visible = false;
            this.D5.Click += new System.EventHandler(this.Dell_Click);
            // 
            // C5
            // 
            this.C5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C5.FlatAppearance.BorderSize = 0;
            this.C5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.C5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C5.Image = global::Записная_книжка.Properties.Resources.карандаш1;
            this.C5.Location = new System.Drawing.Point(59, 333);
            this.C5.Name = "C5";
            this.C5.Size = new System.Drawing.Size(26, 26);
            this.C5.TabIndex = 26;
            this.C5.TabStop = false;
            this.toolTip1.SetToolTip(this.C5, "Изменить запись");
            this.C5.UseVisualStyleBackColor = true;
            this.C5.Visible = false;
            this.C5.Click += new System.EventHandler(this.Change_Click);
            // 
            // D4
            // 
            this.D4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.D4.FlatAppearance.BorderSize = 0;
            this.D4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.D4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D4.Image = global::Записная_книжка.Properties.Resources.ластик1;
            this.D4.Location = new System.Drawing.Point(91, 277);
            this.D4.Name = "D4";
            this.D4.Size = new System.Drawing.Size(26, 26);
            this.D4.TabIndex = 25;
            this.D4.TabStop = false;
            this.toolTip1.SetToolTip(this.D4, "Удалить запись");
            this.D4.UseVisualStyleBackColor = true;
            this.D4.Visible = false;
            this.D4.Click += new System.EventHandler(this.Dell_Click);
            // 
            // C4
            // 
            this.C4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C4.FlatAppearance.BorderSize = 0;
            this.C4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.C4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C4.Image = global::Записная_книжка.Properties.Resources.карандаш1;
            this.C4.Location = new System.Drawing.Point(59, 277);
            this.C4.Name = "C4";
            this.C4.Size = new System.Drawing.Size(26, 26);
            this.C4.TabIndex = 24;
            this.C4.TabStop = false;
            this.toolTip1.SetToolTip(this.C4, "Изменить запись");
            this.C4.UseVisualStyleBackColor = true;
            this.C4.Visible = false;
            this.C4.Click += new System.EventHandler(this.Change_Click);
            // 
            // D3
            // 
            this.D3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.D3.FlatAppearance.BorderSize = 0;
            this.D3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.D3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D3.Image = global::Записная_книжка.Properties.Resources.ластик1;
            this.D3.Location = new System.Drawing.Point(91, 221);
            this.D3.Name = "D3";
            this.D3.Size = new System.Drawing.Size(26, 26);
            this.D3.TabIndex = 23;
            this.D3.TabStop = false;
            this.toolTip1.SetToolTip(this.D3, "Удалить запись");
            this.D3.UseVisualStyleBackColor = true;
            this.D3.Visible = false;
            this.D3.Click += new System.EventHandler(this.Dell_Click);
            // 
            // C3
            // 
            this.C3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C3.FlatAppearance.BorderSize = 0;
            this.C3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.C3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C3.Image = global::Записная_книжка.Properties.Resources.карандаш1;
            this.C3.Location = new System.Drawing.Point(59, 221);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(26, 26);
            this.C3.TabIndex = 22;
            this.C3.TabStop = false;
            this.toolTip1.SetToolTip(this.C3, "Изменить запись");
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Visible = false;
            this.C3.Click += new System.EventHandler(this.Change_Click);
            // 
            // D2
            // 
            this.D2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.D2.FlatAppearance.BorderSize = 0;
            this.D2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.D2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D2.Image = global::Записная_книжка.Properties.Resources.ластик1;
            this.D2.Location = new System.Drawing.Point(91, 165);
            this.D2.Name = "D2";
            this.D2.Size = new System.Drawing.Size(26, 26);
            this.D2.TabIndex = 21;
            this.D2.TabStop = false;
            this.toolTip1.SetToolTip(this.D2, "Удалить запись");
            this.D2.UseVisualStyleBackColor = true;
            this.D2.Visible = false;
            this.D2.Click += new System.EventHandler(this.Dell_Click);
            // 
            // C2
            // 
            this.C2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C2.FlatAppearance.BorderSize = 0;
            this.C2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.C2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C2.Image = global::Записная_книжка.Properties.Resources.карандаш1;
            this.C2.Location = new System.Drawing.Point(59, 165);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(26, 26);
            this.C2.TabIndex = 20;
            this.C2.TabStop = false;
            this.toolTip1.SetToolTip(this.C2, "Изменить запись");
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Visible = false;
            this.C2.Click += new System.EventHandler(this.Change_Click);
            // 
            // D1
            // 
            this.D1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.D1.FlatAppearance.BorderSize = 0;
            this.D1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.D1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D1.Image = global::Записная_книжка.Properties.Resources.ластик1;
            this.D1.Location = new System.Drawing.Point(91, 109);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(26, 26);
            this.D1.TabIndex = 19;
            this.D1.TabStop = false;
            this.D1.Text = "-";
            this.toolTip1.SetToolTip(this.D1, "Удалить запись");
            this.D1.UseVisualStyleBackColor = true;
            this.D1.Visible = false;
            this.D1.Click += new System.EventHandler(this.Dell_Click);
            // 
            // C1
            // 
            this.C1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C1.FlatAppearance.BorderSize = 0;
            this.C1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.C1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C1.Image = global::Записная_книжка.Properties.Resources.карандаш1;
            this.C1.Location = new System.Drawing.Point(59, 109);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(26, 26);
            this.C1.TabIndex = 18;
            this.C1.TabStop = false;
            this.toolTip1.SetToolTip(this.C1, "Изменить запись");
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Visible = false;
            this.C1.Click += new System.EventHandler(this.Change_Click);
            // 
            // label10
            // 
            this.label10.AutoEllipsis = true;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(654, 75);
            this.label10.MinimumSize = new System.Drawing.Size(282, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(282, 22);
            this.label10.TabIndex = 9;
            this.label10.Visible = false;
            this.label10.Click += new System.EventHandler(this.Note_Click);
            this.label10.MouseLeave += new System.EventHandler(this.Note_MouseLeave);
            this.label10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Note_MouseMove);
            // 
            // label18
            // 
            this.label18.AutoEllipsis = true;
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label18.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(654, 523);
            this.label18.MinimumSize = new System.Drawing.Size(282, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(282, 22);
            this.label18.TabIndex = 17;
            this.label18.Visible = false;
            this.label18.Click += new System.EventHandler(this.Note_Click);
            this.label18.MouseLeave += new System.EventHandler(this.Note_MouseLeave);
            this.label18.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Note_MouseMove);
            // 
            // label17
            // 
            this.label17.AutoEllipsis = true;
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(654, 467);
            this.label17.MinimumSize = new System.Drawing.Size(282, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(282, 22);
            this.label17.TabIndex = 16;
            this.label17.Visible = false;
            this.label17.Click += new System.EventHandler(this.Note_Click);
            this.label17.MouseLeave += new System.EventHandler(this.Note_MouseLeave);
            this.label17.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Note_MouseMove);
            // 
            // label16
            // 
            this.label16.AutoEllipsis = true;
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(654, 411);
            this.label16.MinimumSize = new System.Drawing.Size(282, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(282, 22);
            this.label16.TabIndex = 15;
            this.label16.Visible = false;
            this.label16.Click += new System.EventHandler(this.Note_Click);
            this.label16.MouseLeave += new System.EventHandler(this.Note_MouseLeave);
            this.label16.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Note_MouseMove);
            // 
            // label15
            // 
            this.label15.AutoEllipsis = true;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(654, 355);
            this.label15.MinimumSize = new System.Drawing.Size(282, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(282, 22);
            this.label15.TabIndex = 14;
            this.label15.Visible = false;
            this.label15.Click += new System.EventHandler(this.Note_Click);
            this.label15.MouseLeave += new System.EventHandler(this.Note_MouseLeave);
            this.label15.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Note_MouseMove);
            // 
            // label14
            // 
            this.label14.AutoEllipsis = true;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(654, 299);
            this.label14.MinimumSize = new System.Drawing.Size(282, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(282, 22);
            this.label14.TabIndex = 13;
            this.label14.Visible = false;
            this.label14.Click += new System.EventHandler(this.Note_Click);
            this.label14.MouseLeave += new System.EventHandler(this.Note_MouseLeave);
            this.label14.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Note_MouseMove);
            // 
            // label13
            // 
            this.label13.AutoEllipsis = true;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(654, 243);
            this.label13.MinimumSize = new System.Drawing.Size(282, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(282, 22);
            this.label13.TabIndex = 12;
            this.label13.Visible = false;
            this.label13.Click += new System.EventHandler(this.Note_Click);
            this.label13.MouseLeave += new System.EventHandler(this.Note_MouseLeave);
            this.label13.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Note_MouseMove);
            // 
            // label12
            // 
            this.label12.AutoEllipsis = true;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(654, 187);
            this.label12.MaximumSize = new System.Drawing.Size(282, 22);
            this.label12.MinimumSize = new System.Drawing.Size(282, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(282, 22);
            this.label12.TabIndex = 11;
            this.label12.Visible = false;
            this.label12.Click += new System.EventHandler(this.Note_Click);
            this.label12.MouseLeave += new System.EventHandler(this.Note_MouseLeave);
            this.label12.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Note_MouseMove);
            // 
            // label11
            // 
            this.label11.AutoEllipsis = true;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(654, 130);
            this.label11.MinimumSize = new System.Drawing.Size(282, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(282, 22);
            this.label11.TabIndex = 10;
            this.label11.Visible = false;
            this.label11.Click += new System.EventHandler(this.Note_Click);
            this.label11.MouseLeave += new System.EventHandler(this.Note_MouseLeave);
            this.label11.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Note_MouseMove);
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(134, 556);
            this.label9.MinimumSize = new System.Drawing.Size(282, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(282, 22);
            this.label9.TabIndex = 8;
            this.label9.Visible = false;
            this.label9.Click += new System.EventHandler(this.Note_Click);
            this.label9.MouseLeave += new System.EventHandler(this.Note_MouseLeave);
            this.label9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Note_MouseMove);
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(134, 500);
            this.label8.MinimumSize = new System.Drawing.Size(282, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(282, 22);
            this.label8.TabIndex = 7;
            this.label8.Visible = false;
            this.label8.Click += new System.EventHandler(this.Note_Click);
            this.label8.MouseLeave += new System.EventHandler(this.Note_MouseLeave);
            this.label8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Note_MouseMove);
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(134, 444);
            this.label7.MinimumSize = new System.Drawing.Size(282, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(282, 22);
            this.label7.TabIndex = 6;
            this.label7.Visible = false;
            this.label7.Click += new System.EventHandler(this.Note_Click);
            this.label7.MouseLeave += new System.EventHandler(this.Note_MouseLeave);
            this.label7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Note_MouseMove);
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(134, 388);
            this.label6.MinimumSize = new System.Drawing.Size(282, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 22);
            this.label6.TabIndex = 5;
            this.label6.Visible = false;
            this.label6.Click += new System.EventHandler(this.Note_Click);
            this.label6.MouseLeave += new System.EventHandler(this.Note_MouseLeave);
            this.label6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Note_MouseMove);
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(134, 332);
            this.label5.MinimumSize = new System.Drawing.Size(282, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 22);
            this.label5.TabIndex = 4;
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.Note_Click);
            this.label5.MouseLeave += new System.EventHandler(this.Note_MouseLeave);
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Note_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(134, 276);
            this.label4.MinimumSize = new System.Drawing.Size(282, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 22);
            this.label4.TabIndex = 3;
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.Note_Click);
            this.label4.MouseLeave += new System.EventHandler(this.Note_MouseLeave);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Note_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(134, 220);
            this.label3.MinimumSize = new System.Drawing.Size(282, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 22);
            this.label3.TabIndex = 2;
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.Note_Click);
            this.label3.MouseLeave += new System.EventHandler(this.Note_MouseLeave);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Note_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(134, 164);
            this.label2.MaximumSize = new System.Drawing.Size(282, 22);
            this.label2.MinimumSize = new System.Drawing.Size(282, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 22);
            this.label2.TabIndex = 1;
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.Note_Click);
            this.label2.MouseLeave += new System.EventHandler(this.Note_MouseLeave);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Note_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(134, 108);
            this.label1.MaximumSize = new System.Drawing.Size(282, 22);
            this.label1.MinimumSize = new System.Drawing.Size(282, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 22);
            this.label1.TabIndex = 0;
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.Note_Click);
            this.label1.MouseLeave += new System.EventHandler(this.Note_MouseLeave);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Note_MouseMove);
            // 
            // NoteB
            // 
            this.NoteB.BackColor = System.Drawing.Color.Transparent;
            this.NoteB.Controls.Add(this.label10);
            this.NoteB.Controls.Add(this.D18);
            this.NoteB.Controls.Add(this.C18);
            this.NoteB.Controls.Add(this.D17);
            this.NoteB.Controls.Add(this.C17);
            this.NoteB.Controls.Add(this.D16);
            this.NoteB.Controls.Add(this.C16);
            this.NoteB.Controls.Add(this.D15);
            this.NoteB.Controls.Add(this.C15);
            this.NoteB.Controls.Add(this.D14);
            this.NoteB.Controls.Add(this.C14);
            this.NoteB.Controls.Add(this.D13);
            this.NoteB.Controls.Add(this.C13);
            this.NoteB.Controls.Add(this.D12);
            this.NoteB.Controls.Add(this.C12);
            this.NoteB.Controls.Add(this.D11);
            this.NoteB.Controls.Add(this.C11);
            this.NoteB.Controls.Add(this.D10);
            this.NoteB.Controls.Add(this.C10);
            this.NoteB.Controls.Add(this.D9);
            this.NoteB.Controls.Add(this.C9);
            this.NoteB.Controls.Add(this.D8);
            this.NoteB.Controls.Add(this.C8);
            this.NoteB.Controls.Add(this.D7);
            this.NoteB.Controls.Add(this.C7);
            this.NoteB.Controls.Add(this.D6);
            this.NoteB.Controls.Add(this.C6);
            this.NoteB.Controls.Add(this.D5);
            this.NoteB.Controls.Add(this.C5);
            this.NoteB.Controls.Add(this.D4);
            this.NoteB.Controls.Add(this.C4);
            this.NoteB.Controls.Add(this.D3);
            this.NoteB.Controls.Add(this.C3);
            this.NoteB.Controls.Add(this.D2);
            this.NoteB.Controls.Add(this.C2);
            this.NoteB.Controls.Add(this.D1);
            this.NoteB.Controls.Add(this.C1);
            this.NoteB.Controls.Add(this.label18);
            this.NoteB.Controls.Add(this.label17);
            this.NoteB.Controls.Add(this.label16);
            this.NoteB.Controls.Add(this.label15);
            this.NoteB.Controls.Add(this.label14);
            this.NoteB.Controls.Add(this.label13);
            this.NoteB.Controls.Add(this.label12);
            this.NoteB.Controls.Add(this.label11);
            this.NoteB.Controls.Add(this.label9);
            this.NoteB.Controls.Add(this.label8);
            this.NoteB.Controls.Add(this.label7);
            this.NoteB.Controls.Add(this.label6);
            this.NoteB.Controls.Add(this.label5);
            this.NoteB.Controls.Add(this.label4);
            this.NoteB.Controls.Add(this.label3);
            this.NoteB.Controls.Add(this.label2);
            this.NoteB.Controls.Add(this.label1);
            this.NoteB.Image = global::Записная_книжка.Properties.Resources.Notebook;
            this.NoteB.Location = new System.Drawing.Point(9, 55);
            this.NoteB.Name = "NoteB";
            this.NoteB.Size = new System.Drawing.Size(1006, 651);
            this.NoteB.TabIndex = 6;
            this.NoteB.TabStop = false;
            // 
            // Background
            // 
            this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background.Image = global::Записная_книжка.Properties.Resources.wood;
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(1015, 706);
            this.Background.TabIndex = 8;
            this.Background.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.ForeColor = System.Drawing.Color.DarkRed;
            this.label19.Location = new System.Drawing.Point(64, 655);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(25, 29);
            this.label19.TabIndex = 9;
            this.label19.Text = "1";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.ForeColor = System.Drawing.Color.DarkRed;
            this.label20.Location = new System.Drawing.Point(939, 614);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(25, 29);
            this.label20.TabIndex = 10;
            this.label20.Text = "2";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(26, 114);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 13);
            this.label21.TabIndex = 11;
            this.label21.Text = "Всего записей:  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1015, 706);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.DellAll);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.AddNote);
            this.Controls.Add(this.NoteB);
            this.Controls.Add(this.Background);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1031, 744);
            this.MinimumSize = new System.Drawing.Size(1031, 744);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Записная книжка";
            ((System.ComponentModel.ISupportInitialize)(this.NoteB)).EndInit();
            this.NoteB.ResumeLayout(false);
            this.NoteB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button AddNote;
        public System.Windows.Forms.Button Search;
        public System.Windows.Forms.Button Next;
        public System.Windows.Forms.Button Previous;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Button C1;
        public System.Windows.Forms.Button D1;
        public System.Windows.Forms.Button C2;
        public System.Windows.Forms.Button D2;
        public System.Windows.Forms.Button C3;
        public System.Windows.Forms.Button D3;
        public System.Windows.Forms.Button C4;
        public System.Windows.Forms.Button D4;
        public System.Windows.Forms.Button C5;
        public System.Windows.Forms.Button D5;
        public System.Windows.Forms.Button C6;
        public System.Windows.Forms.Button D6;
        public System.Windows.Forms.Button C7;
        public System.Windows.Forms.Button D7;
        public System.Windows.Forms.Button C8;
        public System.Windows.Forms.Button D8;
        public System.Windows.Forms.Button C9;
        public System.Windows.Forms.Button D9;
        public System.Windows.Forms.Button C10;
        public System.Windows.Forms.Button D10;
        public System.Windows.Forms.Button C11;
        public System.Windows.Forms.Button D11;
        public System.Windows.Forms.Button C12;
        public System.Windows.Forms.Button D12;
        public System.Windows.Forms.Button C13;
        public System.Windows.Forms.Button D13;
        public System.Windows.Forms.Button C14;
        public System.Windows.Forms.Button D14;
        public System.Windows.Forms.Button C15;
        public System.Windows.Forms.Button D15;
        public System.Windows.Forms.Button C16;
        public System.Windows.Forms.Button D16;
        public System.Windows.Forms.Button C17;
        public System.Windows.Forms.Button D17;
        public System.Windows.Forms.Button C18;
        public System.Windows.Forms.Button D18;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button DellAll;
        private System.Windows.Forms.PictureBox NoteB;
        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
    }
}

