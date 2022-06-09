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

		//		обработчики событий.
		/// <summary>
		/// обработчик события нажатия на клавишу при фокусе на одном полей ввода.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ConverterBase(object sender, EventArgs e)
		{
			labelException.Text = ""; //очистка поля с ошибками.
			TextBox sended = sender as TextBox; //распаковка отправителя события.
			if (sended.Text == "") //если отправитель пуст, то очищаются и все остальные поля ввода.
			{
				tenBox.Text = "";
				sixteenBox.Text = "";
				eightBox.Text = "";
				twoBox.Text = "";
				return; //выход из метода для предотвращения ошибок.
			}
			try //попытка преобразовать string в long.
			{
				long tenbase;
				if (sended == tenBox)
				{
					sixteenBox.Text = Convert.ToString(long.Parse(tenBox.Text), 16); 
					eightBox.Text = Convert.ToString(long.Parse(tenBox.Text), 8);
					twoBox.Text = Convert.ToString(long.Parse(tenBox.Text), 2);
				}
				else if (sended == sixteenBox)
				{
					tenbase = Convert.ToInt64(sixteenBox.Text, 16);
					tenBox.Text = $"{tenbase}";
					eightBox.Text = Convert.ToString(tenbase, 8);
					twoBox.Text = Convert.ToString(tenbase, 2);
				}
				else if (sended == eightBox)
				{
					tenbase = Convert.ToInt64(eightBox.Text, 8);
					tenBox.Text = $"{tenbase}";
					sixteenBox.Text = Convert.ToString(tenbase, 16);
					twoBox.Text = Convert.ToString(tenbase, 2);
				}
				else if (sended == twoBox)
				{
					tenbase = Convert.ToInt64(twoBox.Text, 2);
					tenBox.Text = $"{tenbase}";
					sixteenBox.Text = Convert.ToString(tenbase, 16);
					eightBox.Text = Convert.ToString(tenbase, 8);
				}
			}
			catch (FormatException) { labelException.Text = "вот ты и ввёл непонятно что вместо числа. это всё, чего ты добился в жизни?"; }
			catch (OverflowException) { labelException.Text = "слишком большое значение - это не хорошо."; }
		}
		/// <summary>
		/// обработчик события нажатия или фокусировки поля ввода.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Selecter(object sender, EventArgs e) => (sender as TextBox).SelectAll(); //выделяет весь текст.


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
		private void Closer(object sender, FormClosingEventArgs e) => Application.Exit();
		/// <summary>
		/// метод выделяет текст во всех полях ввода.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
	}
}