namespace CritterCam
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            cameraStreamPictureBox = new PictureBox();
            waterLevelProgressBar = new ProgressBar();
            mainFormPanel = new Panel();
            feedScheduleContainer = new GroupBox();
            firstFeedLabel = new Label();
            secondFeedLabel = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            loadingSensorDataGif = new PictureBox();
            label8 = new Label();
            PHValLabel = new Label();
            tdsValLabel = new Label();
            tempLabel = new Label();
            label7 = new Label();
            label6 = new Label();
            tdsLabel = new Label();
            label3 = new Label();
            currentTimeLabel = new Label();
            groupBox1 = new GroupBox();
            hoursLeftLeft = new Label();
            hoursLeftRight = new Label();
            lightingProgressBar = new ProgressBar();
            label5 = new Label();
            label4 = new Label();
            emojiPictureBox = new PictureBox();
            controlsContainer = new GroupBox();
            loadingControlsGif = new PictureBox();
            dispenseFoodLabel = new Label();
            controlLabel = new Label();
            FeedOnceButton = new Button();
            DateTimePictureBox = new PictureBox();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            toolTip4 = new ToolTip(components);
            toolTip5 = new ToolTip(components);
            loadingPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)cameraStreamPictureBox).BeginInit();
            mainFormPanel.SuspendLayout();
            feedScheduleContainer.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loadingSensorDataGif).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)emojiPictureBox).BeginInit();
            controlsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loadingControlsGif).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DateTimePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loadingPictureBox).BeginInit();
            SuspendLayout();
            // 
            // cameraStreamPictureBox
            // 
            cameraStreamPictureBox.BackColor = Color.Black;
            cameraStreamPictureBox.Location = new Point(-2, 3);
            cameraStreamPictureBox.Name = "cameraStreamPictureBox";
            cameraStreamPictureBox.Size = new Size(819, 1023);
            cameraStreamPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            cameraStreamPictureBox.TabIndex = 0;
            cameraStreamPictureBox.TabStop = false;
            // 
            // waterLevelProgressBar
            // 
            waterLevelProgressBar.BackColor = SystemColors.ActiveBorder;
            waterLevelProgressBar.ForeColor = SystemColors.ControlLight;
            waterLevelProgressBar.Location = new Point(1, 215);
            waterLevelProgressBar.Name = "waterLevelProgressBar";
            waterLevelProgressBar.Size = new Size(168, 25);
            waterLevelProgressBar.TabIndex = 1;
            toolTip3.SetToolTip(waterLevelProgressBar, "Progress Bar is also:\r\nSump Water Level\r\nTank Flow Rate\r\nWater Pump Gauge\r\n\r\n");
            // 
            // mainFormPanel
            // 
            mainFormPanel.BackColor = Color.Transparent;
            mainFormPanel.Controls.Add(feedScheduleContainer);
            mainFormPanel.Controls.Add(groupBox2);
            mainFormPanel.ForeColor = Color.Black;
            mainFormPanel.Location = new Point(1009, 3);
            mainFormPanel.Name = "mainFormPanel";
            mainFormPanel.Size = new Size(169, 662);
            mainFormPanel.TabIndex = 2;
            // 
            // feedScheduleContainer
            // 
            feedScheduleContainer.BackColor = Color.Transparent;
            feedScheduleContainer.Controls.Add(firstFeedLabel);
            feedScheduleContainer.Controls.Add(secondFeedLabel);
            feedScheduleContainer.Controls.Add(label1);
            feedScheduleContainer.ForeColor = Color.Transparent;
            feedScheduleContainer.Location = new Point(3, 493);
            feedScheduleContainer.Name = "feedScheduleContainer";
            feedScheduleContainer.Size = new Size(169, 170);
            feedScheduleContainer.TabIndex = 17;
            feedScheduleContainer.TabStop = false;
            feedScheduleContainer.Text = "groupBox3";
            toolTip3.SetToolTip(feedScheduleContainer, "Auto-Feeds two times a day\r\nTime turns gray on feed completion\r\nTime resets to green at midnight");
            // 
            // firstFeedLabel
            // 
            firstFeedLabel.AutoSize = true;
            firstFeedLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstFeedLabel.ForeColor = Color.LimeGreen;
            firstFeedLabel.Location = new Point(37, 65);
            firstFeedLabel.Name = "firstFeedLabel";
            firstFeedLabel.Size = new Size(98, 32);
            firstFeedLabel.TabIndex = 5;
            firstFeedLabel.Text = "7:41 am";
            toolTip3.SetToolTip(firstFeedLabel, "Auto-Feeds two times a day\r\nTime turns gray on feed completion\r\nTime resets to green at midnight\r\n");
            // 
            // secondFeedLabel
            // 
            secondFeedLabel.AutoSize = true;
            secondFeedLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            secondFeedLabel.ForeColor = Color.LimeGreen;
            secondFeedLabel.Location = new Point(37, 97);
            secondFeedLabel.Name = "secondFeedLabel";
            secondFeedLabel.Size = new Size(100, 32);
            secondFeedLabel.TabIndex = 6;
            secondFeedLabel.Text = "7:41 pm";
            toolTip3.SetToolTip(secondFeedLabel, "Auto-Feeds two times a day\r\nTime turns gray on feed completion\r\nTime resets to green at midnight\r\n");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 19);
            label1.Name = "label1";
            label1.Size = new Size(153, 37);
            label1.TabIndex = 4;
            label1.Text = "Auto-Feed:";
            toolTip3.SetToolTip(label1, "Auto-Feeds two times a day\r\nTime turns gray on feed completion\r\nTime resets to green at midnight\r\n");
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(loadingSensorDataGif);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(PHValLabel);
            groupBox2.Controls.Add(tdsValLabel);
            groupBox2.Controls.Add(waterLevelProgressBar);
            groupBox2.Controls.Add(tempLabel);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(tdsLabel);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(0, 188);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(169, 280);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            toolTip3.SetToolTip(groupBox2, "Progress Bar is also:\r\nSump Water Level\r\nTank Flow Rate\r\nWater Pump Gauge\r\n\r\n");
            // 
            // loadingSensorDataGif
            // 
            loadingSensorDataGif.InitialImage = Properties.Resources.loadingGif;
            loadingSensorDataGif.Location = new Point(15, 56);
            loadingSensorDataGif.Name = "loadingSensorDataGif";
            loadingSensorDataGif.Size = new Size(140, 140);
            loadingSensorDataGif.TabIndex = 8;
            loadingSensorDataGif.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(0, 191);
            label8.Name = "label8";
            label8.Size = new Size(171, 30);
            label8.TabIndex = 10;
            label8.Text = "Filtering Strength";
            toolTip3.SetToolTip(label8, "Progress Bar is also:\r\nSump Water Level\r\nTank Flow Rate\r\nWater Pump Gauge\r\n\r\n");
            // 
            // PHValLabel
            // 
            PHValLabel.AutoSize = true;
            PHValLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PHValLabel.ForeColor = Color.LightSkyBlue;
            PHValLabel.Location = new Point(99, 131);
            PHValLabel.Name = "PHValLabel";
            PHValLabel.Size = new Size(44, 30);
            PHValLabel.TabIndex = 9;
            PHValLabel.Text = "n/a";
            // 
            // tdsValLabel
            // 
            tdsValLabel.AutoSize = true;
            tdsValLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tdsValLabel.ForeColor = Color.Khaki;
            tdsValLabel.Location = new Point(99, 101);
            tdsValLabel.Name = "tdsValLabel";
            tdsValLabel.Size = new Size(44, 30);
            tdsValLabel.TabIndex = 8;
            tdsValLabel.Text = "n/a";
            // 
            // tempLabel
            // 
            tempLabel.AutoSize = true;
            tempLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tempLabel.ForeColor = Color.IndianRed;
            tempLabel.Location = new Point(99, 71);
            tempLabel.Name = "tempLabel";
            tempLabel.Size = new Size(44, 30);
            tempLabel.TabIndex = 7;
            tempLabel.Text = "n/a";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1, 16);
            label7.Name = "label7";
            label7.Size = new Size(171, 37);
            label7.TabIndex = 6;
            label7.Text = "Sensor Data:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(15, 131);
            label6.Name = "label6";
            label6.Size = new Size(45, 30);
            label6.TabIndex = 5;
            label6.Text = "pH:";
            toolTip5.SetToolTip(label6, "pH measures how acidic or basic a solution is on a scale from 0 to 14. \r\nA pH of 7 is neutral, below 7 is acidic, and above 7 is basic.");
            // 
            // tdsLabel
            // 
            tdsLabel.AutoSize = true;
            tdsLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tdsLabel.ForeColor = Color.White;
            tdsLabel.Location = new Point(15, 101);
            tdsLabel.Name = "tdsLabel";
            tdsLabel.Size = new Size(55, 30);
            tdsLabel.TabIndex = 0;
            tdsLabel.Text = "TDS:";
            toolTip1.SetToolTip(tdsLabel, "TDS measures how many solubles are dissolved in the water.\r\nAquarists will use TDS as a water change indicator\r\nAir =0,Tap = 150, good = 250, fair = 400, poor = 600, danger = 800");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(15, 71);
            label3.Name = "label3";
            label3.Size = new Size(68, 30);
            label3.TabIndex = 4;
            label3.Text = "Temp:";
            toolTip4.SetToolTip(label3, "~75F is optimal for guppies and turtles ");
            // 
            // currentTimeLabel
            // 
            currentTimeLabel.AutoSize = true;
            currentTimeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currentTimeLabel.ForeColor = Color.LimeGreen;
            currentTimeLabel.Location = new Point(823, 165);
            currentTimeLabel.Name = "currentTimeLabel";
            currentTimeLabel.Size = new Size(58, 30);
            currentTimeLabel.TabIndex = 5;
            currentTimeLabel.Text = "Time";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(hoursLeftLeft);
            groupBox1.Controls.Add(hoursLeftRight);
            groupBox1.Controls.Add(lightingProgressBar);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(823, 493);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(169, 170);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            toolTip2.SetToolTip(groupBox1, "10.5 Hour long lighting duration\r\nThe bar will be full after 10.5h of light\r\nbar resets at midnight\r\n");
            // 
            // hoursLeftLeft
            // 
            hoursLeftLeft.AutoSize = true;
            hoursLeftLeft.BackColor = Color.Lavender;
            hoursLeftLeft.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hoursLeftLeft.ForeColor = Color.LimeGreen;
            hoursLeftLeft.Location = new Point(3, 110);
            hoursLeftLeft.Name = "hoursLeftLeft";
            hoursLeftLeft.Size = new Size(67, 23);
            hoursLeftLeft.TabIndex = 16;
            hoursLeftLeft.Text = "0h Left";
            // 
            // hoursLeftRight
            // 
            hoursLeftRight.AutoSize = true;
            hoursLeftRight.BackColor = Color.Lavender;
            hoursLeftRight.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hoursLeftRight.ForeColor = Color.LimeGreen;
            hoursLeftRight.Location = new Point(91, 110);
            hoursLeftRight.Name = "hoursLeftRight";
            hoursLeftRight.Size = new Size(67, 23);
            hoursLeftRight.TabIndex = 15;
            hoursLeftRight.Text = "0h Left";
            // 
            // lightingProgressBar
            // 
            lightingProgressBar.Location = new Point(0, 99);
            lightingProgressBar.Name = "lightingProgressBar";
            lightingProgressBar.Size = new Size(169, 39);
            lightingProgressBar.TabIndex = 7;
            toolTip2.SetToolTip(lightingProgressBar, "10.5 Hour long lighting duration\r\nThe bar will be full after 10.5h of light\r\nbar resets at midnight\r\n");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 69);
            label5.Name = "label5";
            label5.Size = new Size(168, 30);
            label5.TabIndex = 8;
            label5.Text = "9:00am - 7:41pm";
            toolTip2.SetToolTip(label5, "10.5 Hour long lighting duration\r\nThe bar will be full after 10.5h of light\r\nbar resets at midnight\r\n");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(2, 19);
            label4.Name = "label4";
            label4.Size = new Size(164, 37);
            label4.TabIndex = 7;
            label4.Text = "Light Timer:";
            toolTip2.SetToolTip(label4, "10.5 Hour long lighting duration\r\nThe bar will be full after 10.5h of light\r\nbar resets at midnight\r\n");
            // 
            // emojiPictureBox
            // 
            emojiPictureBox.InitialImage = Properties.Resources.sleepingmoon;
            emojiPictureBox.Location = new Point(842, 6);
            emojiPictureBox.Name = "emojiPictureBox";
            emojiPictureBox.Size = new Size(170, 170);
            emojiPictureBox.TabIndex = 18;
            emojiPictureBox.TabStop = false;
            // 
            // controlsContainer
            // 
            controlsContainer.Controls.Add(loadingControlsGif);
            controlsContainer.Controls.Add(dispenseFoodLabel);
            controlsContainer.Controls.Add(controlLabel);
            controlsContainer.Controls.Add(FeedOnceButton);
            controlsContainer.Location = new Point(823, 188);
            controlsContainer.Name = "controlsContainer";
            controlsContainer.Size = new Size(169, 280);
            controlsContainer.TabIndex = 19;
            controlsContainer.TabStop = false;
            controlsContainer.Text = "groupBox4";
            // 
            // loadingControlsGif
            // 
            loadingControlsGif.InitialImage = Properties.Resources.loadingGif;
            loadingControlsGif.Location = new Point(10, 53);
            loadingControlsGif.Name = "loadingControlsGif";
            loadingControlsGif.Size = new Size(150, 150);
            loadingControlsGif.TabIndex = 9;
            loadingControlsGif.TabStop = false;
            // 
            // dispenseFoodLabel
            // 
            dispenseFoodLabel.AutoSize = true;
            dispenseFoodLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dispenseFoodLabel.ForeColor = Color.LimeGreen;
            dispenseFoodLabel.Location = new Point(3, 173);
            dispenseFoodLabel.Name = "dispenseFoodLabel";
            dispenseFoodLabel.Size = new Size(165, 30);
            dispenseFoodLabel.TabIndex = 6;
            dispenseFoodLabel.Text = "Feed Successful!";
            dispenseFoodLabel.Visible = false;
            // 
            // controlLabel
            // 
            controlLabel.AutoSize = true;
            controlLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            controlLabel.ForeColor = Color.White;
            controlLabel.Location = new Point(19, 19);
            controlLabel.Name = "controlLabel";
            controlLabel.Size = new Size(128, 37);
            controlLabel.TabIndex = 5;
            controlLabel.Text = "Controls:";
            // 
            // FeedOnceButton
            // 
            FeedOnceButton.BackColor = Color.LimeGreen;
            FeedOnceButton.Cursor = Cursors.Cross;
            FeedOnceButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FeedOnceButton.ForeColor = Color.White;
            FeedOnceButton.Location = new Point(15, 78);
            FeedOnceButton.Name = "FeedOnceButton";
            FeedOnceButton.Size = new Size(140, 92);
            FeedOnceButton.TabIndex = 1;
            FeedOnceButton.Text = "Dispense Food";
            toolTip3.SetToolTip(FeedOnceButton, "Send request to spin motor\r\nturtle and fish flake mixture\r\n");
            FeedOnceButton.UseVisualStyleBackColor = false;
            FeedOnceButton.Visible = false;
            FeedOnceButton.Click += FeedOnceButton_Click;
            // 
            // DateTimePictureBox
            // 
            DateTimePictureBox.BackColor = Color.Transparent;
            DateTimePictureBox.Location = new Point(-2, 922);
            DateTimePictureBox.Name = "DateTimePictureBox";
            DateTimePictureBox.Size = new Size(237, 50);
            DateTimePictureBox.TabIndex = 3;
            DateTimePictureBox.TabStop = false;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "TDS Avg: 100-500";
            // 
            // toolTip4
            // 
            toolTip4.ToolTipTitle = "Temp Avg: 70-85F";
            // 
            // toolTip5
            // 
            toolTip5.ToolTipTitle = "PH Avg: 6.0-8.0";
            // 
            // loadingPictureBox
            // 
            loadingPictureBox.InitialImage = Properties.Resources.loadingGif;
            loadingPictureBox.Location = new Point(164, 144);
            loadingPictureBox.Name = "loadingPictureBox";
            loadingPictureBox.Size = new Size(500, 500);
            loadingPictureBox.TabIndex = 7;
            loadingPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1185, 971);
            Controls.Add(currentTimeLabel);
            Controls.Add(emojiPictureBox);
            Controls.Add(groupBox1);
            Controls.Add(loadingPictureBox);
            Controls.Add(DateTimePictureBox);
            Controls.Add(mainFormPanel);
            Controls.Add(cameraStreamPictureBox);
            Controls.Add(controlsContainer);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Critter Cam - Vincent Tai";
            ((System.ComponentModel.ISupportInitialize)cameraStreamPictureBox).EndInit();
            mainFormPanel.ResumeLayout(false);
            feedScheduleContainer.ResumeLayout(false);
            feedScheduleContainer.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)loadingSensorDataGif).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)emojiPictureBox).EndInit();
            controlsContainer.ResumeLayout(false);
            controlsContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)loadingControlsGif).EndInit();
            ((System.ComponentModel.ISupportInitialize)DateTimePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)loadingPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox cameraStreamPictureBox;
        private System.Windows.Forms.ProgressBar waterLevelProgressBar;
        private System.Windows.Forms.Panel mainFormPanel;
        private System.Windows.Forms.Label tdsLabel;
        private Button FeedOnceButton;
        private PictureBox DateTimePictureBox;
        private Label label1;
        private Label secondFeedLabel;
        private Label firstFeedLabel;
        private ProgressBar lightingProgressBar;
        private Label label4;
        private Label label5;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private GroupBox feedScheduleContainer;
        private Label label3;
        private PictureBox emojiPictureBox;
        private Label hoursLeftLeft;
        private Label hoursLeftRight;
        private GroupBox controlsContainer;
        private Label label6;
        private Label controlLabel;
        private Label label7;
        private Label PHValLabel;
        private Label tdsValLabel;
        private Label tempLabel;
        private Label label8;
        private Label dispenseFoodLabel;
        private Label currentTimeLabel;
        private ToolTip toolTip1;
        private ToolTip toolTip3;
        private ToolTip toolTip2;
        private ToolTip toolTip4;
        private ToolTip toolTip5;
        private PictureBox loadingPictureBox;
        private PictureBox loadingSensorDataGif;
        private PictureBox loadingControlsGif;
    }
}
