#include "DHT.h"
#define DHTPIN 8
#define DHTTYPE DHT11

DHT dht(DHTPIN, DHTTYPE);
unsigned long then;

void setup() {
  then = millis();
  Serial.begin(9600);
  dht.begin();
}

void loop() {
  unsigned long now = millis();

  if (now - then >= 3000) {
    
    float temperature = dht.readTemperature();
    float humidity = dht.readHumidity();
    
    if (isnan(temperature) || isnan(humidity)) {
      Serial.write("Failed to read from DHT sensor!");
      return;
    }
    
    Serial.println("{\"humidity\": \"" + String(humidity) + "\", \"temperature\": \"" + String(temperature) + "\"}");    
    then = now;
  }
}
