using System.ComponentModel;

namespace Parcial02
{
    partial class frmCreateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateUser));
            this.tlpCreateUser = new System.Windows.Forms.TableLayoutPanel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblCarnet = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRepeatPass = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtRPass = new System.Windows.Forms.TextBox();
            this.txtAnwser = new System.Windows.Forms.TextBox();
            this.cmbQuestions = new System.Windows.Forms.ComboBox();
            this.lblTitleCreate = new System.Windows.Forms.Label();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picCreateMenu = new System.Windows.Forms.PictureBox();
            this.tlpCreateUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picCreateMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpCreateUser
            // 
            this.tlpCreateUser.ColumnCount = 2;
            this.tlpCreateUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.99443F));
            this.tlpCreateUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.00557F));
            this.tlpCreateUser.Controls.Add(this.txtUsername, 1, 1);
            this.tlpCreateUser.Controls.Add(this.lblAnswer, 0, 5);
            this.tlpCreateUser.Controls.Add(this.lblCarnet, 0, 0);
            this.tlpCreateUser.Controls.Add(this.lblUsername, 0, 1);
            this.tlpCreateUser.Controls.Add(this.lblPassword, 0, 2);
            this.tlpCreateUser.Controls.Add(this.lblRepeatPass, 0, 3);
            this.tlpCreateUser.Controls.Add(this.lblQuestion, 0, 4);
            this.tlpCreateUser.Controls.Add(this.txtCarnet, 1, 0);
            this.tlpCreateUser.Controls.Add(this.txtPass, 1, 2);
            this.tlpCreateUser.Controls.Add(this.txtRPass, 1, 3);
            this.tlpCreateUser.Controls.Add(this.txtAnwser, 1, 5);
            this.tlpCreateUser.Controls.Add(this.cmbQuestions, 1, 4);
            this.tlpCreateUser.Location = new System.Drawing.Point(9, 109);
            this.tlpCreateUser.Name = "tlpCreateUser";
            this.tlpCreateUser.RowCount = 6;
            this.tlpCreateUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66668F));
            this.tlpCreateUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tlpCreateUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tlpCreateUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tlpCreateUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tlpCreateUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpCreateUser.Size = new System.Drawing.Size(601, 465);
            this.tlpCreateUser.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtUsername.Location = new System.Drawing.Point(171, 102);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(427, 27);
            this.txtUsername.TabIndex = 7;
            // 
            // lblAnswer
            // 
            this.lblAnswer.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAnswer.Location = new System.Drawing.Point(3, 385);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(162, 71);
            this.lblAnswer.TabIndex = 5;
            this.lblAnswer.Text = "Respuesta:";
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCarnet
            // 
            this.lblCarnet.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblCarnet.Location = new System.Drawing.Point(3, 0);
            this.lblCarnet.Name = "lblCarnet";
            this.lblCarnet.Size = new System.Drawing.Size(162, 71);
            this.lblCarnet.TabIndex = 0;
            this.lblCarnet.Text = "Ingresa tu carnet:";
            this.lblCarnet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblUsername.Location = new System.Drawing.Point(3, 77);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(162, 71);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Ingresa tu nombre de usuario:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPassword.Location = new System.Drawing.Point(3, 154);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(162, 71);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Ingresa tu contraseña:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRepeatPass
            // 
            this.lblRepeatPass.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblRepeatPass.Location = new System.Drawing.Point(3, 231);
            this.lblRepeatPass.Name = "lblRepeatPass";
            this.lblRepeatPass.Size = new System.Drawing.Size(162, 71);
            this.lblRepeatPass.TabIndex = 3;
            this.lblRepeatPass.Text = "Repite la contraseña:";
            this.lblRepeatPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblQuestion.Location = new System.Drawing.Point(3, 308);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(162, 71);
            this.lblQuestion.TabIndex = 4;
            this.lblQuestion.Text = "Pregunta de seguridad:";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCarnet
            // 
            this.txtCarnet.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCarnet.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtCarnet.Location = new System.Drawing.Point(171, 25);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(427, 27);
            this.txtCarnet.TabIndex = 6;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtPass.Location = new System.Drawing.Point(171, 179);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(427, 27);
            this.txtPass.TabIndex = 8;
            // 
            // txtRPass
            // 
            this.txtRPass.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRPass.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtRPass.Location = new System.Drawing.Point(171, 256);
            this.txtRPass.Name = "txtRPass";
            this.txtRPass.PasswordChar = '*';
            this.txtRPass.Size = new System.Drawing.Size(427, 27);
            this.txtRPass.TabIndex = 9;
            // 
            // txtAnwser
            // 
            this.txtAnwser.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnwser.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtAnwser.Location = new System.Drawing.Point(171, 411);
            this.txtAnwser.Name = "txtAnwser";
            this.txtAnwser.Size = new System.Drawing.Size(427, 27);
            this.txtAnwser.TabIndex = 11;
            // 
            // cmbQuestions
            // 
            this.cmbQuestions.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbQuestions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuestions.FormattingEnabled = true;
            this.cmbQuestions.Location = new System.Drawing.Point(171, 334);
            this.cmbQuestions.Name = "cmbQuestions";
            this.cmbQuestions.Size = new System.Drawing.Size(427, 25);
            this.cmbQuestions.TabIndex = 12;
            // 
            // lblTitleCreate
            // 
            this.lblTitleCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitleCreate.Font = new System.Drawing.Font("Franklin Gothic Book", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTitleCreate.Location = new System.Drawing.Point(148, 9);
            this.lblTitleCreate.Name = "lblTitleCreate";
            this.lblTitleCreate.Size = new System.Drawing.Size(462, 104);
            this.lblTitleCreate.TabIndex = 0;
            this.lblTitleCreate.Text = "Bienvenido a Clínica UCA\r\n¡Regístrate!";
            this.lblTitleCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (67)))), ((int) (((byte) (143)))), ((int) (((byte) (214)))));
            this.btnCreateUser.Font = new System.Drawing.Font("Franklin Gothic Book", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCreateUser.Location = new System.Drawing.Point(345, 590);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(210, 67);
            this.btnCreateUser.TabIndex = 1;
            this.btnCreateUser.Text = "Crear usuario";
            this.btnCreateUser.UseVisualStyleBackColor = false;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.btnCancel.Font = new System.Drawing.Font("Franklin Gothic Book", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCancel.Location = new System.Drawing.Point(67, 590);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(210, 67);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // picCreateMenu
            // 
            this.picCreateMenu.Image = ((System.Drawing.Image) (resources.GetObject("picCreateMenu.Image")));
            this.picCreateMenu.Location = new System.Drawing.Point(9, 2);
            this.picCreateMenu.Name = "picCreateMenu";
            this.picCreateMenu.Size = new System.Drawing.Size(133, 104);
            this.picCreateMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCreateMenu.TabIndex = 3;
            this.picCreateMenu.TabStop = false;
            // 
            // frmCreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 669);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.lblTitleCreate);
            this.Controls.Add(this.tlpCreateUser);
            this.Controls.Add(this.picCreateMenu);
            this.Font = new System.Drawing.Font("Franklin Gothic Book", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCreateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCreateUser_FormClosing);
            this.Load += new System.EventHandler(this.frmCreateUser_Load);
            this.tlpCreateUser.ResumeLayout(false);
            this.tlpCreateUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picCreateMenu)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox cmbQuestions;

        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtRPass;
        private System.Windows.Forms.TextBox txtAnwser;

        private System.Windows.Forms.PictureBox picCreateMenu;

        private System.Windows.Forms.Button btnCancel;

        private System.Windows.Forms.TextBox txtUsername;

        private System.Windows.Forms.TextBox txtCarnet;

       

        private System.Windows.Forms.Button btnCreateUser;

        private System.Windows.Forms.Label lblRepeatPass;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblAnswer;

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
       

        private System.Windows.Forms.Label lblCarnet;
       

        private System.Windows.Forms.Label lblTitleCreate;

        private System.Windows.Forms.TableLayoutPanel tlpCreateUser;

       

        #endregion
    }
}