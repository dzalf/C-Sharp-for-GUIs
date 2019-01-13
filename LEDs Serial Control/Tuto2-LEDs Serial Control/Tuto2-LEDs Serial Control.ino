#include <LiquidCrystal.h>

// Constants for manipulation of the LCD shield (keyes)
#define btnRIGHT  0
#define btnUP     1
#define btnDOWN   2
#define btnLEFT   3
#define btnSELECT 4
#define btnNONE   5

// LCD object declaration
LiquidCrystal lcd(8, 9, 4, 5, 6, 7);           // select the pins used on the LCD panel
// LEDs Ports Declaration

const int leds[3] = {52, 53, 48};
// Serial string manipulation variables
bool stringFinished = false;
bool comuActive = false;
bool serialHead = false;
bool serialTail = false;
String inputString = "";
String command = "";
String serialArray[30] = {""}; // capable of receiving up to 30 instructions

uint8_t lcd_key = 0;
int adc_key_in = 0;
int wordCounter = 0;
int loopCounter = 0;

int previous = btnNONE;

void setup() {

  lcd.begin(16, 2);
  Serial.begin(115200);
  for (int i = 0; i < 3; i++) {
    pinMode(leds[i], OUTPUT);

  }
  for (int i = 0; i < 3; i++) {

    digitalWrite(leds[i], LOW);
  }
  lcd.setCursor(1, 0);
  lcd.print("Second GUI Test");
}

void loop() {

  if (stringFinished) {

    stringFinished = false;


    while (loopCounter < wordCounter) {

      command = serialArray[loopCounter];


      if (command.equals("INIT")) {
        engageCOM();
      }

      if (comuActive) {

        if (command.equals("STOP")) {
          killCOM();
        }

        if (command.substring(0, 4).equals("TEXT")) {
          getPrintTextLCD();
        }

        if (command.substring(0, 3).equals("LED")) {
          triggerLED();
        }

        if (command.substring(0, 4).equals("DELA")) {
          delayRoutine();
        }
      }
      loopCounter++;
    }

    wordCounter = 0;
    loopCounter = 0;

  }

  lcd_key = read_LCD_buttons();   // read the buttons

  if (lcd_key != previous) {
    decypherKey(lcd_key);
    previous = lcd_key;
  }

}

void engageCOM() {

  String InitMsg = "COM Ready!";
  Serial.println("COMU_OK");
  comuActive = true;

  lcd.setCursor(0, 1);
  lcd.print(InitMsg);

  for (int i = InitMsg.length(); i < 16; i++ ) {
    lcd.write(' ');
  }
}

void killCOM() {

  comuActive = false;
  String StopMSg = "COM Stopped!";
  lcd.setCursor(0, 1);
  lcd.print(StopMSg);

  for (int i = StopMSg.length(); i < 16; i++ ) {
    lcd.write(' ');
  }
  Serial.flush();
}

void delayRoutine() {

  long previous = millis();
  String timeDelayString = command.substring(5, command.length());
  long timeDelay = timeDelayString.toInt();

  delay(timeDelay);
  //Serial.println(timeDelayString);
  String delayMsg = "DELAY t = ";
  lcd.setCursor(0, 1);
  lcd.print(delayMsg);
  lcd.print(millis() - previous);

  for (int i = (delayMsg.length() + timeDelayString.length()) ; i < 16; i++ ) {
    lcd.write(' ');
  }

}

void triggerLED() {

  char ledVal = command.charAt(3);
  int ledPin = ledVal - 48 ;

  String stateString = command.substring(5, command.length());
  //Serial.println(stateString);
  lcd.setCursor(0, 1);
  lcd.print("LED ");
  lcd.print(ledVal);


  if (stateString.equals("ON")) {
    digitalWrite(leds[ledPin], HIGH);
    lcd.print(" ON");
    for (int i = 8; i < 16; i++ ) {
      lcd.write(' ');
    }
  }
  if (stateString.equals("OFF")) {
    digitalWrite(leds[ledPin], LOW);
    lcd.print(" OFF");
    for (int i = 9; i < 16; i++ ) {
      lcd.write(' ');
    }
  }
}

int read_LCD_buttons() {              // read the buttons

  adc_key_in = analogRead(0);       // read the value from the sensor

  if (adc_key_in < 50)   return btnRIGHT;
  if (adc_key_in < 195)  return btnUP;
  if (adc_key_in < 380)  return btnDOWN;
  if (adc_key_in < 555)  return btnLEFT;
  if (adc_key_in < 790)  return btnSELECT;

  return btnNONE;                // when all others fail, return this.
}

void getPrintTextLCD() {

  String txt = command.substring(5, command.length());
  //Serial.println(txt);
  lcd.setCursor(0, 1);
  lcd.print(txt);
  for (int i = txt.length(); i < 16; i++ ) {
    lcd.write(' ');
  }
}

void decypherKey(int key) {

  lcd.setCursor(0, 1);

  switch (key) {

    case btnRIGHT: {

        Serial.println("RIGHT");
        break;
      }
    case btnLEFT: {
        Serial.println("LEFT");
        break;
      }
    case btnUP: {
        Serial.println("UP");
        break;
      }
    case btnDOWN: {
        Serial.println("DOWN");
        break;
      }
    case btnSELECT: {
        Serial.println("SELECT");
        break;
      }
  }
}

void serialEvent() {
  // this is simply beautiful! DO NOT CHANGE IT SO MUCH

  while (Serial.available()) {

    char inChar = (char)Serial.read();

    if (inChar == '\n') {
      serialTail = true;
    }

    if (serialHead && !serialTail) {
      // here I build the instruction
      inputString += inChar;
    }

    if (inChar == '#') {
      serialHead = true;
    }

    if (serialTail) {

      serialArray[wordCounter] = inputString;

      stringFinished = true;
      Serial.flush();


      wordCounter++;

      serialHead = false;
      serialTail = false;
      inputString = "";

    }
  }
}
