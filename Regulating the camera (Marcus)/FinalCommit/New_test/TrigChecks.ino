void trigCheck()
{  
  if(motionTrig)
  {
    loopCount++;
    if(loopCount >= 3)
    {
      motionTrig = false;
      loopCount = 0;
    }
  }

  //Has door been closed after trigger?
  if(doorTrig)
  {
    if(digitalRead(pinDoor) == LOW)
    {
      doorTrig = false;
    }
  }
}

