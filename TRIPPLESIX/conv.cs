using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRIPPLESIX
{
	public partial class conv : Form
	{
		/// <summary>
		/// конструктор третьей формы.
		/// </summary>
		public conv()
		{
			InitializeComponent();
		}

		/// <summary>
		/// обработчик события нажатия на клавишу при фокусе на одном полей ввода.
		/// </summary>
		/// <param name="sender">кто именно отправил событие.</param>
		/// <param name="e"></param>
		private void ConvertBase(object sender, KeyPressEventArgs e)
		{
			TextBox who = sender as TextBox;
			try
			{
				if (who.Name == "tenBox")
				{
					sixteenBox.Text = Convert.ToString(int.Parse(tenBox.Text), 16);
					eightBox.Text = Convert.ToString(int.Parse(tenBox.Text), 8);
					twoBox.Text = Convert.ToString(int.Parse(tenBox.Text), 2);
				}
				else if (who.Name == "sixteenBox")
				{
					eightBox.Text = Convert.ToString(int.Parse(tenBox.Text), 8);
					tenBox.Text = Convert.ToString(int.Parse(tenBox.Text), 10);
					twoBox.Text = Convert.ToString(int.Parse(tenBox.Text), 2);
				}
				else if (who.Name == "eightBox")
				{
					sixteenBox.Text = Convert.ToString(int.Parse(tenBox.Text), 16);
					tenBox.Text = Convert.ToString(int.Parse(tenBox.Text), 10);
					twoBox.Text = Convert.ToString(int.Parse(tenBox.Text), 2);
				}
				else if (who.Name == "twoBox")
				{
					sixteenBox.Text = Convert.ToString(int.Parse(tenBox.Text), 16);
					eightBox.Text = Convert.ToString(int.Parse(tenBox.Text), 8);
					tenBox.Text = Convert.ToString(int.Parse(tenBox.Text), 2);
				}
			}
            catch (ArgumentException ex)
            {
				MessageBox.Show("ты чо наделол, я в лицо получил эти буквы. теперь сиди и сам разбирайся чем я получил по морде.\n" + ex, "это что");
            }
            catch (FormatException)
            {
				labelException.Text = "ну вот ты и ввёл буквы в число. это всё, чего ты добился в жизни?";
            }
			catch (OverflowException)
            {
				labelException.Text = "ну сам понимаешь, слишком много цифр это не хорошо.";
            }
		}



		//важные методы для всех форм.
			/// <summary>
			/// обработчик события нажатия на кнопку "к кнопочкам".
			/// </summary>
			/// <remarks>
			/// при нажатии на кнопку, метод возвращает из остальных форм обратно в первую.
			/// </remarks>
			/// <param name="sender"></param>
			/// <param name="e"></param>
			private void Backer(object sender, EventArgs e)
		{
			Buttoner f1 = new Buttoner(); //создание объекта первой формы.
			f1.Show(); //отображение первой формы.
			this.Hide(); //скрытие этой формы.
		}

		//					закрытие всех форм на крестик.
		/// <summary>
		/// обработчик события закрытия формы на крестик.
		/// </summary>
		/// <remarks>
		/// при нажатии на крестик на одной из форм, закроется вся программа.
		/// </remarks>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Closer(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}