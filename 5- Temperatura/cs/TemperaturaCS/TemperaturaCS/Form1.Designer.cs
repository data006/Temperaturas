namespace TemperaturaCS
{
	partial class frmTemperaturaCS
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
			this.btnOk = new System.Windows.Forms.Button();
			this.grpTempOut = new System.Windows.Forms.GroupBox();
			this.txtOut = new System.Windows.Forms.TextBox();
			this.radOutR = new System.Windows.Forms.RadioButton();
			this.radOutK = new System.Windows.Forms.RadioButton();
			this.radOutF = new System.Windows.Forms.RadioButton();
			this.radOutC = new System.Windows.Forms.RadioButton();
			this.grpTempIn = new System.Windows.Forms.GroupBox();
			this.txtIn = new System.Windows.Forms.TextBox();
			this.radInR = new System.Windows.Forms.RadioButton();
			this.radInK = new System.Windows.Forms.RadioButton();
			this.radInF = new System.Windows.Forms.RadioButton();
			this.radinC = new System.Windows.Forms.RadioButton();
			this.grpTempOut.SuspendLayout();
			this.grpTempIn.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(307, 318);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(171, 42);
			this.btnOk.TabIndex = 5;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// grpTempOut
			// 
			this.grpTempOut.Controls.Add(this.txtOut);
			this.grpTempOut.Controls.Add(this.radOutR);
			this.grpTempOut.Controls.Add(this.radOutK);
			this.grpTempOut.Controls.Add(this.radOutF);
			this.grpTempOut.Controls.Add(this.radOutC);
			this.grpTempOut.Location = new System.Drawing.Point(430, 91);
			this.grpTempOut.Name = "grpTempOut";
			this.grpTempOut.Size = new System.Drawing.Size(192, 169);
			this.grpTempOut.TabIndex = 4;
			this.grpTempOut.TabStop = false;
			this.grpTempOut.Text = "Temperatura de Salida";
			// 
			// txtOut
			// 
			this.txtOut.Location = new System.Drawing.Point(20, 132);
			this.txtOut.Name = "txtOut";
			this.txtOut.ReadOnly = true;
			this.txtOut.Size = new System.Drawing.Size(149, 20);
			this.txtOut.TabIndex = 5;
			// 
			// radOutR
			// 
			this.radOutR.AutoSize = true;
			this.radOutR.Location = new System.Drawing.Point(20, 96);
			this.radOutR.Name = "radOutR";
			this.radOutR.Size = new System.Drawing.Size(65, 17);
			this.radOutR.TabIndex = 7;
			this.radOutR.TabStop = true;
			this.radOutR.Text = "Rankine";
			this.radOutR.UseVisualStyleBackColor = true;
			// 
			// radOutK
			// 
			this.radOutK.AutoSize = true;
			this.radOutK.Location = new System.Drawing.Point(20, 73);
			this.radOutK.Name = "radOutK";
			this.radOutK.Size = new System.Drawing.Size(54, 17);
			this.radOutK.TabIndex = 6;
			this.radOutK.TabStop = true;
			this.radOutK.Text = "Kelvin";
			this.radOutK.UseVisualStyleBackColor = true;
			// 
			// radOutF
			// 
			this.radOutF.AutoSize = true;
			this.radOutF.Location = new System.Drawing.Point(20, 50);
			this.radOutF.Name = "radOutF";
			this.radOutF.Size = new System.Drawing.Size(75, 17);
			this.radOutF.TabIndex = 5;
			this.radOutF.TabStop = true;
			this.radOutF.Text = "Fahrenheit";
			this.radOutF.UseVisualStyleBackColor = true;
			// 
			// radOutC
			// 
			this.radOutC.AutoSize = true;
			this.radOutC.Location = new System.Drawing.Point(20, 27);
			this.radOutC.Name = "radOutC";
			this.radOutC.Size = new System.Drawing.Size(58, 17);
			this.radOutC.TabIndex = 4;
			this.radOutC.TabStop = true;
			this.radOutC.Text = "Celsius";
			this.radOutC.UseVisualStyleBackColor = true;
			// 
			// grpTempIn
			// 
			this.grpTempIn.Controls.Add(this.txtIn);
			this.grpTempIn.Controls.Add(this.radInR);
			this.grpTempIn.Controls.Add(this.radInK);
			this.grpTempIn.Controls.Add(this.radInF);
			this.grpTempIn.Controls.Add(this.radinC);
			this.grpTempIn.Location = new System.Drawing.Point(179, 91);
			this.grpTempIn.Name = "grpTempIn";
			this.grpTempIn.Size = new System.Drawing.Size(182, 169);
			this.grpTempIn.TabIndex = 3;
			this.grpTempIn.TabStop = false;
			this.grpTempIn.Text = "Temperatura de Entrada";
			// 
			// txtIn
			// 
			this.txtIn.Location = new System.Drawing.Point(14, 132);
			this.txtIn.Name = "txtIn";
			this.txtIn.Size = new System.Drawing.Size(150, 20);
			this.txtIn.TabIndex = 4;
			this.txtIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIn_KeyPress);
			// 
			// radInR
			// 
			this.radInR.AutoSize = true;
			this.radInR.Location = new System.Drawing.Point(14, 97);
			this.radInR.Name = "radInR";
			this.radInR.Size = new System.Drawing.Size(65, 17);
			this.radInR.TabIndex = 3;
			this.radInR.TabStop = true;
			this.radInR.Text = "Rankine";
			this.radInR.UseVisualStyleBackColor = true;
			this.radInR.CheckedChanged += new System.EventHandler(this.radInR_CheckedChanged);
			// 
			// radInK
			// 
			this.radInK.AutoSize = true;
			this.radInK.Location = new System.Drawing.Point(14, 74);
			this.radInK.Name = "radInK";
			this.radInK.Size = new System.Drawing.Size(54, 17);
			this.radInK.TabIndex = 2;
			this.radInK.TabStop = true;
			this.radInK.Text = "Kelvin";
			this.radInK.UseVisualStyleBackColor = true;
			this.radInK.CheckedChanged += new System.EventHandler(this.radInK_CheckedChanged);
			// 
			// radInF
			// 
			this.radInF.AutoSize = true;
			this.radInF.Location = new System.Drawing.Point(14, 51);
			this.radInF.Name = "radInF";
			this.radInF.Size = new System.Drawing.Size(75, 17);
			this.radInF.TabIndex = 1;
			this.radInF.TabStop = true;
			this.radInF.Text = "Fahrenheit";
			this.radInF.UseVisualStyleBackColor = true;
			this.radInF.CheckedChanged += new System.EventHandler(this.radInF_CheckedChanged);
			// 
			// radinC
			// 
			this.radinC.AutoSize = true;
			this.radinC.Location = new System.Drawing.Point(14, 28);
			this.radinC.Name = "radinC";
			this.radinC.Size = new System.Drawing.Size(58, 17);
			this.radinC.TabIndex = 0;
			this.radinC.TabStop = true;
			this.radinC.Text = "Celsius";
			this.radinC.UseVisualStyleBackColor = true;
			this.radinC.CheckedChanged += new System.EventHandler(this.radinC_CheckedChanged);
			// 
			// frmTemperaturaCS
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.grpTempOut);
			this.Controls.Add(this.grpTempIn);
			this.Name = "frmTemperaturaCS";
			this.Text = "TemperaturaCS";
			this.grpTempOut.ResumeLayout(false);
			this.grpTempOut.PerformLayout();
			this.grpTempIn.ResumeLayout(false);
			this.grpTempIn.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.Button btnOk;
		internal System.Windows.Forms.GroupBox grpTempOut;
		internal System.Windows.Forms.TextBox txtOut;
		internal System.Windows.Forms.RadioButton radOutR;
		internal System.Windows.Forms.RadioButton radOutK;
		internal System.Windows.Forms.RadioButton radOutF;
		internal System.Windows.Forms.RadioButton radOutC;
		internal System.Windows.Forms.GroupBox grpTempIn;
		internal System.Windows.Forms.TextBox txtIn;
		internal System.Windows.Forms.RadioButton radInR;
		internal System.Windows.Forms.RadioButton radInK;
		internal System.Windows.Forms.RadioButton radInF;
		internal System.Windows.Forms.RadioButton radinC;
	}
}

