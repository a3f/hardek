﻿namespace HardekSuite.Forms {
    partial class uxHealing {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uxHealing));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Health", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Mana", System.Windows.Forms.HorizontalAlignment.Left);
            this.potionExhaustionText = new System.Windows.Forms.TextBox();
            this.potionExhaustionLabel = new System.Windows.Forms.Label();
            this.spellExhaustionLabel = new System.Windows.Forms.Label();
            this.spellExhaustionText = new System.Windows.Forms.TextBox();
            this.paralyzeCheck = new System.Windows.Forms.CheckBox();
            this.antidoteCheck = new System.Windows.Forms.CheckBox();
            this.uxHealthMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uxItemHealth = new System.Windows.Forms.ToolStripMenuItem();
            this.uxUHHealth = new System.Windows.Forms.ToolStripMenuItem();
            this.uxIHHealth = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSmallHealthPotion = new System.Windows.Forms.ToolStripMenuItem();
            this.uxHealthPotion = new System.Windows.Forms.ToolStripMenuItem();
            this.uxStrongHealthPotion = new System.Windows.Forms.ToolStripMenuItem();
            this.uxGreatHealthPotion = new System.Windows.Forms.ToolStripMenuItem();
            this.uxUltimateHealthPotion = new System.Windows.Forms.ToolStripMenuItem();
            this.uxHealthSpiritPotion = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSpellHealth = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSpellWords = new System.Windows.Forms.ToolStripTextBox();
            this.uxSpellMana = new System.Windows.Forms.ToolStripTextBox();
            this.uxAddSpellHealth = new System.Windows.Forms.ToolStripMenuItem();
            this.uxHealthAdd = new System.Windows.Forms.Button();
            this.uxPercent = new System.Windows.Forms.HScrollBar();
            this.uxManaAdd = new System.Windows.Forms.Button();
            this.uxManaMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uxItemMana = new System.Windows.Forms.ToolStripMenuItem();
            this.uxManaPotion = new System.Windows.Forms.ToolStripMenuItem();
            this.uxStrongManaPotion = new System.Windows.Forms.ToolStripMenuItem();
            this.uxGreatManaPotion = new System.Windows.Forms.ToolStripMenuItem();
            this.uxManaSpiritPotion = new System.Windows.Forms.ToolStripMenuItem();
            this.uxLabelPercent = new System.Windows.Forms.Label();
            this.uxOptions = new System.Windows.Forms.GroupBox();
            this.uxEnable = new System.Windows.Forms.CheckBox();
            this.uxDelete = new System.Windows.Forms.Button();
            this.uxList = new System.Windows.Forms.ListView();
            this.uxColumnPercent = new System.Windows.Forms.ColumnHeader();
            this.uxColumnAction = new System.Windows.Forms.ColumnHeader();
            this.uxColumnMana = new System.Windows.Forms.ColumnHeader();
            this.uxClear = new System.Windows.Forms.Button();
            this.uxHealthMenu.SuspendLayout();
            this.uxManaMenu.SuspendLayout();
            this.uxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // potionExhaustionText
            // 
            this.potionExhaustionText.Location = new System.Drawing.Point(104, 42);
            this.potionExhaustionText.Name = "potionExhaustionText";
            this.potionExhaustionText.Size = new System.Drawing.Size(53, 20);
            this.potionExhaustionText.TabIndex = 2;
            this.potionExhaustionText.Text = "700";
            this.potionExhaustionText.TextChanged += new System.EventHandler(this.potionExhaustionText_TextChanged);
            this.potionExhaustionText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.potionExhaustionText_KeyPress);
            // 
            // potionExhaustionLabel
            // 
            this.potionExhaustionLabel.AutoSize = true;
            this.potionExhaustionLabel.Location = new System.Drawing.Point(3, 45);
            this.potionExhaustionLabel.Name = "potionExhaustionLabel";
            this.potionExhaustionLabel.Size = new System.Drawing.Size(95, 13);
            this.potionExhaustionLabel.TabIndex = 3;
            this.potionExhaustionLabel.Text = "Potion Exhaustion:";
            // 
            // spellExhaustionLabel
            // 
            this.spellExhaustionLabel.AutoSize = true;
            this.spellExhaustionLabel.Location = new System.Drawing.Point(3, 20);
            this.spellExhaustionLabel.Name = "spellExhaustionLabel";
            this.spellExhaustionLabel.Size = new System.Drawing.Size(88, 13);
            this.spellExhaustionLabel.TabIndex = 5;
            this.spellExhaustionLabel.Text = "Spell Exhaustion:";
            // 
            // spellExhaustionText
            // 
            this.spellExhaustionText.Location = new System.Drawing.Point(104, 17);
            this.spellExhaustionText.Name = "spellExhaustionText";
            this.spellExhaustionText.Size = new System.Drawing.Size(53, 20);
            this.spellExhaustionText.TabIndex = 4;
            this.spellExhaustionText.Text = "1080";
            this.spellExhaustionText.TextChanged += new System.EventHandler(this.spellExhaustionText_TextChanged);
            this.spellExhaustionText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.potionExhaustionText_KeyPress);
            // 
            // paralyzeCheck
            // 
            this.paralyzeCheck.AutoSize = true;
            this.paralyzeCheck.Location = new System.Drawing.Point(157, 19);
            this.paralyzeCheck.Name = "paralyzeCheck";
            this.paralyzeCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.paralyzeCheck.Size = new System.Drawing.Size(91, 17);
            this.paralyzeCheck.TabIndex = 6;
            this.paralyzeCheck.Text = "Paralyze Heal";
            this.paralyzeCheck.UseVisualStyleBackColor = true;
            this.paralyzeCheck.CheckedChanged += new System.EventHandler(this.paralyzeCheck_CheckedChanged);
            // 
            // antidoteCheck
            // 
            this.antidoteCheck.AutoSize = true;
            this.antidoteCheck.Location = new System.Drawing.Point(165, 44);
            this.antidoteCheck.Name = "antidoteCheck";
            this.antidoteCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.antidoteCheck.Size = new System.Drawing.Size(83, 17);
            this.antidoteCheck.TabIndex = 7;
            this.antidoteCheck.Text = "Poison Heal";
            this.antidoteCheck.UseVisualStyleBackColor = true;
            this.antidoteCheck.CheckedChanged += new System.EventHandler(this.antidoteCheck_CheckedChanged);
            // 
            // uxHealthMenu
            // 
            this.uxHealthMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxItemHealth,
            this.uxSpellHealth});
            this.uxHealthMenu.Name = "addHealthMenu";
            this.uxHealthMenu.Size = new System.Drawing.Size(108, 48);
            // 
            // uxItemHealth
            // 
            this.uxItemHealth.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxUHHealth,
            this.uxIHHealth,
            this.uxSmallHealthPotion,
            this.uxHealthPotion,
            this.uxStrongHealthPotion,
            this.uxGreatHealthPotion,
            this.uxUltimateHealthPotion,
            this.uxHealthSpiritPotion});
            this.uxItemHealth.Name = "uxItemHealth";
            this.uxItemHealth.Size = new System.Drawing.Size(107, 22);
            this.uxItemHealth.Text = "Item";
            // 
            // uxUHHealth
            // 
            this.uxUHHealth.Image = ((System.Drawing.Image)(resources.GetObject("uxUHHealth.Image")));
            this.uxUHHealth.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.uxUHHealth.Name = "uxUHHealth";
            this.uxUHHealth.Size = new System.Drawing.Size(207, 38);
            this.uxUHHealth.Text = "Ultimate Healing Rune";
            this.uxUHHealth.Click += new System.EventHandler(this.addHealth);
            // 
            // uxIHHealth
            // 
            this.uxIHHealth.Image = ((System.Drawing.Image)(resources.GetObject("uxIHHealth.Image")));
            this.uxIHHealth.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.uxIHHealth.Name = "uxIHHealth";
            this.uxIHHealth.Size = new System.Drawing.Size(207, 38);
            this.uxIHHealth.Text = "Intense Healing Rune";
            this.uxIHHealth.Click += new System.EventHandler(this.addHealth);
            // 
            // uxSmallHealthPotion
            // 
            this.uxSmallHealthPotion.Image = ((System.Drawing.Image)(resources.GetObject("uxSmallHealthPotion.Image")));
            this.uxSmallHealthPotion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.uxSmallHealthPotion.Name = "uxSmallHealthPotion";
            this.uxSmallHealthPotion.Size = new System.Drawing.Size(207, 38);
            this.uxSmallHealthPotion.Text = "Small Health Potion";
            this.uxSmallHealthPotion.Visible = false;
            this.uxSmallHealthPotion.Click += new System.EventHandler(this.addHealth);
            // 
            // uxHealthPotion
            // 
            this.uxHealthPotion.Image = ((System.Drawing.Image)(resources.GetObject("uxHealthPotion.Image")));
            this.uxHealthPotion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.uxHealthPotion.Name = "uxHealthPotion";
            this.uxHealthPotion.Size = new System.Drawing.Size(207, 38);
            this.uxHealthPotion.Text = "Health Potion";
            this.uxHealthPotion.Click += new System.EventHandler(this.addHealth);
            // 
            // uxStrongHealthPotion
            // 
            this.uxStrongHealthPotion.Image = ((System.Drawing.Image)(resources.GetObject("uxStrongHealthPotion.Image")));
            this.uxStrongHealthPotion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.uxStrongHealthPotion.Name = "uxStrongHealthPotion";
            this.uxStrongHealthPotion.Size = new System.Drawing.Size(207, 38);
            this.uxStrongHealthPotion.Text = "Strong Health Potion";
            this.uxStrongHealthPotion.Click += new System.EventHandler(this.addHealth);
            // 
            // uxGreatHealthPotion
            // 
            this.uxGreatHealthPotion.Image = ((System.Drawing.Image)(resources.GetObject("uxGreatHealthPotion.Image")));
            this.uxGreatHealthPotion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.uxGreatHealthPotion.Name = "uxGreatHealthPotion";
            this.uxGreatHealthPotion.Size = new System.Drawing.Size(207, 38);
            this.uxGreatHealthPotion.Text = "Great Health Potion";
            this.uxGreatHealthPotion.Click += new System.EventHandler(this.addHealth);
            // 
            // uxUltimateHealthPotion
            // 
            this.uxUltimateHealthPotion.Image = ((System.Drawing.Image)(resources.GetObject("uxUltimateHealthPotion.Image")));
            this.uxUltimateHealthPotion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.uxUltimateHealthPotion.Name = "uxUltimateHealthPotion";
            this.uxUltimateHealthPotion.Size = new System.Drawing.Size(207, 38);
            this.uxUltimateHealthPotion.Text = "Ultimate Health Potion";
            this.uxUltimateHealthPotion.Click += new System.EventHandler(this.addHealth);
            // 
            // uxHealthSpiritPotion
            // 
            this.uxHealthSpiritPotion.Image = ((System.Drawing.Image)(resources.GetObject("uxHealthSpiritPotion.Image")));
            this.uxHealthSpiritPotion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.uxHealthSpiritPotion.Name = "uxHealthSpiritPotion";
            this.uxHealthSpiritPotion.Size = new System.Drawing.Size(207, 38);
            this.uxHealthSpiritPotion.Text = "Great Spirit Potion";
            this.uxHealthSpiritPotion.Click += new System.EventHandler(this.addHealth);
            // 
            // uxSpellHealth
            // 
            this.uxSpellHealth.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxSpellWords,
            this.uxSpellMana,
            this.uxAddSpellHealth});
            this.uxSpellHealth.Name = "uxSpellHealth";
            this.uxSpellHealth.Size = new System.Drawing.Size(107, 22);
            this.uxSpellHealth.Text = "Spell";
            // 
            // uxSpellWords
            // 
            this.uxSpellWords.ForeColor = System.Drawing.SystemColors.GrayText;
            this.uxSpellWords.Name = "uxSpellWords";
            this.uxSpellWords.Size = new System.Drawing.Size(100, 21);
            this.uxSpellWords.Tag = "Spell";
            this.uxSpellWords.Text = "Spell";
            this.uxSpellWords.Leave += new System.EventHandler(this.spellHealth_Leave);
            this.uxSpellWords.Enter += new System.EventHandler(this.spellHealth_Enter);
            this.uxSpellWords.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.spellHealth_KeyPress);
            // 
            // uxSpellMana
            // 
            this.uxSpellMana.ForeColor = System.Drawing.SystemColors.GrayText;
            this.uxSpellMana.Name = "uxSpellMana";
            this.uxSpellMana.Size = new System.Drawing.Size(100, 21);
            this.uxSpellMana.Tag = "Mana Cost";
            this.uxSpellMana.Text = "Mana Cost";
            this.uxSpellMana.Leave += new System.EventHandler(this.spellHealth_Leave);
            this.uxSpellMana.Enter += new System.EventHandler(this.spellHealth_Enter);
            this.uxSpellMana.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.manaSpellHealth_KeyPress);
            // 
            // uxAddSpellHealth
            // 
            this.uxAddSpellHealth.Image = ((System.Drawing.Image)(resources.GetObject("uxAddSpellHealth.Image")));
            this.uxAddSpellHealth.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.uxAddSpellHealth.Name = "uxAddSpellHealth";
            this.uxAddSpellHealth.Size = new System.Drawing.Size(176, 38);
            this.uxAddSpellHealth.Text = "Add";
            this.uxAddSpellHealth.Click += new System.EventHandler(this.addHealth);
            // 
            // uxHealthAdd
            // 
            this.uxHealthAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxHealthAdd.ForeColor = System.Drawing.Color.Firebrick;
            this.uxHealthAdd.Location = new System.Drawing.Point(12, 251);
            this.uxHealthAdd.Name = "uxHealthAdd";
            this.uxHealthAdd.Size = new System.Drawing.Size(98, 23);
            this.uxHealthAdd.TabIndex = 10;
            this.uxHealthAdd.Text = "Add Health";
            this.uxHealthAdd.UseVisualStyleBackColor = true;
            this.uxHealthAdd.Click += new System.EventHandler(this.addHealthButton_Click);
            // 
            // uxPercent
            // 
            this.uxPercent.LargeChange = 5;
            this.uxPercent.Location = new System.Drawing.Point(12, 235);
            this.uxPercent.Name = "uxPercent";
            this.uxPercent.Size = new System.Drawing.Size(254, 13);
            this.uxPercent.TabIndex = 1;
            this.uxPercent.Value = 50;
            this.uxPercent.Scroll += new System.Windows.Forms.ScrollEventHandler(this.uxPercent_Scroll);
            // 
            // uxManaAdd
            // 
            this.uxManaAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxManaAdd.ForeColor = System.Drawing.Color.RoyalBlue;
            this.uxManaAdd.Location = new System.Drawing.Point(168, 251);
            this.uxManaAdd.Name = "uxManaAdd";
            this.uxManaAdd.Size = new System.Drawing.Size(98, 23);
            this.uxManaAdd.TabIndex = 11;
            this.uxManaAdd.Text = "Add Mana";
            this.uxManaAdd.UseVisualStyleBackColor = true;
            this.uxManaAdd.Click += new System.EventHandler(this.uxMana_Click);
            // 
            // uxManaMenu
            // 
            this.uxManaMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxItemMana});
            this.uxManaMenu.Name = "addHealthMenu";
            this.uxManaMenu.Size = new System.Drawing.Size(108, 26);
            // 
            // uxItemMana
            // 
            this.uxItemMana.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxManaPotion,
            this.uxStrongManaPotion,
            this.uxGreatManaPotion,
            this.uxManaSpiritPotion});
            this.uxItemMana.Name = "uxItemMana";
            this.uxItemMana.Size = new System.Drawing.Size(107, 22);
            this.uxItemMana.Text = "Item";
            // 
            // uxManaPotion
            // 
            this.uxManaPotion.Image = ((System.Drawing.Image)(resources.GetObject("uxManaPotion.Image")));
            this.uxManaPotion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.uxManaPotion.Name = "uxManaPotion";
            this.uxManaPotion.Size = new System.Drawing.Size(195, 38);
            this.uxManaPotion.Text = "Mana Potion";
            this.uxManaPotion.Click += new System.EventHandler(this.addMana);
            // 
            // uxStrongManaPotion
            // 
            this.uxStrongManaPotion.Image = ((System.Drawing.Image)(resources.GetObject("uxStrongManaPotion.Image")));
            this.uxStrongManaPotion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.uxStrongManaPotion.Name = "uxStrongManaPotion";
            this.uxStrongManaPotion.Size = new System.Drawing.Size(195, 38);
            this.uxStrongManaPotion.Text = "Strong Mana Potion";
            this.uxStrongManaPotion.Click += new System.EventHandler(this.addMana);
            // 
            // uxGreatManaPotion
            // 
            this.uxGreatManaPotion.Image = ((System.Drawing.Image)(resources.GetObject("uxGreatManaPotion.Image")));
            this.uxGreatManaPotion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.uxGreatManaPotion.Name = "uxGreatManaPotion";
            this.uxGreatManaPotion.Size = new System.Drawing.Size(195, 38);
            this.uxGreatManaPotion.Text = "Great Mana Potion";
            this.uxGreatManaPotion.Click += new System.EventHandler(this.addMana);
            // 
            // uxManaSpiritPotion
            // 
            this.uxManaSpiritPotion.Image = ((System.Drawing.Image)(resources.GetObject("uxManaSpiritPotion.Image")));
            this.uxManaSpiritPotion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.uxManaSpiritPotion.Name = "uxManaSpiritPotion";
            this.uxManaSpiritPotion.Size = new System.Drawing.Size(195, 38);
            this.uxManaSpiritPotion.Text = "Great Spirit Potion";
            this.uxManaSpiritPotion.Click += new System.EventHandler(this.addMana);
            // 
            // uxLabelPercent
            // 
            this.uxLabelPercent.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabelPercent.Location = new System.Drawing.Point(116, 251);
            this.uxLabelPercent.Name = "uxLabelPercent";
            this.uxLabelPercent.Size = new System.Drawing.Size(46, 23);
            this.uxLabelPercent.TabIndex = 12;
            this.uxLabelPercent.Text = "50%";
            this.uxLabelPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uxOptions
            // 
            this.uxOptions.Controls.Add(this.spellExhaustionLabel);
            this.uxOptions.Controls.Add(this.antidoteCheck);
            this.uxOptions.Controls.Add(this.potionExhaustionLabel);
            this.uxOptions.Controls.Add(this.uxEnable);
            this.uxOptions.Controls.Add(this.paralyzeCheck);
            this.uxOptions.Controls.Add(this.spellExhaustionText);
            this.uxOptions.Controls.Add(this.potionExhaustionText);
            this.uxOptions.Location = new System.Drawing.Point(12, 309);
            this.uxOptions.Name = "uxOptions";
            this.uxOptions.Size = new System.Drawing.Size(254, 91);
            this.uxOptions.TabIndex = 13;
            this.uxOptions.TabStop = false;
            this.uxOptions.Text = "Options";
            // 
            // uxEnable
            // 
            this.uxEnable.AutoSize = true;
            this.uxEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEnable.Location = new System.Drawing.Point(178, 65);
            this.uxEnable.Name = "uxEnable";
            this.uxEnable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uxEnable.Size = new System.Drawing.Size(70, 20);
            this.uxEnable.TabIndex = 16;
            this.uxEnable.Text = "Enable";
            this.uxEnable.UseVisualStyleBackColor = true;
            this.uxEnable.CheckedChanged += new System.EventHandler(this.uxEnable_CheckedChanged);
            // 
            // uxDelete
            // 
            this.uxDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDelete.Location = new System.Drawing.Point(12, 280);
            this.uxDelete.Name = "uxDelete";
            this.uxDelete.Size = new System.Drawing.Size(128, 23);
            this.uxDelete.TabIndex = 14;
            this.uxDelete.Text = "Delete Selected";
            this.uxDelete.UseVisualStyleBackColor = true;
            this.uxDelete.Click += new System.EventHandler(this.uxDelete_Click);
            // 
            // uxList
            // 
            this.uxList.AllowColumnReorder = true;
            this.uxList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.uxColumnPercent,
            this.uxColumnAction,
            this.uxColumnMana});
            this.uxList.FullRowSelect = true;
            this.uxList.GridLines = true;
            listViewGroup1.Header = "Health";
            listViewGroup1.Name = "uxGroupHealth";
            listViewGroup2.Header = "Mana";
            listViewGroup2.Name = "uxGroupMana";
            this.uxList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.uxList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.uxList.Location = new System.Drawing.Point(12, 12);
            this.uxList.Name = "uxList";
            this.uxList.Size = new System.Drawing.Size(254, 220);
            this.uxList.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.uxList.TabIndex = 1;
            this.uxList.UseCompatibleStateImageBehavior = false;
            this.uxList.View = System.Windows.Forms.View.Details;
            // 
            // uxColumnPercent
            // 
            this.uxColumnPercent.DisplayIndex = 1;
            this.uxColumnPercent.Text = "Percent";
            this.uxColumnPercent.Width = 50;
            // 
            // uxColumnAction
            // 
            this.uxColumnAction.DisplayIndex = 0;
            this.uxColumnAction.Text = "Action";
            this.uxColumnAction.Width = 150;
            // 
            // uxColumnMana
            // 
            this.uxColumnMana.Text = "Mana";
            this.uxColumnMana.Width = 50;
            // 
            // uxClear
            // 
            this.uxClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxClear.Location = new System.Drawing.Point(144, 280);
            this.uxClear.Name = "uxClear";
            this.uxClear.Size = new System.Drawing.Size(128, 23);
            this.uxClear.TabIndex = 15;
            this.uxClear.Text = "Clear List";
            this.uxClear.UseVisualStyleBackColor = true;
            this.uxClear.Click += new System.EventHandler(this.uxClear_Click);
            // 
            // uxHealing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 408);
            this.Controls.Add(this.uxClear);
            this.Controls.Add(this.uxList);
            this.Controls.Add(this.uxOptions);
            this.Controls.Add(this.uxPercent);
            this.Controls.Add(this.uxLabelPercent);
            this.Controls.Add(this.uxHealthAdd);
            this.Controls.Add(this.uxDelete);
            this.Controls.Add(this.uxManaAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "uxHealing";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Healing";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.HealingForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.uxHealing_FormClosing);
            this.uxHealthMenu.ResumeLayout(false);
            this.uxManaMenu.ResumeLayout(false);
            this.uxOptions.ResumeLayout(false);
            this.uxOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox potionExhaustionText;
        private System.Windows.Forms.Label potionExhaustionLabel;
        private System.Windows.Forms.Label spellExhaustionLabel;
        private System.Windows.Forms.TextBox spellExhaustionText;
        private System.Windows.Forms.CheckBox paralyzeCheck;
        private System.Windows.Forms.CheckBox antidoteCheck;
        private System.Windows.Forms.ContextMenuStrip uxHealthMenu;
        private System.Windows.Forms.ToolStripMenuItem uxItemHealth;
        private System.Windows.Forms.ToolStripMenuItem uxUHHealth;
        private System.Windows.Forms.ToolStripMenuItem uxIHHealth;
        private System.Windows.Forms.ToolStripMenuItem uxSmallHealthPotion;
        private System.Windows.Forms.ToolStripMenuItem uxHealthPotion;
        private System.Windows.Forms.ToolStripMenuItem uxStrongHealthPotion;
        private System.Windows.Forms.ToolStripMenuItem uxGreatHealthPotion;
        private System.Windows.Forms.ToolStripMenuItem uxUltimateHealthPotion;
        private System.Windows.Forms.ToolStripMenuItem uxHealthSpiritPotion;
        private System.Windows.Forms.ToolStripMenuItem uxSpellHealth;
        private System.Windows.Forms.ToolStripTextBox uxSpellWords;
        private System.Windows.Forms.Button uxHealthAdd;
        private System.Windows.Forms.ToolStripMenuItem uxAddSpellHealth;
        private System.Windows.Forms.ToolStripTextBox uxSpellMana;
        private System.Windows.Forms.HScrollBar uxPercent;
        private System.Windows.Forms.Button uxManaAdd;
        private System.Windows.Forms.ContextMenuStrip uxManaMenu;
        private System.Windows.Forms.ToolStripMenuItem uxItemMana;
        private System.Windows.Forms.ToolStripMenuItem uxManaPotion;
        private System.Windows.Forms.ToolStripMenuItem uxStrongManaPotion;
        private System.Windows.Forms.ToolStripMenuItem uxGreatManaPotion;
        private System.Windows.Forms.ToolStripMenuItem uxManaSpiritPotion;
        private System.Windows.Forms.Label uxLabelPercent;
        private System.Windows.Forms.GroupBox uxOptions;
        private System.Windows.Forms.Button uxDelete;
        private System.Windows.Forms.CheckBox uxEnable;
        private System.Windows.Forms.ListView uxList;
        private System.Windows.Forms.ColumnHeader uxColumnPercent;
        private System.Windows.Forms.ColumnHeader uxColumnAction;
        private System.Windows.Forms.ColumnHeader uxColumnMana;
        private System.Windows.Forms.Button uxClear;
    }
}