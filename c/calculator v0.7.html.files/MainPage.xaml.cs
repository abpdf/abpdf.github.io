using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Security.Authentication.Identity.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace App1
{
	/// <summary>
	/// 可用于自身或导航至 Frame 内部的空白页。
	/// </summary>
	public sealed partial class MainPage : Page
	{
		public MainPage()
		{
			this.InitializeComponent();
		}
		decimal number1 = 0;
		decimal number2 = 0;
		decimal number3 = 0;
		bool finish2 = false;
		bool finish1 = false;
		int order = 1;
		decimal bits = 1;
		bool decimal1 = false;
		bool decimal2 = false;
		int operator1;
		decimal result_number = 0;
		double number4;
		double number5;
		decimal number6;

		private void number_0(object sender, RoutedEventArgs e)
		{
			number3 = 0;
			if (order == 1)
			{
				if (number1<0)
				{
					number3 = -1 * number3;
				}
			}
			else
			{
				if (number2 < 0)
				{
					number3 = -1 * number3;
				}
			}
			if (order == 1)
			{
				if (finish1 == true)
				{
					number1 = 0;
					result_number = 0;
					bits = 1;
					decimal1 = false;
					decimal2 = false;
					textblock1.Text = number1.ToString();
					finish1 = false;
				}
				if (decimal1 == false)
				{
					number1 = number1 * 10 + number3;
					textblock1.Text = number1.ToString();
				}
				if (decimal1 == true)
				{
					bits = bits * 10;
					number1 = number3 / bits+ number1;
					textblock1.Text = number1.ToString();
				}
			}
			if (order == 2)
			{
				if (finish2 == true)
				{
					finish2 = false;
					if (operator1 == 4)
					{
						textblock2.Text = number1.ToString()+ "÷";
					}
					if (operator1 == 3)
					{
						textblock2.Text = number1.ToString() + "×";
					}
					if (operator1 == 2)
					{
						textblock2.Text = number1.ToString() + "-";
					}
					if (operator1 == 1)
					{
						textblock2.Text = number1.ToString() + "+";
					}
				}
				if (finish1 == true)
				{
					finish1 = false;
					number2 = 0;
					decimal2 = false;
					bits = 1;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == false)
				{
					number2 = number2 * 10 +number3;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == true)
				{
					bits = bits * 10;
					number2 = number3 / bits + number2;
					textblock1.Text = number2.ToString();
				}
			}
		}

		private void number_1(object sender, RoutedEventArgs e)
		{
			number3 = 1;
			if (order == 1)
			{
				if (number1 < 0)
				{
					number3 = -1 * number3;
				}
			}
			else
			{
				if (number2 < 0)
				{
					number3 = -1 * number3;
				}
			}
			if (order == 1)
			{
				if (finish1 == true)
				{
					number1 = 0;
					result_number = 0;
					bits = 1;
					decimal1 = false;
					decimal2 = false;
					textblock1.Text = number1.ToString();
					finish1 = false;
				}
				if (decimal1 == false)
				{
					number1 = number1 * 10 + number3;
					textblock1.Text = number1.ToString();
				}
				if (decimal1 == true)
				{
					bits = bits * 10;
					number1 = number3 / bits + number1;
					textblock1.Text = number1.ToString();
				}
			}
			if (order == 2)
			{
				if (finish2 == true)
				{
					finish2 = false;
					if (operator1 == 4)
					{
						textblock2.Text = number1.ToString() + "÷";
					}
					if (operator1 == 3)
					{
						textblock2.Text = number1.ToString() + "×";
					}
					if (operator1 == 2)
					{
						textblock2.Text = number1.ToString() + "-";
					}
					if (operator1 == 1)
					{
						textblock2.Text = number1.ToString() + "+";
					}
				}
				if (finish1 == true)
				{
					finish1 = false;
					number2 = 0;
					decimal2 = false;
					bits = 1;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == false)
				{
					number2 = number2 * 10 + number3;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == true)
				{
					bits = bits * 10;
					number2 = number3 / bits + number2;
					textblock1.Text = number2.ToString();
				}
			}
		}

		private void number_2(object sender, RoutedEventArgs e)
		{
			number3 = 2;
			if (order == 1)
			{
				if (number1 < 0)
				{
					number3 = -1 * number3;
				}
			}
			else
			{
				if (number2 < 0)
				{
					number3 = -1 * number3;
				}
			}
			if (order == 1)
			{
				if (finish1 == true)
				{
					number1 = 0;
					result_number = 0;
					bits = 1;
					decimal1 = false;
					decimal2 = false;
					textblock1.Text = number1.ToString();
					finish1 = false;
				}
				if (decimal1 == false)
				{
					number1 = number1 * 10 + number3;
					textblock1.Text = number1.ToString();
				}
				if (decimal1 == true)
				{
					bits = bits * 10;
					number1 = number3 / bits + number1;
					textblock1.Text = number1.ToString();
				}
			}
			if (order == 2)
			{
				if (finish2 == true)
				{
					finish2 = false;
					if (operator1 == 4)
					{
						textblock2.Text = number1.ToString() + "÷";
					}
					if (operator1 == 3)
					{
						textblock2.Text = number1.ToString() + "×";
					}
					if (operator1 == 2)
					{
						textblock2.Text = number1.ToString() + "-";
					}
					if (operator1 == 1)
					{
						textblock2.Text = number1.ToString() + "+";
					}
				}
				if (finish1 == true)
				{
					finish1 = false;
					number2 = 0;
					decimal2 = false;
					bits = 1;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == false)
				{
					number2 = number2 * 10 + number3;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == true)
				{
					bits = bits * 10;
					number2 = number3 / bits + number2;
					textblock1.Text = number2.ToString();
				}
			}
		}

		private void number_3(object sender, RoutedEventArgs e)
		{
			number3 = 3;
			if (order == 1)
			{
				if (number1 < 0)
				{
					number3 = -1 * number3;
				}
			}
			else
			{
				if (number2 < 0)
				{
					number3 = -1 * number3;
				}
			}
			if (order == 1)
			{
				if (finish1 == true)
				{
					number1 = 0;
					result_number = 0;
					bits = 1;
					decimal1 = false;
					decimal2 = false;
					textblock1.Text = number1.ToString();
					finish1 = false;
				}
				if (decimal1 == false)
				{
					number1 = number1 * 10 + number3;
					textblock1.Text = number1.ToString();
				}
				if (decimal1 == true)
				{
					bits = bits * 10;
					number1 = number3 / bits + number1;
					textblock1.Text = number1.ToString();
				}
			}
			if (order == 2)
			{
				if (finish2 == true)
				{
					finish2 = false;
					if (operator1 == 4)
					{
						textblock2.Text = number1.ToString() + "÷";
					}
					if (operator1 == 3)
					{
						textblock2.Text = number1.ToString() + "×";
					}
					if (operator1 == 2)
					{
						textblock2.Text = number1.ToString() + "-";
					}
					if (operator1 == 1)
					{
						textblock2.Text = number1.ToString() + "+";
					}
				}
				if (finish1 == true)
				{
					finish1 = false;
					number2 = 0;
					decimal2 = false;
					bits = 1;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == false)
				{
					number2 = number2 * 10 + number3;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == true)
				{
					bits = bits * 10;
					number2 = number3 / bits + number2;
					textblock1.Text = number2.ToString();
				}
			}
		}

		private void number_4(object sender, RoutedEventArgs e)
		{
			number3 = 4;
			if (order == 1)
			{
				if (number1 < 0)
				{
					number3 = -1 * number3;
				}
			}
			else
			{
				if (number2 < 0)
				{
					number3 = -1 * number3;
				}
			}
			if (order == 1)
			{
				if (finish1 == true)
				{
					number1 = 0;
					result_number = 0;
					bits = 1;
					decimal1 = false;
					decimal2 = false;
					textblock1.Text = number1.ToString();
					finish1 = false;
				}
				if (decimal1 == false)
				{
					number1 = number1 * 10 + number3;
					textblock1.Text = number1.ToString();
				}
				if (decimal1 == true)
				{
					bits = bits * 10;
					number1 = number3 / bits + number1;
					textblock1.Text = number1.ToString();
				}
			}
			if (order == 2)
			{
				if (finish2 == true)
				{
					finish2 = false;
					if (operator1 == 4)
					{
						textblock2.Text = number1.ToString() + "÷";
					}
					if (operator1 == 3)
					{
						textblock2.Text = number1.ToString() + "×";
					}
					if (operator1 == 2)
					{
						textblock2.Text = number1.ToString() + "-";
					}
					if (operator1 == 1)
					{
						textblock2.Text = number1.ToString() + "+";
					}
				}
				if (finish1 == true)
				{
					finish1 = false;
					number2 = 0;
					decimal2 = false;
					bits = 1;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == false)
				{
					number2 = number2 * 10 + number3;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == true)
				{
					bits = bits * 10;
					number2 = number3 / bits + number2;
					textblock1.Text = number2.ToString();
				}
			}
		}

		private void number_5(object sender, RoutedEventArgs e)
		{
			number3 =5;
			if (order == 1)
			{
				if (number1 < 0)
				{
					number3 = -1 * number3;
				}
			}
			else
			{
				if (number2 < 0)
				{
					number3 = -1 * number3;
				}
			}
			if (order == 1)
			{
				if (finish1 == true)
				{
					number1 = 0;
					result_number = 0;
					bits = 1;
					decimal1 = false;
					decimal2 = false;
					textblock1.Text = number1.ToString();
					finish1 = false;
				}
				if (decimal1 == false)
				{
					number1 = number1 * 10 + number3;
					textblock1.Text = number1.ToString();
				}
				if (decimal1 == true)
				{
					bits = bits * 10;
					number1 = number3 / bits + number1;
					textblock1.Text = number1.ToString();
				}
			}
			if (order == 2)
			{
				if (finish2 == true)
				{
					finish2 = false;
					if (operator1 == 4)
					{
						textblock2.Text = number1.ToString() + "÷";
					}
					if (operator1 == 3)
					{
						textblock2.Text = number1.ToString() + "×";
					}
					if (operator1 == 2)
					{
						textblock2.Text = number1.ToString() + "-";
					}
					if (operator1 == 1)
					{
						textblock2.Text = number1.ToString() + "+";
					}
				}
				if (finish1 == true)
				{
					finish1 = false;
					number2 = 0;
					decimal2 = false;
					bits = 1;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == false)
				{
					number2 = number2 * 10 + number3;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == true)
				{
					bits = bits * 10;
					number2 = number3 / bits + number2;
					textblock1.Text = number2.ToString();
				}
			}
		}

		private void number_6(object sender, RoutedEventArgs e)
		{
			number3 = 6;
			if (order == 1)
			{
				if (number1 < 0)
				{
					number3 = -1 * number3;
				}
			}
			else
			{
				if (number2 < 0)
				{
					number3 = -1 * number3;
				}
			}
			if (order == 1)
			{
				if (finish1 == true)
				{
					number1 = 0;
					result_number = 0;
					bits = 1;
					decimal1 = false;
					decimal2 = false;
					textblock1.Text = number1.ToString();
					finish1 = false;
				}
				if (decimal1 == false)
				{
					number1 = number1 * 10 + number3;
					textblock1.Text = number1.ToString();
				}
				if (decimal1 == true)
				{
					bits = bits * 10;
					number1 = number3 / bits + number1;
					textblock1.Text = number1.ToString();
				}
			}
			if (order == 2)
			{
				if (finish2 == true)
				{
					finish2 = false;
					if (operator1 == 4)
					{
						textblock2.Text = number1.ToString() + "÷";
					}
					if (operator1 == 3)
					{
						textblock2.Text = number1.ToString() + "×";
					}
					if (operator1 == 2)
					{
						textblock2.Text = number1.ToString() + "-";
					}
					if (operator1 == 1)
					{
						textblock2.Text = number1.ToString() + "+";
					}
				}
				if (finish1 == true)
				{
					finish1 = false;
					number2 = 0;
					decimal2 = false;
					bits = 1;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == false)
				{
					number2 = number2 * 10 + number3;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == true)
				{
					bits = bits * 10;
					number2 = number3 / bits + number2;
					textblock1.Text = number2.ToString();
				}
			}
		}

		private void number_7(object sender, RoutedEventArgs e)
		{
			number3 =7;
			if (order == 1)
			{
				if (number1 < 0)
				{
					number3 = -1 * number3;
				}
			}
			else
			{
				if (number2 < 0)
				{
					number3 = -1 * number3;
				}
			}
			if (order == 1)
			{
				if (finish1 == true)
				{
					number1 = 0;
					result_number = 0;
					bits = 1;
					decimal1 = false;
					decimal2 = false;
					textblock1.Text = number1.ToString();
					finish1 = false;
				}
				if (decimal1 == false)
				{
					number1 = number1 * 10 + number3;
					textblock1.Text = number1.ToString();
				}
				if (decimal1 == true)
				{
					bits = bits * 10;
					number1 = number3 / bits + number1;
					textblock1.Text = number1.ToString();
				}
			}
			if (order == 2)
			{
				if (finish2 == true)
				{
					finish2 = false;
					if (operator1 == 4)
					{
						textblock2.Text = number1.ToString() + "÷";
					}
					if (operator1 == 3)
					{
						textblock2.Text = number1.ToString() + "×";
					}
					if (operator1 == 2)
					{
						textblock2.Text = number1.ToString() + "-";
					}
					if (operator1 == 1)
					{
						textblock2.Text = number1.ToString() + "+";
					}
				}
				if (finish1 == true)
				{
					finish1 = false;
					number2 = 0;
					decimal2 = false;
					bits = 1;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == false)
				{
					number2 = number2 * 10 + number3;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == true)
				{
					bits = bits * 10;
					number2 = number3 / bits + number2;
					textblock1.Text = number2.ToString();
				}
			}
		}

		private void number_8(object sender, RoutedEventArgs e)
		{
			number3 = 8;
			if (order == 1)
			{
				if (number1 < 0)
				{
					number3 = -1 * number3;
				}
			}
			else
			{
				if (number2 < 0)
				{
					number3 = -1 * number3;
				}
			}
			if (order == 1)
			{
				if (finish1 == true)
				{
					number1 = 0;
					result_number = 0;
					bits = 1;
					decimal1 = false;
					decimal2 = false;
					textblock1.Text = number1.ToString();
					finish1 = false;
				}
				if (decimal1 == false)
				{
					number1 = number1 * 10 + number3;
					textblock1.Text = number1.ToString();
				}
				if (decimal1 == true)
				{
					bits = bits * 10;
					number1 = number3 / bits + number1;
					textblock1.Text = number1.ToString();
				}
			}
			if (order == 2)
			{
				if (finish2 == true)
				{
					finish2 = false;
					if (operator1 == 4)
					{
						textblock2.Text = number1.ToString() + "÷";
					}
					if (operator1 == 3)
					{
						textblock2.Text = number1.ToString() + "×";
					}
					if (operator1 == 2)
					{
						textblock2.Text = number1.ToString() + "-";
					}
					if (operator1 == 1)
					{
						textblock2.Text = number1.ToString() + "+";
					}
				}
				if (finish1 == true)
				{
					finish1 = false;
					number2 = 0;
					decimal2 = false;
					bits = 1;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == false)
				{
					number2 = number2 * 10 + number3;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == true)
				{
					bits = bits * 10;
					number2 = number3 / bits + number2;
					textblock1.Text = number2.ToString();
				}
			}
		}

		private void number_9(object sender, RoutedEventArgs e)
		{
			number3 = 9;
			if (order == 1)
			{
				if (number1 < 0)
				{
					number3 = -1 * number3;
				}
			}
			else
			{
				if (number2 < 0)
				{
					number3 = -1 * number3;
				}
			}
			if (order == 1)
			{
				if (finish1 == true)
				{
					number1 = 0;
					result_number = 0;
					bits = 1;
					decimal1 = false;
					decimal2 = false;
					textblock1.Text = number1.ToString();
					finish1 = false;
				}
				if (decimal1 == false)
				{
					number1 = number1 * 10 + number3;
					textblock1.Text = number1.ToString();
				}
				if (decimal1 == true)
				{
					bits = bits * 10;
					number1 = number3 / bits + number1;
					textblock1.Text = number1.ToString();
				}
			}
			if (order == 2)
			{
				if (finish2 == true)
				{
					finish2 = false;
					if (operator1 == 4)
					{
						textblock2.Text = number1.ToString() + "÷";
					}
					if (operator1 == 3)
					{
						textblock2.Text = number1.ToString() + "×";
					}
					if (operator1 == 2)
					{
						textblock2.Text = number1.ToString() + "-";
					}
					if (operator1 == 1)
					{
						textblock2.Text = number1.ToString() + "+";
					}
				}
				if (finish1 == true)
				{
					finish1 = false;
					number2 = 0;
					decimal2 = false;
					bits = 1;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == false)
				{
					number2 = number2 * 10 + number3;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == true)
				{
					bits = bits * 10;
					number2 = number3 / bits + number2;
					textblock1.Text = number2.ToString();
				}
			}
		}

		private void c_button(object sender, RoutedEventArgs e)
		{
			number1 = 0;
			number2 = 0;
			decimal1 = false;
			decimal2 = false;
			bits = 1;
			finish1 = false;
			finish2 = false;
			textblock1.Text = number1.ToString();
			textblock2.Text = "";
			order = 1;
			operator1 = 0;
			result_number = 0;
		}

		private void ce_button(object sender, RoutedEventArgs e)
		{
			if (order == 1)
			{
				number1 = 0;
				decimal1 = false;
				finish1 = false;
				finish2 = false;
				bits = 1;
				textblock1.Text = number1.ToString();
			}
			if (order == 2)
			{
				number2 = 0;
				decimal2 = false;
				finish1 = false;
				bits = 1; textblock1.Text = number2.ToString();
			}
		}

		private void percent_button(object sender, RoutedEventArgs e)
		{
			if (order == 1)
			{
				number1 = number1 / 100;
				ListView Fruits = new ListView();
				Fruits.Items.Add(number1 * 100 + "÷100 =" + number1);
				StackPanel1.Children.Add(Fruits);
				textblock1.Text = number1.ToString();
			}
			if (order == 2)
			{
				number2 = number2 / 100;
				ListView Fruits = new ListView();
				Fruits.Items.Add(number2 * 100 + "÷100 =" + number2);
				StackPanel1.Children.Add(Fruits);
				textblock1.Text = number2.ToString();
			}
		}

		private void division_button(object sender, RoutedEventArgs e)
		{
			if (order == 1)
			{
				textblock1.Text = number1.ToString() + "÷";
				operator1 = 4;
				order = 2;
				number2 = 0;
				finish2 = true;

			}
			else
			{
				if (textblock2.Text == "")
				{
					textblock1.Text = number1.ToString() + "÷";
					textblock2.Text = "";
					operator1 = 4;
					order = 2;
					finish2 = true;
				}
				else
				{
					finish2 = true;
					if (operator1 == 4)
					{
						if (number2 == 0)
						{
							textblock1.Text = "0不能做除数！";
							finish1 = true;
						}
						else
						{
							textblock2.Text = "";
							result_number = number1 / number2;
							ListView Fruits = new ListView();
							Fruits.Items.Add(number1 + "÷" + number2 + "=" + result_number);
							StackPanel1.Children.Add(Fruits);
							number1 = result_number;
							textblock1.Text = number1.ToString() + "÷";
						}
					}
					if (operator1 == 3)
					{
						textblock2.Text = "";
						result_number = number1 * number2;
						ListView Fruits = new ListView();
						Fruits.Items.Add(number1 + "×" + number2 + "=" + result_number);
						StackPanel1.Children.Add(Fruits);
						number1 = result_number;
						textblock1.Text = number1.ToString() + "÷";
					}
					if (operator1 == 2)
					{
						textblock2.Text = "";
						result_number = number1 - number2;
						ListView Fruits = new ListView();
						Fruits.Items.Add( number1 + "-" + number2 + "=" + result_number);
						StackPanel1.Children.Add(Fruits);
						number1 = result_number;
						textblock1.Text = number1.ToString() + "÷";
					}
					if (operator1 == 1)
					{
						textblock2.Text = "";
						result_number = number1 + number2;
						ListView Fruits = new ListView();
						Fruits.Items.Add(number1 + "+" + number2 + "=" + result_number);
						StackPanel1.Children.Add(Fruits);
						number1 = result_number;
						textblock1.Text = number1.ToString() + "÷";
					}
					number2 = 0;
					operator1 = 4;
					decimal2 = false;
				}
			}
			bits = 1;
		}

		private void multiplication_button(object sender, RoutedEventArgs e)
		{
			if (order == 1)
			{
				textblock1.Text = number1.ToString() + "×";
				operator1 = 3;
				order = 2;
				number2 = 0;
				finish2 = true;

			}
			else
			{
				if (textblock2.Text == "")
				{
					textblock1.Text = number1.ToString() + "×";
					textblock2.Text = "";
					operator1 = 3;
					order = 2;
					finish2 = true;
				}
				else
				{
					finish2 = true;
					if (operator1 == 4)
					{
						if (number2 == 0)
						{
							textblock1.Text = "0不能做除数！";
							finish1 = true;
						}
						else
						{
							textblock2.Text = "";
							result_number = number1 / number2;
							ListView Fruits = new ListView();
							Fruits.Items.Add(number1 + "÷" + number2 + "=" + result_number);
							StackPanel1.Children.Add(Fruits);
							number1 = result_number;
							textblock1.Text = number1.ToString() + "×";
						}
					}
					if (operator1 == 3)
					{
						textblock2.Text = "";
						result_number = number1 * number2;
						ListView Fruits = new ListView();
						Fruits.Items.Add(number1 + "×" + number2 + "=" + result_number);
						StackPanel1.Children.Add(Fruits);
						number1 = result_number;
						textblock1.Text = number1.ToString() + "×";
					}
					if (operator1 == 2)
					{
						textblock2.Text = "";
						result_number = number1 - number2;
						ListView Fruits = new ListView();
						Fruits.Items.Add( number1 + "-" + number2 + "=" + result_number);
						StackPanel1.Children.Add(Fruits);
						number1 = result_number;
						textblock1.Text = number1.ToString() + "×";
					}
					if (operator1 == 1)
					{
						textblock2.Text = "";
						result_number = number1 + number2;
						ListView Fruits = new ListView();
						Fruits.Items.Add( number1 + "+" + number2 + "=" + result_number);
						StackPanel1.Children.Add(Fruits);
						number1 = result_number;
						textblock1.Text = number1.ToString() + "×";
					}
					number2 = 0;
					operator1 = 3;
					decimal2 = false;
				}
			}
			bits = 1;
		}

		private void subtraction_button(object sender, RoutedEventArgs e)
		{
			if (order == 1)
			{
				textblock1.Text = number1.ToString() + "-";
				operator1 = 2;
				order = 2;
				number2 = 0;
				finish2 = true;

			}
			else
			{
				if (textblock2.Text == "")
				{
					textblock1.Text = number1.ToString() + "-";
					textblock2.Text = "";
					operator1 = 2;
					order = 2;
					finish2 = true;
				}
				else
				{
					finish2 = true;
					if (operator1 == 4)
					{
						if (number2 == 0)
						{
							textblock1.Text = "0不能做除数！";
							finish1 = true;
						}
						else
						{
							textblock2.Text = "";
							result_number = number1 / number2;
							ListView Fruits = new ListView();
							Fruits.Items.Add(number1 + "÷" + number2 + "=" + result_number);
							StackPanel1.Children.Add(Fruits);
							number1 = result_number;
							textblock1.Text = number1.ToString() + "-";
						}
					}
					if (operator1 == 3)
					{
						textblock2.Text = "";
						result_number = number1 * number2;
						ListView Fruits = new ListView();
						Fruits.Items.Add( number1 + "×" + number2 + "=" + result_number);
						StackPanel1.Children.Add(Fruits);
						number1 = result_number;
						textblock1.Text = number1.ToString() + "-";
					}
					if (operator1 == 2)
					{
						textblock2.Text = "";
						result_number = number1 - number2;
						ListView Fruits = new ListView();
						Fruits.Items.Add(number1 + "-" + number2 + "=" + result_number);
						StackPanel1.Children.Add(Fruits);
						number1 = result_number;
						textblock1.Text = number1.ToString() + "-";
					}
					if (operator1 == 1)
					{
						textblock2.Text = "";
						result_number = number1 + number2;
						ListView Fruits = new ListView();
						Fruits.Items.Add( number1 + "+" + number2 + "=" + result_number);
						StackPanel1.Children.Add(Fruits);
						number1 = result_number;
						textblock1.Text = number1.ToString() + "-";
					}
					number2 = 0;
					operator1 = 2;
					decimal2 = false;
				}
			}
			bits = 1;
		}

		private void addition_button(object sender, RoutedEventArgs e)
		{
			if (order == 1)
			{
				textblock1.Text = number1.ToString() + "+";
				operator1 = 1;
				order = 2;
				number2 = 0;
				finish2 = true;

			}
			else
			{
				if (textblock2.Text == "")
				{
					textblock1.Text = number1.ToString() + "+";
					textblock2.Text = "";
					operator1 = 1;
					order = 2;
					finish2 = true;
				}
				else
				{
					finish2 = true;
					if (operator1 == 4)
					{
						if (number2 == 0)
						{
							textblock1.Text = "0不能做除数！";
							finish1 = true;
						}
						else
						{
							textblock2.Text = "";
							result_number = number1 / number2;
							ListView Fruits = new ListView();
							Fruits.Items.Add(number1 + "÷" + number2 + "=" + result_number);
							StackPanel1.Children.Add(Fruits);
							number1 = result_number;
							textblock1.Text = number1.ToString() + "+";
						}
					}
					if (operator1 == 3)
					{
						textblock2.Text = "";
						result_number = number1 * number2;
						ListView Fruits = new ListView();
						Fruits.Items.Add(number1 + "×" + number2 + "=" + result_number);
						StackPanel1.Children.Add(Fruits);
						number1 = result_number;
						textblock1.Text = number1.ToString() + "+";
					}
					if (operator1 == 2)
					{
						textblock2.Text = "";
						result_number = number1 - number2;
						ListView Fruits = new ListView();
						Fruits.Items.Add(number1 + "-" + number2 + "=" + result_number);
						StackPanel1.Children.Add(Fruits);
						number1 = result_number;
						textblock1.Text = number1.ToString() + "+";
					}
					if (operator1 == 1)
					{
						textblock2.Text = "";
						result_number = number1 + number2;
						ListView Fruits = new ListView();
						Fruits.Items.Add( number1 + "+" + number2 + "=" + result_number);
						StackPanel1.Children.Add(Fruits);
						number1 = result_number;
						textblock1.Text = number1.ToString() + "+";
					}
					number2 = 0;
					operator1 = 1;
					decimal2 = false;
				}
			}
			bits = 1;
		}

		private void equal_button(object sender, RoutedEventArgs e)
		{
			if (operator1 == 0)
			{
				result_number = number1;
				textblock1.Text = number1 + "=" + result_number;
				textblock2.Text = "";
				ListView Fruits = new ListView();
				Fruits.Items.Add(number1 + "=" + result_number);
				StackPanel1.Children.Add(Fruits);
			}
			if (operator1 == 1)
			{
				result_number = number1 + number2;
				textblock1.Text = number1 + "+" + number2 + "=" + result_number;
				textblock2.Text = "";
				ListView Fruits = new ListView();
				Fruits.Items.Add(number1 + "+" + number2 + "=" + result_number);
				StackPanel1.Children.Add(Fruits);
				finish1 = true;
				order = 1;
			}
			if (operator1 == 2)
			{
				result_number = number1 - number2;
				textblock1.Text = number1 + "-" + number2 + "=" + result_number;
				textblock2.Text = "";
				ListView Fruits = new ListView();
				Fruits.Items.Add(number1 + "-" + number2 + "=" + result_number);
				StackPanel1.Children.Add(Fruits);
				finish1 = true;
				order = 1;
			}
			if (operator1 == 3)
			{
				result_number = number1 * number2;
				textblock1.Text = number1 + "×" + number2 + "=" + result_number;
				textblock2.Text = "";
				ListView Fruits = new ListView();
				Fruits.Items.Add( number1 + "×" + number2 + "=" + result_number);
				StackPanel1.Children.Add(Fruits);
				finish1 = true;
				order = 1;
			}
			if (operator1 == 4)
			{
				if (number2 == 0)
				{
					result_number = number1;
					textblock1.Text = "0不能做除数。";
				}
				else
				{
					result_number = number1 / number2;
					textblock1.Text = number1 + "÷" + number2 + "=" + result_number;
					textblock2.Text = "";
					ListView Fruits = new ListView();
					Fruits.Items.Add(number1 + "÷" + number2 + "=" + result_number);
					StackPanel1.Children.Add(Fruits);
					finish1 = true;
					order = 1;
				}
			}
			number1 = result_number;
		}

		private void square_button(object sender, RoutedEventArgs e)
		{
			if (order == 1)
			{
				ListView Fruits = new ListView();
				Fruits.Items.Add( number1 + "^ 2 =" + number1 * number1);
				StackPanel1.Children.Add(Fruits);
				number1 = number1 * number1; 
				textblock1.Text = number1.ToString();
				finish1 = true;
			}
			if (order == 2)
			{
				ListView Fruits = new ListView();
				Fruits.Items.Add( number2 + "^ 2 =" + number2 * number2);
				StackPanel1.Children.Add(Fruits);
				number2 = number2 * number2;
				textblock1.Text = number2.ToString();
				finish1 = true;
			}
		}

		private void square_root_button(object sender, RoutedEventArgs e)
		{
			if (order == 1)
			{
				if (number1 < 0)
				{
					textblock1.Text = "负数没有平方根!";
				}
				else
				{
					number4 = (double)number1;
					number1 = (decimal)Math.Sqrt(number4);
					ListView Fruits = new ListView();
					Fruits.Items.Add( number4 + "^ 0.5=" + number1);
					StackPanel1.Children.Add(Fruits);
					textblock1.Text = number1.ToString();
				}
			}
			if (order == 2)
			{
				if (number2 < 0)
				{
					textblock1.Text = "负数没有平方根!";
				}
				else
				{
					number5 = (double)number2;
					number2 = (decimal)Math.Sqrt(number5);
					ListView Fruits = new ListView();
					Fruits.Items.Add(number5 + "^ 0.5 =" + number2);
					StackPanel1.Children.Add(Fruits);
					textblock1.Text = number2.ToString();
				}
			}
			finish1 = true;
		}

		private void reciprocal_button(object sender, RoutedEventArgs e)
		{
			if (order == 1)
			{
				if (number1 == 0)
				{
					textblock1.Text = "0不能做除数!";
				}
				else
				{
					ListView Fruits = new ListView();
					Fruits.Items.Add( "1/" + number1 + " =" + 1 / number1);
					StackPanel1.Children.Add(Fruits);
					number1 = 1 / number1; 
					textblock1.Text = number1.ToString();
				}
				finish1 = true;
			}
			if (order == 2)
			{
				if (number2 == 0)
				{
					textblock1.Text = "0不能做除数!";
				}
				else
				{
					ListView Fruits = new ListView();
					Fruits.Items.Add("1/" + number2 + " =" + 1 / number2);
					StackPanel1.Children.Add(Fruits);
					number2 = 1 / number2;
					textblock1.Text = number2.ToString();
				}
				finish1 = true;
			}
		}

		private void decimal_point_button(object sender, RoutedEventArgs e)
		{
			if (order == 1)
			{
				decimal1 = true;
			}
			if (order == 2)
			{
				decimal2 = true;
			}
		}

		
		private void positive_and_negative_button(object sender, RoutedEventArgs e)
		{
			if (order == 1)
			{
				number1 = -1 * number1;
				textblock1.Text= number1.ToString();
			}
			if (order == 2)
			{
				number2 = -1 * number2;
				textblock1.Text = number2.ToString();
			}
		}


		private void return_button(object sender, RoutedEventArgs e)
		{
			if (order ==1)
			{
				if (finish1==true)
				{
					number1 = 0;
					finish1 = false;
				}
				else
				{
					if (decimal1 == true)
					{
						number1 = Math.Floor(number1 * bits / 10) * 10 / bits;
						bits = bits / 10;
						if (bits==1)
						{
							decimal1 = false;
						}
					}
					else
					{
						number1 = Math.Floor(number1 / 10);
					}
				}
				textblock1.Text = number1.ToString();
                operator1 = 0;
                number2 = 0;
			}
			if (order == 2)
			{
				if (finish1 == true)
				{
					number2 = 0;
					finish1 = false;
					textblock1.Text = number2.ToString();
				}
				else
				{
					if (number2 == 0)
					{
						order = 1;
						operator1 = 0;
						textblock2.Text = "";
						textblock1.Text = number1.ToString();
						if (number1 %1 != 0)
						{
							bits = 1;
							number6 = number1 % 1;
							while (number6 % 1 != 0)
							{
								bits = bits * 10;
								number6 = number6 * 10;
							}
						}
					}
					else
					{
						if (decimal2 == true)
						{
							number2 = Math.Floor(number2 * bits / 10) * 10 / bits;
							bits = bits / 10;
							if (bits == 1)
							{
								decimal2 = false;
							}
							textblock1.Text = number2.ToString();
						}
						else
						{
							number2 = Math.Floor(number2 / 10);
							textblock1.Text = number2.ToString();
						}
					}	
				}
			}
		}

		private void clean_history(object sender, RoutedEventArgs e)
		{
			StackPanel1.Children.Clear();
		}
	}
}
