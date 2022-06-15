using System;
using System.IO;
using Microsoft.Win32;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Security;
using System.Windows.Media;

namespace UPG_Inventory
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        //    WindowState prevState;
        //    bool min = false;
        public MainWindow()
        {
            InitializeComponent();
            if (File.Exists("dataUPG.upg") == true)
            {
                Open();
            }
        }
        async private void Open()
        {
            if (File.Exists("dataUPG.upg") == true)
            {
                try
                {
                    using (StreamReader reader = new StreamReader("dataUPG.upg", false))
                    {
                        
                        string line = reader.ReadLine();
                        char[] cr = new char[line.Length];
                        for (int i = 0; i < line.Length; i++)
                        {
                            cr[i] = line[i];
                        }
                        Item1Image(cr[0].ToString());
                        Item2Image(cr[2].ToString());
                        Item3Image(cr[4].ToString());
                        Item4Image(cr[6].ToString());
                        Item5Image(cr[8].ToString());

                        TextBox_1.Text = cr[1].ToString();
                        TextBox_2.Text = cr[3].ToString();
                        TextBox_3.Text = cr[5].ToString();
                        TextBox_4.Text = cr[7].ToString();
                        TextBox_5.Text = cr[9].ToString();

                        Change_background_item(0, Convert.ToInt32(cr[10]) - 48);
                        Change_background_item(1, Convert.ToInt32(cr[11]) - 48);
                        Change_background_item(2, Convert.ToInt32(cr[12]) - 48);
                        Change_background_item(3, Convert.ToInt32(cr[13]) - 48);
                        Change_background_item(4, Convert.ToInt32(cr[14]) - 48);
                    }
                }
                catch
                {
                    Clear_all();
                }
            }
        }
        async private void save()
        {
            if (File.Exists("dataUPG.upg") == false)
            {
                File.CreateText("dataUPG.upg");
            }
            try
            {
                using (StreamWriter writer = new StreamWriter("dataUPG.upg", false))
                {
                    // Сохранение предметов + кол-во зарядов

                    if (Item1.Source != null)
                    {
                        switch (Item1.Source.ToString().Substring(Item1.Source.ToString().LastIndexOf('/')).Trim('/'))
                        {
                            case "Блудная косичка Бьерна.png":
                                {
                                    await writer.WriteAsync("1");
                                }
                                break;
                            case "Взрывчатка.png":
                                {
                                    await writer.WriteAsync("2");
                                }
                                break;
                            case "Корона короля пресетов.png":
                                {
                                    await writer.WriteAsync("3");
                                }
                                break;
                            case "Красочная манга.png":
                                {
                                    await writer.WriteAsync("4");
                                }
                                break;
                            case "Кубик хуюбика.png":
                                {
                                    await writer.WriteAsync("5");
                                }
                                break;
                            case "Облизанный ободок унитаза.png":
                                {
                                    await writer.WriteAsync("6");
                                }
                                break;
                            case "Очки EZ.png":
                                {
                                    await writer.WriteAsync("7");
                                }
                                break;
                            case "Повязка Рэмбо.png":
                                {
                                    await writer.WriteAsync("8");
                                }
                                break;
                            case "Реверсивные сапоги.png":
                                {
                                    await writer.WriteAsync("9");
                                }
                                break;
                            case "Ремонтный набор.png":
                                {
                                    await writer.WriteAsync("a");
                                }
                                break;
                            case "Рука Мидаса.png":
                                {
                                    await writer.WriteAsync("b");
                                }
                                break;
                            case "Свиток реролла.png":
                                {
                                    await writer.WriteAsync("c");
                                }
                                break;
                            case "Святая карта Юпитер.png":
                                {
                                    await writer.WriteAsync("d");
                                }
                                break;
                            case "Читерский кубик.png":
                                {
                                    await writer.WriteAsync("e");
                                }
                                break;
                            case "Шар всезнания.png":
                                {
                                    await writer.WriteAsync("f");
                                }
                                break;
                        }
                        await writer.WriteAsync(TextBox_1.Text);
                    }
                    else
                        await writer.WriteAsync("00");
                    if (Item2.Source != null)
                    {
                        switch (Item2.Source.ToString().Substring(Item2.Source.ToString().LastIndexOf('/')).Trim('/'))
                        {
                            case "Блудная косичка Бьерна.png":
                                {
                                    await writer.WriteAsync("1");
                                }
                                break;
                            case "Взрывчатка.png":
                                {
                                    await writer.WriteAsync("2");
                                }
                                break;
                            case "Корона короля пресетов.png":
                                {
                                    await writer.WriteAsync("3");
                                }
                                break;
                            case "Красочная манга.png":
                                {
                                    await writer.WriteAsync("4");
                                }
                                break;
                            case "Кубик хуюбика.png":
                                {
                                    await writer.WriteAsync("5");
                                }
                                break;
                            case "Облизанный ободок унитаза.png":
                                {
                                    await writer.WriteAsync("6");
                                }
                                break;
                            case "Очки EZ.png":
                                {
                                    await writer.WriteAsync("7");
                                }
                                break;
                            case "Повязка Рэмбо.png":
                                {
                                    await writer.WriteAsync("8");
                                }
                                break;
                            case "Реверсивные сапоги.png":
                                {
                                    await writer.WriteAsync("9");
                                }
                                break;
                            case "Ремонтный набор.png":
                                {
                                    await writer.WriteAsync("a");
                                }
                                break;
                            case "Рука Мидаса.png":
                                {
                                    await writer.WriteAsync("b");
                                }
                                break;
                            case "Свиток реролла.png":
                                {
                                    await writer.WriteAsync("c");
                                }
                                break;
                            case "Святая карта Юпитер.png":
                                {
                                    await writer.WriteAsync("d");
                                }
                                break;
                            case "Читерский кубик.png":
                                {
                                    await writer.WriteAsync("e");
                                }
                                break;
                            case "Шар всезнания.png":
                                {
                                    await writer.WriteAsync("f");
                                }
                                break;
                        }
                        await writer.WriteAsync(TextBox_2.Text);
                    }
                    else
                        await writer.WriteAsync("00");
                    if (Item3.Source != null)
                    {
                        switch (Item3.Source.ToString().Substring(Item3.Source.ToString().LastIndexOf('/')).Trim('/'))
                        {
                            case "Блудная косичка Бьерна.png":
                                {
                                    await writer.WriteAsync("1");
                                }
                                break;
                            case "Взрывчатка.png":
                                {
                                    await writer.WriteAsync("2");
                                }
                                break;
                            case "Корона короля пресетов.png":
                                {
                                    await writer.WriteAsync("3");
                                }
                                break;
                            case "Красочная манга.png":
                                {
                                    await writer.WriteAsync("4");
                                }
                                break;
                            case "Кубик хуюбика.png":
                                {
                                    await writer.WriteAsync("5");
                                }
                                break;
                            case "Облизанный ободок унитаза.png":
                                {
                                    await writer.WriteAsync("6");
                                }
                                break;
                            case "Очки EZ.png":
                                {
                                    await writer.WriteAsync("7");
                                }
                                break;
                            case "Повязка Рэмбо.png":
                                {
                                    await writer.WriteAsync("8");
                                }
                                break;
                            case "Реверсивные сапоги.png":
                                {
                                    await writer.WriteAsync("9");
                                }
                                break;
                            case "Ремонтный набор.png":
                                {
                                    await writer.WriteAsync("a");
                                }
                                break;
                            case "Рука Мидаса.png":
                                {
                                    await writer.WriteAsync("b");
                                }
                                break;
                            case "Свиток реролла.png":
                                {
                                    await writer.WriteAsync("c");
                                }
                                break;
                            case "Святая карта Юпитер.png":
                                {
                                    await writer.WriteAsync("d");
                                }
                                break;
                            case "Читерский кубик.png":
                                {
                                    await writer.WriteAsync("e");
                                }
                                break;
                            case "Шар всезнания.png":
                                {
                                    await writer.WriteAsync("f");
                                }
                                break;
                        }
                        await writer.WriteAsync(TextBox_3.Text);
                    }
                    else
                        await writer.WriteAsync("00");
                    if (Item4.Source != null)
                    {
                        switch (Item4.Source.ToString().Substring(Item4.Source.ToString().LastIndexOf('/')).Trim('/'))
                        {
                            case "Блудная косичка Бьерна.png":
                                {
                                    await writer.WriteAsync("1");
                                }
                                break;
                            case "Взрывчатка.png":
                                {
                                    await writer.WriteAsync("2");
                                }
                                break;
                            case "Корона короля пресетов.png":
                                {
                                    await writer.WriteAsync("3");
                                }
                                break;
                            case "Красочная манга.png":
                                {
                                    await writer.WriteAsync("4");
                                }
                                break;
                            case "Кубик хуюбика.png":
                                {
                                    await writer.WriteAsync("5");
                                }
                                break;
                            case "Облизанный ободок унитаза.png":
                                {
                                    await writer.WriteAsync("6");
                                }
                                break;
                            case "Очки EZ.png":
                                {
                                    await writer.WriteAsync("7");
                                }
                                break;
                            case "Повязка Рэмбо.png":
                                {
                                    await writer.WriteAsync("8");
                                }
                                break;
                            case "Реверсивные сапоги.png":
                                {
                                    await writer.WriteAsync("9");
                                }
                                break;
                            case "Ремонтный набор.png":
                                {
                                    await writer.WriteAsync("a");
                                }
                                break;
                            case "Рука Мидаса.png":
                                {
                                    await writer.WriteAsync("b");
                                }
                                break;
                            case "Свиток реролла.png":
                                {
                                    await writer.WriteAsync("c");
                                }
                                break;
                            case "Святая карта Юпитер.png":
                                {
                                    await writer.WriteAsync("d");
                                }
                                break;
                            case "Читерский кубик.png":
                                {
                                    await writer.WriteAsync("e");
                                }
                                break;
                            case "Шар всезнания.png":
                                {
                                    await writer.WriteAsync("f");
                                }
                                break;
                        }
                        await writer.WriteAsync(TextBox_4.Text);
                    }
                    else
                        await writer.WriteAsync("00");
                    if (Item5.Source != null)
                    {
                        switch (Item5.Source.ToString().Substring(Item5.Source.ToString().LastIndexOf('/')).Trim('/'))
                        {
                            case "Блудная косичка Бьерна.png":
                                {
                                    await writer.WriteAsync("1");
                                }
                                break;
                            case "Взрывчатка.png":
                                {
                                    await writer.WriteAsync("2");
                                }
                                break;
                            case "Корона короля пресетов.png":
                                {
                                    await writer.WriteAsync("3");
                                }
                                break;
                            case "Красочная манга.png":
                                {
                                    await writer.WriteAsync("4");
                                }
                                break;
                            case "Кубик хуюбика.png":
                                {
                                    await writer.WriteAsync("5");
                                }
                                break;
                            case "Облизанный ободок унитаза.png":
                                {
                                    await writer.WriteAsync("6");
                                }
                                break;
                            case "Очки EZ.png":
                                {
                                    await writer.WriteAsync("7");
                                }
                                break;
                            case "Повязка Рэмбо.png":
                                {
                                    await writer.WriteAsync("8");
                                }
                                break;
                            case "Реверсивные сапоги.png":
                                {
                                    await writer.WriteAsync("9");
                                }
                                break;
                            case "Ремонтный набор.png":
                                {
                                    await writer.WriteAsync("a");
                                }
                                break;
                            case "Рука Мидаса.png":
                                {
                                    await writer.WriteAsync("b");
                                }
                                break;
                            case "Свиток реролла.png":
                                {
                                    await writer.WriteAsync("c");
                                }
                                break;
                            case "Святая карта Юпитер.png":
                                {
                                    await writer.WriteAsync("d");
                                }
                                break;
                            case "Читерский кубик.png":
                                {
                                    await writer.WriteAsync("e");
                                }
                                break;
                            case "Шар всезнания.png":
                                {
                                    await writer.WriteAsync("f");
                                }
                                break;
                        }
                        await writer.WriteAsync(TextBox_5.Text);
                    }
                    else
                        await writer.WriteAsync("00");

                    // бафф или дебафф

                    if (_panel_1 == 0)
                        await writer.WriteAsync("0");
                    else if(_panel_1 == 1)
                        await writer.WriteAsync("1");
                    else if (_panel_1 == 2)
                        await writer.WriteAsync("2");

                    if (_panel_2 == 0)
                        await writer.WriteAsync("0");
                    else if(_panel_2 == 1)
                        await writer.WriteAsync("1");
                    else if (_panel_2 == 2)
                        await writer.WriteAsync("2");

                    if (_panel_3 == 0)
                        await writer.WriteAsync("0");
                    else if(_panel_3 == 1)
                        await writer.WriteAsync("1");
                    else if (_panel_3 == 2)
                        await writer.WriteAsync("2");

                    if (_panel_4 == 0)
                        await writer.WriteAsync("0");
                    else if(_panel_4 == 1)
                        await writer.WriteAsync("1");
                    else if (_panel_4 == 2)
                        await writer.WriteAsync("2");

                    if (_panel_5 == 0)
                        await writer.WriteAsync("0");
                    else if(_panel_5 == 1)
                        await writer.WriteAsync("1");
                    else if (_panel_5 == 2)
                        await writer.WriteAsync("2");
                }
            }
            catch
            {

            }


        }
        //private void Window_StateChanged(object sender, EventArgs e)
        //{
        //    if (WindowState == WindowState.Minimized)
        //    {
        //        Hide();
        //        min = true;
        //    }
        //    else
        //    {
        //        prevState = WindowState;
        //    }
        //}
        //private void TaskbarIcon_TrayLeftMouseDown(object sender, RoutedEventArgs e)
        //{
        //    if (min == true)
        //    {
        //        Show();
        //        min = false;
        //    }
        //    else
        //    {
        //        Hide();
        //        min = true;
        //    }
        //    WindowState = prevState;
        //}
        //=================================================================
        private void saving(object sender, System.ComponentModel.CancelEventArgs e)
        {
            save();
        }
        //=================================================================
        // замена иконок предметов
        private void Item1Image(string ImageNum)
        {
            switch (ImageNum)
            {
                case "e":
                    Item1.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Читерский кубик.png"));
                    TextBox_1.Text = "1";
                    Change_background_item(0,2);
                    break;
                case "5":
                    Item1.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Кубик хуюбика.png"));
                    TextBox_1.Text = "0";
                    Change_background_item(0, 1);
                    break;
                case "7":
                    Item1.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Очки EZ.png"));
                    TextBox_1.Text = "0";
                    Change_background_item(0, 2);
                    break;
                case "8":
                    Item1.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Повязка Рэмбо.png"));
                    TextBox_1.Text = "0";
                    Change_background_item(0, 1);
                    break;
                case "c":
                    Item1.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Свиток реролла.png"));
                    TextBox_1.Text = "1";
                    Change_background_item(0, 2);
                    break;
                case "f":
                    Item1.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Шар всезнания.png"));
                    TextBox_1.Text = "1";
                    Change_background_item(0, 2);
                    break;
                case "3":
                    Item1.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Корона короля пресетов.png"));
                    TextBox_1.Text = "1";
                    Change_background_item(0, 2);
                    break;
                case "2":
                    Item1.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Взрывчатка.png"));
                    TextBox_1.Text = "2";
                    Change_background_item(0, 1);
                    break;
                case "a":
                    Item1.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Ремонтный набор.png"));
                    TextBox_1.Text = "1";
                    Change_background_item(0, 2);
                    break;
                case "4":
                    Item1.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Красочная манга.png"));
                    TextBox_1.Text = "1";
                    Change_background_item(0, 2);
                    break;
                case "6":
                    Item1.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Облизанный ободок унитаза.png"));
                    TextBox_1.Text = "1";
                    Change_background_item(0, 0);
                    break;
                case "b":
                    Item1.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Рука мидаса.png"));
                    TextBox_1.Text = "3";
                    Change_background_item(0, 0);
                    break;
                case "9":
                    Item1.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Реверсивные сапоги.png"));
                    TextBox_1.Text = "1";
                    Change_background_item(0, 1);
                    break;
                case "d":
                    Item1.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Святая карта Юпитер.png"));
                    TextBox_1.Text = "1";
                    Change_background_item(0, 2);
                    break;
                case "1":
                    Item1.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Блудная косичка Бьерна.png"));
                    TextBox_1.Text = "1";
                    Change_background_item(0, 1);
                    break;
            }
        }
        private void Item2Image(string ImageNum)
        {
            switch (ImageNum)
            {
                case "e":
                    Item2.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Читерский кубик.png"));
                    TextBox_2.Text = "1";
                    Change_background_item(1, 2);
                    break;
                case "5":
                    Item2.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Кубик хуюбика.png"));
                    TextBox_2.Text = "0";
                    Change_background_item(1, 1);
                    break;
                case "7":
                    Item2.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Очки EZ.png"));
                    TextBox_2.Text = "0";
                    Change_background_item(1, 2);
                    break;
                case "8":
                    Item2.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Повязка Рэмбо.png"));
                    TextBox_2.Text = "0";
                    Change_background_item(1, 1);
                    break;
                case "c":
                    Item2.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Свиток реролла.png"));
                    TextBox_2.Text = "1";
                    Change_background_item(1, 2);
                    break;
                case "f":
                    Item2.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Шар всезнания.png"));
                    TextBox_2.Text = "1";
                    Change_background_item(1, 2);
                    break;
                case "3":
                    Item2.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Корона короля пресетов.png"));
                    TextBox_2.Text = "1";
                    Change_background_item(1, 2);
                    break;
                case "2":
                    Item2.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Взрывчатка.png"));
                    TextBox_2.Text = "2";
                    Change_background_item(1, 1);
                    break;
                case "a":
                    Item2.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Ремонтный набор.png"));
                    TextBox_2.Text = "1";
                    Change_background_item(1, 2);
                    break;
                case "4":
                    Item2.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Красочная манга.png"));
                    TextBox_2.Text = "1";
                    Change_background_item(1, 2);
                    break;
                case "6":
                    Item2.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Облизанный ободок унитаза.png"));
                    TextBox_2.Text = "1";
                    Change_background_item(1, 0);
                    break;
                case "b":
                    Item2.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Рука мидаса.png"));
                    TextBox_2.Text = "3";
                    Change_background_item(1, 0);
                    break;
                case "9":
                    Item2.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Реверсивные сапоги.png"));
                    TextBox_2.Text = "1";
                    Change_background_item(1, 1);
                    break;
                case "d":
                    Item2.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Святая карта Юпитер.png"));
                    TextBox_2.Text = "1";
                    Change_background_item(1, 2);
                    break;
                case "1":
                    Item2.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Блудная косичка Бьерна.png"));
                    TextBox_2.Text = "1";
                    Change_background_item(1, 1);
                    break;
            }
        }
        private void Item3Image(string ImageNum)
        {
            switch (ImageNum)
            {
                case "e":
                    Item3.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Читерский кубик.png"));
                    TextBox_3.Text = "1";
                    Change_background_item(2, 2);
                    break;
                case "5":
                    Item3.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Кубик хуюбика.png"));
                    TextBox_3.Text = "0";
                    Change_background_item(2, 1);
                    break;
                case "7":
                    Item3.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Очки EZ.png"));
                    TextBox_3.Text = "0";
                    Change_background_item(2, 2);
                    break;
                case "8":
                    Item3.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Повязка Рэмбо.png"));
                    TextBox_3.Text = "0";
                    Change_background_item(2, 1);
                    break;
                case "c":
                    Item3.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Свиток реролла.png"));
                    TextBox_3.Text = "1";
                    Change_background_item(2, 2);
                    break;
                case "f":
                    Item3.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Шар всезнания.png"));
                    TextBox_3.Text = "1";
                    Change_background_item(2, 2);
                    break;
                case "3":
                    Item3.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Корона короля пресетов.png"));
                    TextBox_3.Text = "1";
                    Change_background_item(2, 2);
                    break;
                case "2":
                    Item3.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Взрывчатка.png"));
                    TextBox_3.Text = "2";
                    Change_background_item(2, 1);
                    break;
                case "a":
                    Item3.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Ремонтный набор.png"));
                    TextBox_3.Text = "1";
                    Change_background_item(2, 2);
                    break;
                case "4":
                    Item3.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Красочная манга.png"));
                    TextBox_3.Text = "1";
                    Change_background_item(2, 2);
                    break;
                case "6":
                    Item3.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Облизанный ободок унитаза.png"));
                    TextBox_3.Text = "1";
                    Change_background_item(2, 0);
                    break;
                case "b":
                    Item3.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Рука мидаса.png"));
                    TextBox_3.Text = "3";
                    Change_background_item(2, 0);
                    break;
                case "9":
                    Item3.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Реверсивные сапоги.png"));
                    TextBox_3.Text = "1";
                    Change_background_item(2, 1);
                    break;
                case "d":
                    Item3.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Святая карта Юпитер.png"));
                    TextBox_3.Text = "1";
                    Change_background_item(2, 2);
                    break;
                case "1":
                    Item3.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Блудная косичка Бьерна.png"));
                    TextBox_3.Text = "1";
                    Change_background_item(2, 1);
                    break;
            }
        }
        private void Item4Image(string ImageNum)
        {
            switch (ImageNum)
            {
                case "e":
                    Item4.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Читерский кубик.png"));
                    TextBox_4.Text = "1";
                    Change_background_item(3, 2);
                    break;
                case "5":
                    Item4.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Кубик хуюбика.png"));
                    TextBox_4.Text = "0";
                    Change_background_item(3, 1);
                    break;
                case "7":
                    Item4.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Очки EZ.png"));
                    TextBox_4.Text = "0";
                    Change_background_item(3, 2);
                    break;
                case "8":
                    Item4.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Повязка Рэмбо.png"));
                    TextBox_4.Text = "0";
                    Change_background_item(3, 1);
                    break;
                case "c":
                    Item4.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Свиток реролла.png"));
                    TextBox_4.Text = "1";
                    Change_background_item(3, 2);
                    break;
                case "f":
                    Item4.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Шар всезнания.png"));
                    TextBox_4.Text = "1";
                    Change_background_item(3, 2);
                    break;
                case "3":
                    Item4.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Корона короля пресетов.png"));
                    TextBox_4.Text = "1";
                    Change_background_item(3, 2);
                    break;
                case "2":
                    Item4.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Взрывчатка.png"));
                    TextBox_4.Text = "2";
                    Change_background_item(3, 1);
                    break;
                case "a":
                    Item4.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Ремонтный набор.png"));
                    TextBox_4.Text = "1";
                    Change_background_item(3, 2);
                    break;
                case "4":
                    Item4.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Красочная манга.png"));
                    TextBox_4.Text = "1";
                    Change_background_item(3, 2);
                    break;
                case "6":
                    Item4.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Облизанный ободок унитаза.png"));
                    TextBox_4.Text = "1";
                    Change_background_item(3, 0);
                    break;
                case "b":
                    Item4.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Рука мидаса.png"));
                    TextBox_4.Text = "3";
                    Change_background_item(3, 0);
                    break;
                case "9":
                    Item4.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Реверсивные сапоги.png"));
                    TextBox_4.Text = "1";
                    Change_background_item(3, 1);
                    break;
                case "d":
                    Item4.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Святая карта Юпитер.png"));
                    TextBox_4.Text = "1";
                    Change_background_item(3, 2);
                    break;
                case "1":
                    Item4.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Блудная косичка Бьерна.png"));
                    TextBox_4.Text = "1";
                    Change_background_item(3, 1);
                    break;
            }
        }
        private void Item5Image(string ImageNum)
        {
            switch (ImageNum)
            {
                case "e":
                    Item5.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Читерский кубик.png"));
                    TextBox_5.Text = "1";
                    Change_background_item(4, 2);
                    break;
                case "5":
                    Item5.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Кубик хуюбика.png"));
                    TextBox_5.Text = "0";
                    Change_background_item(4, 1);
                    break;
                case "7":
                    Item5.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Очки EZ.png"));
                    TextBox_5.Text = "0";
                    Change_background_item(4, 2);
                    break;
                case "8":
                    Item5.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Повязка Рэмбо.png"));
                    TextBox_5.Text = "0";
                    Change_background_item(4, 1);
                    break;
                case "c":
                    Item5.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Свиток реролла.png"));
                    TextBox_5.Text = "1";
                    Change_background_item(4, 2);
                    break;
                case "f":
                    Item5.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Шар всезнания.png"));
                    TextBox_5.Text = "1";
                    Change_background_item(4, 2);
                    break;
                case "3":
                    Item5.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Корона короля пресетов.png"));
                    TextBox_5.Text = "1";
                    Change_background_item(4, 2);
                    break;
                case "2":
                    Item5.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Взрывчатка.png"));
                    TextBox_5.Text = "2";
                    Change_background_item(4, 1);
                    break;
                case "a":
                    Item5.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Ремонтный набор.png"));
                    TextBox_5.Text = "1";
                    Change_background_item(4, 2);
                    break;
                case "4":
                    Item5.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Красочная манга.png"));
                    TextBox_5.Text = "1";
                    Change_background_item(4, 2);
                    break;
                case "6":
                    Item5.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Облизанный ободок унитаза.png"));
                    TextBox_5.Text = "1";
                    Change_background_item(4, 0);
                    break;
                case "b":
                    Item5.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Рука мидаса.png"));
                    TextBox_5.Text = "3";
                    Change_background_item(4, 0);
                    break;
                case "9":
                    Item5.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Реверсивные сапоги.png"));
                    TextBox_5.Text = "1";
                    Change_background_item(4, 1);
                    break;
                case "d":
                    Item5.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Святая карта Юпитер.png"));
                    TextBox_5.Text = "1";
                    Change_background_item(4, 2);
                    break;
                case "1":
                    Item5.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + '\\' + "Блудная косичка Бьерна.png"));
                    TextBox_5.Text = "1";
                    Change_background_item(4, 1);
                    break;
            }
        }
        //=================================================================
        // Radiobutton 1 ячейка
        private void rb_1_1_Checked(object sender, RoutedEventArgs e)
        {
            Item1Image("1");
        }
        private void rb_1_2_Checked(object sender, RoutedEventArgs e)
        {
            Item1Image("2");
        }

        private void rb_1_3_Checked(object sender, RoutedEventArgs e)
        {
            Item1Image("3");
        }

        private void rb_1_4_Checked(object sender, RoutedEventArgs e)
        {
            Item1Image("4");
        }
        private void rb_1_5_Checked(object sender, RoutedEventArgs e)
        {
            Item1Image("5");
        }
        private void rb_1_6_Checked(object sender, RoutedEventArgs e)
        {
            Item1Image("6");
        }

        private void rb_1_7_Checked(object sender, RoutedEventArgs e)
        {
            Item1Image("7");
        }

        private void rb_1_8_Checked(object sender, RoutedEventArgs e)
        {
            Item1Image("8");
        }
        private void rb_1_9_Checked(object sender, RoutedEventArgs e)
        {
            Item1Image("9");
        }

        private void rb_1_10_Checked(object sender, RoutedEventArgs e)
        {
            Item1Image("a");
        }
        private void rb_1_11_Checked(object sender, RoutedEventArgs e)
        {
            Item1Image("b");
        }

        private void rb_1_12_Checked(object sender, RoutedEventArgs e)
        {
            Item1Image("c");
        }

        private void rb_1_13_Checked(object sender, RoutedEventArgs e)
        {
            Item1Image("d");
        }
        private void rb_1_14_Checked(object sender, RoutedEventArgs e)
        {
            Item1Image("e");
        }

        private void rb_1_15_Checked(object sender, RoutedEventArgs e)
        {
            Item1Image("f");
        }
        //==================================================================================
        // Radiobutton 2 ячейка
        private void rb_2_1_Checked(object sender, RoutedEventArgs e)
        {
            Item2Image("1");
        }
        private void rb_2_2_Checked(object sender, RoutedEventArgs e)
        {
            Item2Image("2");
        }

        private void rb_2_3_Checked(object sender, RoutedEventArgs e)
        {
            Item2Image("3");
        }

        private void rb_2_4_Checked(object sender, RoutedEventArgs e)
        {
            Item2Image("4");
        }
        private void rb_2_5_Checked(object sender, RoutedEventArgs e)
        {
            Item2Image("5");
        }
        private void rb_2_6_Checked(object sender, RoutedEventArgs e)
        {
            Item2Image("6");
        }

        private void rb_2_7_Checked(object sender, RoutedEventArgs e)
        {
            Item2Image("7");
        }

        private void rb_2_8_Checked(object sender, RoutedEventArgs e)
        {
            Item2Image("8");
        }
        private void rb_2_9_Checked(object sender, RoutedEventArgs e)
        {
            Item2Image("9");
        }

        private void rb_2_10_Checked(object sender, RoutedEventArgs e)
        {
            Item2Image("a");
        }
        private void rb_2_11_Checked(object sender, RoutedEventArgs e)
        {
            Item2Image("b");
        }

        private void rb_2_12_Checked(object sender, RoutedEventArgs e)
        {
            Item2Image("c");
        }

        private void rb_2_13_Checked(object sender, RoutedEventArgs e)
        {
            Item2Image("d");
        }
        private void rb_2_14_Checked(object sender, RoutedEventArgs e)
        {
            Item2Image("e");
        }

        private void rb_2_15_Checked(object sender, RoutedEventArgs e)
        {
            Item2Image("f");
        }
        //==================================================================================
        // Radiobutton 3 ячейка
        private void rb_3_1_Checked(object sender, RoutedEventArgs e)
        {
            Item3Image("1");
        }
        private void rb_3_2_Checked(object sender, RoutedEventArgs e)
        {
            Item3Image("2");
        }

        private void rb_3_3_Checked(object sender, RoutedEventArgs e)
        {
            Item3Image("3");
        }

        private void rb_3_4_Checked(object sender, RoutedEventArgs e)
        {
            Item3Image("4");
        }
        private void rb_3_5_Checked(object sender, RoutedEventArgs e)
        {
            Item3Image("5");
        }
        private void rb_3_6_Checked(object sender, RoutedEventArgs e)
        {
            Item3Image("6");
        }

        private void rb_3_7_Checked(object sender, RoutedEventArgs e)
        {
            Item3Image("7");
        }

        private void rb_3_8_Checked(object sender, RoutedEventArgs e)
        {
            Item3Image("8");
        }
        private void rb_3_9_Checked(object sender, RoutedEventArgs e)
        {
            Item3Image("9");
        }

        private void rb_3_10_Checked(object sender, RoutedEventArgs e)
        {
            Item3Image("a");
        }
        private void rb_3_11_Checked(object sender, RoutedEventArgs e)
        {
            Item3Image("b");
        }

        private void rb_3_12_Checked(object sender, RoutedEventArgs e)
        {
            Item3Image("c");
        }

        private void rb_3_13_Checked(object sender, RoutedEventArgs e)
        {
            Item3Image("d");
        }
        private void rb_3_14_Checked(object sender, RoutedEventArgs e)
        {
            Item3Image("e");
        }

        private void rb_3_15_Checked(object sender, RoutedEventArgs e)
        {
            Item3Image("f");
        }
        //==================================================================================
        // Radiobutton 4 ячейка
        private void rb_4_1_Checked(object sender, RoutedEventArgs e)
        {
            Item4Image("1");
        }
        private void rb_4_2_Checked(object sender, RoutedEventArgs e)
        {
            Item4Image("2");
        }

        private void rb_4_3_Checked(object sender, RoutedEventArgs e)
        {
            Item4Image("3");
        }

        private void rb_4_4_Checked(object sender, RoutedEventArgs e)
        {
            Item4Image("4");
        }
        private void rb_4_5_Checked(object sender, RoutedEventArgs e)
        {
            Item4Image("5");
        }
        private void rb_4_6_Checked(object sender, RoutedEventArgs e)
        {
            Item4Image("6");
        }

        private void rb_4_7_Checked(object sender, RoutedEventArgs e)
        {
            Item4Image("7");
        }

        private void rb_4_8_Checked(object sender, RoutedEventArgs e)
        {
            Item4Image("8");
        }
        private void rb_4_9_Checked(object sender, RoutedEventArgs e)
        {
            Item4Image("9");
        }

        private void rb_4_10_Checked(object sender, RoutedEventArgs e)
        {
            Item4Image("a");
        }
        private void rb_4_11_Checked(object sender, RoutedEventArgs e)
        {
            Item4Image("b");
        }

        private void rb_4_12_Checked(object sender, RoutedEventArgs e)
        {
            Item4Image("c");
        }

        private void rb_4_13_Checked(object sender, RoutedEventArgs e)
        {
            Item4Image("d");
        }
        private void rb_4_14_Checked(object sender, RoutedEventArgs e)
        {
            Item4Image("e");
        }

        private void rb_4_15_Checked(object sender, RoutedEventArgs e)
        {
            Item4Image("f");
        }
        //======================================================================
        // Radiobutton 4 ячейка
        private void rb_5_1_Checked(object sender, RoutedEventArgs e)
        {
            Item5Image("1");
        }
        private void rb_5_2_Checked(object sender, RoutedEventArgs e)
        {
            Item5Image("2");
        }

        private void rb_5_3_Checked(object sender, RoutedEventArgs e)
        {
            Item5Image("3");
        }

        private void rb_5_4_Checked(object sender, RoutedEventArgs e)
        {
            Item5Image("4");
        }
        private void rb_5_5_Checked(object sender, RoutedEventArgs e)
        {
            Item5Image("5");
        }
        private void rb_5_6_Checked(object sender, RoutedEventArgs e)
        {
            Item5Image("6");
        }

        private void rb_5_7_Checked(object sender, RoutedEventArgs e)
        {
            Item5Image("7");
        }

        private void rb_5_8_Checked(object sender, RoutedEventArgs e)
        {
            Item5Image("8");
        }
        private void rb_5_9_Checked(object sender, RoutedEventArgs e)
        {
            Item5Image("9");
        }

        private void rb_5_10_Checked(object sender, RoutedEventArgs e)
        {
            Item5Image("a");
        }
        private void rb_5_11_Checked(object sender, RoutedEventArgs e)
        {
            Item5Image("b");
        }

        private void rb_5_12_Checked(object sender, RoutedEventArgs e)
        {
            Item5Image("c");
        }

        private void rb_5_13_Checked(object sender, RoutedEventArgs e)
        {
            Item5Image("d");
        }
        private void rb_5_14_Checked(object sender, RoutedEventArgs e)
        {
            Item5Image("e");
        }

        private void rb_5_15_Checked(object sender, RoutedEventArgs e)
        {
            Item5Image("f");
        }
        //==================================================================================
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void TB_Changed_1(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(TextBox_1.Text) > 0)
                    Item_sum_1.Content = TextBox_1.Text;
                if (Convert.ToInt32(TextBox_1.Text) == 0)
                    Item_sum_1.Content = null;
                
            }
            catch
            {
                Item_sum_1.Content = null;
            }
        }
        private void TB_Changed_2(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(TextBox_2.Text) > 0)
                    Item_sum_2.Content = TextBox_2.Text;
                if (Convert.ToInt32(TextBox_2.Text) == 0)
                    Item_sum_2.Content = null;
                
            }
            catch
            {
                Item_sum_2.Content = null;
            }
        }
        private void TB_Changed_3(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(TextBox_3.Text) > 0)
                    Item_sum_3.Content = TextBox_3.Text;
                if (Convert.ToInt32(TextBox_3.Text) == 0)
                    Item_sum_3.Content = null;
                
            }
            catch
            {
                Item_sum_3.Content = null;
                
            }
        }
        private void TB_Changed_4(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(TextBox_4.Text) > 0)
                    Item_sum_4.Content = TextBox_4.Text;
                if (Convert.ToInt32(TextBox_4.Text) == 0)
                    Item_sum_4.Content = null;
               
            }
            catch
            {
                Item_sum_4.Content = null;
               
            }
        }
        private void TB_Changed_5(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(TextBox_5.Text) > 0)
                    Item_sum_5.Content = TextBox_5.Text;
                if (Convert.ToInt32(TextBox_5.Text) == 0)
                    Item_sum_5.Content = null;
                
            }
            catch
            {
                Item_sum_5.Content = null;
                
            }
        }

        private void ButtonClear_1(object sender, RoutedEventArgs e)
        {
            Item_sum_1.Content = null;
            TextBox_1.Text = "0";

            Item1.Source = null;

            Panel_1.Background = Brushes.White;
            Panel_1.Opacity = 0;
            _panel_1 = 0;

            rb_1_1.IsChecked = false;
            rb_1_2.IsChecked = false;
            rb_1_3.IsChecked = false;
            rb_1_4.IsChecked = false;
            rb_1_5.IsChecked = false;
            rb_1_6.IsChecked = false;
            rb_1_7.IsChecked = false;
            rb_1_8.IsChecked = false;
            rb_1_9.IsChecked = false;
            rb_1_10.IsChecked = false;
            rb_1_11.IsChecked = false;
            rb_1_12.IsChecked = false;
            rb_1_13.IsChecked = false;
            rb_1_14.IsChecked = false;
            rb_1_15.IsChecked = false;
        }
        private void ButtonClear_2(object sender, RoutedEventArgs e)
        {
            Item_sum_2.Content = null;
            TextBox_2.Text = "0";

            Item2.Source = null;

            Panel_2.Background = Brushes.White;
            Panel_2.Opacity = 0;
            _panel_2 = 0;

            rb_2_1.IsChecked = false;
            rb_2_2.IsChecked = false;
            rb_2_3.IsChecked = false;
            rb_2_4.IsChecked = false;
            rb_2_5.IsChecked = false;
            rb_2_6.IsChecked = false;
            rb_2_7.IsChecked = false;
            rb_2_8.IsChecked = false;
            rb_2_9.IsChecked = false;
            rb_2_10.IsChecked = false;
            rb_2_11.IsChecked = false;
            rb_2_12.IsChecked = false;
            rb_2_13.IsChecked = false;
            rb_2_14.IsChecked = false;
            rb_2_15.IsChecked = false;
        }
        private void ButtonClear_3(object sender, RoutedEventArgs e)
        {
            Item_sum_3.Content = null;
            TextBox_3.Text = "0";

            Item3.Source = null;

            Panel_3.Background = Brushes.White;
            Panel_3.Opacity = 0;
            _panel_3 = 0;

            rb_3_1.IsChecked = false;
            rb_3_2.IsChecked = false;
            rb_3_3.IsChecked = false;
            rb_3_4.IsChecked = false;
            rb_3_5.IsChecked = false;
            rb_3_6.IsChecked = false;
            rb_3_7.IsChecked = false;
            rb_3_8.IsChecked = false;
            rb_3_9.IsChecked = false;
            rb_3_10.IsChecked = false;
            rb_3_11.IsChecked = false;
            rb_3_12.IsChecked = false;
            rb_3_13.IsChecked = false;
            rb_3_14.IsChecked = false;
            rb_3_15.IsChecked = false;
        }
        private void ButtonClear_4(object sender, RoutedEventArgs e)
        {
            Item_sum_4.Content = null;
            TextBox_4.Text = "0";

            Item4.Source = null;

            Panel_4.Background = Brushes.White;
            Panel_4.Opacity = 0;
            _panel_4 = 0;

            rb_4_1.IsChecked = false;
            rb_4_2.IsChecked = false;
            rb_4_3.IsChecked = false;
            rb_4_4.IsChecked = false;
            rb_4_5.IsChecked = false;
            rb_4_6.IsChecked = false;
            rb_4_7.IsChecked = false;
            rb_4_8.IsChecked = false;
            rb_4_9.IsChecked = false;
            rb_4_10.IsChecked = false;
            rb_4_11.IsChecked = false;
            rb_4_12.IsChecked = false;
            rb_4_13.IsChecked = false;
            rb_4_14.IsChecked = false;
            rb_4_15.IsChecked = false;
        }
        private void ButtonClear_5(object sender, RoutedEventArgs e)
        {
            Item_sum_5.Content = null;
            TextBox_5.Text = "0";

            Item5.Source = null;

            Panel_5.Background = Brushes.White;
            Panel_5.Opacity = 0;
            _panel_5 = 0;

            rb_5_1.IsChecked = false;
            rb_5_2.IsChecked = false;
            rb_5_3.IsChecked = false;
            rb_5_4.IsChecked = false;
            rb_5_5.IsChecked = false;
            rb_5_6.IsChecked = false;
            rb_5_7.IsChecked = false;
            rb_5_8.IsChecked = false;
            rb_5_9.IsChecked = false;
            rb_5_10.IsChecked = false;
            rb_5_11.IsChecked = false;
            rb_5_12.IsChecked = false;
            rb_5_13.IsChecked = false;
            rb_5_14.IsChecked = false;
            rb_5_15.IsChecked = false;
        }
        int _panel_1 = 0;
        int _panel_2 = 0;
        int _panel_3 = 0;
        int _panel_4 = 0;
        int _panel_5 = 0;

        private void Clear_all()
        {
            Item_sum_5.Content = null;
            TextBox_5.Text = "0";

            Item5.Source = null;

            Panel_5.Background = Brushes.White;
            Panel_5.Opacity = 0;

            rb_5_1.IsChecked = false;
            rb_5_2.IsChecked = false;
            rb_5_3.IsChecked = false;
            rb_5_4.IsChecked = false;
            rb_5_5.IsChecked = false;
            rb_5_6.IsChecked = false;
            rb_5_7.IsChecked = false;
            rb_5_8.IsChecked = false;
            rb_5_9.IsChecked = false;
            rb_5_10.IsChecked = false;
            rb_5_11.IsChecked = false;
            rb_5_12.IsChecked = false;
            rb_5_13.IsChecked = false;
            rb_5_14.IsChecked = false;
            rb_5_15.IsChecked = false;

            Item_sum_4.Content = null;
            TextBox_4.Text = "0";

            Item4.Source = null;

            Panel_4.Background = Brushes.White;
            Panel_4.Opacity = 0;

            rb_4_1.IsChecked = false;
            rb_4_2.IsChecked = false;
            rb_4_3.IsChecked = false;
            rb_4_4.IsChecked = false;
            rb_4_5.IsChecked = false;
            rb_4_6.IsChecked = false;
            rb_4_7.IsChecked = false;
            rb_4_8.IsChecked = false;
            rb_4_9.IsChecked = false;
            rb_4_10.IsChecked = false;
            rb_4_11.IsChecked = false;
            rb_4_12.IsChecked = false;
            rb_4_13.IsChecked = false;
            rb_4_14.IsChecked = false;
            rb_4_15.IsChecked = false;

            Item_sum_3.Content = null;
            TextBox_3.Text = "0";

            Item3.Source = null;

            Panel_3.Background = Brushes.White;
            Panel_3.Opacity = 0;

            rb_3_1.IsChecked = false;
            rb_3_2.IsChecked = false;
            rb_3_3.IsChecked = false;
            rb_3_4.IsChecked = false;
            rb_3_5.IsChecked = false;
            rb_3_6.IsChecked = false;
            rb_3_7.IsChecked = false;
            rb_3_8.IsChecked = false;
            rb_3_9.IsChecked = false;
            rb_3_10.IsChecked = false;
            rb_3_11.IsChecked = false;
            rb_3_12.IsChecked = false;
            rb_3_13.IsChecked = false;
            rb_3_14.IsChecked = false;
            rb_3_15.IsChecked = false;

            Item_sum_2.Content = null;
            TextBox_2.Text = "0";

            Item2.Source = null;

            Panel_2.Background = Brushes.White;
            Panel_2.Opacity = 0;

            rb_2_1.IsChecked = false;
            rb_2_2.IsChecked = false;
            rb_2_3.IsChecked = false;
            rb_2_4.IsChecked = false;
            rb_2_5.IsChecked = false;
            rb_2_6.IsChecked = false;
            rb_2_7.IsChecked = false;
            rb_2_8.IsChecked = false;
            rb_2_9.IsChecked = false;
            rb_2_10.IsChecked = false;
            rb_2_11.IsChecked = false;
            rb_2_12.IsChecked = false;
            rb_2_13.IsChecked = false;
            rb_2_14.IsChecked = false;
            rb_2_15.IsChecked = false;

            Item_sum_1.Content = null;
            TextBox_1.Text = "0";

            Item1.Source = null;

            Panel_1.Background = Brushes.White;
            Panel_1.Opacity = 0;

            rb_1_1.IsChecked = false;
            rb_1_2.IsChecked = false;
            rb_1_3.IsChecked = false;
            rb_1_4.IsChecked = false;
            rb_1_5.IsChecked = false;
            rb_1_6.IsChecked = false;
            rb_1_7.IsChecked = false;
            rb_1_8.IsChecked = false;
            rb_1_9.IsChecked = false;
            rb_1_10.IsChecked = false;
            rb_1_11.IsChecked = false;
            rb_1_12.IsChecked = false;
            rb_1_13.IsChecked = false;
            rb_1_14.IsChecked = false;
            rb_1_15.IsChecked = false;

            _panel_1 = 0;
            _panel_2 = 0;
            _panel_3 = 0;
            _panel_4 = 0;
            _panel_5 = 0;
        }
        private void Change_background_item(int Index_item, int index_color)
        {
            switch (Index_item)
            {
                case 0:
                    {
                        if (index_color == 0)
                        {
                            Panel_1.Background = Brushes.White;
                            Panel_1.Opacity = 0;
                            _panel_1 = 0;
                        }
                        else if (index_color == 1)
                        {
                            Panel_1.Background = Brushes.Red;
                            Panel_1.Opacity = 0.25;
                            _panel_1 = 1;
                        }

                        else if (index_color == 2)
                        {
                            Panel_1.Background = Brushes.Blue;
                            Panel_1.Opacity = 0.25;
                            _panel_1 = 2;
                        }
                    }
                    break;
                case 1:
                    {
                        if (index_color == 0)
                        {
                            Panel_2.Background = Brushes.White;
                            Panel_2.Opacity = 0;
                            _panel_2 = 0;
                        }
                        else if (index_color == 1)
                        {
                            Panel_2.Background = Brushes.Red;
                            Panel_2.Opacity = 0.25;
                            _panel_2 = 1;
                        }

                        else if (index_color == 2)
                        {
                            Panel_2.Background = Brushes.Blue;
                            Panel_2.Opacity = 0.25;
                            _panel_2 = 2;
                        }
                    }
                    break;
                case 2:
                    {
                        if (index_color == 0)
                        {
                            Panel_3.Background = Brushes.White;
                            Panel_3.Opacity = 0;
                            _panel_3 = 0;
                        }
                        else if (index_color == 1)
                        {
                            Panel_3.Background = Brushes.Red;
                            Panel_3.Opacity = 0.25;
                            _panel_3 = 1;
                        }

                        else if (index_color == 2)
                        {
                            Panel_3.Background = Brushes.Blue;
                            Panel_3.Opacity = 0.25;
                            _panel_3 = 2;
                        }
                    }
                    break;
                case 3:
                    {
                        if (index_color == 0)
                        {
                            Panel_4.Background = Brushes.White;
                            Panel_4.Opacity = 0;
                            _panel_4 = 0;
                        }
                        else if (index_color == 1)
                        {
                            Panel_4.Background = Brushes.Red;
                            Panel_4.Opacity = 0.25;
                            _panel_4 = 1;
                        }

                        else if (index_color == 2)
                        {
                            Panel_4.Background = Brushes.Blue;
                            Panel_4.Opacity = 0.25;
                            _panel_4 = 2;
                        }
                    }
                    break;
                case 4:
                    {
                        if (index_color == 0)
                        {
                            Panel_5.Background = Brushes.White;
                            Panel_5.Opacity = 0;
                            _panel_5 = 0;
                        }
                        else if (index_color == 1)
                        {
                            Panel_5.Background = Brushes.Red;
                            Panel_5.Opacity = 0.25;
                            _panel_5 = 1;
                        }

                        else if (index_color == 2)
                        {
                            Panel_5.Background = Brushes.Blue;
                            Panel_5.Opacity = 0.25;
                            _panel_5 = 2;
                        }
                    }
                    break;
            }
        }
        //===========================================================
        private void Button_White_1(object sender, RoutedEventArgs e)
        {
            Change_background_item(0, 0);
        }
        private void Button_White_2(object sender, RoutedEventArgs e)
        {
            Change_background_item(1, 0);
        }
        private void Button_White_3(object sender, RoutedEventArgs e)
        {
            Change_background_item(2, 0);
        }
        private void Button_White_4(object sender, RoutedEventArgs e)
        {
            Change_background_item(3, 0);
        }
        private void Button_White_5(object sender, RoutedEventArgs e)
        {
            Change_background_item(4, 0);
        }
        //===========================================================
        private void Button_red_1(object sender, RoutedEventArgs e)
        {
            Change_background_item(0, 1);
        }
        private void Button_red_2(object sender, RoutedEventArgs e)
        {
            Change_background_item(1, 1);
        }
        private void Button_red_3(object sender, RoutedEventArgs e)
        {
            Change_background_item(2, 1);
        }
        private void Button_red_4(object sender, RoutedEventArgs e)
        {
            Change_background_item(3, 1);
        }
        private void Button_red_5(object sender, RoutedEventArgs e)
        {
            Change_background_item(4, 1);
        }
        //===========================================================
        private void Button_blue_1(object sender, RoutedEventArgs e)
        {
            Change_background_item(0, 2);
        }
        private void Button_blue_2(object sender, RoutedEventArgs e)
        {
            Change_background_item(1, 2);
        }
        private void Button_blue_3(object sender, RoutedEventArgs e)
        {
            Change_background_item(2, 2);
        }
        private void Button_blue_4(object sender, RoutedEventArgs e)
        {
            Change_background_item(3, 2);
        }
        private void Button_blue_5(object sender, RoutedEventArgs e)
        {
            Change_background_item(4, 2);
        }

        private void ButtonPlus_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(TextBox_1.Text) < 9)
                    TextBox_1.Text = (Convert.ToInt32(TextBox_1.Text) + 1).ToString();
            }
            catch
            {

            }
            
        }

        private void ButtonPlus_2(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(TextBox_2.Text) < 9)
                    TextBox_2.Text = (Convert.ToInt32(TextBox_2.Text) + 1).ToString();
            }
            catch
            {

            }
            
        }

        private void ButtonPlus_3(object sender, RoutedEventArgs e)
        {
            try
            {

                if (Convert.ToInt32(TextBox_3.Text) < 9)
                    TextBox_3.Text = (Convert.ToInt32(TextBox_3.Text) + 1).ToString();
            }
            catch
            {

            }
        }

        private void ButtonPlus_4(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(TextBox_4.Text) < 9)
                    TextBox_4.Text = (Convert.ToInt32(TextBox_4.Text) + 1).ToString();
            }
            catch
            {

            }
            
        }

        private void ButtonPlus_5(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(TextBox_5.Text) < 9)
                    TextBox_5.Text = (Convert.ToInt32(TextBox_5.Text) + 1).ToString();
            }
            catch
            {

            }
        }

        private void ButtonMinus_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(TextBox_1.Text) > 0)
                    TextBox_1.Text = (Convert.ToInt32(TextBox_1.Text) - 1).ToString();
            }
            catch
            {

            }
            
        }

        private void ButtonMinus_2(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(TextBox_2.Text) > 0)
                    TextBox_2.Text = (Convert.ToInt32(TextBox_2.Text) - 1).ToString();
            }
            catch
            {

            }
            
        }

        private void ButtonMinus_3(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(TextBox_3.Text) > 0)
                    TextBox_3.Text = (Convert.ToInt32(TextBox_3.Text) - 1).ToString();
            }
            catch
            {

            }
            
        }

        private void ButtonMinus_4(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(TextBox_4.Text) > 0)
                    TextBox_4.Text = (Convert.ToInt32(TextBox_4.Text) - 1).ToString();
            }
            catch
            {

            }
            
        }

        private void ButtonMinus_5(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(TextBox_5.Text) > 0)
                    TextBox_5.Text = (Convert.ToInt32(TextBox_5.Text) - 1).ToString();
            }
            catch
            {

            }
            
        }
    }
}
