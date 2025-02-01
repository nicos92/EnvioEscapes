namespace EnvioEscapes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SliderSeg = new System.Windows.Forms.TrackBar();
            this.SliderEsc = new System.Windows.Forms.TrackBar();
            this.LblEsc = new System.Windows.Forms.Label();
            this.LblSeg = new System.Windows.Forms.Label();
            this.LblEstado = new System.Windows.Forms.Label();
            this.LblProgreso = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnDetener = new Controles.NSButton();
            this.BtnIniciar = new Controles.NSButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SliderSeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderEsc)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.SliderSeg, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.SliderEsc, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.LblEsc, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblSeg, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.LblEstado, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblProgreso, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 11);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(750, 407);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SliderSeg
            // 
            this.SliderSeg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SliderSeg.Dock = System.Windows.Forms.DockStyle.Top;
            this.SliderSeg.LargeChange = 1;
            this.SliderSeg.Location = new System.Drawing.Point(80, 237);
            this.SliderSeg.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SliderSeg.Minimum = 1;
            this.SliderSeg.Name = "SliderSeg";
            this.SliderSeg.Size = new System.Drawing.Size(590, 45);
            this.SliderSeg.TabIndex = 2;
            this.SliderSeg.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SliderSeg.Value = 1;
            this.SliderSeg.Scroll += new System.EventHandler(this.SliderSeg_Scroll);
            // 
            // SliderEsc
            // 
            this.SliderEsc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SliderEsc.Dock = System.Windows.Forms.DockStyle.Top;
            this.SliderEsc.LargeChange = 1;
            this.SliderEsc.Location = new System.Drawing.Point(80, 133);
            this.SliderEsc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SliderEsc.Maximum = 100;
            this.SliderEsc.Minimum = 1;
            this.SliderEsc.Name = "SliderEsc";
            this.SliderEsc.Size = new System.Drawing.Size(590, 45);
            this.SliderEsc.TabIndex = 1;
            this.SliderEsc.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SliderEsc.Value = 1;
            this.SliderEsc.ValueChanged += new System.EventHandler(this.SliderEsc_ValueChanged);
            // 
            // LblEsc
            // 
            this.LblEsc.AutoSize = true;
            this.LblEsc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblEsc.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEsc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblEsc.Location = new System.Drawing.Point(80, 111);
            this.LblEsc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblEsc.Name = "LblEsc";
            this.LblEsc.Size = new System.Drawing.Size(590, 18);
            this.LblEsc.TabIndex = 0;
            this.LblEsc.Text = "Cantidad de Esc: ";
            // 
            // LblSeg
            // 
            this.LblSeg.AutoSize = true;
            this.LblSeg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblSeg.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSeg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblSeg.Location = new System.Drawing.Point(80, 215);
            this.LblSeg.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblSeg.Name = "LblSeg";
            this.LblSeg.Size = new System.Drawing.Size(590, 18);
            this.LblSeg.TabIndex = 0;
            this.LblSeg.Text = "Intervalo de Segundos: ";
            // 
            // LblEstado
            // 
            this.LblEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblEstado.Location = new System.Drawing.Point(328, 0);
            this.LblEstado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(93, 25);
            this.LblEstado.TabIndex = 0;
            this.LblEstado.Text = "Estado:";
            // 
            // LblProgreso
            // 
            this.LblProgreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblProgreso.AutoSize = true;
            this.LblProgreso.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProgreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.LblProgreso.Location = new System.Drawing.Point(305, 52);
            this.LblProgreso.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblProgreso.Name = "LblProgreso";
            this.LblProgreso.Size = new System.Drawing.Size(140, 32);
            this.LblProgreso.TabIndex = 0;
            this.LblProgreso.Text = "Inactivo";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BtnDetener, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnIniciar, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(80, 323);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(590, 80);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // BtnDetener
            // 
            this.BtnDetener.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDetener.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.BtnDetener.BackGroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.BtnDetener.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnDetener.BorderRadius = 19;
            this.BtnDetener.BorderSize = 2;
            this.BtnDetener.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDetener.Enabled = false;
            this.BtnDetener.FlatAppearance.BorderSize = 0;
            this.BtnDetener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDetener.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDetener.ForeColor = System.Drawing.Color.White;
            this.BtnDetener.Location = new System.Drawing.Point(317, 14);
            this.BtnDetener.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnDetener.Name = "BtnDetener";
            this.BtnDetener.Size = new System.Drawing.Size(250, 51);
            this.BtnDetener.TabIndex = 4;
            this.BtnDetener.Text = "Detener";
            this.BtnDetener.TextColor = System.Drawing.Color.White;
            this.BtnDetener.UseVisualStyleBackColor = false;
            this.BtnDetener.Click += new System.EventHandler(this.BtnDetener_Click);
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.BtnIniciar.BackGroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.BtnIniciar.BorderColor = System.Drawing.Color.DarkGreen;
            this.BtnIniciar.BorderRadius = 19;
            this.BtnIniciar.BorderSize = 2;
            this.BtnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIniciar.FlatAppearance.BorderSize = 0;
            this.BtnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciar.ForeColor = System.Drawing.Color.White;
            this.BtnIniciar.Location = new System.Drawing.Point(22, 14);
            this.BtnIniciar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(250, 51);
            this.BtnIniciar.TabIndex = 3;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.TextColor = System.Drawing.Color.White;
            this.BtnIniciar.UseVisualStyleBackColor = false;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(776, 429);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(796, 472);
            this.MinimumSize = new System.Drawing.Size(796, 472);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(13, 11, 13, 11);
            this.Text = "NicoS92 App Envio de Escapes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SliderSeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderEsc)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TrackBar SliderSeg;
        private System.Windows.Forms.TrackBar SliderEsc;
        private System.Windows.Forms.Label LblEsc;
        private System.Windows.Forms.Label LblSeg;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.Label LblProgreso;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Controles.NSButton BtnDetener;
        private Controles.NSButton BtnIniciar;
    }
}

