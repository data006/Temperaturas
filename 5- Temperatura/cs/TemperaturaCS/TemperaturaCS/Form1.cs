using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperaturaCS
{
	public partial class frmTemperaturaCS : Form
	{
		public frmTemperaturaCS()
		{
			InitializeComponent();
		}

		public void btnOk_Click(object sender, EventArgs e)
		{
			
			double tempEntrada, tempSalida;
			if (txtIn.Text != string.Empty & !((txtIn.Text ?? "") == ".") & !((txtIn.Text ?? "") == "-") & !((txtIn.Text ?? "") == ".-") & !((txtIn.Text ?? "") == "-.") & !txtIn.Text.Contains(".-"))
			{
				tempEntrada = Conversion.Val(txtIn.Text);
				if (radinC.Checked)
				{
					if (radOutF.Checked)
					{
						tempSalida = tempEntrada * 1.8 + 32;
						txtOut.Text = Conversions.ToString(tempSalida);
					}
					else if (radOutK.Checked)
					{
						if (tempEntrada >= -273.15)
						{
							tempSalida = tempEntrada + 273.15;
							txtOut.Text = Conversions.ToString(tempSalida);
						}
						else if (tempEntrada < -273.15)
						{
							txtOut.Text = Conversions.ToString(0);
							MessageBox.Show("La temperatura no puede ser menor a 0 Kelvin");
						}
					}
					else if (radOutR.Checked)
					{
						if (tempEntrada >= -273.15)
						{
							tempSalida = tempEntrada * 1.8 + 491.67;
							txtOut.Text = Conversions.ToString(tempSalida);
						}
						else if (tempEntrada < -273.15)
						{
							txtOut.Text = Conversions.ToString(0);
							MessageBox.Show("La temperatura no puede ser menor a 0 Rankine");
						}
					}
				}
				else if (radInF.Checked)
				{
					if (radOutC.Checked)
					{
						tempSalida = (tempEntrada - 32) / 1.8;
						txtOut.Text = Conversions.ToString(tempSalida);
					}
					else if (radOutK.Checked)
					{
						if (tempEntrada >= -459.67)
						{
							tempSalida = (tempEntrada - 32) / 1.8 + 273.15;
							txtOut.Text = Conversions.ToString(tempSalida);
						}
						else if (tempEntrada < -459.67)
						{
							txtOut.Text = Conversions.ToString(0);
							MessageBox.Show("La temperatura no puede ser menor a 0 Kelvin");
						}
					}
					else if (radOutR.Checked)
					{
						if (tempEntrada >= -459.67)
						{
							tempSalida = tempEntrada + 459.67;
							txtOut.Text = Conversions.ToString(tempSalida);
						}
						else if (tempEntrada < -459.67)
						{
							txtOut.Text = Conversions.ToString(0);
							MessageBox.Show("La temperatura no puede ser menor a 0 Rankine");
						}
					}
				}
				else if (radInK.Checked)
				{
					if (tempEntrada < 0)
					{
						MessageBox.Show("La temperatura no puede ser menor a 0 Kelvin");
					}
					else if (radOutC.Checked)
					{
						tempSalida = tempEntrada - 273.15;
						txtOut.Text = Conversions.ToString(tempSalida);
					}
					else if (radOutF.Checked)
					{
						tempSalida = (tempEntrada - 273.15) * 1.8 + 32;
						txtOut.Text = Conversions.ToString(tempSalida);
					}
					else if (radOutR.Checked)
					{
						tempSalida = tempEntrada * 1.8;
						txtOut.Text = Conversions.ToString(tempSalida);
					}
				}
				else if (radInR.Checked)
				{
					if (tempEntrada < 0)
					{
						MessageBox.Show("La temperatura no puede ser menor a 0 Rankine");
					}
					else if (radOutC.Checked)
					{
						tempSalida = (tempEntrada - 491.67) * (5 / (double)9);
						txtOut.Text = Conversions.ToString(tempSalida);
					}
					else if (radOutF.Checked)
					{
						tempSalida = tempEntrada - 459.67;
						txtOut.Text = Conversions.ToString(tempSalida);
					}
					else if (radOutK.Checked)
					{
						tempSalida = tempEntrada * (5 / (double)9);
						txtOut.Text = Conversions.ToString(tempSalida);
					}
				}
			}

		}






		public void radinC_CheckedChanged(object sender, EventArgs e)
		{

			if (radinC.Checked)
			{
				radOutC.Enabled = false;
				radOutF.Checked = true;
			}
			else
			{
				radOutC.Enabled = true;
			}

		}



		public void radInF_CheckedChanged(object sender, EventArgs e)
		{

			if (radInF.Checked)
			{
				radOutF.Enabled = false;
				radOutK.Checked = true;
			}
			else
			{
				radOutF.Enabled = true;
			}

		}



		public void radInK_CheckedChanged(object sender, EventArgs e)
		{

			if (radInK.Checked)
			{
				radOutK.Enabled = false;
				radOutR.Checked = true;
			}
			else
			{
				radOutK.Enabled = true;
			}


		}





		public void radInR_CheckedChanged(object sender, EventArgs e)
		{

			if (radInR.Checked)
			{
				radOutR.Enabled = false;
				radOutC.Checked = true;
			}
			else
			{
				radOutR.Enabled = true;
			}


		}








		public void txtIn_KeyPress(object sender, KeyPressEventArgs e)
		{


			if ((txtIn.Text ?? "") == (string.Empty ?? ""))
			{
				e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar) & !(Conversions.ToString(e.KeyChar) == ".") & !(Conversions.ToString(e.KeyChar) == "-");
			}
			else if (!txtIn.Text.Contains("."))
			{
				e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar) & !(Conversions.ToString(e.KeyChar) == ".");
			}
			else if (!txtIn.Text.Contains("-"))
			{
				e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar) & !(Conversions.ToString(e.KeyChar) == "-");
			}
			else if (txtIn.Text.Contains(".") & txtIn.Text.Contains("-"))
			{
				e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar);
			}

		}

		
	}
}
