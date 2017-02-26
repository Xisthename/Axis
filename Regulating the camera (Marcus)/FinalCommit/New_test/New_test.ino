/*
    Author: Marcus Sandberg, Michael Ong, Jack Mao
    Date: 2017-02-19
*/

#include <ESP8266WiFi.h>

#define calibrationTime 30
#define pause 1200
#define pinMotion 5
#define pinDoor 4
#define httpPort 80

bool motionTrig = false;
bool doorTrig = false;
int loopCount = 0;

const char* ssid     = "NETGEAR44";
const char* password = "royalbanana761";
const char* host = "192.168.0.60";

const String urlMotion = "http://192.168.0.60/axis-cgi/com/ptz.cgi?camera=1&gotoserverpresetname=Motion";
const String urlDoor = "http://192.168.0.60/axis-cgi/com/ptz.cgi?camera=1&gotoserverpresetname=Door";

void setup() {
  Serial.begin(115200);
  delay(100);

  // Set pin
  pinMode(pinMotion, INPUT);
  pinMode(pinDoor, INPUT_PULLUP);
  digitalWrite(pinMotion, LOW);

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
  delay(1500);

  Serial.print("connecting to ");
  Serial.println(host);

  // Use WiFiClient class to create TCP connections
  WiFiClient client;
  if (!client.connect(host, httpPort)) {
    Serial.println("connection failed");
    return;
  }

  //Delay after last triggering
  trigCheck();
  
    // Has the door been opened?
    if (digitalRead(pinDoor) == HIGH && !doorTrig)
    {
      doorTrig = true;
      Serial.print("Requesting URL: ");
      Serial.println(urlDoor);
      // This will send the request to the server
      client.print(String("GET ") + urlDoor + " HTTP/1.1\r\n" +
                   "Host: " + host + "\r\n" +
                   "Connection: close\r\n\r\n");
    //Has any motion been detected?
    }else if (digitalRead(pinMotion) == HIGH && !motionTrig)
    {
      motionTrig = true;
      Serial.print("Requesting URL: ");
      Serial.println(urlMotion);
      // This will send the request to the server
      client.print(String("GET ") + urlMotion + " HTTP/1.1\r\n" +
                   "Host: " + host + "\r\n" +
                   "Connection: close\r\n\r\n");
    }
}
