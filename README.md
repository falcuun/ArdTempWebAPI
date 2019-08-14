# Arduino Temperature Web API
This service is intended as a test and practice of dotnet Core Web APIs.
It is just an example of how you can stream the temperature from your Arduino to the web for people to know exactly what the
temperature is like in your city. 

Follow all the steps from below, please:

In order to have the software functioning as intended you will need an Arduino Uno micro controller,
BMP180 Sensor and Arduino Monitor with ability to save Serial data to a file.
###### Arduino Uno
[https://store.arduino.cc/arduino-uno-rev3](https://store.arduino.cc/arduino-uno-rev3)
###### BMP180 Sensor
[https://www.adafruit.com/product/1603](https://www.adafruit.com/product/1603)

[https://www.ebay.com/itm/BMP180-Replace-BMP085-Digital-Barometric-Pressure-Sensor-Module-For-Arduino-/201414876396](https://www.ebay.com/itm/BMP180-Replace-BMP085-Digital-Barometric-Pressure-Sensor-Module-For-Arduino-/201414876396)
###### Arduino Monitor
[https://github.com/falcuun/SimpleArduinoMonitor](https://github.com/falcuun/SimpleArduinoMonitor)

 - Once you obtain all needed hardware and software:
 	-  Download the Arduino code from: [https://github.com/falcuun/TemperatureMonitoringArduino](https://github.com/falcuun/TemperatureMonitoringArduino)
 	-  Download Arduino Serial Monitor from: [https://github.com/falcuun/SimpleArduinoMonitor](https://github.com/falcuun/SimpleArduinoMonitor)
 	-  Download This Web API.  
 - Once you have all Downloaded:.
 	- Plug Your Board to USB port.
 	- Compile and Upload the Arduino Sketch to your board
 	- Run the Arduino Monitor, Select COM name and Baud Rate, hit CONNECT and then READ
 	- Check the "WRITE ONE LINE" box and hit "SAVE TO FILE" button and chose your text file
 		- Or write in your own file path to the textbox under the button 
 	- Start the API Service and type in the file path of the file you're saving your data to
 	- Make a GET Request with your browser to [https://localhost:5001/api/temperatures](https://localhost:5001/api/temperatures)
 		- Get Your Temperature data back at you in JSON Format.

     
      
