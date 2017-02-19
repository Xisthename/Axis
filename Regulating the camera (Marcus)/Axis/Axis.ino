/*
    Author: Marcus Sandberg, Michael Ong, Jack Mao
    Date: 2017-02-19
*/

#include <ESP8266WiFi.h>

#define calibrationTime 30
#define pause 1200
#define PinMotion 5
#define PinDoor 4
#define httpPort 80

const char* ssid     = "NETGEAR44";
const char* password = "royalbanana761";
const char* host = "192.168.0.60";

String urlMotion, urlDoor = ""; // PTZ positions
int pirTrig = 0;

void setup() {
  Serial.begin(115200);
  delay(100);

  // Set pin
  pinMode(PinMotion, INPUT);
  pinMode(PinDoor, INPUT);
  digitalWrite(PinMotion, LOW);
  digitalWrite(PinDoor, LOW);

  // We start by connecting to a WiFi network
  Serial.println();
  Serial.println();
  Serial.print("Connecting to ");
  Serial.println(ssid);

  WiFi.begin(ssid, password);

  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }

  Serial.println("");
  Serial.println("WiFi connected");
  Serial.println("IP address: ");
  Serial.println(WiFi.localIP());
  Serial.println("");
  Serial.print("calibrating sensor ");
  for (int i = 0; i < calibrationTime; i++) {
    Serial.print(".");
    delay(1000);
  }
  Serial.println(" done");
  Serial.println("SENSOR ACTIVE");
  delay(50);
}


void loop() {
  delay(3000);

  Serial.print("connecting to ");
  Serial.println(host);

  // Use WiFiClient class to create TCP connections
  WiFiClient client;
  if (!client.connect(host, httpPort)) {
    Serial.println("connection failed");
    return;
  }

  if (pirTrig == 0)
  {

    // Even if the door is open or close, if motion are detected camera will go to PTZ Motion position.
    if (((digitalRead(PinMotion) == HIGH) && (digitalRead(PinDoor) == HIGH)) || ((digitalRead(PinMotion) == HIGH) && (digitalRead(PinDoor) == LOW)))
    {
      pirTrig = 1;
      urlMotion = "http://192.168.0.60/axis-cgi/com/ptz.cgi?camera=1&gotoserverpresetname=Motion";       //Choose PTZ Motion
      Serial.print("Requesting URL: ");
      Serial.println(urlMotion);
      // This will send the request to the server
      client.print(String("GET ") + urlMotion + " HTTP/1.1\r\n" +
                   "Host: " + host + "\r\n" +
                   "Connection: close\r\n\r\n");
      Serial.println(PinDoor);
    }

  } else {

    // If none motion detected and the door is open or close, the camera will go to PTZ Door position.
    if (((digitalRead(PinMotion) == LOW) && (digitalRead(PinDoor) == LOW)) || ((digitalRead(PinMotion) == LOW) && (digitalRead(PinDoor) == HIGH)))
    {
      pirTrig = 0;
      urlDoor = "http://192.168.0.60/axis-cgi/com/ptz.cgi?user=root&pwd=pass&camera=1&gotoserverpresetname=Door";       //Choose PTZ Door
      Serial.print("Requesting URL: ");
      Serial.println(urlDoor);
      // This will send the request to the server
      client.print(String("GET ") + urlDoor + " HTTP/1.1\r\n" +
                   "Host: " + host + "\r\n" +
                   "Connection: close\r\n\r\n");
    } else {

      pirTrig = 1;

    }
  }

  delay(500);

  Serial.println();
  Serial.println("closing connection");
}
