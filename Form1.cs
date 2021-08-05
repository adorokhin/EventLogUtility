using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace EventLogUtility
{
    public partial class Form_EventLogUtility : Form
    {

        private string sEventLog = string.Empty;
        private string sEventSource = string.Empty;
        
        private void GetStrings()
        {
            sEventLog = this.textBox_EventLog_Name.Text.Trim();
            sEventSource = this.textBox_EventSource_Name.Text.Trim();
            if (0 == string.Compare(sEventLog, sEventSource, true))
                throw new Exception ("<EE> EventLog Source == EventLog Name");
        }


        public Form_EventLogUtility()
        {
            InitializeComponent();
        }

        private void button_CreateEventLog_Click(object sender, EventArgs e)
        {
            try
            {
                GetStrings();
                if((sEventLog == string.Empty) || (sEventSource == string.Empty))
                    return;

                if (!EventLog.SourceExists(sEventSource))
				    EventLog.CreateEventSource(sEventSource, sEventLog);

                EventLog log = new EventLog();
                log.Source = sEventSource;
                log.WriteEntry("test message", EventLogEntryType.Error);
            }
            catch (Exception ex)
            {
                this.textBox_Output.Text = ex.ToString();
            }
        }

        private void Delete_EventLog_Click(object sender, EventArgs e)
        {
            try
            {
                GetStrings();
                if ((sEventLog == string.Empty) || (sEventSource == string.Empty))
                    return;

                if (EventLog.SourceExists(sEventSource))
                {
                    // Find the log associated with this source.    
                    //string logName = EventLog.LogNameFromSourceName(sEventSource, ".");
                    //if (logName != "MyLog")
                    //    return;
                    // Delete the source and the log.
                    EventLog.DeleteEventSource(sEventSource);
                    EventLog.Delete(sEventLog);
                }
                else 
                {
                    if (true == EventLog.Exists(sEventLog))
                    {
                        if (DialogResult.Yes == MessageBox.Show(("Source: " + sEventSource + " Does not exist. Proceed deleting EventLog [" + sEventLog + "]?"), "Proceed?", MessageBoxButtons.YesNo))
                            EventLog.Delete(sEventLog);
                    }
                    else
                    {
                        this.textBox_Output.Text += ("EventLog [" + sEventLog + "] Does not exist.");
                        this.textBox_Output.Text += System.Environment.NewLine;
                    }
                }
            }
            catch (Exception ex)
            {
                this.textBox_Output.Text += ex.ToString();
                this.textBox_Output.Text += System.Environment.NewLine;
            }
        }

        private void button_DeleteEventLogOnly_Click(object sender, EventArgs e)
        {

            try
            {
                sEventLog = this.textBox_EventLog_Name.Text.Trim();
                //sEventSource = this.textBox_EventSource_Name.Text.Trim();

                if ((sEventLog == string.Empty))
                    return;

                EventLog.Delete(sEventLog);
            }
            catch (Exception ex)
            {
                this.textBox_Output.Text += ex.ToString();
                this.textBox_Output.Text += System.Environment.NewLine;
            }

        }

        private void button_DeleteEventSourceOnly_Click(object sender, EventArgs e)
        {
            try
            {
                sEventSource = this.textBox_EventSource_Name.Text.Trim();
                if ((sEventSource == string.Empty))
                    return;
                EventLog.DeleteEventSource(sEventSource);
            }
            catch (Exception ex)
            {
                this.textBox_Output.Text += ex.ToString();
                this.textBox_Output.Text += System.Environment.NewLine;
            }

        }
    }
}
