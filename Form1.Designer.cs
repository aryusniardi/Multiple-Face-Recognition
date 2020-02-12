namespace UAS_ComputerVision_MultipleFaceDetectionAndRecognition
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imageBoxGrey = new Emgu.CV.UI.ImageBox();
            this.addFaceButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numbersOfFaces = new System.Windows.Forms.Label();
            this.personsLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.detectAndRecognizeButton = new System.Windows.Forms.Button();
            this.imageBoxResult = new Emgu.CV.UI.ImageBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxGrey)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxResult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imageBoxGrey);
            this.groupBox1.Controls.Add(this.addFaceButton);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(329, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 281);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Training : ";
            // 
            // imageBoxGrey
            // 
            this.imageBoxGrey.Location = new System.Drawing.Point(9, 19);
            this.imageBoxGrey.Name = "imageBoxGrey";
            this.imageBoxGrey.Size = new System.Drawing.Size(185, 145);
            this.imageBoxGrey.TabIndex = 2;
            this.imageBoxGrey.TabStop = false;
            // 
            // addFaceButton
            // 
            this.addFaceButton.Location = new System.Drawing.Point(7, 252);
            this.addFaceButton.Name = "addFaceButton";
            this.addFaceButton.Size = new System.Drawing.Size(187, 23);
            this.addFaceButton.TabIndex = 5;
            this.addFaceButton.Text = "Add Face";
            this.addFaceButton.UseVisualStyleBackColor = true;
            this.addFaceButton.Click += new System.EventHandler(this.addFaceButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numbersOfFaces);
            this.groupBox2.Controls.Add(this.personsLabel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.detectAndRecognizeButton);
            this.groupBox2.Location = new System.Drawing.Point(536, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 280);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results : ";
            // 
            // numbersOfFaces
            // 
            this.numbersOfFaces.AutoSize = true;
            this.numbersOfFaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbersOfFaces.ForeColor = System.Drawing.Color.Crimson;
            this.numbersOfFaces.Location = new System.Drawing.Point(17, 176);
            this.numbersOfFaces.Name = "numbersOfFaces";
            this.numbersOfFaces.Size = new System.Drawing.Size(216, 20);
            this.numbersOfFaces.TabIndex = 4;
            this.numbersOfFaces.Text = "Number of Face Detected";
            this.numbersOfFaces.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // personsLabel
            // 
            this.personsLabel.AutoSize = true;
            this.personsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personsLabel.ForeColor = System.Drawing.Color.Crimson;
            this.personsLabel.Location = new System.Drawing.Point(32, 46);
            this.personsLabel.Name = "personsLabel";
            this.personsLabel.Size = new System.Drawing.Size(177, 20);
            this.personsLabel.TabIndex = 3;
            this.personsLabel.Text = "Names of the Person";
            this.personsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Faces Detected : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Persons present in the Scene : ";
            // 
            // detectAndRecognizeButton
            // 
            this.detectAndRecognizeButton.Location = new System.Drawing.Point(6, 250);
            this.detectAndRecognizeButton.Name = "detectAndRecognizeButton";
            this.detectAndRecognizeButton.Size = new System.Drawing.Size(240, 23);
            this.detectAndRecognizeButton.TabIndex = 0;
            this.detectAndRecognizeButton.Text = "Detect and Recognize";
            this.detectAndRecognizeButton.UseVisualStyleBackColor = true;
            this.detectAndRecognizeButton.Click += new System.EventHandler(this.detectAndRecognizeButton_Click);
            // 
            // imageBoxResult
            // 
            this.imageBoxResult.Location = new System.Drawing.Point(12, 13);
            this.imageBoxResult.Name = "imageBoxResult";
            this.imageBoxResult.Size = new System.Drawing.Size(311, 280);
            this.imageBoxResult.TabIndex = 2;
            this.imageBoxResult.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 309);
            this.Controls.Add(this.imageBoxResult);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Multiple Face Detection and Recognition";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxGrey)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addFaceButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label numbersOfFaces;
        private System.Windows.Forms.Label personsLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button detectAndRecognizeButton;
        private Emgu.CV.UI.ImageBox imageBoxGrey;
        private Emgu.CV.UI.ImageBox imageBoxResult;
    }
}

