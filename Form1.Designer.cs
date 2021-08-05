namespace EventLogUtility
{
    partial class Form_EventLogUtility
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_CreateEventLog = new System.Windows.Forms.Button();
            this.Delete_EventLog = new System.Windows.Forms.Button();
            this.Label_EventLog = new System.Windows.Forms.Label();
            this.textBox_EventLog_Name = new System.Windows.Forms.TextBox();
            this.textBox_EventSource_Name = new System.Windows.Forms.TextBox();
            this.label_EventSource = new System.Windows.Forms.Label();
            this.textBox_Output = new System.Windows.Forms.TextBox();
            this.button_DeleteEventLogOnly = new System.Windows.Forms.Button();
            this.button_DeleteEventSourceOnly = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_CreateEventLog
            // 
            this.button_CreateEventLog.Location = new System.Drawing.Point(84, 57);
            this.button_CreateEventLog.Name = "button_CreateEventLog";
            this.button_CreateEventLog.Size = new System.Drawing.Size(141, 23);
            this.button_CreateEventLog.TabIndex = 0;
            this.button_CreateEventLog.Text = "Create EventLog";
            this.button_CreateEventLog.UseVisualStyleBackColor = true;
            this.button_CreateEventLog.Click += new System.EventHandler(this.button_CreateEventLog_Click);
            // 
            // Delete_EventLog
            // 
            this.Delete_EventLog.Location = new System.Drawing.Point(278, 57);
            this.Delete_EventLog.Name = "Delete_EventLog";
            this.Delete_EventLog.Size = new System.Drawing.Size(141, 23);
            this.Delete_EventLog.TabIndex = 1;
            this.Delete_EventLog.Text = "Delete EventLog";
            this.Delete_EventLog.UseVisualStyleBackColor = true;
            this.Delete_EventLog.Click += new System.EventHandler(this.Delete_EventLog_Click);
            // 
            // Label_EventLog
            // 
            this.Label_EventLog.AutoSize = true;
            this.Label_EventLog.Location = new System.Drawing.Point(17, 9);
            this.Label_EventLog.Name = "Label_EventLog";
            this.Label_EventLog.Size = new System.Drawing.Size(56, 13);
            this.Label_EventLog.TabIndex = 2;
            this.Label_EventLog.Text = "Log Name";
            // 
            // textBox_EventLog_Name
            // 
            this.textBox_EventLog_Name.Location = new System.Drawing.Point(79, 9);
            this.textBox_EventLog_Name.Name = "textBox_EventLog_Name";
            this.textBox_EventLog_Name.Size = new System.Drawing.Size(349, 20);
            this.textBox_EventLog_Name.TabIndex = 3;
            // 
            // textBox_EventSource_Name
            // 
            this.textBox_EventSource_Name.Location = new System.Drawing.Point(79, 31);
            this.textBox_EventSource_Name.Name = "textBox_EventSource_Name";
            this.textBox_EventSource_Name.Size = new System.Drawing.Size(349, 20);
            this.textBox_EventSource_Name.TabIndex = 5;
            // 
            // label_EventSource
            // 
            this.label_EventSource.AutoSize = true;
            this.label_EventSource.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.label_EventSource.Location = new System.Drawing.Point(17, 35);
            this.label_EventSource.Name = "label_EventSource";
            this.label_EventSource.Size = new System.Drawing.Size(62, 13);
            this.label_EventSource.TabIndex = 4;
            this.label_EventSource.Text = "Log Source";
            // 
            // textBox_Output
            // 
            this.textBox_Output.Location = new System.Drawing.Point(10, 86);
            this.textBox_Output.Multiline = true;
            this.textBox_Output.Name = "textBox_Output";
            this.textBox_Output.Size = new System.Drawing.Size(477, 164);
            this.textBox_Output.TabIndex = 6;
            // 
            // button_DeleteEventLogOnly
            // 
            this.button_DeleteEventLogOnly.Location = new System.Drawing.Point(434, 9);
            this.button_DeleteEventLogOnly.Name = "button_DeleteEventLogOnly";
            this.button_DeleteEventLogOnly.Size = new System.Drawing.Size(47, 23);
            this.button_DeleteEventLogOnly.TabIndex = 7;
            this.button_DeleteEventLogOnly.Text = "Del.";
            this.button_DeleteEventLogOnly.UseVisualStyleBackColor = true;
            this.button_DeleteEventLogOnly.Click += new System.EventHandler(this.button_DeleteEventLogOnly_Click);
            // 
            // button_DeleteEventSourceOnly
            // 
            this.button_DeleteEventSourceOnly.Location = new System.Drawing.Point(434, 31);
            this.button_DeleteEventSourceOnly.Name = "button_DeleteEventSourceOnly";
            this.button_DeleteEventSourceOnly.Size = new System.Drawing.Size(47, 23);
            this.button_DeleteEventSourceOnly.TabIndex = 8;
            this.button_DeleteEventSourceOnly.Text = "Del.";
            this.button_DeleteEventSourceOnly.UseVisualStyleBackColor = true;
            this.button_DeleteEventSourceOnly.Click += new System.EventHandler(this.button_DeleteEventSourceOnly_Click);
            // 
            // Form_EventLogUtility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 262);
            this.Controls.Add(this.button_DeleteEventSourceOnly);
            this.Controls.Add(this.button_DeleteEventLogOnly);
            this.Controls.Add(this.textBox_Output);
            this.Controls.Add(this.textBox_EventSource_Name);
            this.Controls.Add(this.label_EventSource);
            this.Controls.Add(this.textBox_EventLog_Name);
            this.Controls.Add(this.Label_EventLog);
            this.Controls.Add(this.Delete_EventLog);
            this.Controls.Add(this.button_CreateEventLog);
            this.Name = "Form_EventLogUtility";
            this.Text = "EventLog Utility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_CreateEventLog;
        private System.Windows.Forms.Button Delete_EventLog;
        private System.Windows.Forms.Label Label_EventLog;
        private System.Windows.Forms.TextBox textBox_EventLog_Name;
        private System.Windows.Forms.TextBox textBox_EventSource_Name;
        private System.Windows.Forms.Label label_EventSource;
        private System.Windows.Forms.TextBox textBox_Output;
        private System.Windows.Forms.Button button_DeleteEventLogOnly;
        private System.Windows.Forms.Button button_DeleteEventSourceOnly;
    }
}

