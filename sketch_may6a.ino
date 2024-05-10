#define S0 4
#define S1 5
#define S2 6
#define S3 7
#define sensorOut 8

int frequency = 0;            // frequecy reading of the color sensor 
// Define pin numbers for the HC-SR04 sensor and LED
const int trigPin = 52;      // Trig pin of the HC-SR04 connected to digital pin 52
const int echoPin = 53;      // Echo pin of the HC-SR04 connected to digital pin 8
const int ledPin = 44;       // LED connected to digital pin 40 through a resistor
//pins for thermistor
const int thermistorPin = A0;  // Analog pin where thermistor is connected
const float seriesResistor = 10000;  // Resistance of the series resistor (10kΩ)

// Setup function runs once when you reset or power up the board
void setup() {
  pinMode(trigPin, OUTPUT); // Set the trigPin as an output (to send ultrasonic signals)
  pinMode(echoPin, INPUT);  // Set the echoPin as an input (to receive ultrasonic signals)
  pinMode(ledPin, OUTPUT);  // Set the ledPin as an output (to control the LED)
  
  //setup color sensor GY-13
  pinMode(S0, OUTPUT);
  pinMode(S1, OUTPUT);
  pinMode(S2, OUTPUT);
  pinMode(S3, OUTPUT);
  pinMode(sensorOut, INPUT);
  //set freq scale to 20%
  digitalWrite(S0, HIGH);
  digitalWrite(S1, LOW);

  Serial.begin(9600);       // Start serial communication at 9600 baud rate display results on serial monitor
}

// Loop function runs repeatedly after setup() is complete
void loop() {
  //distance sensor
  long duration, distance;  // Declare variables for the duration of the echo pulse and the calculated distance
  int adcValue = analogRead(thermistorPin);  // Read the analog value from the thermistor
  float resistance = (1023.0 / adcValue - 1) * seriesResistor;  // Calculate the resistance of the thermistor
  digitalWrite(trigPin, LOW);  // Ensure trigPin starts LOW
  delayMicroseconds(2);       // Wait for 2 microseconds
  digitalWrite(trigPin, HIGH); // Send a 10-microsecond high pulse
  delayMicroseconds(10);       // Wait for 10 microseconds
  digitalWrite(trigPin, LOW);  // Return trigPin to LOW
  
  // Measure the length of the incoming pulse
  duration = pulseIn(echoPin, HIGH);
  
  // Calculate the distance (in cm) based on the duration of the echo
  distance = duration * 0.034 / 2; // Speed of sound wave divided by 2 (go and return)

  // Print the distance to the Serial Monitor
  Serial.print("Distance: ");
  Serial.println(distance);

  // Check if the distance is less than 500 units
  if(distance < 18) {
    digitalWrite(ledPin, HIGH); // Turn on the LED if true
  } else {
    digitalWrite(ledPin, LOW);  // Turn off the LED if false
  }

  //color sensor setup red filtered photodiodes to read
  digitalWrite(S2, LOW);
  digitalWrite(S3, LOW);
  //read the out freq
  frequency = pulseIn(sensorOut, LOW);
  //REMAPPING
  frequency = map(frequency, 40, 500, 255, 0);
  //print results 
  //red
  Serial.print("R:");
  Serial.print(frequency);
  Serial.print("  ");
  delay(100);
  //green
  digitalWrite(S2, HIGH);
  digitalWrite(S3, HIGH);
  //read the out freq
  frequency = pulseIn(sensorOut, LOW);
  frequency = map(frequency, 40, 610, 255, 0);
  //print results 
  Serial.print("G:");
  Serial.print(frequency);
  Serial.print("  ");
  delay(100);
  //blue
  digitalWrite(S2, LOW);
  digitalWrite(S3, HIGH);
  //read the out freq
  frequency = pulseIn(sensorOut, LOW);
  frequency = map(frequency, 15, 180, 255, 0);
  //print results 
  Serial.print("B:");
  Serial.print(frequency);
  Serial.println("  ");
  delay(100);
  //green
  // Calculate temperature from the resistance of NTC thermistor
  float temperatureC = 1.0 / (log(resistance / 10000) / 3950 + 1 / (25 + 273.15)) - 273.15;  // Convert to Celsius
  temperatureC = temperatureC + 12; //calibration
  float temperatureF = temperatureC * 9.0 / 5.0 + 32;  // Convert Celsius to Fahrenheit

  Serial.print("Temperature: ");
  Serial.print(temperatureF);
  Serial.println(" F");

  delay(500); // Wait for half a second before the next loop iteration
}
