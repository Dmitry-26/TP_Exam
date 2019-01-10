using System;

namespace App {
    class LengthConverter {
        public double convertKm(double length) {
            return length * 1.609;
        }
        public double convertMiles(double length) {
            return length / 1.609;
        }
    }
}