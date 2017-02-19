/*
 *  Author: Marcus Sandberg
 */
 
#include <ESP8266WiFi.h>

#define calibrationTime 30
#define pause 1200
#define pirPin 5
#define ledPin 0
#define httpPort 80
const char* ssid     = "Holgerbergen";
const char* password = "Flamingotango";
String url = "";
const char* host = "192.168.1.60";

int pirTrig = 0;
 
void setup() {
  Serial.begin(115200);
  delay(100);
 
  // We start by connecting to a WiFi network

  pinMode(pirPin, INPUT);
  digitalWrite(pirPin, LOW);
  
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
      pirTrig = 0;
    }else{
      pirTrig = 1;
    }
  }
 

  delay(500);
  
  Serial.println();
  Serial.println("closing connection");
}
