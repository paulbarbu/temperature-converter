using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
	public partial class Form1 : Form {
		
		public Form1() {
			InitializeComponent();
		}
		

		private void btnClear_Click(object sender, EventArgs e) {
			foreach(Control a in this.Controls){
				if (a.GetType() == typeof(TextBox)) {
					if (a.Enabled == true) {
						a.Text = "";
					}
				}
			}
		}

		private void btnCnVert_Click(object sender, EventArgs e) {
			if (cfk.Checked == true) {
				double x, xa;
				if (!Double.TryParse(cBox.Text, out x)) {
					MessageBox.Show("Celsius needs a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cBox.Focus();
				}
				else {
					Double.TryParse(cBox.Text, out x);
					xa = CtoK(x);
					x = CtoF(x);
					fBox.Clear();
					fBox.Text = x.ToString();

					kBox.Clear();
					kBox.Text = xa.ToString();
					
				}
			}
			else if (fck.Checked == true) {
				double x;
				if (!Double.TryParse(fBox.Text, out x)) {
					MessageBox.Show("Fahrenheit needs a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					fBox.Focus();
				}
				else {
					Double.TryParse(fBox.Text, out x);
					x = FtoC(x);
					cBox.Clear();
					cBox.Text = x.ToString();

					kBox.Clear();
					x = CtoK(x);
					kBox.Text = x.ToString();
				}
			}
			
			else if (kcf.Checked == true) {
				double x;
				if (!Double.TryParse(kBox.Text, out x)) {
					MessageBox.Show("Kelvinneeds a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					kBox.Focus();
				}
				else{
					Double.TryParse(kBox.Text, out x);
					x = KtoC(x);
					cBox.Clear();
					cBox.Text = x.ToString();

					fBox.Clear();
					x = CtoF(x);
					fBox.Text = x.ToString();
				}

			}
			
			else {
				
			}
		}
		public double CtoF(double convert) {
			double F = (convert * 1.8) + 32;
			return F;
		}

		public double FtoC(double convert) {
			double C = (convert - 32) / 1.8;
			return C;
		}

		public double KtoC(double convert) {
			double C = convert - 273.15;
			return C;
		}

		public double CtoK(double convert) {
			double K = convert + 273.15;
			return K;
		}

		private void kcf_CheckedChanged(object sender, EventArgs e) {
			btnCnVert.Enabled = true;
			btnClear.Enabled = true;
			cBox.Enabled = false;
			fBox.Enabled = false;
			kBox.Enabled = true;
		}

		private void fck_CheckedChanged_1(object sender, EventArgs e) {
			btnCnVert.Enabled = true;
			btnClear.Enabled = true;
			cBox.Enabled = false;
			fBox.Enabled = true;
			kBox.Enabled = false;
		}

		private void cfk_CheckedChanged_1(object sender, EventArgs e) {
			btnCnVert.Enabled = true;
			btnClear.Enabled = true;
			cBox.Enabled = true;
			fBox.Enabled = false;
			kBox.Enabled = false;
		}

		private void Form1_Load(object sender, EventArgs e) {
		}

		private void cBox_TextChanged(object sender, EventArgs e) {
			double x, xa;
			
				Double.TryParse(cBox.Text, out x);
				xa = CtoK(x);
				x = CtoF(x);
				//fBox.Clear();
				fBox.Text = x.ToString();

				//kBox.Clear();
				kBox.Text = xa.ToString();

			
		}

		private void fBox_TextChanged(object sender, EventArgs e) {
			double x;
			
				Double.TryParse(fBox.Text, out x);
				x = FtoC(x);
				//cBox.Clear();
				cBox.Text = x.ToString();

				//kBox.Clear();
				x = CtoK(x);
				kBox.Text = x.ToString();
			
		}

		private void kBox_TextChanged(object sender, EventArgs e) {
			double x;
			
				Double.TryParse(kBox.Text, out x);
				x = KtoC(x);
				//cBox.Clear();
				cBox.Text = x.ToString();

				//fBox.Clear();
				x = CtoF(x);
				fBox.Text = x.ToString();
			
		}

		private void label2_Click(object sender, EventArgs e) {
		}

	}
}
