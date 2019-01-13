

bool stringFinished = false;
bool comuActive = false;
bool serialHead = false;
bool serialTail = false;
String inputString = "";

const int leds[3] = {52, 53, 48};

void setup() {
  // put your setup code here, to run once:
Serial.begin(115200);

  for (int i = 0; i < 3; i++) {
    pinMode(leds[i], OUTPUT);

  }
  for (int i = 0; i < 3; i++) {

    digitalWrite(leds[i], LOW);
  }
}

void loop() {
  // put your main code here, to run repeatedly:
  if(stringFinished){
    stringFinished = false;
    Serial.println(inputString);
    Serial.println("Done");
  }
}

void serialEvent() {

  while (Serial.available()) {
     digitalWrite(leds[0], HIGH);

    char inChar = (char)Serial.read();

    if (inChar == '#'){ 
      serialHead = true;
    }

    if (serialHead && !serialTail) {
      // here I build the instruction
      inputString += inChar;
      Serial.println(inputString);
    }

    if (inChar == '\n' && inputString.length() > 1) {
      serialTail = true;
      stringFinished = true;
      inputString = "";
      serialHead = false;
      serialTail = false;
    }
  }
   digitalWrite(leds[0], LOW);
}
