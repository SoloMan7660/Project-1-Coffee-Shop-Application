namespace Project_1
{
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            drinkListBox = new ListBox();
            radioButtons = new GroupBox();
            largeRadioButton = new RadioButton();
            mediumRadioButton = new RadioButton();
            smallRadioButton = new RadioButton();
            quantityTextBox = new TextBox();
            label1 = new Label();
            addButton = new Button();
            orderListBox = new ListBox();
            totalLabel = new Label();
            removeButton = new Button();
            clearButton = new Button();
            checkoutButton = new Button();
            titleProject = new Label();
            radioButtons.SuspendLayout();
            SuspendLayout();
            // 
            // drinkListBox
            // 
            drinkListBox.FormattingEnabled = true;
            drinkListBox.Items.AddRange(new object[] { "Coffee", "Latte", "Tea" });
            drinkListBox.Location = new Point(132, 390);
            drinkListBox.Name = "drinkListBox";
            drinkListBox.Size = new Size(204, 228);
            drinkListBox.TabIndex = 0;
            drinkListBox.SelectedIndexChanged += drinkListBox_SelectedIndexChanged;
            // 
            // radioButtons
            // 
            radioButtons.Controls.Add(largeRadioButton);
            radioButtons.Controls.Add(mediumRadioButton);
            radioButtons.Controls.Add(smallRadioButton);
            radioButtons.Location = new Point(483, 393);
            radioButtons.Name = "radioButtons";
            radioButtons.Size = new Size(243, 241);
            radioButtons.TabIndex = 1;
            radioButtons.TabStop = false;
            radioButtons.Enter += radioButtons_Enter;
            // 
            // largeRadioButton
            // 
            largeRadioButton.AutoSize = true;
            largeRadioButton.Location = new Point(6, 174);
            largeRadioButton.Name = "largeRadioButton";
            largeRadioButton.Size = new Size(190, 36);
            largeRadioButton.TabIndex = 2;
            largeRadioButton.TabStop = true;
            largeRadioButton.Text = "Large(+$1.00)";
            largeRadioButton.UseVisualStyleBackColor = true;
            largeRadioButton.CheckedChanged += largeRadioButton_CheckedChanged;
            // 
            // mediumRadioButton
            // 
            mediumRadioButton.AutoSize = true;
            mediumRadioButton.Location = new Point(6, 126);
            mediumRadioButton.Name = "mediumRadioButton";
            mediumRadioButton.Size = new Size(222, 36);
            mediumRadioButton.TabIndex = 1;
            mediumRadioButton.TabStop = true;
            mediumRadioButton.Text = "Medium(+$0.50)";
            mediumRadioButton.UseVisualStyleBackColor = true;
            mediumRadioButton.CheckedChanged += mediumRadioButton_CheckedChanged;
            // 
            // smallRadioButton
            // 
            smallRadioButton.AutoSize = true;
            smallRadioButton.Location = new Point(8, 84);
            smallRadioButton.Name = "smallRadioButton";
            smallRadioButton.Size = new Size(190, 36);
            smallRadioButton.TabIndex = 0;
            smallRadioButton.TabStop = true;
            smallRadioButton.Text = "Small(+$0.00)";
            smallRadioButton.UseVisualStyleBackColor = true;
            smallRadioButton.CheckedChanged += smallRadioButton_CheckedChanged;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(467, 719);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(259, 39);
            quantityTextBox.TabIndex = 2;
            quantityTextBox.TextChanged += quantityTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(346, 726);
            label1.Name = "label1";
            label1.Size = new Size(111, 32);
            label1.TabIndex = 3;
            label1.Text = "Quantity:";
            // 
            // addButton
            // 
            addButton.Location = new Point(484, 651);
            addButton.Name = "addButton";
            addButton.Size = new Size(245, 42);
            addButton.TabIndex = 4;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // orderListBox
            // 
            orderListBox.FormattingEnabled = true;
            orderListBox.Location = new Point(855, 404);
            orderListBox.Name = "orderListBox";
            orderListBox.Size = new Size(346, 196);
            orderListBox.TabIndex = 5;
            orderListBox.SelectedIndexChanged += orderListBox_SelectedIndexChanged;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(919, 726);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(65, 32);
            totalLabel.TabIndex = 6;
            totalLabel.Text = "Total";
            totalLabel.Click += totalLabel_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(1207, 438);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(215, 49);
            removeButton.TabIndex = 7;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(1207, 511);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(215, 49);
            clearButton.TabIndex = 8;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // checkoutButton
            // 
            checkoutButton.Location = new Point(1113, 709);
            checkoutButton.Name = "checkoutButton";
            checkoutButton.Size = new Size(215, 49);
            checkoutButton.TabIndex = 9;
            checkoutButton.Text = "Checkout";
            checkoutButton.UseVisualStyleBackColor = true;
            checkoutButton.Click += checkoutButton_Click;
            // 
            // titleProject
            // 
            titleProject.AutoSize = true;
            titleProject.Font = new Font("Elephant", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleProject.Location = new Point(415, 141);
            titleProject.Name = "titleProject";
            titleProject.Size = new Size(569, 123);
            titleProject.TabIndex = 10;
            titleProject.Text = "Solo's Cafe";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1468, 878);
            Controls.Add(titleProject);
            Controls.Add(checkoutButton);
            Controls.Add(clearButton);
            Controls.Add(removeButton);
            Controls.Add(totalLabel);
            Controls.Add(orderListBox);
            Controls.Add(addButton);
            Controls.Add(label1);
            Controls.Add(quantityTextBox);
            Controls.Add(radioButtons);
            Controls.Add(drinkListBox);
            Name = "Form1";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Form1";
            Load += Form1_Load;
            radioButtons.ResumeLayout(false);
            radioButtons.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox drinkListBox;
        private GroupBox radioButtons;
        private RadioButton largeRadioButton;
        private RadioButton mediumRadioButton;
        private RadioButton smallRadioButton;
        private TextBox quantityTextBox;
        private Label label1;
        private Button addButton;
        private ListBox orderListBox;
        private Label totalLabel;
        private Button removeButton;
        private Button clearButton;
        private Button checkoutButton;
        private Label titleProject;
    }
}
