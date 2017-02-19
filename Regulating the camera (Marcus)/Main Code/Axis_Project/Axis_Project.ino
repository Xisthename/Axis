/*
 *  Author: Marcus Sandberg
 */
 
#include <ESP8266WiFi.h>


/*
 * Calibrationtime: Time in seconds for PIR-sensor to calibrate.
 * Pause: Time in between sensor checks.
 * PirPin: pin assigned to PIR-sensor signal
  */
  
#define calibrationTime 20
#define pause 750
#define pirPin 5

#define httpPort 80

// Wifi information and camera IP-address assignment.
const char* ssid     = "Holgerbergen";
const char* password = "Flamingotango";
String url = "";
const char* host = "192.168.1.60";

int pirTrig = 0;
 
void setup() {
  Serial.begin(115200);
  delay(100);
 
  //Pin initiation
  pinMode(pirPin, INPUT);
  digitalWrite(pirPin, LOW);

  //Connecting to network
  
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

  //Waiting for sensor to calibrate
  Serial.print("calibrating sensor ");
  for(int i = 0; i < calibrationTime; i++){
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

  if(pirTrig == 0)
  {
    if(digitalRead(pirPin) == HIGH)
    {
      pirTrig = 1;
      Serial.println("Movement detected!");
      url = "insert correct URL";       //To be fixed
      Serial.print("Requesting URL: ");
      Serial.println(url);
      // This will send the request to the server
      client.print(String("GET ") + url + " HTTP/1.1\r\n" +
               "Host: " + host + "\r\n" + 
               "Connection: close\r\n\r\n");
    }
  }else if(pirTrig = 1)
  {
    if(digitalRead(pirPin) == LOW)
    {
      Serial.println("Movement detection lost.");
      pirTrig = 0;
    }else{
      pirTrig = 1;
    }
  }
 

  delay(pause);
  
  Serial.println();
  Serial.println("closing connection");
}
