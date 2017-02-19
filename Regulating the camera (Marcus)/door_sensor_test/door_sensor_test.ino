const int door_sensor = 5;
const int buzzer = 12;
int state = 0;

void setup() {
  // put your setup code here, to run once:
  pinMode(door_sensor, INPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  state = digitalRead(door_sensor);
  
  if(state = HIGH)
  {
    tone(buzzer, 400);
  }else
  {
    noTone(buzzer);
  }
}
