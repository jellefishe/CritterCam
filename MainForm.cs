using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CritterCam
{
    public partial class MainForm : Form
    {
        private CameraService cameraService = new CameraService();
        private System.Windows.Forms.Timer imageUpdateTimer;
        private System.Windows.Forms.Timer dateTimeUpdateTimer;
        private System.Windows.Forms.Timer lightingTimer;
        private System.Windows.Forms.Timer colorUpdateTimer;
        private System.Windows.Forms.Timer dataFetchTimer;
        private System.Windows.Forms.Timer fadeTimer;
        private System.Windows.Forms.Timer timeUpdateTimer;
        public MainForm()
        {
            InitializeComponent();
            InitializeLoadingPictureBox();
            InitializeImageUpdateTimer();
            InitializeDateTimeUpdateTimer();
            InitializeLightingTimer();
            InitializeColorUpdateTimer();
            InitializeStatusPictureBox();
            InitializeDataFetchTimer();
            InitializeFadeTimer();
            InitializeTimeUpdateTimer();
        }
        private void InitializeLoadingPictureBox()
        {
            try
            {
                loadingPictureBox.Image = Properties.Resources.loadingGif;
                loadingPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                loadingControlsGif.Image = Properties.Resources.loadingGif;
                loadingControlsGif.SizeMode = PictureBoxSizeMode.StretchImage;

                loadingSensorDataGif.Image = Properties.Resources.loadingGif;
                loadingSensorDataGif.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load GIF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InitializeStatusPictureBox()
        {
            try
            {
                // Get the current time
                DateTime now = DateTime.Now;
                TimeSpan currentTime = now.TimeOfDay;
                TimeSpan startTime = new TimeSpan(9, 0, 0);   // 09:00 AM
                TimeSpan endTime = new TimeSpan(19, 41, 0);    // 07:35 PM

                // Load image based on the time of day
                if (currentTime >= startTime && currentTime <= endTime)
                {
                    // Set image to 'happysun' if time is between 09:00 AM and 07:35 PM
                    emojiPictureBox.Image = Properties.Resources.happysun;
                }
                else
                {
                    // Set image to 'sleepingmoon' otherwise
                    emojiPictureBox.Image = Properties.Resources.sleepingmoon;
                }

                // Adjust the PictureBox size mode as needed
                emojiPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to set image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InitializeDataFetchTimer()
        {
            dataFetchTimer = new System.Windows.Forms.Timer();
            dataFetchTimer.Interval = 5000; // Fetch data every 5 seconds
            dataFetchTimer.Tick += async (sender, e) => await FetchAndUpdateData();
            dataFetchTimer.Start();
        }
        private void InitializeTimeUpdateTimer()
        {
            timeUpdateTimer = new System.Windows.Forms.Timer();
            timeUpdateTimer.Interval = 1000; // Update every second
            timeUpdateTimer.Tick += UpdateCurrentTimeLabel;
            timeUpdateTimer.Start();
        }
        private void InitializeImageUpdateTimer()
        {
            imageUpdateTimer = new System.Windows.Forms.Timer();
            imageUpdateTimer.Interval = 75; // Update interval in milliseconds (150 ms for ~6.67 FPS)
            imageUpdateTimer.Tick += async (sender, e) => await UpdateImage();
            imageUpdateTimer.Start();
        }
        private void InitializeFadeTimer()
        {
            fadeTimer = new System.Windows.Forms.Timer();
            fadeTimer.Interval = 3000; // Set the timer interval to 3 seconds (3000 milliseconds)
            fadeTimer.Tick += FadeTimer_Tick;
        }
        private void InitializeDateTimeUpdateTimer()
        {
            dateTimeUpdateTimer = new System.Windows.Forms.Timer();
            dateTimeUpdateTimer.Interval = 1000; // Update every second
            dateTimeUpdateTimer.Tick += UpdateDateTime;
            dateTimeUpdateTimer.Start();
        }

        private void InitializeColorUpdateTimer()
        {
            colorUpdateTimer = new System.Windows.Forms.Timer();
            colorUpdateTimer.Interval = 1000; // Check every second
            colorUpdateTimer.Tick += ColorUpdateTimer_Tick;
            colorUpdateTimer.Start();
        }
        private void InitializeLightingTimer()
        {
            lightingTimer = new System.Windows.Forms.Timer();
            lightingTimer.Interval = 1000; // Update every second
            lightingTimer.Tick += UpdateLightingProgressBar;
            lightingTimer.Start();
        }

        private async Task UpdateImage()
        {
            string cameraIp = "68.37.174.6"; // Your public IP address
            string port = "8080";            // The port you forwarded
            string resolution = "UXGA";      // Resolution 1600x1200

            byte[] imageData = await cameraService.GetCameraSnapshot(cameraIp, port, resolution);

            if (imageData != null)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    Image image = Image.FromStream(ms);

                    // Rotate the image 90 degrees clockwise
                    image.RotateFlip(RotateFlipType.Rotate90FlipNone);

                    // Dispose of the previous image if it exists
                    if (cameraStreamPictureBox.Image != null)
                    {
                        cameraStreamPictureBox.Image.Dispose();
                    }

                    // Set the rotated image to the PictureBox
                    cameraStreamPictureBox.Image = image;

                    if (loadingPictureBox.Visible)
                    {
                        loadingPictureBox.Visible = false;
                        loadingPictureBox.Dispose(); // Optional: Dispose if you no longer need it
                    }
                }
            }
        }
        private void UpdateCurrentTimeLabel(object sender, EventArgs e)
        {
            // Get the current time
            DateTime now = DateTime.Now;

            // Format the time to a 12-hour format with AM/PM
            string formattedTime = now.ToString("h:mm tt");

            // Update the label's text
            currentTimeLabel.Text = formattedTime;
        }
        private void UpdateDateTime(object sender, EventArgs e)
        {
            // Get the current time in EST
            DateTime estTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow,
                TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"));

            // Prepare the text to draw
            string dateTimeText = estTime.ToString("dd/MM/yyyy    HH:mm:ss");

            // Create a new bitmap for the DateTimePictureBox with transparent background
            Bitmap bmp = new Bitmap(DateTimePictureBox.Width, DateTimePictureBox.Height);
            bmp.MakeTransparent();

            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Enable high quality rendering
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                // Set up drawing tools
                using (Font font = new Font("Arial", 16))
                using (SolidBrush brush = new SolidBrush(Color.White))
                using (StringFormat sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Near;
                    sf.LineAlignment = StringAlignment.Far;

                    // Draw the text at the bottom left of the PictureBox
                    RectangleF rect = new RectangleF(5, 0, DateTimePictureBox.Width - 10, DateTimePictureBox.Height - 5);
                    g.DrawString(dateTimeText, font, brush, rect, sf);
                }
            }

            // Dispose of the previous image if it exists
            if (DateTimePictureBox.Image != null)
            {
                DateTimePictureBox.Image.Dispose();
            }

            // Set the new image to the DateTimePictureBox
            DateTimePictureBox.Image = bmp;
        }
        private void UpdateLightingProgressBar(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            TimeSpan startTime = new TimeSpan(9, 0, 0); // 09:00 AM
            TimeSpan endTime = new TimeSpan(19, 41, 0); // 07:35 PM
            TimeSpan midnight = new TimeSpan(23, 59, 59); // 00:00 AM
            hoursLeftRight.Visible = true;
            hoursLeftRight.Text = $"10.5h Left";
            hoursLeftRight.BackColor = Color.Lavender;

            hoursLeftLeft.Visible = false;

            if (now.TimeOfDay >= endTime && now.TimeOfDay < midnight)
            {
                lightingProgressBar.Value = 100;
                hoursLeftLeft.Visible = true;
                hoursLeftLeft.Text = $"Completed";
                hoursLeftLeft.BackColor = Color.Red;

                hoursLeftRight.Visible = false;
            }
            else if (now.TimeOfDay < startTime)
            {
                lightingProgressBar.Value = 0;
                hoursLeftRight.Visible = true;
                hoursLeftRight.Text = $"10.5h Left";
                hoursLeftRight.BackColor = Color.Lavender;

                hoursLeftLeft.Visible = false;
            }
            else
            {
                TimeSpan totalDuration = endTime - startTime;
                TimeSpan elapsedDuration = now.TimeOfDay - startTime;
                int progress = (int)((elapsedDuration.TotalMinutes / totalDuration.TotalMinutes) * 100);
                lightingProgressBar.Value = Math.Min(progress, 100);

                // Calculate hours left until the end time
                TimeSpan timeLeft = endTime - now.TimeOfDay;
                double hoursLeft = Math.Round(timeLeft.TotalHours, 1);
                hoursLeftLeft.Text = $"{hoursLeft}h Left";
                hoursLeftRight.Text = $"{hoursLeft}h Left";
            }

            // Update color based on the progress value
            if (lightingProgressBar.Value < 45)
            {
                lightingProgressBar.SetState(1); // Green color
                hoursLeftRight.Visible = true;
                hoursLeftRight.BackColor = Color.Lavender;

                hoursLeftLeft.Visible = false;
            }
            else if (lightingProgressBar.Value >= 33 && lightingProgressBar.Value < 75)
            {
                lightingProgressBar.SetState(3); // Yellow color
                hoursLeftLeft.Visible = true;
                hoursLeftLeft.BackColor = Color.Gold;

                hoursLeftRight.Visible = false;
            }
            else
            {
                lightingProgressBar.SetState(2); // Red color
                hoursLeftLeft.Visible = true;
                hoursLeftLeft.BackColor = Color.Red;

                hoursLeftRight.Visible = false;
            }
        }
        private async Task FetchAndUpdateData()
        {
            // Replace with your public IP address and forwarded port
            string publicIp = "68.37.174.6"; // Your public IP address
            string port = "8081";            // The port you forwarded

            string url = $"http://{publicIp}:{port}/data";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Parse the JSON response
                    var data = JsonConvert.DeserializeObject<SensorData>(responseBody);

                    // Update the UI elements
                    if (data != null)
                    {
                        UpdateUI(data);
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Failed to fetch data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateUI(SensorData data)
        {
            FeedOnceButton.Visible = true;
            int calibratedTDS = Convert.ToInt32(data.Tds * 0.75);
            tdsValLabel.Text = $"{calibratedTDS}"; //0.75 calibration
            tempLabel.Text = "75F";
            PHValLabel.Text = "7.6";
            // Calculate water level percentage
            double distance = data.Distance;
            double minDistance = 3.5; // Minimum distance in cm for 100%
            double maxDistance = 16.5; // Maximum distance in cm for 0%

            double percentage = (distance - maxDistance) / (minDistance - maxDistance) * 100;
            if (data.Distance > 100)
            {
                percentage = 100;
            }
            else
            {
                percentage = Math.Clamp(percentage, 0, 100); // Ensure percentage is within 0 to 100 range
            }
            // Update the progress bar
            waterLevelProgressBar.Value = (int)percentage;

            if (loadingControlsGif.Visible & loadingSensorDataGif.Visible)
            {
                loadingSensorDataGif.Visible = false;
                loadingSensorDataGif.Dispose();
                loadingControlsGif.Visible = false;
                loadingControlsGif.Dispose(); 

            }
        }

        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            // Hide the dispenseFoodLabel
            dispenseFoodLabel.Visible = false;

            // Stop the timer after hiding the label
            fadeTimer.Stop();
        }
        private void ColorUpdateTimer_Tick(object sender, EventArgs e)
        {
            // Get the current time
            DateTime now = DateTime.Now;

            // Define the time thresholds
            TimeSpan firstFeedTime = new TimeSpan(7, 41, 0);   
            TimeSpan secondFeedTime = new TimeSpan(19, 41, 0); 

            // Get the current time of day
            TimeSpan currentTime = now.TimeOfDay;
            firstFeedLabel.ForeColor = Color.LimeGreen;
            secondFeedLabel.ForeColor = Color.LimeGreen;

            // Check and update firstFeedLabel color
            if (currentTime >= firstFeedTime)
            {
                firstFeedLabel.ForeColor = Color.Gray;
            }

            // Check and update secondFeedLabel color
            if (currentTime >= secondFeedTime)
            {
                secondFeedLabel.ForeColor = Color.Gray;
            }
        }
        private async Task SendFeedRequest()
        {
            string publicIp = "68.37.174.6";
            string externalPort = "8081";        // The port you forwarded for the feed request
            string url = $"http://{publicIp}:{externalPort}/feed"; // Replace with your ESP32 IP address

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Failed to send feed request: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private async void FeedOnceButton_Click(object sender, EventArgs e)
        {
            await SendFeedRequest();

            dispenseFoodLabel.Visible = true;
            fadeTimer.Start();
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Stop and dispose of the timers when the form is closing
            imageUpdateTimer.Stop();
            imageUpdateTimer.Dispose();
            dateTimeUpdateTimer.Stop();
            dateTimeUpdateTimer.Dispose();
            lightingTimer.Stop();
            lightingTimer.Dispose();
            timeUpdateTimer.Stop();
            timeUpdateTimer.Dispose();
            base.OnFormClosing(e);
        }

    }
    public class SensorData
    {
        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("tds")]
        public int Tds { get; set; }
    }

    public class CameraService
    {
        private static readonly HttpClient client;

        static CameraService()
        {
            client = new HttpClient
            {
                Timeout = Timeout.InfiniteTimeSpan // Set the timeout to infinite
            };
        }

        public async Task<byte[]> GetCameraSnapshot(string ipAddress, string port, string resolution)
        {
            string url = $"http://{ipAddress}:{port}/capture?res=UXGA";

            const int maxRetries = 5; // Maximum number of retries
            const int initialDelay = 1000; // Initial delay in milliseconds

            for (int retryCount = 0; retryCount < maxRetries; retryCount++)
            {
                try
                {
                    var response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    return await response.Content.ReadAsByteArrayAsync();
                }
                catch (Exception ex) when (ex is HttpRequestException || ex is TaskCanceledException)
                {
                    //Console.WriteLine($"Error: {ex.Message}. Retrying... ({retryCount + 1}/{maxRetries})");

                    if (retryCount == maxRetries - 1)
                    {
                        Console.WriteLine("All retries exhausted. Could not get a successful response.");
                        return null; // Rethrow the exception if the last retry fails
                    }

                    // Wait for an exponential backoff before retrying
                    await Task.Delay(initialDelay * (int)Math.Pow(2, retryCount));
                }
            }

            // This line should never be reached
            return null;
        }
    }

    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}
