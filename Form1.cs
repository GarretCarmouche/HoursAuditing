using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using System.IO;

namespace HoursAuditing
{
    public partial class Hours : Form
    {
        int seconds = 0;
        Boolean counting = false;
        Boolean resetconfirm = false;
        string currenttask;
        List<string> tasks = new List<string>();
        Dictionary<string,int> tasktimes = new Dictionary<string, int>();
        String filelocation = "Data.txt";
       
        

        public Hours()
        {
            InitializeComponent();
            if(!File.Exists(@filelocation))
            {
                String[] dat = { };
                File.WriteAllLines(@filelocation,dat);
            }
            String[] data = File.ReadAllLines(@filelocation);
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("Data " + i + " " + data[i]);
            }
            if(data.Length>= 1)
            seconds = Int32.Parse(data[0]);
            Console.WriteLine(data.Length);
            for (int i = 1; i < data.Length -1; i+= 2)
            {
                Console.WriteLine(i);
                Console.WriteLine("Data i + 1 "+data[i + 1]);
                tasks.Add(data[i]);
                tasktimes.Add(data[i], Int32.Parse(data[i + 1]));
            }
            Thread timethread = new Thread(new ThreadStart(time));
            timethread.Start();
        }

        public void savedata()
        {
            String[] data = new String[tasks.Count*2+1];
            data[0] = "" + seconds;
            for(int i = 0; i/2 < tasks.Count; i+=2)
            {
                data[i + 1] = tasks[i/2];
                data[i + 2] = "" + tasktimes[tasks[i/2]];
            }
            for(int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("Data "+i+ ": " + data[i]);
            }
            File.Delete(@filelocation);
            File.WriteAllLines(@filelocation,data);
            Console.WriteLine("Data saved");
        }

        public void time()
        {
            Thread.Sleep(100);
            while(true)
            {
                updatetasks();
                string newText = "Total time: " + convertTime(seconds);
                TotalLabel.Invoke((MethodInvoker)delegate {
                    // Running on the UI thread
                    TotalLabel.Text = newText;
                });
                if (counting)
                {
                    seconds++;
                    if(currenttask.Length > 0)
                    tasktimes[currenttask] = tasktimes[currenttask] + 1;
                }
                Thread.Sleep(1000);
            }
        }

        public void updatetasks()
        {
            string text = "";
            for (int i = 0; i < tasks.Count; i++)
            {
                text = text + "\n" + tasks[i] + ": " + convertTime(tasktimes[tasks[i]]);
            }
            TasksLabel.Invoke((MethodInvoker)delegate
            {
                TasksLabel.Text = text;
            });
        }

        public void reset()
        {
            seconds = 0;
            TasksLabel.Text = "";
            tasks = new List<string>();
            tasktimes = new Dictionary<string, int>();
            resetconfirm = false;
        }

        public void resettime()
        {
            Thread.Sleep(5000);
            resetconfirm = false;
            ResetButton.Invoke((MethodInvoker)delegate
            {
                ResetButton.Text = "Reset";
            });
        }

        public String convertTime(int s)
        {
            int hours = 0, minutes = 0, seconds = 0;
            String time = "",hoursstring,minutesstring,secondsstring;
            double sec = s;
            hours = (int) Math.Floor(sec / 60 / 60);
            sec -= (hours * 60 * 60);
            minutes = (int) Math.Floor(sec / 60);
            sec -= (minutes * 60);
            seconds = (int)sec;
            if (hours < 10)
                hoursstring = "0" + hours;
            else
                hoursstring = "" + hours;

            if (minutes < 10)
                minutesstring = "0" + minutes;
            else
                minutesstring = "" + minutes;

            if (seconds < 10)
                secondsstring = "0" + seconds;
            else
                secondsstring = "" + seconds;

            time = hoursstring + ":" + minutesstring + ":" + secondsstring;
            return time;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            String buttontext;
            if (!counting)
            {
                currenttask = CurrentTaskBox.Text.ToString();
                if (currenttask.Length > 0)
                {
                    Boolean previoustask = false;
                    for (int i = 0; i < tasks.Count; i++)
                    {
                        if (tasks[i] == currenttask)
                        {
                            previoustask = true;
                            break;
                        }
                    }
                    if (!previoustask)
                    {
                        tasks.Add(currenttask);
                        tasktimes.Add(currenttask, 0);
                    }
                }
                buttontext = "Stop time";
            }
                
            else
            {
                buttontext = "Start time";
                
            }
                
            StartButton.Invoke((MethodInvoker)delegate
            {
                StartButton.Text = buttontext;
            });
            counting = !counting;
        }

        private void TotalLabel_Click(object sender, EventArgs e)
        {

        }

        private void Hours_Load(object sender, EventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (resetconfirm)
            {
                reset();
                ResetButton.Text = "Reset";
            }
            else
            {
                resetconfirm = true;
                ResetButton.Text = "Confirm";
                Thread resetconfirmthread = new Thread(new ThreadStart(resettime));
                resetconfirmthread.Start();
            }
                
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            savedata();
            counting = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            savedata();
        }
    }
}
