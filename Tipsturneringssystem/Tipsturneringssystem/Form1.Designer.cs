namespace Tipsturneringssystem
{
    partial class Main
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
            this.btn_opretTurnering = new System.Windows.Forms.Button();
            this.btn_opretCup = new System.Windows.Forms.Button();
            this.btn_seStilling = new System.Windows.Forms.Button();
            this.btn_tidligereTurneringer = new System.Windows.Forms.Button();
            this.btn_opretBruger = new System.Windows.Forms.Button();
            this.btn_opretTips = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_opretBruger = new System.Windows.Forms.Panel();
            this.dataGridView_Brugernavn = new System.Windows.Forms.DataGridView();
            this.btn_gemBruger = new System.Windows.Forms.Button();
            this.txt_opretBruger = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_opretBruger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Brugernavn)).BeginInit();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_opretTurnering
            // 
            this.btn_opretTurnering.Location = new System.Drawing.Point(13, 13);
            this.btn_opretTurnering.Name = "btn_opretTurnering";
            this.btn_opretTurnering.Size = new System.Drawing.Size(132, 50);
            this.btn_opretTurnering.TabIndex = 0;
            this.btn_opretTurnering.Text = "Opret Turnering";
            this.btn_opretTurnering.UseVisualStyleBackColor = true;
            // 
            // btn_opretCup
            // 
            this.btn_opretCup.Location = new System.Drawing.Point(12, 69);
            this.btn_opretCup.Name = "btn_opretCup";
            this.btn_opretCup.Size = new System.Drawing.Size(133, 50);
            this.btn_opretCup.TabIndex = 1;
            this.btn_opretCup.Text = "Opret Cup";
            this.btn_opretCup.UseVisualStyleBackColor = true;
            // 
            // btn_seStilling
            // 
            this.btn_seStilling.Location = new System.Drawing.Point(12, 125);
            this.btn_seStilling.Name = "btn_seStilling";
            this.btn_seStilling.Size = new System.Drawing.Size(132, 50);
            this.btn_seStilling.TabIndex = 2;
            this.btn_seStilling.Text = "Se Stilling";
            this.btn_seStilling.UseVisualStyleBackColor = true;
            // 
            // btn_tidligereTurneringer
            // 
            this.btn_tidligereTurneringer.Location = new System.Drawing.Point(12, 181);
            this.btn_tidligereTurneringer.Name = "btn_tidligereTurneringer";
            this.btn_tidligereTurneringer.Size = new System.Drawing.Size(132, 50);
            this.btn_tidligereTurneringer.TabIndex = 3;
            this.btn_tidligereTurneringer.Text = "Tidligere Turneringer";
            this.btn_tidligereTurneringer.UseVisualStyleBackColor = true;
            // 
            // btn_opretBruger
            // 
            this.btn_opretBruger.Location = new System.Drawing.Point(12, 237);
            this.btn_opretBruger.Name = "btn_opretBruger";
            this.btn_opretBruger.Size = new System.Drawing.Size(132, 50);
            this.btn_opretBruger.TabIndex = 4;
            this.btn_opretBruger.Text = "Opret bruger";
            this.btn_opretBruger.UseVisualStyleBackColor = true;
            this.btn_opretBruger.Click += new System.EventHandler(this.btn_opretBruger_Click);
            // 
            // btn_opretTips
            // 
            this.btn_opretTips.Location = new System.Drawing.Point(12, 293);
            this.btn_opretTips.Name = "btn_opretTips";
            this.btn_opretTips.Size = new System.Drawing.Size(132, 50);
            this.btn_opretTips.TabIndex = 5;
            this.btn_opretTips.Text = "Opret Tips";
            this.btn_opretTips.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(124, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(495, 330);
            this.dataGridView1.TabIndex = 6;
            // 
            // panel_opretBruger
            // 
            this.panel_opretBruger.Controls.Add(this.dataGridView_Brugernavn);
            this.panel_opretBruger.Controls.Add(this.btn_gemBruger);
            this.panel_opretBruger.Controls.Add(this.txt_opretBruger);
            this.panel_opretBruger.Controls.Add(this.label1);
            this.panel_opretBruger.Location = new System.Drawing.Point(152, 13);
            this.panel_opretBruger.Name = "panel_opretBruger";
            this.panel_opretBruger.Size = new System.Drawing.Size(618, 408);
            this.panel_opretBruger.TabIndex = 7;
            // 
            // dataGridView_Brugernavn
            // 
            this.dataGridView_Brugernavn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Brugernavn.Location = new System.Drawing.Point(426, 0);
            this.dataGridView_Brugernavn.Name = "dataGridView_Brugernavn";
            this.dataGridView_Brugernavn.RowTemplate.Height = 24;
            this.dataGridView_Brugernavn.Size = new System.Drawing.Size(188, 330);
            this.dataGridView_Brugernavn.TabIndex = 3;
            // 
            // btn_gemBruger
            // 
            this.btn_gemBruger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gemBruger.Location = new System.Drawing.Point(8, 93);
            this.btn_gemBruger.Name = "btn_gemBruger";
            this.btn_gemBruger.Size = new System.Drawing.Size(177, 69);
            this.btn_gemBruger.TabIndex = 2;
            this.btn_gemBruger.Text = "Gem bruger";
            this.btn_gemBruger.UseVisualStyleBackColor = true;
            this.btn_gemBruger.Click += new System.EventHandler(this.btn_gemBruger_Click);
            // 
            // txt_opretBruger
            // 
            this.txt_opretBruger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_opretBruger.Location = new System.Drawing.Point(8, 56);
            this.txt_opretBruger.Name = "txt_opretBruger";
            this.txt_opretBruger.Size = new System.Drawing.Size(177, 30);
            this.txt_opretBruger.TabIndex = 1;
            this.txt_opretBruger.TextChanged += new System.EventHandler(this.txt_opretBruger_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indtast Brugernavn:";
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.dataGridView1);
            this.panel_main.Location = new System.Drawing.Point(151, 13);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(618, 408);
            this.panel_main.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 433);
            this.Controls.Add(this.btn_opretTips);
            this.Controls.Add(this.btn_opretBruger);
            this.Controls.Add(this.btn_tidligereTurneringer);
            this.Controls.Add(this.btn_seStilling);
            this.Controls.Add(this.btn_opretCup);
            this.Controls.Add(this.btn_opretTurnering);
            this.Controls.Add(this.panel_opretBruger);
            this.Controls.Add(this.panel_main);
            this.Name = "Main";
            this.Text = "Tipsturneringsmanager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_opretBruger.ResumeLayout(false);
            this.panel_opretBruger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Brugernavn)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_opretTurnering;
        private System.Windows.Forms.Button btn_opretCup;
        private System.Windows.Forms.Button btn_seStilling;
        private System.Windows.Forms.Button btn_tidligereTurneringer;
        private System.Windows.Forms.Button btn_opretBruger;
        private System.Windows.Forms.Button btn_opretTips;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel_opretBruger;
        private System.Windows.Forms.Button btn_gemBruger;
        private System.Windows.Forms.TextBox txt_opretBruger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.DataGridView dataGridView_Brugernavn;

    }
}

