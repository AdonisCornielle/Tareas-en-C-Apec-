using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//BWSamp 00: For Sleep usage
using System.Threading;

namespace BackGroundWorkSample
{
    public partial class frmBackGround : Form
    {

        //BWSamp 04: Cancel Action
        private bool cancel_work = false;
        long count_a, count_e, count_i, count_o, count_u;

        public frmBackGround()
        {
            InitializeComponent();
        }

        //BWSamp 01: Functions that count and Updates vowel counters.
        private void CheckVowelA(char c)
        {
            long Vowel_count;
            if (c == 'A' || c == 'a')
            {
                if (chkUseBackground.CheckState != CheckState.Checked)
                {
                    long.TryParse(txtA.Text, out  Vowel_count);
                    Vowel_count++;
                    txtA.Text = Vowel_count.ToString();
                }
                else
                    count_a = count_a + 1;
            }
        }

        private void CheckVowelE(char c)
        {
            long Vowel_count;
            if (c == 'E' || c == 'e')
            {
                 if (chkUseBackground.CheckState != CheckState.Checked)
                {
                    long.TryParse(txtE.Text, out Vowel_count);
                    Vowel_count++;
                    txtE.Text = Vowel_count.ToString();
                 }
                else
                    count_e = count_e + 1;
            }
        }

        private void CheckVowelI(char c)
        {
            long Vowel_count;
            if (c == 'I' || c == 'i')
            {
                if (chkUseBackground.CheckState != CheckState.Checked)
                {
                    long.TryParse(txtI.Text, out Vowel_count);
                    Vowel_count++;
                    txtI.Text = Vowel_count.ToString();
                }
                else
                    count_i = count_i+ 1;
            }
        }

        private void CheckVowelO(char c)
        {
            long Vowel_count;
            if (c == 'O' || c == 'o')
            {
                if (chkUseBackground.CheckState != CheckState.Checked)
                {
                    long.TryParse(txtO.Text, out Vowel_count);
                    Vowel_count++;
                    txtO.Text = Vowel_count.ToString();
                }
                else
                    count_o = count_o + 1;
            }
        }

        private void CheckVowelU(char c)
        {
            long Vowel_count;
            if (c == 'U' || c == 'u')
            {
                if (chkUseBackground.CheckState != CheckState.Checked)
                {
                    long.TryParse(txtU.Text, out Vowel_count);
                    Vowel_count++;
                    txtU.Text = Vowel_count.ToString();
                }
                else
                    count_u = count_u + 1;
            }
        }

        //BWSamp 02: Simulate Long Running Task
        private void btnStart_Click(object sender, EventArgs e)
        {
            //2.1: Set Cancel Work as false when the job starts
            cancel_work = false;
            count_a = 0;
            count_e = 0; 
            count_i = 0; 
            count_o = 0;
            count_u = 0;

            //2.2: To use back ground worker, call RunWorkerAsync
            if (chkUseBackground.CheckState != CheckState.Checked)
            {
                DoWithoutBKGrd();
            }
            else
            {
                BckThread.RunWorkerAsync();
            }
        }

        //BWSamp 03: Long Running Task without Background Worker
        public void DoWithoutBKGrd()
        {
            //3.1: Get text length
            string strcontent = txtContent.Text;
            long len = strcontent.Length;
            int Prog_Inc = (int)(len / 100);

            //3.2: Copy the string content to char array
            char[] chars = strcontent.ToCharArray();

            //3.3: Iterate through each char and increment the Vowels count
            for (int itr = 0; itr < len; itr++)
            {
                if (cancel_work == false)
                {
                    char c = chars[itr];
                    lblEvtComplete.Text = "Count In-Progress";

                    //3.3.1: Count for A
                    CheckVowelA(c);

                    //3.3.2: Count for E
                    CheckVowelE(c);

                    //3.3.3: Count for I
                    CheckVowelI(c);

                    //3.3.4: Count for O
                    CheckVowelO(c);

                    //3.3.5: Count for U
                    CheckVowelU(c);

                    //3.4: Update Progress bar
                    int prog_value = (itr / Prog_Inc);
                    if (prog_value > 100)
                        prog_value = 100;
                    ProgressB.Value = prog_value;
                    Thread.Sleep(10);
                    if (chkUseDoevents.CheckState == CheckState.Checked )
                        Application.DoEvents();
                }
                else
                {
                    txtA.Text = "0";
                    txtE.Text = "0";
                    txtI.Text = "0";
                    txtO.Text = "0";
                    txtU.Text = "0";
                    lblEvtComplete.Text = "Counts Cancelled";
                    return;
                }
                lblEvtComplete.Text = "Vowels counted";
            }
        }

        //BWSamp 05: Set the Cancel Flag to cancel the current active job
        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancel_work = true;
            if (chkUseBackground.CheckState == CheckState.Checked)
                BckThread.CancelAsync();
        }

        //BWSamp 06: When using BkGrd component, uncheck and disable doevents
        private void chkUseBackground_Click(object sender, EventArgs e)
        {
            if (chkUseBackground.CheckState == CheckState.Checked)
            {
                chkUseDoevents.Enabled = false;
                chkUseDoevents.CheckState = CheckState.Unchecked;
            }
            else
                chkUseDoevents.Enabled = true;
        }

        //BWSamp 07: Do the Job with Back-Ground Thread
        private void BckThread_DoWork(object sender, DoWorkEventArgs e)
        {
            //7.1: Get text length
            string strcontent = txtContent.Text;
            long len = strcontent.Length;
            int Prog_Inc = (int)(len / 100);

            //7.2: Copy the string content to char array
            char[] chars = strcontent.ToCharArray();

            //7.3: Iterate through each char and increment the Vowels count
            for (int itr = 0; itr < len; itr++)
            {
                char c = chars[itr];

                //7.3.2: Check the Cancel State
                if (BckThread.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }

                //7.3.2: Count for A
                CheckVowelA(c);

                //7.3.3: Count for E
                CheckVowelE(c);

                //7.3.4: Count for I
                CheckVowelI(c);

                //7.3.5: Count for O
                CheckVowelO(c);

                //7.3.6: Count for U
                CheckVowelU(c);

                //7.4: Update Progress bar
                int prog_value = (itr / Prog_Inc);
                if (prog_value > 100)
                    prog_value = 100;
                BckThread.ReportProgress(prog_value);
                Thread.Sleep(10);
            }
        }

        //BWSamp 08: Handle Progress Changed of Bck Worker Thread
        private void BckThread_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressB.Value = e.ProgressPercentage;
            txtA.Text = count_a.ToString();
            txtE.Text = count_e.ToString();
            txtI.Text = count_i.ToString();
            txtO.Text = count_o.ToString();
            txtU.Text = count_u.ToString();
        }

        //BWSamp09: Handle Bck Task completed
        private void BckThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
                lblEvtComplete.Text = "Cancelled";
            else
                lblEvtComplete.Text = "Completed";
        }
    }
}