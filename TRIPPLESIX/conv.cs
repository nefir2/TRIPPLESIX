using System;
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
			labelException.Text = "";
			sixteenBox.Text = Convert.ToString(long.MaxValue, 16);
			eightBox.Text = Convert.ToString(long.MaxValue, 8);
			twoBox.Text = Convert.ToString(long.MaxValue, 2);
			tenBox.Text = Convert.ToString(long.MaxValue);
			tenBox.SelectAll();
		}

		//where my last code???
		/// <summary>
		/// обработчик события нажатия на клавишу при фокусе на одном полей ввода.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ConverterBase(object sender, KeyEventArgs e)
		{
			
			labelException.Text = "";
			if (tenBox.Text == "")
			{
				sixteenBox.Text = "";
				eightBox.Text = "";
				twoBox.Text = "";
				return;
			}
			try
			{
				sixteenBox.Text = Convert.ToString(long.Parse(tenBox.Text), 16);
				eightBox.Text = Convert.ToString(long.Parse(tenBox.Text), 8);
				twoBox.Text = Convert.ToString(long.Parse(tenBox.Text), 2);
			}
			catch (ArgumentException ex) //неизвестный 
			{
				MessageBox.Show("ты чо наделол, я в лицо получил эти буквы. теперь сиди и сам разбирайся чем я получил по морде.\n" + ex, "это что");
			}
			catch (FormatException)
			{
				labelException.Text = "ну вот ты и ввёл непонятно что вместо числа. это всё, чего ты добился в жизни?";
			}
			catch (OverflowException)
			{
				labelException.Text = "ну сам понимаешь, слишком большое значение - это не хорошо.";
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