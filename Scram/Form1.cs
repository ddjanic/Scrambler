using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Scram
{
    public partial class formMain : Form
    {
        Scram.ClassScrabler NewScr = new Scram.ClassScrabler();

        public formMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Выход из программы
            if (Application.MessageLoop)
            {
                // исп.если приложение графическое
                Application.Exit();
            }
            else
            {
                // исп. если приложение консольное
                Environment.Exit(1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tBBinary.Text = NewScr.BinaryString(tBEnter.Text);
            // опускаемся вниз 
            // и ставим фокус на каретке в конце
            tBBinary.SelectionStart = tBBinary.Text.Length;
            tBBinary.ScrollToCaret();
            tBBinary.Refresh();

            tBScrambled.Text = NewScr.ScrambledString(tBEnter.Text);
            // опускаемся вниз 
            // и ставим фокус на каретке в конце
            tBScrambled.SelectionStart = tBScrambled.Text.Length;
            tBScrambled.ScrollToCaret();
            tBScrambled.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tBEnter.Text = NewScr.MainString(tBBinary.Text, 0);
            // опускаемся вниз 
            // и ставим фокус на каретке в конце
            tBEnter.SelectionStart = tBEnter.Text.Length;
            tBEnter.ScrollToCaret();
            tBEnter.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tBDeScrambled.Text = NewScr.MainString(tBScrambled.Text, 1);
            // опускаемся вниз 
            // и ставим фокус на каретке в конце
            tBDeScrambled.SelectionStart = tBDeScrambled.Text.Length;
            tBDeScrambled.ScrollToCaret();
            tBDeScrambled.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            opn.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (opn.ShowDialog(this) == DialogResult.OK)
            {
                tBEnter.Text = File.ReadAllText(opn.FileName, Encoding.Default);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            opn.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (opn.ShowDialog(this) == DialogResult.OK)
            {
                tBScrambled.Text = File.ReadAllText(opn.FileName, Encoding.Default);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sv.FileName, tBScrambled.Text, Encoding.Default);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sv.FileName, tBDeScrambled.Text, Encoding.Default);
            }
        }

        // шифрование AES, оно же Рэндал, длинна кприкто ключа 8 букв
        private void EncryptFile(string inputFile, string outputFile)
        {
            try
            {
                string password = @textBox1.Text; // храним ключ здесь
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                string cryptFile = outputFile;
                FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                    RMCrypto.CreateEncryptor(key, key),
                    CryptoStreamMode.Write);

                FileStream fsIn = new FileStream(inputFile, FileMode.Open);

                int data;
                while ((data = fsIn.ReadByte()) != -1)
                    cs.WriteByte((byte)data);


                fsIn.Close();
                cs.Close();
                fsCrypt.Close();
            }
            catch
            {
                MessageBox.Show("Encryption failed!", "Error");
            }
        }


        // дешифрование AES, оно же Рэндал, длинна кприкто ключа 8 букв
        private void DecryptFile(string inputFile, string outputFile)
        {

            {
                string password = @textBox2.Text; // храним ключ здесь

                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                    RMCrypto.CreateDecryptor(key, key),
                    CryptoStreamMode.Read);

                FileStream fsOut = new FileStream(outputFile, FileMode.Create);

                int data;
                while ((data = cs.ReadByte()) != -1)
                    fsOut.WriteByte((byte)data);

                fsOut.Close();
                cs.Close();
                fsCrypt.Close();

            }
        }

        // генерация случайных чисел на основе RTC таймера реального времени ПРИ скремблирвоании и де-скремблирвоании
        // для получения свойств случайной последовательности при работе со скремблированием и обратным дескремблирвоанием
        public static class RandomProvider
        {
            private static int seed = Environment.TickCount;

            private static ThreadLocal<Random> randomWrapper = new ThreadLocal<Random>(() =>
                new Random(Interlocked.Increment(ref seed))
            );

            public static Random GetThreadRandom()
            {
                return randomWrapper.Value;
            }
        }

        // общая расшаренная переменная хранения полного пути файла - открытый файл для шифрации
        string open_path_enc;

        // шифрация
        // открываем файл для шифрации с которого будем получать поток
        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            opn.Filter = "Запись оцифрованного аудиопотока (*.wav)|*.wav|Адаптивное кодирование с переменной скоростью (*.amr)|*.amr|Все файлы (*.*)|*.*";
            if (opn.ShowDialog(this) == DialogResult.OK)
            {
                textBox3.Text = opn.FileName;
                open_path_enc = opn.FileName;
            }
        }

        // общая расшаренная переменная хранения полного пути файла - сохраняемый файл для шифрации
        string save_path_enc;
        // шифрация
        // сохраняем файл для шифрации на который будем писать поток
        private void button10_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Запись оцифрованного аудиопотока (*.wav)|*.wav|Адаптивное кодирование с переменной скоростью (*.amr)|*.amr|Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = sv.FileName;
                save_path_enc = sv.FileName;
                EncryptFile(open_path_enc, save_path_enc);
            }
        }

        // общая расшаренная переменная хранения полного пути файла - открытый файл для дешифрации
        string open_path_dec;
        // дешифрация
        // открываем файл для дешифрации с которого будем получать поток
        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            opn.Filter = "Запись оцифрованного аудиопотока (*.wav)|*.wav|Адаптивное кодирование с переменной скоростью (*.amr)|*.amr|Все файлы (*.*)|*.*";
            if (opn.ShowDialog(this) == DialogResult.OK)
            {
                textBox5.Text = opn.FileName;
                open_path_dec = opn.FileName;
            }
        }

        // общая расшаренная переменная хранения полного пути файла - сохраняемый файл для дешифрации
        string save_path_dec;
        // дешифрация
        // сохраняем файл для дешифрации на который будем писать поток
        private void button11_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Запись оцифрованного аудиопотока (*.wav)|*.wav|Адаптивное кодирование с переменной скоростью (*.amr)|*.amr|Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                textBox6.Text = sv.FileName;
                save_path_dec = sv.FileName;
                DecryptFile(open_path_dec, save_path_dec);
            }
        }
    }
}
