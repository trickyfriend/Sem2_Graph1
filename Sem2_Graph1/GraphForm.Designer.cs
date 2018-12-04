namespace Sem2_Graph1
{
    partial class GraphForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.labelNumber = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.radioButtonNodeAdd = new System.Windows.Forms.RadioButton();
            this.radioButtonEdgeAdd = new System.Windows.Forms.RadioButton();
            this.radioButtonNodeRemove = new System.Windows.Forms.RadioButton();
            this.radioButtonEdgeRemove = new System.Windows.Forms.RadioButton();
            this.radioButtonNodeMove = new System.Windows.Forms.RadioButton();
            this.textBoxNodeValue = new System.Windows.Forms.TextBox();
            this.textBoxEdgeWeight = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(27, 31);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(743, 596);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(792, 31);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(314, 50);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load File";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(792, 87);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(314, 50);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save File";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(792, 159);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(314, 50);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRun.ForeColor = System.Drawing.Color.Firebrick;
            this.buttonRun.Location = new System.Drawing.Point(792, 444);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(130, 135);
            this.buttonRun.TabIndex = 4;
            this.buttonRun.Text = "FIND THE NODE";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelNumber.Location = new System.Drawing.Point(960, 444);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(0, 135);
            this.labelNumber.TabIndex = 5;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // radioButtonNodeAdd
            // 
            this.radioButtonNodeAdd.AutoSize = true;
            this.radioButtonNodeAdd.Checked = true;
            this.radioButtonNodeAdd.Location = new System.Drawing.Point(792, 245);
            this.radioButtonNodeAdd.Name = "radioButtonNodeAdd";
            this.radioButtonNodeAdd.Size = new System.Drawing.Size(96, 21);
            this.radioButtonNodeAdd.TabIndex = 6;
            this.radioButtonNodeAdd.TabStop = true;
            this.radioButtonNodeAdd.Text = "Add Node:";
            this.radioButtonNodeAdd.UseVisualStyleBackColor = true;
            // 
            // radioButtonEdgeAdd
            // 
            this.radioButtonEdgeAdd.AutoSize = true;
            this.radioButtonEdgeAdd.Location = new System.Drawing.Point(792, 272);
            this.radioButtonEdgeAdd.Name = "radioButtonEdgeAdd";
            this.radioButtonEdgeAdd.Size = new System.Drawing.Size(95, 21);
            this.radioButtonEdgeAdd.TabIndex = 7;
            this.radioButtonEdgeAdd.Text = "Add Edge:";
            this.radioButtonEdgeAdd.UseVisualStyleBackColor = true;
            // 
            // radioButtonNodeRemove
            // 
            this.radioButtonNodeRemove.AutoSize = true;
            this.radioButtonNodeRemove.Location = new System.Drawing.Point(792, 318);
            this.radioButtonNodeRemove.Name = "radioButtonNodeRemove";
            this.radioButtonNodeRemove.Size = new System.Drawing.Size(178, 21);
            this.radioButtonNodeRemove.TabIndex = 8;
            this.radioButtonNodeRemove.Text = "Remove Selected Node";
            this.radioButtonNodeRemove.UseVisualStyleBackColor = true;
            // 
            // radioButtonEdgeRemove
            // 
            this.radioButtonEdgeRemove.AutoSize = true;
            this.radioButtonEdgeRemove.Location = new System.Drawing.Point(792, 345);
            this.radioButtonEdgeRemove.Name = "radioButtonEdgeRemove";
            this.radioButtonEdgeRemove.Size = new System.Drawing.Size(177, 21);
            this.radioButtonEdgeRemove.TabIndex = 9;
            this.radioButtonEdgeRemove.Text = "Remove Selected Edge";
            this.radioButtonEdgeRemove.UseVisualStyleBackColor = true;
            // 
            // radioButtonNodeMove
            // 
            this.radioButtonNodeMove.AutoSize = true;
            this.radioButtonNodeMove.Location = new System.Drawing.Point(792, 388);
            this.radioButtonNodeMove.Name = "radioButtonNodeMove";
            this.radioButtonNodeMove.Size = new System.Drawing.Size(160, 21);
            this.radioButtonNodeMove.TabIndex = 10;
            this.radioButtonNodeMove.Text = "Move Selected Node";
            this.radioButtonNodeMove.UseVisualStyleBackColor = true;
            // 
            // textBoxNodeValue
            // 
            this.textBoxNodeValue.Location = new System.Drawing.Point(904, 244);
            this.textBoxNodeValue.Name = "textBoxNodeValue";
            this.textBoxNodeValue.Size = new System.Drawing.Size(40, 22);
            this.textBoxNodeValue.TabIndex = 11;
            this.textBoxNodeValue.Text = "1";
            // 
            // textBoxEdgeWeight
            // 
            this.textBoxEdgeWeight.Location = new System.Drawing.Point(904, 272);
            this.textBoxEdgeWeight.Name = "textBoxEdgeWeight";
            this.textBoxEdgeWeight.Size = new System.Drawing.Size(40, 22);
            this.textBoxEdgeWeight.TabIndex = 12;
            this.textBoxEdgeWeight.Text = "1";
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 655);
            this.Controls.Add(this.textBoxEdgeWeight);
            this.Controls.Add(this.textBoxNodeValue);
            this.Controls.Add(this.radioButtonNodeMove);
            this.Controls.Add(this.radioButtonEdgeRemove);
            this.Controls.Add(this.radioButtonNodeRemove);
            this.Controls.Add(this.radioButtonEdgeAdd);
            this.Controls.Add(this.radioButtonNodeAdd);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.pictureBox);
            this.Name = "GraphForm";
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.GraphForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.RadioButton radioButtonNodeAdd;
        private System.Windows.Forms.RadioButton radioButtonEdgeAdd;
        private System.Windows.Forms.RadioButton radioButtonNodeRemove;
        private System.Windows.Forms.RadioButton radioButtonEdgeRemove;
        private System.Windows.Forms.RadioButton radioButtonNodeMove;
        private System.Windows.Forms.TextBox textBoxNodeValue;
        private System.Windows.Forms.TextBox textBoxEdgeWeight;
    }
}

