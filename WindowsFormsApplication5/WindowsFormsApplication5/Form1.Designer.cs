namespace WindowsFormsApplication5
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
            this.groupBoxGasStation = new System.Windows.Forms.GroupBox();
            this.labelCurrency1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxToPayForTheOil = new System.Windows.Forms.GroupBox();
            this.labelCurrency = new System.Windows.Forms.Label();
            this.labelToPayForTheOil = new System.Windows.Forms.Label();
            this.textBoxMoneyClient = new System.Windows.Forms.TextBox();
            this.textBoxLiters = new System.Windows.Forms.TextBox();
            this.groupBoxCheckBox = new System.Windows.Forms.GroupBox();
            this.radioButtonClientMoney = new System.Windows.Forms.RadioButton();
            this.radioButtonLiters = new System.Windows.Forms.RadioButton();
            this.textBoxPriceForOil = new System.Windows.Forms.TextBox();
            this.labelPriceForOil = new System.Windows.Forms.Label();
            this.comboBoxOils = new System.Windows.Forms.ComboBox();
            this.labelOil = new System.Windows.Forms.Label();
            this.groupBoxMiniCafe = new System.Windows.Forms.GroupBox();
            this.labelCurrency5 = new System.Windows.Forms.Label();
            this.labelCurrency4 = new System.Windows.Forms.Label();
            this.labelCurrency3 = new System.Windows.Forms.Label();
            this.labelCurrency2 = new System.Windows.Forms.Label();
            this.textBoxSumCocaCola = new System.Windows.Forms.TextBox();
            this.textBoxPriceCocaCola = new System.Windows.Forms.TextBox();
            this.textBoxSumFrenchFries = new System.Windows.Forms.TextBox();
            this.textBoxPriceFrenchFries = new System.Windows.Forms.TextBox();
            this.textBoxSumBurgers = new System.Windows.Forms.TextBox();
            this.textBoxPriceBurger = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSumHotDogs = new System.Windows.Forms.TextBox();
            this.textBoxPriceHotDog = new System.Windows.Forms.TextBox();
            this.checkBoxCocaCola = new System.Windows.Forms.CheckBox();
            this.checkBoxFrenchfries = new System.Windows.Forms.CheckBox();
            this.checkBoxBurger = new System.Windows.Forms.CheckBox();
            this.checkBoxHotDog = new System.Windows.Forms.CheckBox();
            this.groupBoxToPayForTheMini = new System.Windows.Forms.GroupBox();
            this.labelCurrencyInMini = new System.Windows.Forms.Label();
            this.labelToPayForTheMini = new System.Windows.Forms.Label();
            this.groupBoxToPayAll = new System.Windows.Forms.GroupBox();
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonYes = new System.Windows.Forms.Button();
            this.labelNewClient = new System.Windows.Forms.Label();
            this.labelUnknown = new System.Windows.Forms.Label();
            this.labelCurrencyInAll = new System.Windows.Forms.Label();
            this.labelToPayForTheAll = new System.Windows.Forms.Label();
            this.buttonMath = new System.Windows.Forms.Button();
            this.timerForCheckNewClient = new System.Windows.Forms.Timer(this.components);
            this.groupBoxGasStation.SuspendLayout();
            this.groupBoxToPayForTheOil.SuspendLayout();
            this.groupBoxCheckBox.SuspendLayout();
            this.groupBoxMiniCafe.SuspendLayout();
            this.groupBoxToPayForTheMini.SuspendLayout();
            this.groupBoxToPayAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGasStation
            // 
            this.groupBoxGasStation.Controls.Add(this.labelCurrency1);
            this.groupBoxGasStation.Controls.Add(this.label3);
            this.groupBoxGasStation.Controls.Add(this.groupBoxToPayForTheOil);
            this.groupBoxGasStation.Controls.Add(this.textBoxMoneyClient);
            this.groupBoxGasStation.Controls.Add(this.textBoxLiters);
            this.groupBoxGasStation.Controls.Add(this.groupBoxCheckBox);
            this.groupBoxGasStation.Controls.Add(this.textBoxPriceForOil);
            this.groupBoxGasStation.Controls.Add(this.labelPriceForOil);
            this.groupBoxGasStation.Controls.Add(this.comboBoxOils);
            this.groupBoxGasStation.Controls.Add(this.labelOil);
            this.groupBoxGasStation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxGasStation.Location = new System.Drawing.Point(13, 13);
            this.groupBoxGasStation.Name = "groupBoxGasStation";
            this.groupBoxGasStation.Size = new System.Drawing.Size(251, 380);
            this.groupBoxGasStation.TabIndex = 0;
            this.groupBoxGasStation.TabStop = false;
            this.groupBoxGasStation.Text = "Автозаправка";
            // 
            // labelCurrency1
            // 
            this.labelCurrency1.AutoSize = true;
            this.labelCurrency1.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrency1.Location = new System.Drawing.Point(228, 186);
            this.labelCurrency1.Name = "labelCurrency1";
            this.labelCurrency1.Size = new System.Drawing.Size(20, 13);
            this.labelCurrency1.TabIndex = 8;
            this.labelCurrency1.Text = "тг";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(229, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "л.";
            // 
            // groupBoxToPayForTheOil
            // 
            this.groupBoxToPayForTheOil.Controls.Add(this.labelCurrency);
            this.groupBoxToPayForTheOil.Controls.Add(this.labelToPayForTheOil);
            this.groupBoxToPayForTheOil.Location = new System.Drawing.Point(10, 217);
            this.groupBoxToPayForTheOil.Name = "groupBoxToPayForTheOil";
            this.groupBoxToPayForTheOil.Size = new System.Drawing.Size(230, 157);
            this.groupBoxToPayForTheOil.TabIndex = 6;
            this.groupBoxToPayForTheOil.TabStop = false;
            this.groupBoxToPayForTheOil.Text = "Для оплаты";
            // 
            // labelCurrency
            // 
            this.labelCurrency.AutoSize = true;
            this.labelCurrency.Location = new System.Drawing.Point(174, 94);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(24, 19);
            this.labelCurrency.TabIndex = 1;
            this.labelCurrency.Text = "тг.";
            // 
            // labelToPayForTheOil
            // 
            this.labelToPayForTheOil.AutoSize = true;
            this.labelToPayForTheOil.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelToPayForTheOil.Location = new System.Drawing.Point(7, 54);
            this.labelToPayForTheOil.Name = "labelToPayForTheOil";
            this.labelToPayForTheOil.Size = new System.Drawing.Size(49, 59);
            this.labelToPayForTheOil.TabIndex = 0;
            this.labelToPayForTheOil.Text = "0";
            // 
            // textBoxMoneyClient
            // 
            this.textBoxMoneyClient.Location = new System.Drawing.Point(140, 172);
            this.textBoxMoneyClient.MaxLength = 6;
            this.textBoxMoneyClient.Name = "textBoxMoneyClient";
            this.textBoxMoneyClient.Size = new System.Drawing.Size(87, 27);
            this.textBoxMoneyClient.TabIndex = 5;
            this.textBoxMoneyClient.TextChanged += new System.EventHandler(this.TextBoxMoneyClient_TextChanged);
            this.textBoxMoneyClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLiters_KeyPress);
            // 
            // textBoxLiters
            // 
            this.textBoxLiters.Location = new System.Drawing.Point(141, 132);
            this.textBoxLiters.MaxLength = 3;
            this.textBoxLiters.Name = "textBoxLiters";
            this.textBoxLiters.Size = new System.Drawing.Size(87, 27);
            this.textBoxLiters.TabIndex = 0;
            this.textBoxLiters.TextChanged += new System.EventHandler(this.TextBoxLiters_TextChanged);
            this.textBoxLiters.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLiters_KeyPress);
            // 
            // groupBoxCheckBox
            // 
            this.groupBoxCheckBox.Controls.Add(this.radioButtonClientMoney);
            this.groupBoxCheckBox.Controls.Add(this.radioButtonLiters);
            this.groupBoxCheckBox.Location = new System.Drawing.Point(10, 118);
            this.groupBoxCheckBox.Name = "groupBoxCheckBox";
            this.groupBoxCheckBox.Size = new System.Drawing.Size(125, 92);
            this.groupBoxCheckBox.TabIndex = 4;
            this.groupBoxCheckBox.TabStop = false;
            // 
            // radioButtonClientMoney
            // 
            this.radioButtonClientMoney.AutoSize = true;
            this.radioButtonClientMoney.Location = new System.Drawing.Point(6, 58);
            this.radioButtonClientMoney.Name = "radioButtonClientMoney";
            this.radioButtonClientMoney.Size = new System.Drawing.Size(73, 23);
            this.radioButtonClientMoney.TabIndex = 1;
            this.radioButtonClientMoney.TabStop = true;
            this.radioButtonClientMoney.Text = "Сумма";
            this.radioButtonClientMoney.UseVisualStyleBackColor = true;
            this.radioButtonClientMoney.CheckedChanged += new System.EventHandler(this.RadioButtonClientMoney_CheckedChanged);
            // 
            // radioButtonLiters
            // 
            this.radioButtonLiters.AutoSize = true;
            this.radioButtonLiters.Location = new System.Drawing.Point(6, 18);
            this.radioButtonLiters.Name = "radioButtonLiters";
            this.radioButtonLiters.Size = new System.Drawing.Size(108, 23);
            this.radioButtonLiters.TabIndex = 0;
            this.radioButtonLiters.TabStop = true;
            this.radioButtonLiters.Text = "Количество";
            this.radioButtonLiters.UseVisualStyleBackColor = true;
            this.radioButtonLiters.CheckedChanged += new System.EventHandler(this.RadioButtonLiters_CheckedChanged);
            // 
            // textBoxPriceForOil
            // 
            this.textBoxPriceForOil.Location = new System.Drawing.Point(103, 69);
            this.textBoxPriceForOil.Name = "textBoxPriceForOil";
            this.textBoxPriceForOil.ReadOnly = true;
            this.textBoxPriceForOil.Size = new System.Drawing.Size(125, 27);
            this.textBoxPriceForOil.TabIndex = 3;
            // 
            // labelPriceForOil
            // 
            this.labelPriceForOil.AutoSize = true;
            this.labelPriceForOil.Location = new System.Drawing.Point(6, 72);
            this.labelPriceForOil.Name = "labelPriceForOil";
            this.labelPriceForOil.Size = new System.Drawing.Size(45, 19);
            this.labelPriceForOil.TabIndex = 2;
            this.labelPriceForOil.Text = "Цена";
            // 
            // comboBoxOils
            // 
            this.comboBoxOils.FormattingEnabled = true;
            this.comboBoxOils.Items.AddRange(new object[] {
            "АИ-80",
            "АИ-92",
            "АИ-95",
            "Дизель"});
            this.comboBoxOils.Location = new System.Drawing.Point(103, 27);
            this.comboBoxOils.Name = "comboBoxOils";
            this.comboBoxOils.Size = new System.Drawing.Size(125, 27);
            this.comboBoxOils.TabIndex = 1;
            this.comboBoxOils.SelectedIndexChanged += new System.EventHandler(this.ComboBoxOils_SelectedIndexChanged);
            // 
            // labelOil
            // 
            this.labelOil.AutoSize = true;
            this.labelOil.Location = new System.Drawing.Point(6, 30);
            this.labelOil.Name = "labelOil";
            this.labelOil.Size = new System.Drawing.Size(60, 19);
            this.labelOil.TabIndex = 0;
            this.labelOil.Text = "Бензин";
            // 
            // groupBoxMiniCafe
            // 
            this.groupBoxMiniCafe.Controls.Add(this.labelCurrency5);
            this.groupBoxMiniCafe.Controls.Add(this.labelCurrency4);
            this.groupBoxMiniCafe.Controls.Add(this.labelCurrency3);
            this.groupBoxMiniCafe.Controls.Add(this.labelCurrency2);
            this.groupBoxMiniCafe.Controls.Add(this.textBoxSumCocaCola);
            this.groupBoxMiniCafe.Controls.Add(this.textBoxPriceCocaCola);
            this.groupBoxMiniCafe.Controls.Add(this.textBoxSumFrenchFries);
            this.groupBoxMiniCafe.Controls.Add(this.textBoxPriceFrenchFries);
            this.groupBoxMiniCafe.Controls.Add(this.textBoxSumBurgers);
            this.groupBoxMiniCafe.Controls.Add(this.textBoxPriceBurger);
            this.groupBoxMiniCafe.Controls.Add(this.label2);
            this.groupBoxMiniCafe.Controls.Add(this.label1);
            this.groupBoxMiniCafe.Controls.Add(this.textBoxSumHotDogs);
            this.groupBoxMiniCafe.Controls.Add(this.textBoxPriceHotDog);
            this.groupBoxMiniCafe.Controls.Add(this.checkBoxCocaCola);
            this.groupBoxMiniCafe.Controls.Add(this.checkBoxFrenchfries);
            this.groupBoxMiniCafe.Controls.Add(this.checkBoxBurger);
            this.groupBoxMiniCafe.Controls.Add(this.checkBoxHotDog);
            this.groupBoxMiniCafe.Controls.Add(this.groupBoxToPayForTheMini);
            this.groupBoxMiniCafe.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxMiniCafe.Location = new System.Drawing.Point(317, 13);
            this.groupBoxMiniCafe.Name = "groupBoxMiniCafe";
            this.groupBoxMiniCafe.Size = new System.Drawing.Size(251, 380);
            this.groupBoxMiniCafe.TabIndex = 1;
            this.groupBoxMiniCafe.TabStop = false;
            this.groupBoxMiniCafe.Text = "Мини Кафе";
            // 
            // labelCurrency5
            // 
            this.labelCurrency5.AutoSize = true;
            this.labelCurrency5.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrency5.Location = new System.Drawing.Point(152, 151);
            this.labelCurrency5.Name = "labelCurrency5";
            this.labelCurrency5.Size = new System.Drawing.Size(20, 13);
            this.labelCurrency5.TabIndex = 24;
            this.labelCurrency5.Text = "тг";
            // 
            // labelCurrency4
            // 
            this.labelCurrency4.AutoSize = true;
            this.labelCurrency4.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrency4.Location = new System.Drawing.Point(152, 120);
            this.labelCurrency4.Name = "labelCurrency4";
            this.labelCurrency4.Size = new System.Drawing.Size(20, 13);
            this.labelCurrency4.TabIndex = 23;
            this.labelCurrency4.Text = "тг";
            // 
            // labelCurrency3
            // 
            this.labelCurrency3.AutoSize = true;
            this.labelCurrency3.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrency3.Location = new System.Drawing.Point(152, 87);
            this.labelCurrency3.Name = "labelCurrency3";
            this.labelCurrency3.Size = new System.Drawing.Size(20, 13);
            this.labelCurrency3.TabIndex = 22;
            this.labelCurrency3.Text = "тг";
            // 
            // labelCurrency2
            // 
            this.labelCurrency2.AutoSize = true;
            this.labelCurrency2.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrency2.Location = new System.Drawing.Point(152, 54);
            this.labelCurrency2.Name = "labelCurrency2";
            this.labelCurrency2.Size = new System.Drawing.Size(20, 13);
            this.labelCurrency2.TabIndex = 9;
            this.labelCurrency2.Text = "тг";
            // 
            // textBoxSumCocaCola
            // 
            this.textBoxSumCocaCola.Location = new System.Drawing.Point(180, 139);
            this.textBoxSumCocaCola.MaxLength = 3;
            this.textBoxSumCocaCola.Name = "textBoxSumCocaCola";
            this.textBoxSumCocaCola.Size = new System.Drawing.Size(60, 27);
            this.textBoxSumCocaCola.TabIndex = 21;
            this.textBoxSumCocaCola.TextChanged += new System.EventHandler(this.TextBoxSumCocaCola_TextChanged);
            this.textBoxSumCocaCola.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLiters_KeyPress);
            // 
            // textBoxPriceCocaCola
            // 
            this.textBoxPriceCocaCola.Location = new System.Drawing.Point(114, 139);
            this.textBoxPriceCocaCola.Name = "textBoxPriceCocaCola";
            this.textBoxPriceCocaCola.ReadOnly = true;
            this.textBoxPriceCocaCola.Size = new System.Drawing.Size(32, 27);
            this.textBoxPriceCocaCola.TabIndex = 20;
            this.textBoxPriceCocaCola.Text = "150";
            // 
            // textBoxSumFrenchFries
            // 
            this.textBoxSumFrenchFries.Location = new System.Drawing.Point(180, 106);
            this.textBoxSumFrenchFries.MaxLength = 3;
            this.textBoxSumFrenchFries.Name = "textBoxSumFrenchFries";
            this.textBoxSumFrenchFries.Size = new System.Drawing.Size(60, 27);
            this.textBoxSumFrenchFries.TabIndex = 19;
            this.textBoxSumFrenchFries.TextChanged += new System.EventHandler(this.TextBoxSumFrenchFries_TextChanged);
            this.textBoxSumFrenchFries.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLiters_KeyPress);
            // 
            // textBoxPriceFrenchFries
            // 
            this.textBoxPriceFrenchFries.Location = new System.Drawing.Point(114, 106);
            this.textBoxPriceFrenchFries.Name = "textBoxPriceFrenchFries";
            this.textBoxPriceFrenchFries.ReadOnly = true;
            this.textBoxPriceFrenchFries.Size = new System.Drawing.Size(32, 27);
            this.textBoxPriceFrenchFries.TabIndex = 18;
            this.textBoxPriceFrenchFries.Text = "200";
            // 
            // textBoxSumBurgers
            // 
            this.textBoxSumBurgers.Location = new System.Drawing.Point(180, 73);
            this.textBoxSumBurgers.MaxLength = 3;
            this.textBoxSumBurgers.Name = "textBoxSumBurgers";
            this.textBoxSumBurgers.Size = new System.Drawing.Size(60, 27);
            this.textBoxSumBurgers.TabIndex = 17;
            this.textBoxSumBurgers.TextChanged += new System.EventHandler(this.TextBoxSumBurgers_TextChanged);
            this.textBoxSumBurgers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLiters_KeyPress);
            // 
            // textBoxPriceBurger
            // 
            this.textBoxPriceBurger.Location = new System.Drawing.Point(114, 73);
            this.textBoxPriceBurger.Name = "textBoxPriceBurger";
            this.textBoxPriceBurger.ReadOnly = true;
            this.textBoxPriceBurger.Size = new System.Drawing.Size(32, 27);
            this.textBoxPriceBurger.TabIndex = 16;
            this.textBoxPriceBurger.Text = "250";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Кол-во";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Цена";
            // 
            // textBoxSumHotDogs
            // 
            this.textBoxSumHotDogs.Location = new System.Drawing.Point(180, 40);
            this.textBoxSumHotDogs.MaxLength = 3;
            this.textBoxSumHotDogs.Name = "textBoxSumHotDogs";
            this.textBoxSumHotDogs.Size = new System.Drawing.Size(60, 27);
            this.textBoxSumHotDogs.TabIndex = 13;
            this.textBoxSumHotDogs.TextChanged += new System.EventHandler(this.TextBoxSumHotDogs_TextChanged);
            this.textBoxSumHotDogs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLiters_KeyPress);
            // 
            // textBoxPriceHotDog
            // 
            this.textBoxPriceHotDog.Location = new System.Drawing.Point(114, 40);
            this.textBoxPriceHotDog.Name = "textBoxPriceHotDog";
            this.textBoxPriceHotDog.ReadOnly = true;
            this.textBoxPriceHotDog.Size = new System.Drawing.Size(32, 27);
            this.textBoxPriceHotDog.TabIndex = 12;
            this.textBoxPriceHotDog.Text = "160";
            // 
            // checkBoxCocaCola
            // 
            this.checkBoxCocaCola.AutoSize = true;
            this.checkBoxCocaCola.Location = new System.Drawing.Point(10, 141);
            this.checkBoxCocaCola.Name = "checkBoxCocaCola";
            this.checkBoxCocaCola.Size = new System.Drawing.Size(100, 23);
            this.checkBoxCocaCola.TabIndex = 11;
            this.checkBoxCocaCola.Text = "Кока-кола";
            this.checkBoxCocaCola.UseVisualStyleBackColor = true;
            this.checkBoxCocaCola.CheckedChanged += new System.EventHandler(this.CheckBoxCocaCola_CheckedChanged);
            // 
            // checkBoxFrenchfries
            // 
            this.checkBoxFrenchfries.AutoSize = true;
            this.checkBoxFrenchfries.Location = new System.Drawing.Point(10, 108);
            this.checkBoxFrenchfries.Name = "checkBoxFrenchfries";
            this.checkBoxFrenchfries.Size = new System.Drawing.Size(58, 23);
            this.checkBoxFrenchfries.TabIndex = 10;
            this.checkBoxFrenchfries.Text = "Фри";
            this.checkBoxFrenchfries.UseVisualStyleBackColor = true;
            this.checkBoxFrenchfries.CheckedChanged += new System.EventHandler(this.CheckBoxFrenchfries_CheckedChanged);
            // 
            // checkBoxBurger
            // 
            this.checkBoxBurger.AutoSize = true;
            this.checkBoxBurger.Location = new System.Drawing.Point(10, 75);
            this.checkBoxBurger.Name = "checkBoxBurger";
            this.checkBoxBurger.Size = new System.Drawing.Size(102, 23);
            this.checkBoxBurger.TabIndex = 9;
            this.checkBoxBurger.Text = "Гамбургер";
            this.checkBoxBurger.UseVisualStyleBackColor = true;
            this.checkBoxBurger.CheckedChanged += new System.EventHandler(this.CheckBoxBurger_CheckedChanged);
            // 
            // checkBoxHotDog
            // 
            this.checkBoxHotDog.AutoSize = true;
            this.checkBoxHotDog.Location = new System.Drawing.Point(10, 42);
            this.checkBoxHotDog.Name = "checkBoxHotDog";
            this.checkBoxHotDog.Size = new System.Drawing.Size(80, 23);
            this.checkBoxHotDog.TabIndex = 8;
            this.checkBoxHotDog.Text = "Хот дог";
            this.checkBoxHotDog.UseVisualStyleBackColor = true;
            this.checkBoxHotDog.CheckedChanged += new System.EventHandler(this.CheckBoxHotDog_CheckedChanged);
            // 
            // groupBoxToPayForTheMini
            // 
            this.groupBoxToPayForTheMini.Controls.Add(this.labelCurrencyInMini);
            this.groupBoxToPayForTheMini.Controls.Add(this.labelToPayForTheMini);
            this.groupBoxToPayForTheMini.Location = new System.Drawing.Point(10, 217);
            this.groupBoxToPayForTheMini.Name = "groupBoxToPayForTheMini";
            this.groupBoxToPayForTheMini.Size = new System.Drawing.Size(230, 157);
            this.groupBoxToPayForTheMini.TabIndex = 7;
            this.groupBoxToPayForTheMini.TabStop = false;
            this.groupBoxToPayForTheMini.Text = "Для оплаты";
            // 
            // labelCurrencyInMini
            // 
            this.labelCurrencyInMini.AutoSize = true;
            this.labelCurrencyInMini.Location = new System.Drawing.Point(160, 94);
            this.labelCurrencyInMini.Name = "labelCurrencyInMini";
            this.labelCurrencyInMini.Size = new System.Drawing.Size(24, 19);
            this.labelCurrencyInMini.TabIndex = 3;
            this.labelCurrencyInMini.Text = "тг.";
            // 
            // labelToPayForTheMini
            // 
            this.labelToPayForTheMini.AutoSize = true;
            this.labelToPayForTheMini.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelToPayForTheMini.Location = new System.Drawing.Point(9, 54);
            this.labelToPayForTheMini.Name = "labelToPayForTheMini";
            this.labelToPayForTheMini.Size = new System.Drawing.Size(49, 59);
            this.labelToPayForTheMini.TabIndex = 2;
            this.labelToPayForTheMini.Text = "0";
            // 
            // groupBoxToPayAll
            // 
            this.groupBoxToPayAll.Controls.Add(this.buttonNo);
            this.groupBoxToPayAll.Controls.Add(this.buttonYes);
            this.groupBoxToPayAll.Controls.Add(this.labelNewClient);
            this.groupBoxToPayAll.Controls.Add(this.labelUnknown);
            this.groupBoxToPayAll.Controls.Add(this.labelCurrencyInAll);
            this.groupBoxToPayAll.Controls.Add(this.labelToPayForTheAll);
            this.groupBoxToPayAll.Controls.Add(this.buttonMath);
            this.groupBoxToPayAll.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxToPayAll.Location = new System.Drawing.Point(13, 399);
            this.groupBoxToPayAll.Name = "groupBoxToPayAll";
            this.groupBoxToPayAll.Size = new System.Drawing.Size(555, 250);
            this.groupBoxToPayAll.TabIndex = 2;
            this.groupBoxToPayAll.TabStop = false;
            this.groupBoxToPayAll.Text = "Всего для оплаты";
            // 
            // buttonNo
            // 
            this.buttonNo.Location = new System.Drawing.Point(418, 214);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(75, 23);
            this.buttonNo.TabIndex = 10;
            this.buttonNo.Text = "Нет";
            this.buttonNo.UseVisualStyleBackColor = true;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // buttonYes
            // 
            this.buttonYes.Location = new System.Drawing.Point(333, 214);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(75, 23);
            this.buttonYes.TabIndex = 9;
            this.buttonYes.Text = "Да";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // labelNewClient
            // 
            this.labelNewClient.AutoSize = true;
            this.labelNewClient.Location = new System.Drawing.Point(155, 218);
            this.labelNewClient.Name = "labelNewClient";
            this.labelNewClient.Size = new System.Drawing.Size(172, 19);
            this.labelNewClient.TabIndex = 7;
            this.labelNewClient.Text = "Есть ли новый клиент ?";
            // 
            // labelUnknown
            // 
            this.labelUnknown.AutoSize = true;
            this.labelUnknown.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUnknown.Location = new System.Drawing.Point(6, 228);
            this.labelUnknown.Name = "labelUnknown";
            this.labelUnknown.Size = new System.Drawing.Size(13, 13);
            this.labelUnknown.TabIndex = 6;
            this.labelUnknown.Text = "0";
            // 
            // labelCurrencyInAll
            // 
            this.labelCurrencyInAll.AutoSize = true;
            this.labelCurrencyInAll.Location = new System.Drawing.Point(488, 167);
            this.labelCurrencyInAll.Name = "labelCurrencyInAll";
            this.labelCurrencyInAll.Size = new System.Drawing.Size(24, 19);
            this.labelCurrencyInAll.TabIndex = 5;
            this.labelCurrencyInAll.Text = "тг.";
            // 
            // labelToPayForTheAll
            // 
            this.labelToPayForTheAll.AutoSize = true;
            this.labelToPayForTheAll.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelToPayForTheAll.Location = new System.Drawing.Point(379, 127);
            this.labelToPayForTheAll.Name = "labelToPayForTheAll";
            this.labelToPayForTheAll.Size = new System.Drawing.Size(49, 59);
            this.labelToPayForTheAll.TabIndex = 4;
            this.labelToPayForTheAll.Text = "0";
            // 
            // buttonMath
            // 
            this.buttonMath.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonMath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMath.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMath.Image = global::WindowsFormsApplication5.Properties.Resources.Cart;
            this.buttonMath.Location = new System.Drawing.Point(69, 100);
            this.buttonMath.Name = "buttonMath";
            this.buttonMath.Size = new System.Drawing.Size(98, 86);
            this.buttonMath.TabIndex = 0;
            this.buttonMath.UseVisualStyleBackColor = false;
            this.buttonMath.Click += new System.EventHandler(this.ButtonMath_Click);
            // 
            // timerForCheckNewClient
            // 
            this.timerForCheckNewClient.Interval = 1000;
            this.timerForCheckNewClient.Tick += new System.EventHandler(this.timerForCheckNewClient_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this.groupBoxToPayAll);
            this.Controls.Add(this.groupBoxMiniCafe);
            this.Controls.Add(this.groupBoxGasStation);
            this.Name = "Form1";
            this.Text = "BestOil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxGasStation.ResumeLayout(false);
            this.groupBoxGasStation.PerformLayout();
            this.groupBoxToPayForTheOil.ResumeLayout(false);
            this.groupBoxToPayForTheOil.PerformLayout();
            this.groupBoxCheckBox.ResumeLayout(false);
            this.groupBoxCheckBox.PerformLayout();
            this.groupBoxMiniCafe.ResumeLayout(false);
            this.groupBoxMiniCafe.PerformLayout();
            this.groupBoxToPayForTheMini.ResumeLayout(false);
            this.groupBoxToPayForTheMini.PerformLayout();
            this.groupBoxToPayAll.ResumeLayout(false);
            this.groupBoxToPayAll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGasStation;
        private System.Windows.Forms.ComboBox comboBoxOils;
        private System.Windows.Forms.Label labelOil;
        private System.Windows.Forms.GroupBox groupBoxMiniCafe;
        private System.Windows.Forms.GroupBox groupBoxToPayAll;
        private System.Windows.Forms.TextBox textBoxPriceForOil;
        private System.Windows.Forms.Label labelPriceForOil;
        private System.Windows.Forms.GroupBox groupBoxToPayForTheOil;
        private System.Windows.Forms.TextBox textBoxMoneyClient;
        private System.Windows.Forms.TextBox textBoxLiters;
        private System.Windows.Forms.GroupBox groupBoxCheckBox;
        private System.Windows.Forms.RadioButton radioButtonClientMoney;
        private System.Windows.Forms.RadioButton radioButtonLiters;
        private System.Windows.Forms.CheckBox checkBoxCocaCola;
        private System.Windows.Forms.CheckBox checkBoxFrenchfries;
        private System.Windows.Forms.CheckBox checkBoxBurger;
        private System.Windows.Forms.CheckBox checkBoxHotDog;
        private System.Windows.Forms.GroupBox groupBoxToPayForTheMini;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSumHotDogs;
        private System.Windows.Forms.TextBox textBoxPriceHotDog;
        private System.Windows.Forms.TextBox textBoxSumCocaCola;
        private System.Windows.Forms.TextBox textBoxPriceCocaCola;
        private System.Windows.Forms.TextBox textBoxSumFrenchFries;
        private System.Windows.Forms.TextBox textBoxPriceFrenchFries;
        private System.Windows.Forms.TextBox textBoxSumBurgers;
        private System.Windows.Forms.TextBox textBoxPriceBurger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCurrency;
        private System.Windows.Forms.Label labelToPayForTheOil;
        private System.Windows.Forms.Label labelCurrencyInMini;
        private System.Windows.Forms.Label labelToPayForTheMini;
        private System.Windows.Forms.Label labelCurrencyInAll;
        private System.Windows.Forms.Label labelToPayForTheAll;
        private System.Windows.Forms.Button buttonMath;
        private System.Windows.Forms.Label labelCurrency1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCurrency5;
        private System.Windows.Forms.Label labelCurrency4;
        private System.Windows.Forms.Label labelCurrency3;
        private System.Windows.Forms.Label labelCurrency2;
        private System.Windows.Forms.Timer timerForCheckNewClient;
        private System.Windows.Forms.Label labelNewClient;
        private System.Windows.Forms.Label labelUnknown;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Button buttonYes;
    }
}

