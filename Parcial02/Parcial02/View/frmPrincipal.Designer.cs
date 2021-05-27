using System.ComponentModel;

namespace Parcial02
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnDoReservation = new System.Windows.Forms.Button();
            this.btnShowR = new System.Windows.Forms.Button();
            this.btnUpdateANDCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabGeneral = new System.Windows.Forms.TabControl();
            this.tabPrincipal = new System.Windows.Forms.TabPage();
            this.tabDate = new System.Windows.Forms.TabPage();
            this.tabView = new System.Windows.Forms.TabPage();
            this.tabUpdate = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.tabGeneral.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDoReservation
            // 
            this.btnDoReservation.BackColor = System.Drawing.Color.Transparent;
            this.btnDoReservation.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("btnDoReservation.BackgroundImage")));
            this.btnDoReservation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDoReservation.Location = new System.Drawing.Point(67, 293);
            this.btnDoReservation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDoReservation.Name = "btnDoReservation";
            this.btnDoReservation.Size = new System.Drawing.Size(150, 110);
            this.btnDoReservation.TabIndex = 0;
            this.btnDoReservation.UseVisualStyleBackColor = false;
            this.btnDoReservation.Click += new System.EventHandler(this.btnDoReservation_Click);
            // 
            // btnShowR
            // 
            this.btnShowR.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("btnShowR.BackgroundImage")));
            this.btnShowR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowR.Location = new System.Drawing.Point(250, 293);
            this.btnShowR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowR.Name = "btnShowR";
            this.btnShowR.Size = new System.Drawing.Size(150, 110);
            this.btnShowR.TabIndex = 1;
            this.btnShowR.UseVisualStyleBackColor = true;
            this.btnShowR.Click += new System.EventHandler(this.btnShowR_Click);
            // 
            // btnUpdateANDCancel
            // 
            this.btnUpdateANDCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateANDCancel.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("btnUpdateANDCancel.BackgroundImage")));
            this.btnUpdateANDCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateANDCancel.Location = new System.Drawing.Point(442, 293);
            this.btnUpdateANDCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateANDCancel.Name = "btnUpdateANDCancel";
            this.btnUpdateANDCancel.Size = new System.Drawing.Size(150, 110);
            this.btnUpdateANDCancel.TabIndex = 2;
            this.btnUpdateANDCancel.UseVisualStyleBackColor = false;
            this.btnUpdateANDCancel.Click += new System.EventHandler(this.btnUpdateANDCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(675, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(67, 399);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 77);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hacer\r\nuna cita";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(250, 402);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 74);
            this.label2.TabIndex = 5;
            this.label2.Text = " Citas \r\nexistentes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(442, 399);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 106);
            this.label3.TabIndex = 6;
            this.label3.Text = "Actualizar y Cancelar Citas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tabPrincipal);
            this.tabGeneral.Controls.Add(this.tabDate);
            this.tabGeneral.Controls.Add(this.tabView);
            this.tabGeneral.Controls.Add(this.tabUpdate);
            this.tabGeneral.Location = new System.Drawing.Point(-3, 0);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(674, 574);
            this.tabGeneral.TabIndex = 7;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.pictureBox1);
            this.tabPrincipal.Controls.Add(this.label3);
            this.tabPrincipal.Controls.Add(this.btnDoReservation);
            this.tabPrincipal.Controls.Add(this.label2);
            this.tabPrincipal.Controls.Add(this.btnShowR);
            this.tabPrincipal.Controls.Add(this.label1);
            this.tabPrincipal.Controls.Add(this.btnUpdateANDCancel);
            this.tabPrincipal.Location = new System.Drawing.Point(4, 30);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrincipal.Size = new System.Drawing.Size(666, 540);
            this.tabPrincipal.TabIndex = 0;
            this.tabPrincipal.Text = "Pagina principal";
            this.tabPrincipal.UseVisualStyleBackColor = true;
            // 
            // tabDate
            // 
            this.tabDate.Location = new System.Drawing.Point(4, 30);
            this.tabDate.Name = "tabDate";
            this.tabDate.Padding = new System.Windows.Forms.Padding(3);
            this.tabDate.Size = new System.Drawing.Size(666, 540);
            this.tabDate.TabIndex = 1;
            this.tabDate.Text = "Hacer cita";
            this.tabDate.UseVisualStyleBackColor = true;
            this.tabDate.MouseEnter += new System.EventHandler(this.tabDate_MouseEnter);
            // 
            // tabView
            // 
            this.tabView.Location = new System.Drawing.Point(4, 30);
            this.tabView.Name = "tabView";
            this.tabView.Padding = new System.Windows.Forms.Padding(3);
            this.tabView.Size = new System.Drawing.Size(666, 540);
            this.tabView.TabIndex = 2;
            this.tabView.Text = "Ver citas";
            this.tabView.UseVisualStyleBackColor = true;
            this.tabView.Enter += new System.EventHandler(this.tabView_Enter);
            // 
            // tabUpdate
            // 
            this.tabUpdate.Location = new System.Drawing.Point(4, 30);
            this.tabUpdate.Name = "tabUpdate";
            this.tabUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdate.Size = new System.Drawing.Size(666, 540);
            this.tabUpdate.TabIndex = 3;
            this.tabUpdate.Text = "Modificar citas";
            this.tabUpdate.UseVisualStyleBackColor = true;
            this.tabUpdate.Enter += new System.EventHandler(this.tabUpdate_Enter);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(669, 575);
            this.Controls.Add(this.tabGeneral);
            this.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.tabGeneral.ResumeLayout(false);
            this.tabPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnCancel;

        private System.Windows.Forms.Button btnDoRes;

        private System.Windows.Forms.ComboBox cmbSpecialities;

        private System.Windows.Forms.DateTimePicker dtpTime;

        private System.Windows.Forms.DateTimePicker dtpDate;

        private System.Windows.Forms.Label lblTitleTime;

        private System.Windows.Forms.TextBox txtUser;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.TabPage tabDate;

        private System.Windows.Forms.TabPage tabView;
        private System.Windows.Forms.TabPage tabUpdate;

        private System.Windows.Forms.TabPage tabPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        
        private System.Windows.Forms.TabControl tabGeneral;
        private System.Windows.Forms.Button btnUpdateANDCancel;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button btnShowR;
        

        private System.Windows.Forms.Button btnDoReservation;

        #endregion
    }
}