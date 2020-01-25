using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WMPLib;

namespace Timer
{
    public partial class Form1 : Form
    {
        int f; //флаг          
        int time; //переменная для красивого отображения
        int time2; //переменная для красивого добавленного отображения
        string t1; //переменная для записи времени             

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e) //РАБОТА ТАЙМЕРА 1. ОТСЧЕТ СЕКУНД
        {
            --time; //уменьшаем секунды            
        }

        private void b_add_Click(object sender, EventArgs e) //ДОБАВЛЕНИЕ ВРЕМЕНИ
        {
            Dann();
            
            time2 = time2 + Convert.ToInt16(t_h.Text) * 3600 + Convert.ToInt16(t_m.Text) * 60;            

            var timespan = TimeSpan.FromSeconds(time2);
            t_add.Text = timespan.ToString(@"hh\:mm\:ss");
        }

        public void Form1_Load(object sender, EventArgs e) //ЗАГРУЗКА ФОРМЫ
        {
            Sbros();

            try
            {
                Files(Properties.Settings.Default.save_out, "00:00:00");
            }
            catch
            {

            }
        }        

        public void b_reset_Click(object sender, EventArgs e) //СБРОС
        {
            Yell();

            t_h.Text = "0"; //записываем значения в часы
            t_m.Text = "1"; //записываем значения в минуты            

            Sbros();

            this.Text = "Timer"; //возвращаем название формы
            
            t_add.Text = "00:00:00"; //обнуление поля с добавленным временем
        }

        public void b_start_Click(object sender, EventArgs e) //СТАРТ -- ПАУЗА
        {
            switch (f)
            {
                case 1: //пауза
                    {
                        Yell();
                        f = 2; //перевод флага на режим старта после паузы
                    }
                    break;
                case 2: //старт после паузы
                    {
                        Green();
                    }
                    break;
                default: //старт первоначальный
                    {
                        Sbros();

                        Dann();

                        Green();
                    }
                    break;
            }
        }

        private void путьКФайлуМузыкиToolStripMenuItem_Click(object sender, EventArgs e) //ВЫБОР ЗВУКОВОГО ФАЙЛА
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.save_sound = openFileDialog1.FileName; 
                Properties.Settings.Default.Save();
            }
        }

        private void путьКФайлуВыводаToolStripMenuItem_Click(object sender, EventArgs e) //ВЫБОР ФАЙЛА ВЫВОДА ВРЕМЕНИ
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.save_out = folderBrowserDialog1.SelectedPath + @"\out.txt";
                Properties.Settings.Default.Save();

                Files(Properties.Settings.Default.save_out, "00:00:00");
            }
        }

        private void инфоToolStripMenuItem_Click(object sender, EventArgs e) //ИНФО
        {
            MessageBox.Show("Автор Punk'sPlay\r\nВерсия 2.5\r\nЕсли что-то хуево работает - не бейте ногами,\r\nа лучше пишите в telegram @punksplay\r\nМир вам!"); //и так все ясно же, ну
        }

        public void Green() //работа с кнопкой
        {
            b_start.BackColor = Color.FromArgb(237, 204, 16); //меняем цвет кнопки на желтый
            b_start.Text = "Pause"; //название кнопки               

            timer1.Start(); //старт таймера 1
            timer2.Start(); //старт таймера 2
            f = 1; //перевод флага на режим паузы
        }

        public void Yell() //работа с кнопкой
        {
            b_start.BackColor = Color.FromArgb(12, 200, 45); //меняем цвет кнопки на зеленый
            b_start.Text = "Start"; //название кнопки

            timer1.Stop(); //остановка таймера 1
            timer2.Stop(); //остановка таймера 2
        }

        public void Dann() //работа с данными
        {
            time = time + Convert.ToInt16(t_h.Text) * 3600 + Convert.ToInt16(t_m.Text) * 60; //получаем секунды
        }

        public void Files(string writePath, string text) //процедура записи в файл
        {
            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                 {
                    sw.WriteLine(text);
                 }
        }

        public void Sbros()
        {
            f = 0; //перевод флага на режим первоначального старта
            time = 0; time2 = 0; //обнуление переменных
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Путь к папке вывода - указать папку, в которую будет помещен файл с выводом времени\r\n" +
                            "Путь к файлу музыки - указать файл с музыкой, который будет воспроизведен по окончанию отсчета\r\n" +
                            "Задать громкость - задать уровень громкости для звукового оповещения по окончанию отсчета\r\n" +
                            "Add - добавляет время, которое указано в полях времени\r\n" +
                            "Reset - сброс таймера\r\n" +
                            "Total added time - общее количество добавленного времени\r\n" +
                            "After time's up - то, что будет записано в файл по окончанию отсчета\r\n");
        }

        private void задатьГромкостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.save_vol = Microsoft.VisualBasic.Interaction.InputBox("Введите значение громкости для звукового оповещения");
        }

        private void timer2_Tick(object sender, EventArgs e) //РАБОТА ТАЙМЕРА 2. БЫСТРОЕ ОБНОВЛЕНИЕ ВСЕГО
        {
            var timespan = TimeSpan.FromSeconds(time);
            t1 = timespan.ToString(@"hh\:mm\:ss");

            this.Text = t1; //вывод таймера в название формы

            Files(Properties.Settings.Default.save_out, t1);

            if (time == 0) //окончание таймера
            {
                var wmp = new WMPLib.WindowsMediaPlayer(); //для музыки
                wmp.URL = Properties.Settings.Default.save_sound;
                wmp.settings.volume = Convert.ToInt16(Properties.Settings.Default.save_vol);
                wmp.controls.play();

                timer1.Stop();
                timer2.Stop();

                Files(Properties.Settings.Default.save_out, t_end.Text);

                Yell();

                Sbros();
            }
        }
    }
}
