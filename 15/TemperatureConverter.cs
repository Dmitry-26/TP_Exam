using System;

namespace App {
    class TemperatureConverter {
        public String convertTemp(int temperature, char convertTo) {
            if (convertTo == 'F') {
                return (temperature * (9/5) + 32).ToString();
            } else if (convertTo == 'C') {
                return ((temperature - 32) / (9/5)).ToString();
            } else {
                return temperature.ToString();
            }
        }
    }
}