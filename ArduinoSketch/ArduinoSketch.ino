#include <SoftwareSerial.h>
#include <Adafruit_NeoPixel.h>
#ifdef __AVR__
  #include <avr/power.h>
#endif

SoftwareSerial BT(10, 11); 

#define PIXEL_PIN      6    // Data Pin of Led strip 
#define PIXEL_COUNT    120   // Number of LEDs in the strip
#define SPEED          50    // Speed of each Color Transition (in ms)
#define IMMEDIATELY    0    // Transition happen instantly
#define RAINBOW_SPEED  50    // Rainbow Transition speed

Adafruit_NeoPixel strip = Adafruit_NeoPixel(PIXEL_COUNT, PIXEL_PIN, NEO_GRB + NEO_KHZ800);

void setup() {
   BT.begin(9600);
   
   BT.println("Connected to Arduino");
   strip.begin();
   strip.show();
}

int brightness = 255;
String temp;

void loop() {
    temp = BT.readString();
    if(temp.startsWith("p"))
    {
      temp.remove(0,1);
      temp.toInt();
      brightness = temp.toInt();
      strip.setBrightness(brightness);
    }

    if(temp.startsWith("w"))
    {
        RunningLights(0xff,0xff,0x00, 50);
    }
    
    if(temp.startsWith("r"))
    {
        colorWipe(0x00,0xff,0x00, 25);
        colorWipe(0x00,0x00,0x00, 25);
    }
    
    if(temp.startsWith("g"))
    {
        rainbowCycle(20);
    }

    if(temp.startsWith("b"))
    {
        NewKITT(0xff, 0, 0, 8, 10, 50);
    }

    if(temp.startsWith("m"))
    {
      strip.clear();
      for(uint16_t i=0; i< PIXEL_COUNT; i++)
      {
        strip.setPixelColor(i,204,0,204);
      }
    }

    if(temp.startsWith("s"))
    {
      SnowSparkle(0x10, 0x10, 0x10, 20, random(100,1000));
    }

    if(temp.startsWith("a"))
    {
      Twinkle(0xff, 0, 0, 10, 100, false);
    }

    if(temp.startsWith("c"))
    {
      strip.clear();
      for(uint16_t i=0; i< PIXEL_COUNT; i++)
      {
        strip.setPixelColor(i,1,255,255);
      }
    }

    if(temp.startsWith("d"))
    {
      strip.clear();
      for(uint16_t i=0; i< PIXEL_COUNT; i++)
      {
        strip.setPixelColor(i,255,154,0);
      }
    }

    if(temp.indexOf("item") >= 0)
    {
      int str_len = temp.length();

      char char_array[str_len];

      temp.toCharArray(char_array, str_len);

      int item;
      int red;
      int green;
      int blue; 
      
      int n = sscanf(char_array,"item%d,%d,%d,%d",&item, &blue, &green, &red);
      if(item == -1)
      {
        for(uint16_t i=0; i< PIXEL_COUNT; i++)
        {
          strip.setPixelColor(i,red,green,blue);
        }
      }
      strip.setPixelColor(item, red,green,blue);
    }
    strip.show();
}
void RunningLights(byte red, byte green, byte blue, int WaveDelay) {
  int Position=0;
  
  for(int i=0; i<PIXEL_COUNT*2; i++)
  {
      Position++; // = 0; //Position + Rate;
      for(int i=0; i<PIXEL_COUNT; i++) {
        // sine wave, 3 offset waves make a rainbow!
        //float level = sin(i+Position) * 127 + 128;
        //setPixel(i,level,0,0);
        //float level = sin(i+Position) * 127 + 128;
        setPixel(i,((sin(i+Position) * 127 + 128)/255)*red,
                   ((sin(i+Position) * 127 + 128)/255)*green,
                   ((sin(i+Position) * 127 + 128)/255)*blue);
      }
      
      showStrip();
      delay(WaveDelay);
  }
}
//------------------------------------------------------------------------
void colorWipe(byte red, byte green, byte blue, int SpeedDelay) {
  for(uint16_t i=0; i<PIXEL_COUNT; i++) {
      setPixel(i, red, green, blue);
      showStrip();
      delay(SpeedDelay);
  }
}
//------------------------------------------------------------------------

void rainbowCycle(int SpeedDelay) {
  byte *c;
  uint16_t i, j;

  for(j=0; j<256*5; j++) { // 5 cycles of all colors on wheel
    for(i=0; i< PIXEL_COUNT; i++) {
      c=Wheel(((i * 256 / PIXEL_COUNT) + j) & 255);
      setPixel(i, *c, *(c+1), *(c+2));
    }
    showStrip();
    delay(SpeedDelay);
  }
}

byte * Wheel(byte WheelPos) {
  static byte c[3];
  
  if(WheelPos < 85) {
   c[0]=WheelPos * 3;
   c[1]=255 - WheelPos * 3;
   c[2]=0;
  } else if(WheelPos < 170) {
   WheelPos -= 85;
   c[0]=255 - WheelPos * 3;
   c[1]=0;
   c[2]=WheelPos * 3;
  } else {
   WheelPos -= 170;
   c[0]=0;
   c[1]=WheelPos * 3;
   c[2]=255 - WheelPos * 3;
  }

  return c;
}
//---------------------------------------------------------------------
void NewKITT(byte red, byte green, byte blue, int EyeSize, int SpeedDelay, int ReturnDelay){
  RightToLeft(red, green, blue, EyeSize, SpeedDelay, ReturnDelay);
  LeftToRight(red, green, blue, EyeSize, SpeedDelay, ReturnDelay);
  OutsideToCenter(red, green, blue, EyeSize, SpeedDelay, ReturnDelay);
  CenterToOutside(red, green, blue, EyeSize, SpeedDelay, ReturnDelay);
  LeftToRight(red, green, blue, EyeSize, SpeedDelay, ReturnDelay);
  RightToLeft(red, green, blue, EyeSize, SpeedDelay, ReturnDelay);
  OutsideToCenter(red, green, blue, EyeSize, SpeedDelay, ReturnDelay);
  CenterToOutside(red, green, blue, EyeSize, SpeedDelay, ReturnDelay);
}
void CenterToOutside(byte red, byte green, byte blue, int EyeSize, int SpeedDelay, int ReturnDelay) {
  for(int i =((PIXEL_COUNT-EyeSize)/2); i>=0; i--) {
    setAll(0,0,0);
    
    setPixel(i, red/10, green/10, blue/10);
    for(int j = 1; j <= EyeSize; j++) {
      setPixel(i+j, red, green, blue); 
    }
    setPixel(i+EyeSize+1, red/10, green/10, blue/10);
    
    setPixel(PIXEL_COUNT-i, red/10, green/10, blue/10);
    for(int j = 1; j <= EyeSize; j++) {
      setPixel(PIXEL_COUNT-i-j, red, green, blue); 
    }
    setPixel(PIXEL_COUNT-i-EyeSize-1, red/10, green/10, blue/10);
    
    showStrip();
    delay(SpeedDelay);
  }
  delay(ReturnDelay);
}

void OutsideToCenter(byte red, byte green, byte blue, int EyeSize, int SpeedDelay, int ReturnDelay) {
  for(int i = 0; i<=((PIXEL_COUNT-EyeSize)/2); i++) {
    setAll(0,0,0);
    
    setPixel(i, red/10, green/10, blue/10);
    for(int j = 1; j <= EyeSize; j++) {
      setPixel(i+j, red, green, blue); 
    }
    setPixel(i+EyeSize+1, red/10, green/10, blue/10);
    
    setPixel(PIXEL_COUNT-i, red/10, green/10, blue/10);
    for(int j = 1; j <= EyeSize; j++) {
      setPixel(PIXEL_COUNT-i-j, red, green, blue); 
    }
    setPixel(PIXEL_COUNT-i-EyeSize-1, red/10, green/10, blue/10);
    
    showStrip();
    delay(SpeedDelay);
  }
  delay(ReturnDelay);
}
void LeftToRight(byte red, byte green, byte blue, int EyeSize, int SpeedDelay, int ReturnDelay) {
  for(int i = 0; i < PIXEL_COUNT-EyeSize-2; i++) {
    setAll(0,0,0);
    setPixel(i, red/10, green/10, blue/10);
    for(int j = 1; j <= EyeSize; j++) {
      setPixel(i+j, red, green, blue); 
    }
    setPixel(i+EyeSize+1, red/10, green/10, blue/10);
    showStrip();
    delay(SpeedDelay);
  }
  delay(ReturnDelay);
}

void RightToLeft(byte red, byte green, byte blue, int EyeSize, int SpeedDelay, int ReturnDelay) {
  for(int i = PIXEL_COUNT-EyeSize-2; i > 0; i--) {
    setAll(0,0,0);
    setPixel(i, red/10, green/10, blue/10);
    for(int j = 1; j <= EyeSize; j++) {
      setPixel(i+j, red, green, blue); 
    }
    setPixel(i+EyeSize+1, red/10, green/10, blue/10);
    showStrip();
    delay(SpeedDelay);
  }
  delay(ReturnDelay);
}

//-----------------------------------------------------------------------
void SnowSparkle(byte red, byte green, byte blue, int SparkleDelay, int SpeedDelay) {
  setAll(red,green,blue);
  
  int Pixel = random(PIXEL_COUNT);
  setPixel(Pixel,0xff,0xff,0xff);
  showStrip();
  delay(SparkleDelay);
  setPixel(Pixel,red,green,blue);
  showStrip();
  delay(SpeedDelay);
}
//-----------------------------------------------------------------------
void Twinkle(byte red, byte green, byte blue, int Count, int SpeedDelay, boolean OnlyOne) {
  setAll(0,0,0);
  
  for (int i=0; i<Count; i++) {
     setPixel(random(PIXEL_COUNT),red,green,blue);
     showStrip();
     delay(SpeedDelay);
     if(OnlyOne) { 
       setAll(0,0,0); 
     }
   }
  
  delay(SpeedDelay);
}
//-----------------------------------------------------------------------
void showStrip() {
 #ifdef ADAFRUIT_NEOPIXEL_H 
   // NeoPixel
   strip.show();
 #endif
 #ifndef ADAFRUIT_NEOPIXEL_H
   // FastLED
   FastLED.show();
 #endif
}

void setPixel(int Pixel, byte red, byte green, byte blue) {
 #ifdef ADAFRUIT_NEOPIXEL_H 
   // NeoPixel
   strip.setPixelColor(Pixel, strip.Color(red, green, blue));
 #endif
 #ifndef ADAFRUIT_NEOPIXEL_H 
   // FastLED
   leds[Pixel].r = red;
   leds[Pixel].g = green;
   leds[Pixel].b = blue;
 #endif
}

void setAll(byte red, byte green, byte blue) {
  for(int i = 0; i < PIXEL_COUNT; i++ ) {
    setPixel(i, red, green, blue); 
  }
  showStrip();
}
